using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Assistant
{
    public partial class Item : UserControl
    {
        private List<string> pathToFiles = new List<string>();

        public Item(Control parent)
        {
            InitializeComponent();
            Parent = parent;
            SetUpItem(openProjectButton, EventArgs.Empty);
        }

        private void SetUpItem(object sender, EventArgs e)
        {
            //Otwiera nowe okno setupu
            ItemSetting itemSetting = new ItemSetting();
            itemSetting.StartPosition = FormStartPosition.CenterScreen;
            itemSetting.ShowDialog();
            //Ustawia texture

            //Dodaje pliki do listy uruchamiania po kliknięciu
        }

        private void OpenProject(object sender, EventArgs e)
        {
            //Otwiera pliki które są gdześ w tablicy 
        }
    }
}
