using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynCAWait_WinFormExample
{
    public partial class Form1 : Form
    {
        ArrayList messages = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = messages;

        }
        private void LogMessages(string msg)
        {
            messages.Add(DateTime.Now.ToLongTimeString() + msg);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            LogMessages("Task Started");
            string clothes = WashClothes();
            DryClothes(clothes);
            CleanHouse();
            CookFood();
           
        }

        private string WashClothes()
        {
            LogMessages("Washing Clothes");
            Task.Delay(1000).Wait();
            LogMessages("Completed washing Clothes");
            return "Wet Clothes";
        }

        private void CookFood()
        {
            LogMessages("Started cooking Food");
            Task.Delay(1000).Wait();
            LogMessages("completed Cooking Food");
        }

        private void CleanHouse()
        {
            LogMessages("Started Cleaning House ");
            Task.Delay(1000).Wait();
            LogMessages("completed Cleaning House");
        }

        private void DryClothes(string clothes)
        {
            LogMessages("drying Clothes");
            Task.Delay(1000).Wait();
            LogMessages("completed drying clothes");

        }
    }
}
