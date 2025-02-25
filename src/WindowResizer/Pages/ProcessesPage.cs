using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowResizer.Configuration;
using WindowResizer.Utils;

// ReSharper disable once CheckNamespace
namespace WindowResizer
{
    public partial class SettingForm
    {
        private void ProcessesPageInit()
        {
            ProcessesGridLayout();

            ProcessesGrid.AutoGenerateColumns = false;
            ProcessesGrid.DataSource = ConfigFactory.Current.WindowSizes;

            ProcessesGrid.ShowCellToolTips = true;
            ProcessesGrid.CellFormatting += ProcessesGrid_CellFormatting;
            ProcessesGrid.CellClick += ProcessesGrid_CellClick;
            ProcessesGrid.CellContentClick += ProcessesGrid_CellContentClick;
            ProcessesGrid.CellValueChanged += ProcessesGrid_CellValueChanged;
            ProcessesGrid.CellMouseEnter += ProcessesGrid_CellMouseEnter;
        }

        private void ProcessesGridLayout()
        {
            ProcessesGrid.AllowUserToAddRows = false;
            ProcessesGrid.RowTemplate.Height = 50;
            ProcessesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProcessesGrid.Columns.Clear();
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Process",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = SystemColors.Highlight,
                    SelectionForeColor = SystemColors.Highlight,
                    SelectionBackColor = SystemColors.Window,
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                },
                FillWeight = 15,
                DisplayIndex = 0,
            });
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                DataPropertyName = "Title",
                HeaderText = "Title",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                },
                FillWeight = 35,
                DisplayIndex = 1,
            });
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Top",
                DataPropertyName = "Top",
                HeaderText = "Top",
                FillWeight = 8,
                DisplayIndex = 2,
            });
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Left",
                DataPropertyName = "Left",
                HeaderText = "Left",
                FillWeight = 8,
                DisplayIndex = 3,
            });
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Right",
                DataPropertyName = "Right",
                HeaderText = "Right",
                FillWeight = 8,
                DisplayIndex = 4,
            });
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Bottom",
                DataPropertyName = "Bottom",
                HeaderText = "Bottom",
                FillWeight = 8,
                DisplayIndex = 5,
            });
            ProcessesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Rect", DataPropertyName = "Rect", Visible = false,
            });

            ProcessesGrid.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "AutoResize",
                DataPropertyName = "AutoResize",
                HeaderText = "Auto",
                FillWeight = 8,
                DisplayIndex = 6,
                FlatStyle = FlatStyle.Standard,
                DefaultCellStyle =
                {
                    SelectionBackColor = SystemColors.Window,
                },
            });

            ProcessesGrid.Columns.Add(new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Remove",
                Name = "Remove",
                HeaderText = "",
                FlatStyle = FlatStyle.Standard,
                DefaultCellStyle =
                {
                    ForeColor = SystemColors.ControlText,
                    BackColor = SystemColors.Window,
                    SelectionBackColor = SystemColors.Window,
                    Padding = new Padding(5)
                },
                FillWeight = 10,
                DisplayIndex = 7,
            });

            foreach (DataGridViewColumn col in ProcessesGrid.Columns)
            {
                if (!col.Name.Equals("Name") && !col.Name.Equals("Title"))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = Helper.ChangeFontSize(ProcessesGrid.Font, 9F, FontStyle.Bold);
            }
        }

        private void ProcessesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProcessesGrid.Columns["AutoResize"]?.Index && e.RowIndex >= 0)
            {
                ProcessesGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ProcessesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ConfigFactory.Save();
        }

        private void ProcessesGrid_CellFormatting(object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = ProcessesGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if ((e.ColumnIndex == ProcessesGrid.Columns["Name"]?.Index ||
                    e.ColumnIndex == ProcessesGrid.Columns["Title"]?.Index) && e.Value != null && e.Value.ToString().Length > 20)
            {
                cell.ToolTipText = cell.Value.ToString();
            }

            if ((e.ColumnIndex >= ProcessesGrid.Columns["Top"]?.Index && e.ColumnIndex <= ProcessesGrid.Columns["Bottom"]?.Index))
            {
                var r = ConfigFactory.Current.WindowSizes[e.RowIndex];
                if (r.State == Common.Windows.WindowState.Maximized)
                {
                    cell.Style.ForeColor = SystemColors.GradientInactiveCaption;
                    cell.ToolTipText = "window Maximized";
                    cell.ReadOnly = true;
                }
            }
        }

        private void ProcessesGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            string name = ProcessesGrid.Columns[e.ColumnIndex].Name;
            switch (name)
            {
                case "Name":
                    ProcessesGrid.Cursor = Cursors.Default;
                    break;

                case "AutoResize":
                case "Remove":
                    ProcessesGrid.Cursor = Cursors.Hand;
                    break;

                default:
                    ProcessesGrid.Cursor = Cursors.IBeam;
                    break;
            }
        }

        private void ProcessesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProcessesGrid.Columns["Remove"]?.Index &&
                e.RowIndex >= 0 &&
                e.RowIndex < ConfigFactory.Current.WindowSizes.Count)
            {
                ConfigFactory.Current.WindowSizes.RemoveAt(e.RowIndex);
                ConfigFactory.Save();
            }
        }
    }
}
