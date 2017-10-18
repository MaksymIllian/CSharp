using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalExCSharp
{
    class Parameters: Object
    {
        TreeNode t;
        string s;
        public Parameters(TreeNode t,string s)
        {
            this.t = t;
            this.s = s;
        }
    }
    class Threads
    {

        finalExCSharp.Form1.ChangeUI ui;
        private int count;
        private List<Thread> threads;
        Random rand = new Random();
        public TreeNode queue;
        string startdirectory;
        public Threads(finalExCSharp.Form1.ChangeUI ui, string startdirectory)
        {
            this.ui = ui;
            this.queue = new TreeNode(startdirectory);
            this.startdirectory = startdirectory;
        }
        public void Run()
        {
            threads = new List<Thread>();

            //var threadOfGettingInformation = new Thread(() => DirSearch(startdirectory));
            //threadOfGettingInformation.IsBackground = true;
            //threads.Add(threadOfGettingInformation);
            //threads[0].Name = "threadOfGettingInformation";
            //threads[0].Start();
            //thread = new Thread(OutOfMemoryExepGenerator);
            //threads.Add(thread);
            //threads[1].Name = "Поток 2";
            //threads[1].Start();
        }
        public void Abort()
        {
            foreach (Thread t in threads)
            {
                t.Abort();
            }
            threads.Clear();
        }
        public void Stop()
        {
            foreach (Thread t in threads)
            {
                t.Suspend();
            }

        }
        public void Resume()
        {
            foreach (Thread t in threads)
            {
                t.Resume();
            }

        }
        public void GettingInformation(string startdirectory, TreeNode queue)
        {
           
            string[] searchdirectory = Directory.GetDirectories(startdirectory);
            if (searchdirectory.Length > 0)
            {
                for (int i = 0; i < searchdirectory.Length; i++)
                {
                    ui(queue);
                    
                    queue.Nodes.Add(searchdirectory[i]);
                    GettingInformation(searchdirectory[i] + @"\", queue.Nodes[i]);
                }
            }
            string[] filesss = Directory.GetFiles(startdirectory);
            for (int i = 0; i < filesss.Length; i++)
            {
                
                queue.Nodes.Add(filesss[i]);

            }
           
        }
        void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        ui(queue);
                        queue.Nodes.Add(f);
                        
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
    }
}
