using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DelegteExample_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Click Me";
            this.Controls.Add(button);
       //   button.Click += new EventHandler(this.button_Click);
            button.Click += delegate(object Sender, EventArgs E)
            {
                MessageBox.Show("You just clicked me");
            };

        }

        public void button_Click(Object sender,EventArgs args)
        {
            MessageBox.Show("You just clicked me");
        }
    }
}
