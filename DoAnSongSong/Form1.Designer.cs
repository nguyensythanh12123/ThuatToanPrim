namespace DoAnSongSong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taodothi = new System.Windows.Forms.Button();
            this.docdothi = new System.Windows.Forms.Button();
            this.Timcaykhung = new System.Windows.Forms.Button();
            this.Luudothi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taodothi
            // 
            this.taodothi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taodothi.ImageIndex = 2;
            this.taodothi.ImageList = this.imageList1;
            this.taodothi.Location = new System.Drawing.Point(13, 13);
            this.taodothi.Name = "taodothi";
            this.taodothi.Size = new System.Drawing.Size(123, 33);
            this.taodothi.TabIndex = 0;
            this.taodothi.Text = "Tạo Đồ Thị";
            this.taodothi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.taodothi.UseVisualStyleBackColor = true;
            this.taodothi.Click += new System.EventHandler(this.taodothi_Click);
            // 
            // docdothi
            // 
            this.docdothi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docdothi.ImageKey = "Programming-Show-Property-icon.png";
            this.docdothi.ImageList = this.imageList1;
            this.docdothi.Location = new System.Drawing.Point(154, 12);
            this.docdothi.Name = "docdothi";
            this.docdothi.Size = new System.Drawing.Size(104, 33);
            this.docdothi.TabIndex = 1;
            this.docdothi.Text = "Đọc Đồ Thị";
            this.docdothi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.docdothi.UseVisualStyleBackColor = true;
            this.docdothi.Click += new System.EventHandler(this.docdothi_Click);
            // 
            // Timcaykhung
            // 
            this.Timcaykhung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timcaykhung.ImageKey = "Search-icon.png";
            this.Timcaykhung.ImageList = this.imageList1;
            this.Timcaykhung.Location = new System.Drawing.Point(280, 12);
            this.Timcaykhung.Name = "Timcaykhung";
            this.Timcaykhung.Size = new System.Drawing.Size(131, 33);
            this.Timcaykhung.TabIndex = 2;
            this.Timcaykhung.Text = "Tìm Cây Khung";
            this.Timcaykhung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Timcaykhung.UseVisualStyleBackColor = true;
            this.Timcaykhung.Click += new System.EventHandler(this.Timcaykhung_Click);
            // 
            // Luudothi
            // 
            this.Luudothi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luudothi.ImageKey = "Save-icon.png";
            this.Luudothi.ImageList = this.imageList1;
            this.Luudothi.Location = new System.Drawing.Point(432, 12);
            this.Luudothi.Name = "Luudothi";
            this.Luudothi.Size = new System.Drawing.Size(131, 33);
            this.Luudothi.TabIndex = 3;
            this.Luudothi.Text = "Lưu Đồ Thị";
            this.Luudothi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Luudothi.UseVisualStyleBackColor = true;
            this.Luudothi.Click += new System.EventHandler(this.Luudothi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(154, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(356, 300);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(516, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Đỉnh Bắt Đầu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "Parallels-1-icon.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(581, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Song Song Hóa Prim";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ImageKey = "Actions-window-close-icon.png";
            this.btn_Dong.ImageList = this.imageList1;
            this.btn_Dong.Location = new System.Drawing.Point(768, 13);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 33);
            this.btn_Dong.TabIndex = 9;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ImageKey = "clear-icon.png";
            this.btn_LamMoi.ImageList = this.imageList1;
            this.btn_LamMoi.Location = new System.Drawing.Point(15, 197);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 33);
            this.btn_LamMoi.TabIndex = 10;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Actions-window-close-icon.png");
            this.imageList1.Images.SetKeyName(1, "clear-icon.png");
            this.imageList1.Images.SetKeyName(2, "Create-New-icon .png");
            this.imageList1.Images.SetKeyName(3, "Parallels-1-icon.png");
            this.imageList1.Images.SetKeyName(4, "Programming-Show-Property-icon.png");
            this.imageList1.Images.SetKeyName(5, "Save-icon.png");
            this.imageList1.Images.SetKeyName(6, "Search-icon.png");
            this.imageList1.Images.SetKeyName(7, "open-file-icon.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageKey = "open-file-icon.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(15, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mở Hình";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(519, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Luudothi);
            this.Controls.Add(this.Timcaykhung);
            this.Controls.Add(this.docdothi);
            this.Controls.Add(this.taodothi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taodothi;
        private System.Windows.Forms.Button docdothi;
        private System.Windows.Forms.Button Timcaykhung;
        private System.Windows.Forms.Button Luudothi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

