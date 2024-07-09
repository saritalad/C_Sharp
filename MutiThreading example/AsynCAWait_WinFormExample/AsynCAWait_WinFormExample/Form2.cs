using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace AsynCAWait_WinFormExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\xyz\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count += content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        // 1 use async word for btn click event
        //2  create a Task (which returns count int so Task<int> Task 
        // in constructor pass a method CountCharacters
        //3 await word signals to wait till the task is completed 
        // 3 steps to make a method asynchronus 
        //async keyword specified that a method is asynchronous
        //await keyword specifies a suspension point
        private async void btn_ProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            lblCount.Text = "Please wait.....File is Processing";
            // int count = CountCharacters();
            int count = await task;
            lblCount.Text = count.ToString() + "Characters in the File";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() => { count = CountCharacters(); }) ;
            thread.Start();
            lblCount.Text = "Please wait.....File is Processing";
            thread.Join();// this blocks theapplication to do other action like resize
            lblCount.Text += count.ToString() + "Characters in the File";
        }
    }
}
