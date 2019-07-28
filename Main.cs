using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Assistant
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            EmptyItem item = new EmptyItem(flowLayoutSoftwarePanel);
            flowLayoutSoftwarePanel.Controls.SetChildIndex(item, 0);
        }

        private void ShowPanel(MainBookmark toShow)
        {
            Hardware.Visible = false;
            Software.Visible = false;
            Settings.Visible = false;
            Timer.Visible = false;

            switch (toShow)
            {
                case MainBookmark.Hardware:
                    Hardware.Visible = true;
                    break;
                case MainBookmark.Software:
                    Software.Visible = true;
                    break;
                case MainBookmark.Timer:
                    Timer.Visible = true;
                    break;
                case MainBookmark.Settings:
                    Settings.Visible = true;
                    break;
                default:
                    break;
            }
        }

        enum MainBookmark
        {
            Hardware,
            Software,
            Timer,
            Settings
        }

        private void HardwareButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MainBookmark.Hardware);
        }

        private void SoftwareButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MainBookmark.Software);
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MainBookmark.Timer);
        }

        private void SetingsButton_Click(object sender, EventArgs e)
        {
            ShowPanel(MainBookmark.Settings);
        }
    }
}
