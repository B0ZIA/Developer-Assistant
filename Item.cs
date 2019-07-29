using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Developer_Assistant
{
    public partial class Item : UserControl
    {
        public ItemData itemData;
        public string ProjectName
        { get { return itemData.projectName; }
          set { SetProjectName(value); itemData.projectName = value; }
        }


        public Item(Control parent, int ID)
        {
            itemData = new ItemData();
            InitializeComponent();
            Parent = parent;
            itemData.ID = ID;
        }

        public void SetUpItem(object sender, EventArgs e)
        {
            //Otwiera nowe okno setupu
            ItemSetting itemSetting = new ItemSetting(itemData.ID);
            itemSetting.StartPosition = FormStartPosition.CenterScreen;
            itemSetting.ShowDialog();
            //Ustawia texture

            //Dodaje pliki do listy uruchamiania po kliknięciu
        }

        private void OpenProject(object sender, EventArgs e)
        {
            //Otwiera pliki które są gdześ w tablicy 
            for (int i = 0; i < itemData.pathsToFile.Count; i++)
            {
                Process.Start(itemData.pathsToFile[i]);
            }
        }

        public void SetProjectName(string name)
        {
            openProjectButton.Text = "Open " + name;
        }
    }
}
