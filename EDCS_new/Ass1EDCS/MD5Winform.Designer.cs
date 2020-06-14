namespace Ass1EDCS
{
    partial class MD5Winform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResourceFile = new System.Windows.Forms.TextBox();
            this.txtDestinationFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutResource = new System.Windows.Forms.TextBox();
            this.txtOutDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn file nguồn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "Chọn file đích";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResourceFile
            // 
            this.txtResourceFile.Location = new System.Drawing.Point(12, 56);
            this.txtResourceFile.Name = "txtResourceFile";
            this.txtResourceFile.Size = new System.Drawing.Size(411, 22);
            this.txtResourceFile.TabIndex = 1;
            // 
            // txtDestinationFile
            // 
            this.txtDestinationFile.Location = new System.Drawing.Point(12, 141);
            this.txtDestinationFile.Name = "txtDestinationFile";
            this.txtDestinationFile.Size = new System.Drawing.Size(411, 22);
            this.txtDestinationFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File nguồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "File đích";
            // 
            // txtOutResource
            // 
            this.txtOutResource.Location = new System.Drawing.Point(12, 265);
            this.txtOutResource.Name = "txtOutResource";
            this.txtOutResource.Size = new System.Drawing.Size(309, 22);
            this.txtOutResource.TabIndex = 1;
            // 
            // txtOutDestination
            // 
            this.txtOutDestination.Location = new System.Drawing.Point(367, 265);
            this.txtOutDestination.Name = "txtOutDestination";
            this.txtOutDestination.Size = new System.Drawing.Size(309, 22);
            this.txtOutDestination.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MD5 file nguồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "MD5 file đích";
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(12, 169);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(100, 58);
            this.btnMD5.TabIndex = 3;
            this.btnMD5.Text = "Check MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // MD5Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(700, 329);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutDestination);
            this.Controls.Add(this.txtDestinationFile);
            this.Controls.Add(this.txtOutResource);
            this.Controls.Add(this.txtResourceFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MD5Winform";
            this.Text = "MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResourceFile;
        private System.Windows.Forms.TextBox txtDestinationFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutResource;
        private System.Windows.Forms.TextBox txtOutDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMD5;
    }
}