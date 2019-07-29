using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Developer_Assistant
{
    public partial class ItemSetting : Form
    {
        public Item myItem;

        public ItemSetting(int myItemID)
        {
            InitializeComponent();
            myItem = Main.softwareItems[myItemID];
            LoadSettings();
        }

        private void AddItemToList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileToRunList.Items.Add(ofd.FileName);
                myItem.itemData.pathsToFile.Add(ofd.FileName);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Main.SaveItemData();

            Close();
        }

        private void ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            SetProjectName();
        }

        private void SetProjectName()
        {
            myItem.ProjectName = projectTextBox.Text;
        }

        private void SelectIconButton_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadSettings()
        {
            projectTextBox.Text = myItem.itemData.projectName;

            for (int i = 0; i < myItem.itemData.pathsToFile.Count; i++)
            {
                fileToRunList.Items.Add(myItem.itemData.pathsToFile[i]);
            }
        }
    }
}
