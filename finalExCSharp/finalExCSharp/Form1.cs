using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalExCSharp
{
    public partial class Form1 : Form
    {
        public delegate void ChangeUI(TreeNode queue);
        Threads t;
        ChangeUI myUI;
        TreeNode treeNode;
        private StreamWriter sr;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void ChangeText(TreeNode queue)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(myUI, queue);
                return;
            }
            
            treeView1.Nodes.Add(queue);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            myUI = new ChangeUI(ChangeText);
          
            //treeNode = new TreeNode();
            string folder = "";
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории";
            DirDialog.SelectedPath = @"C:\";
            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                folder = DirDialog.SelectedPath;
            }
            if (folder != "")
            {
               // t = new Threads(myUI, folder);
                treeView1.Nodes.Clear();
                treeNode = new TreeNode(folder + " " + "(" + File.GetCreationTime(folder) + ")");
                var gettingInformation = Task.Factory.StartNew(() => { GettingInformation(folder, treeNode); });
                var outputInformation = gettingInformation.ContinueWith((previous) =>
                {
                    treeView1.Nodes.Add(treeNode);//Доступ к UI контрлам
                }, TaskScheduler.FromCurrentSynchronizationContext());

                var saveInformatio = gettingInformation.ContinueWith((previous) =>
                {
                    exportToXml(treeNode, "data.xml");

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            
        }
        public static long DirSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += DirSize(di);
            }
            return (Size);
        }
        public void GettingInformation(string startdirectory, TreeNode queue)
        {

            string[] searchdirectory = Directory.GetDirectories(startdirectory);
            
            if (searchdirectory.Length > 0)
            {
                for (int i = 0; i < searchdirectory.Length; i++)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(searchdirectory[i]);
                    long size = DirSize(directoryInfo);
                    queue.Nodes.Add(searchdirectory[i] + " " + "(" + "Size: " + (size * Math.Pow(10, -6)).ToString() + "mb" + " "
                       + ", " + "data:" + File.GetCreationTime(searchdirectory[i]) + ")"); //+ " " + directoryInfo);
                    GettingInformation(searchdirectory[i] + @"\", queue.Nodes[i]);
                
                }
            }
            string[] filesss = Directory.GetFiles(startdirectory);
            for (int i = 0; i < filesss.Length; i++)
            {
              
                FileInfo fInfo = new FileInfo(filesss[i]);
                queue.Nodes.Add(filesss[i] + " " + "(" + "Size: " + (fInfo.Length * Math.Pow(10, -6)).ToString()
                    + "mb" + ", " + "data: " + File.GetCreationTime(filesss[i]) + ")");
                
            }
            
        }

        public void exportToXml(TreeNode tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            //Write the header
            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            //Write our root node
            sr.WriteLine("<" + tv.Nodes[0].Text + ">");
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes);
            }
            //Close the root node
            sr.WriteLine("</" + tv.Nodes[0].Text + ">");
            sr.Close();
        }

        private void saveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
               
                if (node.Nodes.Count > 0)
                {
                    sr.WriteLine("<" + node.Text + ">");
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text + ">");
                }
                else 
                    sr.WriteLine(node.Text);
            }
        }

    }
}
