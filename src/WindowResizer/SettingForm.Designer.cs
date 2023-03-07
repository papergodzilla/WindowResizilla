namespace WindowResizer
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.ProcessesGrid = new System.Windows.Forms.DataGridView();
            this.ConfigExportBtn = new System.Windows.Forms.Button();
            this.ConfigImportBtn = new System.Windows.Forms.Button();
            this.ConfigExportGroup = new System.Windows.Forms.GroupBox();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.HotkeysPage = new System.Windows.Forms.TabPage();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveAllKeyBtn = new System.Windows.Forms.Button();
            this.SaveAllKeyLabel = new System.Windows.Forms.Label();
            this.SaveAllLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.RestoreAllKeyLabel = new System.Windows.Forms.Label();
            this.RestoreLabel = new System.Windows.Forms.Label();
            this.RestoreKeyLabel = new System.Windows.Forms.Label();
            this.RestoreKeyBtn = new System.Windows.Forms.Button();
            this.SaveKeyLabel = new System.Windows.Forms.Label();
            this.SaveKeyBtn = new System.Windows.Forms.Button();
            this.DisableInFullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.RestoreAllKeyBtn = new System.Windows.Forms.Button();
            this.RestoreAllLabel = new System.Windows.Forms.Label();
            this.ProcessesPage = new System.Windows.Forms.TabPage();
            this.ProfilesTab = new System.Windows.Forms.TabPage();
            this.ProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.ProfilesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NewProfile = new System.Windows.Forms.Button();
            this.AboutPage = new System.Windows.Forms.TabPage();
            this.AboutGroup = new System.Windows.Forms.GroupBox();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesGrid)).BeginInit();
            this.ConfigExportGroup.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.HotkeysPage.SuspendLayout();
            this.settingGroupBox.SuspendLayout();
            this.ProcessesPage.SuspendLayout();
            this.ProfilesTab.SuspendLayout();
            this.ProfileGroupBox.SuspendLayout();
            this.AboutPage.SuspendLayout();
            this.AboutGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessesGrid
            // 
            this.ProcessesGrid.AllowUserToResizeRows = false;
            this.ProcessesGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProcessesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProcessesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProcessesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ProcessesGrid.GridColor = System.Drawing.SystemColors.Window;
            this.ProcessesGrid.Location = new System.Drawing.Point(5, 13);
            this.ProcessesGrid.MultiSelect = false;
            this.ProcessesGrid.Name = "ProcessesGrid";
            this.ProcessesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProcessesGrid.RowHeadersVisible = false;
            this.ProcessesGrid.RowHeadersWidth = 51;
            this.ProcessesGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProcessesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProcessesGrid.ShowCellToolTips = false;
            this.ProcessesGrid.Size = new System.Drawing.Size(1013, 586);
            this.ProcessesGrid.TabIndex = 7;
            this.ProcessesGrid.TabStop = false;
            // 
            // ConfigExportBtn
            // 
            this.ConfigExportBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfigExportBtn.Location = new System.Drawing.Point(118, 37);
            this.ConfigExportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfigExportBtn.Name = "ConfigExportBtn";
            this.ConfigExportBtn.Size = new System.Drawing.Size(72, 32);
            this.ConfigExportBtn.TabIndex = 9;
            this.ConfigExportBtn.Text = "Export";
            this.ConfigExportBtn.UseVisualStyleBackColor = false;
            this.ConfigExportBtn.Click += new System.EventHandler(this.ConfigExportBtn_Click);
            // 
            // ConfigImportBtn
            // 
            this.ConfigImportBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfigImportBtn.Location = new System.Drawing.Point(21, 37);
            this.ConfigImportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfigImportBtn.Name = "ConfigImportBtn";
            this.ConfigImportBtn.Size = new System.Drawing.Size(72, 32);
            this.ConfigImportBtn.TabIndex = 10;
            this.ConfigImportBtn.Text = "Import";
            this.ConfigImportBtn.UseVisualStyleBackColor = false;
            this.ConfigImportBtn.Click += new System.EventHandler(this.ConfigImportBtn_Click);
            // 
            // ConfigExportGroup
            // 
            this.ConfigExportGroup.Controls.Add(this.ConfigImportBtn);
            this.ConfigExportGroup.Controls.Add(this.ConfigExportBtn);
            this.ConfigExportGroup.Location = new System.Drawing.Point(26, 277);
            this.ConfigExportGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfigExportGroup.Name = "ConfigExportGroup";
            this.ConfigExportGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfigExportGroup.Size = new System.Drawing.Size(740, 90);
            this.ConfigExportGroup.TabIndex = 12;
            this.ConfigExportGroup.TabStop = false;
            this.ConfigExportGroup.Text = "Import/Export Config";
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.Location = new System.Drawing.Point(21, 80);
            this.GithubLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(400, 19);
            this.GithubLinkLabel.TabIndex = 14;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "GithubLinkLabel";
            this.GithubLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Location = new System.Drawing.Point(21, 38);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(240, 19);
            this.VersionLabel.TabIndex = 15;
            this.VersionLabel.Text = "VersionLabel";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingTab
            // 
            this.SettingTab.Controls.Add(this.HotkeysPage);
            this.SettingTab.Controls.Add(this.ProcessesPage);
            this.SettingTab.Controls.Add(this.ProfilesTab);
            this.SettingTab.Controls.Add(this.AboutPage);
            this.SettingTab.ItemSize = new System.Drawing.Size(180, 40);
            this.SettingTab.Location = new System.Drawing.Point(10, 10);
            this.SettingTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Drawing.Point(0, 0);
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(1031, 652);
            this.SettingTab.TabIndex = 18;
            // 
            // HotkeysPage
            // 
            this.HotkeysPage.BackColor = System.Drawing.SystemColors.Window;
            this.HotkeysPage.Controls.Add(this.settingGroupBox);
            this.HotkeysPage.Location = new System.Drawing.Point(4, 44);
            this.HotkeysPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HotkeysPage.Name = "HotkeysPage";
            this.HotkeysPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HotkeysPage.Size = new System.Drawing.Size(1023, 604);
            this.HotkeysPage.TabIndex = 0;
            this.HotkeysPage.Text = "Hotkeys";
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Controls.Add(this.SaveAllKeyBtn);
            this.settingGroupBox.Controls.Add(this.SaveAllKeyLabel);
            this.settingGroupBox.Controls.Add(this.SaveAllLabel);
            this.settingGroupBox.Controls.Add(this.SaveLabel);
            this.settingGroupBox.Controls.Add(this.RestoreAllKeyLabel);
            this.settingGroupBox.Controls.Add(this.RestoreLabel);
            this.settingGroupBox.Controls.Add(this.RestoreKeyLabel);
            this.settingGroupBox.Controls.Add(this.RestoreKeyBtn);
            this.settingGroupBox.Controls.Add(this.SaveKeyLabel);
            this.settingGroupBox.Controls.Add(this.SaveKeyBtn);
            this.settingGroupBox.Controls.Add(this.DisableInFullScreenCheckBox);
            this.settingGroupBox.Controls.Add(this.RestoreAllKeyBtn);
            this.settingGroupBox.Controls.Add(this.RestoreAllLabel);
            this.settingGroupBox.Location = new System.Drawing.Point(26, 19);
            this.settingGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingGroupBox.Size = new System.Drawing.Size(653, 332);
            this.settingGroupBox.TabIndex = 16;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Hotkeys ";
            // 
            // SaveAllKeyBtn
            // 
            this.SaveAllKeyBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveAllKeyBtn.Location = new System.Drawing.Point(523, 143);
            this.SaveAllKeyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveAllKeyBtn.Name = "SaveAllKeyBtn";
            this.SaveAllKeyBtn.Size = new System.Drawing.Size(96, 32);
            this.SaveAllKeyBtn.TabIndex = 18;
            this.SaveAllKeyBtn.Text = "Edit";
            this.SaveAllKeyBtn.UseVisualStyleBackColor = false;
            // 
            // SaveAllKeyLabel
            // 
            this.SaveAllKeyLabel.AutoSize = true;
            this.SaveAllKeyLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveAllKeyLabel.Location = new System.Drawing.Point(163, 154);
            this.SaveAllKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveAllKeyLabel.Name = "SaveAllKeyLabel";
            this.SaveAllKeyLabel.Size = new System.Drawing.Size(87, 13);
            this.SaveAllKeyLabel.TabIndex = 17;
            this.SaveAllKeyLabel.Text = "SaveAllKeyLabel";
            // 
            // SaveAllLabel
            // 
            this.SaveAllLabel.AutoSize = true;
            this.SaveAllLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveAllLabel.Location = new System.Drawing.Point(26, 154);
            this.SaveAllLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveAllLabel.Name = "SaveAllLabel";
            this.SaveAllLabel.Size = new System.Drawing.Size(46, 13);
            this.SaveAllLabel.TabIndex = 16;
            this.SaveAllLabel.Text = "Save All";
            this.SaveAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveLabel.Location = new System.Drawing.Point(26, 41);
            this.SaveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(32, 13);
            this.SaveLabel.TabIndex = 2;
            this.SaveLabel.Text = "Save";
            this.SaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RestoreAllKeyLabel
            // 
            this.RestoreAllKeyLabel.AutoSize = true;
            this.RestoreAllKeyLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RestoreAllKeyLabel.Location = new System.Drawing.Point(163, 215);
            this.RestoreAllKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestoreAllKeyLabel.Name = "RestoreAllKeyLabel";
            this.RestoreAllKeyLabel.Size = new System.Drawing.Size(99, 13);
            this.RestoreAllKeyLabel.TabIndex = 15;
            this.RestoreAllKeyLabel.Text = "RestoreAllKeyLabel";
            // 
            // RestoreLabel
            // 
            this.RestoreLabel.AutoSize = true;
            this.RestoreLabel.Location = new System.Drawing.Point(26, 94);
            this.RestoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestoreLabel.Name = "RestoreLabel";
            this.RestoreLabel.Size = new System.Drawing.Size(44, 13);
            this.RestoreLabel.TabIndex = 5;
            this.RestoreLabel.Text = "Restore";
            this.RestoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RestoreKeyLabel
            // 
            this.RestoreKeyLabel.AutoSize = true;
            this.RestoreKeyLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RestoreKeyLabel.Location = new System.Drawing.Point(163, 94);
            this.RestoreKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestoreKeyLabel.Name = "RestoreKeyLabel";
            this.RestoreKeyLabel.Size = new System.Drawing.Size(88, 13);
            this.RestoreKeyLabel.TabIndex = 14;
            this.RestoreKeyLabel.Text = "RestoreKeyLabel";
            // 
            // RestoreKeyBtn
            // 
            this.RestoreKeyBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RestoreKeyBtn.Location = new System.Drawing.Point(523, 84);
            this.RestoreKeyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RestoreKeyBtn.Name = "RestoreKeyBtn";
            this.RestoreKeyBtn.Size = new System.Drawing.Size(96, 32);
            this.RestoreKeyBtn.TabIndex = 12;
            this.RestoreKeyBtn.Text = "Edit";
            this.RestoreKeyBtn.UseVisualStyleBackColor = false;
            // 
            // SaveKeyLabel
            // 
            this.SaveKeyLabel.AutoSize = true;
            this.SaveKeyLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveKeyLabel.Location = new System.Drawing.Point(163, 41);
            this.SaveKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveKeyLabel.Name = "SaveKeyLabel";
            this.SaveKeyLabel.Size = new System.Drawing.Size(76, 13);
            this.SaveKeyLabel.TabIndex = 11;
            this.SaveKeyLabel.Text = "SaveKeyLabel";
            // 
            // SaveKeyBtn
            // 
            this.SaveKeyBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveKeyBtn.Location = new System.Drawing.Point(523, 30);
            this.SaveKeyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveKeyBtn.Name = "SaveKeyBtn";
            this.SaveKeyBtn.Size = new System.Drawing.Size(96, 32);
            this.SaveKeyBtn.TabIndex = 10;
            this.SaveKeyBtn.Text = "Edit";
            this.SaveKeyBtn.UseVisualStyleBackColor = false;
            // 
            // DisableInFullScreenCheckBox
            // 
            this.DisableInFullScreenCheckBox.AutoSize = true;
            this.DisableInFullScreenCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisableInFullScreenCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisableInFullScreenCheckBox.Location = new System.Drawing.Point(26, 280);
            this.DisableInFullScreenCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisableInFullScreenCheckBox.Name = "DisableInFullScreenCheckBox";
            this.DisableInFullScreenCheckBox.Size = new System.Drawing.Size(155, 17);
            this.DisableInFullScreenCheckBox.TabIndex = 6;
            this.DisableInFullScreenCheckBox.TabStop = false;
            this.DisableInFullScreenCheckBox.Text = "Disable in FullScreen Mode";
            this.DisableInFullScreenCheckBox.UseVisualStyleBackColor = false;
            // 
            // RestoreAllKeyBtn
            // 
            this.RestoreAllKeyBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RestoreAllKeyBtn.Location = new System.Drawing.Point(523, 205);
            this.RestoreAllKeyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RestoreAllKeyBtn.Name = "RestoreAllKeyBtn";
            this.RestoreAllKeyBtn.Size = new System.Drawing.Size(96, 32);
            this.RestoreAllKeyBtn.TabIndex = 13;
            this.RestoreAllKeyBtn.Text = "Edit";
            this.RestoreAllKeyBtn.UseVisualStyleBackColor = false;
            // 
            // RestoreAllLabel
            // 
            this.RestoreAllLabel.AutoSize = true;
            this.RestoreAllLabel.Location = new System.Drawing.Point(26, 215);
            this.RestoreAllLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestoreAllLabel.Name = "RestoreAllLabel";
            this.RestoreAllLabel.Size = new System.Drawing.Size(58, 13);
            this.RestoreAllLabel.TabIndex = 9;
            this.RestoreAllLabel.Text = "Restore All";
            this.RestoreAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProcessesPage
            // 
            this.ProcessesPage.AutoScroll = true;
            this.ProcessesPage.BackColor = System.Drawing.SystemColors.Window;
            this.ProcessesPage.Controls.Add(this.ProcessesGrid);
            this.ProcessesPage.Location = new System.Drawing.Point(4, 44);
            this.ProcessesPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProcessesPage.Name = "ProcessesPage";
            this.ProcessesPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProcessesPage.Size = new System.Drawing.Size(1023, 604);
            this.ProcessesPage.TabIndex = 1;
            this.ProcessesPage.Text = "Processes";
            // 
            // ProfilesTab
            // 
            this.ProfilesTab.Controls.Add(this.ProfileGroupBox);
            this.ProfilesTab.Controls.Add(this.NewProfile);
            this.ProfilesTab.Location = new System.Drawing.Point(4, 44);
            this.ProfilesTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfilesTab.Name = "ProfilesTab";
            this.ProfilesTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfilesTab.Size = new System.Drawing.Size(1023, 604);
            this.ProfilesTab.TabIndex = 3;
            this.ProfilesTab.Text = "Profiles";
            this.ProfilesTab.UseVisualStyleBackColor = true;
            // 
            // ProfileGroupBox
            // 
            this.ProfileGroupBox.Controls.Add(this.ProfilesLayout);
            this.ProfileGroupBox.Location = new System.Drawing.Point(26, 83);
            this.ProfileGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfileGroupBox.Size = new System.Drawing.Size(740, 444);
            this.ProfileGroupBox.TabIndex = 16;
            this.ProfileGroupBox.TabStop = false;
            this.ProfileGroupBox.Text = "Profiles";
            // 
            // ProfilesLayout
            // 
            this.ProfilesLayout.AutoScroll = true;
            this.ProfilesLayout.AutoSize = true;
            this.ProfilesLayout.ColumnCount = 4;
            this.ProfilesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ProfilesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ProfilesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ProfilesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ProfilesLayout.Location = new System.Drawing.Point(30, 26);
            this.ProfilesLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfilesLayout.Name = "ProfilesLayout";
            this.ProfilesLayout.RowCount = 1;
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ProfilesLayout.Size = new System.Drawing.Size(672, 48);
            this.ProfilesLayout.TabIndex = 16;
            // 
            // NewProfile
            // 
            this.NewProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.NewProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewProfile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.NewProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewProfile.Location = new System.Drawing.Point(26, 23);
            this.NewProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewProfile.Name = "NewProfile";
            this.NewProfile.Size = new System.Drawing.Size(104, 40);
            this.NewProfile.TabIndex = 15;
            this.NewProfile.Text = "New Profile";
            this.NewProfile.UseVisualStyleBackColor = false;
            // 
            // AboutPage
            // 
            this.AboutPage.BackColor = System.Drawing.SystemColors.Window;
            this.AboutPage.Controls.Add(this.AboutGroup);
            this.AboutPage.Controls.Add(this.ConfigExportGroup);
            this.AboutPage.Location = new System.Drawing.Point(4, 44);
            this.AboutPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AboutPage.Size = new System.Drawing.Size(1023, 604);
            this.AboutPage.TabIndex = 2;
            this.AboutPage.Text = "About";
            // 
            // AboutGroup
            // 
            this.AboutGroup.Controls.Add(this.StartupCheckBox);
            this.AboutGroup.Controls.Add(this.UpdateCheckBox);
            this.AboutGroup.Controls.Add(this.VersionLabel);
            this.AboutGroup.Controls.Add(this.GithubLinkLabel);
            this.AboutGroup.Location = new System.Drawing.Point(26, 19);
            this.AboutGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AboutGroup.Name = "AboutGroup";
            this.AboutGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AboutGroup.Size = new System.Drawing.Size(740, 229);
            this.AboutGroup.TabIndex = 16;
            this.AboutGroup.TabStop = false;
            this.AboutGroup.Text = "About";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartupCheckBox.Location = new System.Drawing.Point(21, 126);
            this.StartupCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(131, 17);
            this.StartupCheckBox.TabIndex = 16;
            this.StartupCheckBox.Text = "Run on system startup";
            this.StartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateCheckBox
            // 
            this.UpdateCheckBox.AutoSize = true;
            this.UpdateCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateCheckBox.Location = new System.Drawing.Point(21, 165);
            this.UpdateCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateCheckBox.Name = "UpdateCheckBox";
            this.UpdateCheckBox.Size = new System.Drawing.Size(174, 17);
            this.UpdateCheckBox.TabIndex = 12;
            this.UpdateCheckBox.Text = "Checking for updates at startup";
            this.UpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1052, 673);
            this.Controls.Add(this.SettingTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesGrid)).EndInit();
            this.ConfigExportGroup.ResumeLayout(false);
            this.SettingTab.ResumeLayout(false);
            this.HotkeysPage.ResumeLayout(false);
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            this.ProcessesPage.ResumeLayout(false);
            this.ProfilesTab.ResumeLayout(false);
            this.ProfileGroupBox.ResumeLayout(false);
            this.ProfileGroupBox.PerformLayout();
            this.AboutPage.ResumeLayout(false);
            this.AboutGroup.ResumeLayout(false);
            this.AboutGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.CheckBox StartupCheckBox;

        private System.Windows.Forms.TableLayoutPanel ProfilesLayout;

        private System.Windows.Forms.GroupBox ProfileGroupBox;

        private System.Windows.Forms.Button NewProfile;

        private System.Windows.Forms.Label SaveAllLabel;
        private System.Windows.Forms.Label SaveAllKeyLabel;
        private System.Windows.Forms.Button SaveAllKeyBtn;

        private System.Windows.Forms.CheckBox UpdateCheckBox;

        private System.Windows.Forms.GroupBox settingGroupBox;

        private System.Windows.Forms.GroupBox ConfigExportGroup;

        #endregion

        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Label RestoreLabel;
        private System.Windows.Forms.CheckBox DisableInFullScreenCheckBox;
        private System.Windows.Forms.DataGridView ProcessesGrid;
        private System.Windows.Forms.Button ConfigExportBtn;
        private System.Windows.Forms.Button ConfigImportBtn;
        private System.Windows.Forms.GroupBox AboutGroup;
        private System.Windows.Forms.Label RestoreAllLabel;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TabControl SettingTab;
        private System.Windows.Forms.TabPage HotkeysPage;
        private System.Windows.Forms.TabPage ProcessesPage;
        private System.Windows.Forms.TabPage AboutPage;
        private System.Windows.Forms.Button SaveKeyBtn;
        private System.Windows.Forms.Label SaveKeyLabel;
        private System.Windows.Forms.Button RestoreKeyBtn;
        private System.Windows.Forms.Button RestoreAllKeyBtn;
        private System.Windows.Forms.Label RestoreKeyLabel;
        private System.Windows.Forms.Label RestoreAllKeyLabel;
        private System.Windows.Forms.TabPage ProfilesTab;
    }
}
