using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Developer_Assistant
{
    public partial class Main : Form
    {
        public static List<Item> softwareItems = new List<Item>();
        public static List<ItemData> softwareItemsData = new List<ItemData>();

        public Main()
        {
            InitializeComponent();

            EmptyItem item = new EmptyItem(flowLayoutSoftwarePanel);
            LoadItemData();
            flowLayoutSoftwarePanel.Controls.SetChildIndex(item, flowLayoutSoftwarePanel.Controls.Count);
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

        public static void SaveItemData()
        {
            //string json = "";
            //for (int i = 0; i < softwareItems.Count; i++)
            //{
            //    json += new JavaScriptSerializer().Serialize(softwareItems[i].itemData);
            //}

            //System.IO.File.WriteAllText(@"save.json", json);
            File.WriteAllText("save.json", JsonConvert.SerializeObject(softwareItemsData));
        }

        public void LoadItemData()
        {
            string json = File.ReadAllText("save.json");

            if (File.ReadAllText("save.json") == "")
                return;

            softwareItemsData = JsonConvert.DeserializeObject<List<ItemData>>(json);
            for (int i = 0; i < softwareItemsData.Count; i++)
            {
                Item item = new Item(flowLayoutSoftwarePanel, i);
                softwareItems.Add(item);
                item.itemData = softwareItemsData[i];
                item.SetProjectName(item.itemData.projectName);
            }
        }
    }
}
