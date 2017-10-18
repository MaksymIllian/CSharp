using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace lecture5
{
    public class Threads
    {
        event ChangeUI ui;
        private int count;
        private List<Thread> threads;
        Random rand = new Random();
        Queue<string> queue;
        public Threads(ChangeUI ui)
        {
            this.ui = ui;
        }
        public void Run()
        {
            threads = new List<Thread>();
            queue = new Queue<string>();
            var thread = new Thread(FileExepGenerator);
            thread.IsBackground = true;
            threads.Add(thread);
            threads[0].Name = "Поток 1";
            threads[0].Start();
            thread = new Thread(OutOfMemoryExepGenerator);
            threads.Add(thread);
            threads[1].Name = "Поток 2";
            threads[1].Start();
        }
        public void Abort()
        {
            foreach(Thread t in threads)
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
        public void FileExepGenerator()
        {
            while (true)
            {

                try
                {
                    FileStream fs = File.Open("file.txt", FileMode.Open);
                }
                catch (FileNotFoundException ex)
                {
                    queue.Enqueue(threads[0].Name + ":" + Environment.NewLine + ex.ToString());
                    ui(queue.Dequeue());
                }
                Thread.Sleep(rand.Next(500,5000));
            }
        }
        public void OutOfMemoryExepGenerator()
        {
            while (true)
            {
                int[] test = new int[2];
                try
                {

                    test[3] = 0;
                }
                catch (IndexOutOfRangeException ex)
                {
                    queue.Enqueue(threads[1].Name + ":" + Environment.NewLine + ex.ToString());
                    ui(queue.Dequeue());
                }
                Thread.Sleep(rand.Next(500, 5000));
            }
        }
    }
}