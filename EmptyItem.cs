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
    public partial class EmptyItem : UserControl
    {
        public EmptyItem(Control parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item(Parent, Main.softwareItems.Count);
            Parent.Controls.SetChildIndex(newItem, 0);
            Main.softwareItems.Add(newItem);
            Main.softwareItemsData.Add(newItem.itemData);
            newItem.SetUpItem(sender, e);
        }
    }
}
