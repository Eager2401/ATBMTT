namespace ATBMTT
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResultPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.btOutputPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File đầu vào";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(128, 22);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(313, 20);
            this.tbPath.TabIndex = 1;
            // 
            // btPath
            // 
            this.btPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPath.Location = new System.Drawing.Point(447, 20);
            this.btPath.Name = "btPath";
            this.btPath.Size = new System.Drawing.Size(37, 23);
            this.btPath.TabIndex = 2;
            this.btPath.Text = "...";
            this.btPath.UseVisualStyleBackColor = true;
            this.btPath.Click += new System.EventHandler(this.btPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thư mục đích";
            // 
            // tbResultPath
            // 
            this.tbResultPath.Location = new System.Drawing.Point(128, 89);
            this.tbResultPath.Name = "tbResultPath";
            this.tbResultPath.Size = new System.Drawing.Size(313, 20);
            this.tbResultPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(130, 123);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(190, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(133, 163);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 6;
            this.btGiaiMa.Text = "Giải Mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(313, 163);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btMaHoa.TabIndex = 7;
            this.btMaHoa.Text = "Mã Hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // btOutputPath
            // 
            this.btOutputPath.Location = new System.Drawing.Point(447, 89);
            this.btOutputPath.Name = "btOutputPath";
            this.btOutputPath.Size = new System.Drawing.Size(37, 23);
            this.btOutputPath.TabIndex = 4;
            this.btOutputPath.Text = "...";
            this.btOutputPath.UseVisualStyleBackColor = true;
            this.btOutputPath.Click += new System.EventHandler(this.btOutputPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập tên file đầu ra";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(128, 54);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(313, 20);
            this.tbFileName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 201);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btOutputPath);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResultPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.Button btOutputPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFileName;
    }
}

