
namespace AsynCAWait_WinFormExample
{
    partial class Form2
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
            this.btn_ProcessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ProcessFile
            // 
            this.btn_ProcessFile.Location = new System.Drawing.Point(227, 51);
            this.btn_ProcessFile.Name = "btn_ProcessFile";
            this.btn_ProcessFile.Size = new System.Drawing.Size(228, 59);
            this.btn_ProcessFile.TabIndex = 0;
            this.btn_ProcessFile.Text = "ProcessFile";
            this.btn_ProcessFile.UseVisualStyleBackColor = true;
            this.btn_ProcessFile.Click += new System.EventHandler(this.btn_ProcessFile_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(242, 158);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(213, 20);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "...................................................";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process File UseThread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btn_ProcessFile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ProcessFile;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button1;
    }
}