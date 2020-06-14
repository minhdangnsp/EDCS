namespace Ass1EDCS
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
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.txt_url_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonAES = new System.Windows.Forms.RadioButton();
            this.radioButtonDES = new System.Windows.Forms.RadioButton();
            this.btnKey = new System.Windows.Forms.Button();
            this.btnCheckMD5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(56, 33);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(174, 22);
            this.txt_key.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(42, 149);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(113, 28);
            this.btnMaHoa.TabIndex = 3;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(428, 149);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(113, 28);
            this.btnGiaiMa.TabIndex = 3;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(428, 27);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(113, 35);
            this.btnChonFile.TabIndex = 3;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // txt_url_input
            // 
            this.txt_url_input.Location = new System.Drawing.Point(13, 102);
            this.txt_url_input.Name = "txt_url_input";
            this.txt_url_input.Size = new System.Drawing.Size(378, 22);
            this.txt_url_input.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dữ liệu vào";
            // 
            // radioButtonAES
            // 
            this.radioButtonAES.AutoSize = true;
            this.radioButtonAES.Location = new System.Drawing.Point(428, 102);
            this.radioButtonAES.Name = "radioButtonAES";
            this.radioButtonAES.Size = new System.Drawing.Size(56, 21);
            this.radioButtonAES.TabIndex = 7;
            this.radioButtonAES.TabStop = true;
            this.radioButtonAES.Text = "AES";
            this.radioButtonAES.UseVisualStyleBackColor = true;
            // 
            // radioButtonDES
            // 
            this.radioButtonDES.AutoSize = true;
            this.radioButtonDES.Location = new System.Drawing.Point(499, 102);
            this.radioButtonDES.Name = "radioButtonDES";
            this.radioButtonDES.Size = new System.Drawing.Size(57, 21);
            this.radioButtonDES.TabIndex = 7;
            this.radioButtonDES.TabStop = true;
            this.radioButtonDES.Text = "DES";
            this.radioButtonDES.UseVisualStyleBackColor = true;
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(236, 27);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(111, 35);
            this.btnKey.TabIndex = 8;
            this.btnKey.Text = "Chọn file key";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // btnCheckMD5
            // 
            this.btnCheckMD5.Location = new System.Drawing.Point(236, 195);
            this.btnCheckMD5.Name = "btnCheckMD5";
            this.btnCheckMD5.Size = new System.Drawing.Size(121, 32);
            this.btnCheckMD5.TabIndex = 9;
            this.btnCheckMD5.Text = "Check MD5";
            this.btnCheckMD5.UseVisualStyleBackColor = true;
            this.btnCheckMD5.Click += new System.EventHandler(this.btnCheckMD5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(606, 239);
            this.Controls.Add(this.btnCheckMD5);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.radioButtonDES);
            this.Controls.Add(this.radioButtonAES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_url_input);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_key);
            this.Name = "Form1";
            this.Text = "frmTextFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.TextBox txt_url_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonAES;
        private System.Windows.Forms.RadioButton radioButtonDES;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.Button btnCheckMD5;
    }
}

