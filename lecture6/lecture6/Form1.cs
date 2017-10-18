using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace lecture6
{
    [Serializable]
    public partial class Form1 : Form
    {
        
        private void FillMyListBox(ListBox myListBox)
        {
            List<string> l = new List<string>();
            myListBox.Items.Clear();
            l = Core.Core.LoadToListTexBox();
            for (int i = 0; i < l.Count; i++)
            {
                myListBox.Items.Add(l[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
            FillMyListBox(listBox);
             // Core.Core.Create();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string picture = Core.Core.ImageToBase64(pictureBox.Image, ImageFormat.Jpeg);
            Core.Core.Add(nameTextBox.Text, lastNameTextBox.Text, homePhoneTextBox.Text,
                mobileTextBox.Text, groupTextBox.Text, picture);
            FillMyListBox(listBox);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string item = listBox.SelectedItem.ToString();
                string result = item.Substring(0, item.IndexOf(" "));
                Core.Core.Delete(result);
                FillMyListBox(listBox);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string picture = Core.Core.ImageToBase64(pictureBox.Image, ImageFormat.Jpeg);
                string item = listBox.SelectedItem.ToString();
                string result = item.Substring(0, item.IndexOf(" "));
                Core.Core.Update(result, nameTextBox.Text,
                    lastNameTextBox.Text, homePhoneTextBox.Text, mobileTextBox.Text,
                    groupTextBox.Text, picture);
                FillMyListBox(listBox);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox.Image = Image.FromFile(ofd.FileName);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
        }
        private void listbox_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
            if (listBox.SelectedItem != null )
            {
                string item = listBox.SelectedItem.ToString();
                string result;
                try
                {
                    result = item.Substring(0, item.IndexOf(" "));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    if (listBox.SelectedItem == "------------")
                        listBox.SelectedIndex += 2; 
                    else
                        listBox.SelectedIndex+=1;
                    item = listBox.SelectedItem.ToString();
                    result = item.Substring(0, item.IndexOf(" "));
                }
                l = Core.Core.LoadToTextBoxes(result);
                nameTextBox.Text = l[0];
                lastNameTextBox.Text = l[1];
                homePhoneTextBox.Text = l[2];
                mobileTextBox.Text = l[3];
                groupTextBox.Text = l[4];
                pictureBox.Image = Core.Core.LoadToPictureBox(result);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
        }

        private void byIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillMyListBox(listBox);
        }

        private void byNameLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
            listBox.Items.Clear();
            l = Core.Core.SortByNameLastName();
            for (int i = 0; i < l.Count; i++)
            {
                listBox.Items.Add(l[i]);
            }
        }

        private void byGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
            listBox.Items.Clear();
            l = Core.Core.Group();
            for (int i = 0; i < l.Count; i++)
            {
                listBox.Items.Add(l[i]);
            }
        }


    }
}
