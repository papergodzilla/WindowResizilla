using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowResizer.Common.Shortcuts;
using WindowResizer.Configuration;
using WindowResizer.Core.Shortcuts;
using WindowResizer.Utils;

// ReSharper disable once CheckNamespace
namespace WindowResizer
{
    public partial class SettingForm
    {
        private static bool _isBinding;
        private static HotkeysControl _bindingControl;

        private readonly Hotkeys _hotKeys = new Hotkeys();
        private readonly List<HotkeysControl> _keyBindControls = new List<HotkeysControl>();

        private readonly GlobalKeyboardHook _globalHook = new GlobalKeyboardHook();
        private readonly HashSet<Keys> _pressedKeys = new HashSet<Keys>();

        private class HotkeysControl
        {
            public HotkeysControl(HotkeysType type, Button button, Label label)
            {
                Type = type;
                Button = button;
                Label = label;
            }

            public HotkeysType Type { get; }

            public Button Button { get; }

            public Label Label { get; }
        }


        private void HotkeysPageInit()
        {
            _globalHook.KeyDown += HookOnKeyDown;
            _globalHook.KeyUp += HookOnKeyUp;

            _keyBindControls.Clear();
            _keyBindControls.Add(new HotkeysControl(HotkeysType.Save, SaveKeyBtn, SaveKeyLabel));
            _keyBindControls.Add(new HotkeysControl(HotkeysType.Restore, RestoreKeyBtn, RestoreKeyLabel));
            _keyBindControls.Add(new HotkeysControl(HotkeysType.SaveAll, SaveAllKeyBtn, SaveAllKeyLabel));
            _keyBindControls.Add(new HotkeysControl(HotkeysType.RestoreAll, RestoreAllKeyBtn, RestoreAllKeyLabel));

            SetToolTips();

            foreach (var control in _keyBindControls)
            {
                control.Button.Click += (sender, e) => OnBindButtonClick(control, sender, e);
                control.Label.Text = GetLabelByType(control.Type);
                control.Label.Font = Helper.ChangeFontSize(SaveLabel.Font, 12F, FontStyle.Bold);
            }

            DisableInFullScreenCheckBox.Checked = ConfigLoader.Config.DisableInFullScreen;
            DisableInFullScreenCheckBox.CheckedChanged += DisableInFullScreen_CheckedChanged;
        }

        private void OnBindButtonClick(HotkeysControl control, object sender, EventArgs e)
        {
            if (_isBinding && _bindingControl.Button != control.Button)
            {
                _bindingControl.Button.PerformClick();
            }

            _bindingControl = control;

            OnKeyBindButtonClick(sender, e);
        }

        private void DisableInFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            ConfigLoader.Config.DisableInFullScreen = DisableInFullScreenCheckBox.Checked;
            ConfigLoader.Save();
        }

        private void SetToolTips()
        {
            Helper.SetToolTip(SaveLabel, "Save foreground window size and position.");
            Helper.SetToolTip(RestoreLabel, "Restore foreground window size and position.");
            Helper.SetToolTip(SaveAllLabel, "Save all window size and position.");
            Helper.SetToolTip(RestoreAllLabel, "Restore all saved windows size and position.");
        }


        private void HookOnKeyDown(object sender, KeyEventArgs args)
        {
            args.Handled = true;

            var key = args.KeyCode;

            if (!_pressedKeys.Add(key))
            {
                return;
            }

            if (key.IsModifierKey())
            {
                _hotKeys.ModifierKeys.Add(key.ToKeyString());
            }
            else
            {
                _hotKeys.Key = key.ToKeyString();
            }

            _bindingControl.Label.Text = $"{_hotKeys.ToKeysString()} ...";
        }

        private void HookOnKeyUp(object sender, KeyEventArgs args)
        {
            args.Handled = true;

            var key = args.KeyCode;
            _pressedKeys.Remove(key);

            if (_pressedKeys.Count == 0)
            {
                _bindingControl.Button.PerformClick();
            }
        }

        private void OnKeyBindButtonClick(object sender, EventArgs _)
        {
            if (_isBinding)
            {
                OnKeyBindEnd();
            }
            else
            {
                OnKeyBindStart();
            }
        }

        private void OnKeyBindStart()
        {
            _isBinding = true;
            _hotKeys.Clear();
            _pressedKeys.Clear();
            _bindingControl.Button.Text = "Recording...";
            _bindingControl.Label.Text = "Waiting...";

            foreach (var control in _keyBindControls.Where(control => _bindingControl.Button != control.Button))
            {
                control.Button.Enabled = false;
            }

            _globalHook.Hook();
        }


        private void OnKeyBindEnd()
        {
            _globalHook.UnHook();

            _isBinding = false;
            _bindingControl.Button.Text = "Edit";
            _bindingControl.Label.Text = _hotKeys.ToKeysString();

            foreach (var control in _keyBindControls)
            {
                control.Button.Enabled = true;
            }

            if (!_hotKeys.IsValid() || !IsKeyChanged(_bindingControl.Type))
            {
                _bindingControl.Label.Text = GetLabelByType(_bindingControl.Type);
                return;
            }

            DialogResult dr = MessageBox.Show($"Set {_bindingControl.Type.ToString()} key to {_hotKeys.ToKeysString()}?", "Hotkey",
                MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                int keyId;
                try
                {
                    keyId = _hook.RegisterHotKey(_hotKeys.GetModifierKeys(), _hotKeys.GetKey());
                }
                catch (Exception e)
                {
                    Helper.ShowMessageBox(e.Message);
                    _bindingControl.Label.Text = GetLabelByType(_bindingControl.Type);
                    return;
                }

                if (App.RegisteredHotKeys.TryGetValue(_bindingControl.Type, out var oldKeyId))
                {
                    _hook.UnRegisterHotKey(oldKeyId);
                }

                App.RegisteredHotKeys[_bindingControl.Type] = keyId;

                SetKeys(_bindingControl.Type, _hotKeys);

                ConfigLoader.Save();
            }
            else
            {
                _bindingControl.Label.Text = GetLabelByType(_bindingControl.Type);
            }
        }

        private static string GetLabelByType(HotkeysType type) =>
            GetKeys(type)?.ToKeysString() ?? string.Empty;

        private bool IsKeyChanged(HotkeysType type) =>
            !_hotKeys.Equals(GetKeys(type));

        private static void SetKeys(HotkeysType type, Hotkeys hotkeys) =>
            ConfigLoader.Config.SetKeys(type, hotkeys);

        private static Hotkeys GetKeys(HotkeysType type) =>
            ConfigLoader.Config.GetKeys(type);
    }
}