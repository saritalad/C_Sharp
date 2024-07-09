
namespace MultiThreadWindowForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimeconsumingWork = new System.Windows.Forms.Button();
            this.btPrintNumbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTimeconsumingWork
            // 
            this.btnTimeconsumingWork.Location = new System.Drawing.Point(287, 46);
            this.btnTimeconsumingWork.Name = "btnTimeconsumingWork";
            this.btnTimeconsumingWork.Size = new System.Drawing.Size(162, 59);
            this.btnTimeconsumingWork.TabIndex = 0;
            this.btnTimeconsumingWork.Text = "Time consuming Work";
            this.btnTimeconsumingWork.UseVisualStyleBackColor = true;
            this.btnTimeconsumingWork.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPrintNumbers
            // 
            this.btPrintNumbers.Location = new System.Drawing.Point(276, 148);
            this.btPrintNumbers.Name = "btPrintNumbers";
            this.btPrintNumbers.Size = new System.Drawing.Size(284, 52);
            this.btPrintNumbers.TabIndex = 1;
            this.btPrintNumbers.Text = "Print Numbers";
            this.btPrintNumbers.UseVisualStyleBackColor = true;
            this.btPrintNumbers.Click += new System.EventHandler(this.btPrintNumbers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(276, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 196);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btPrintNumbers);
            this.Controls.Add(this.btnTimeconsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeconsumingWork;
        private System.Windows.Forms.Button btPrintNumbers;
        private System.Windows.Forms.ListBox listBox1;
    }
}

