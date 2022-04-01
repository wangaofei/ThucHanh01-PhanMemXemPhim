namespace ThucHanh01
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxSlider = new System.Windows.Forms.PictureBox();
            this.pictureBoxBannerMain = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxAds1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAds2 = new System.Windows.Forms.PictureBox();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBannerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAds2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Location = new System.Drawing.Point(0, -93);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1018, 64);
            this.panelheader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "HP\'S FILM";
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Interval = 1800;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.jpg");
            this.imageList1.Images.SetKeyName(1, "1.jpg");
            this.imageList1.Images.SetKeyName(2, "2.jpg");
            this.imageList1.Images.SetKeyName(3, "3.jpg");
            this.imageList1.Images.SetKeyName(4, "4.jpg");
            this.imageList1.Images.SetKeyName(5, "5.jpg");
            this.imageList1.Images.SetKeyName(6, "6.jpg");
            this.imageList1.Images.SetKeyName(7, "7.jpg");
            this.imageList1.Images.SetKeyName(8, "8.jpg");
            this.imageList1.Images.SetKeyName(9, "9.jpg");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(160, 698);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1095, 1500);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP\'S FILM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxSlider
            // 
            this.pictureBoxSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxSlider.Location = new System.Drawing.Point(0, 75);
            this.pictureBoxSlider.Name = "pictureBoxSlider";
            this.pictureBoxSlider.Size = new System.Drawing.Size(1421, 558);
            this.pictureBoxSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlider.TabIndex = 1;
            this.pictureBoxSlider.TabStop = false;
            this.pictureBoxSlider.Click += new System.EventHandler(this.pictureBoxSlider_Click);
            // 
            // pictureBoxBannerMain
            // 
            this.pictureBoxBannerMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxBannerMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBannerMain.Location = new System.Drawing.Point(419, 130);
            this.pictureBoxBannerMain.Name = "pictureBoxBannerMain";
            this.pictureBoxBannerMain.Size = new System.Drawing.Size(439, 615);
            this.pictureBoxBannerMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBannerMain.TabIndex = 4;
            this.pictureBoxBannerMain.TabStop = false;
            this.pictureBoxBannerMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBannerMain_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // pictureBoxAds1
            // 
            this.pictureBoxAds1.Location = new System.Drawing.Point(0, 698);
            this.pictureBoxAds1.Name = "pictureBoxAds1";
            this.pictureBoxAds1.Size = new System.Drawing.Size(160, 500);
            this.pictureBoxAds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAds1.TabIndex = 6;
            this.pictureBoxAds1.TabStop = false;
            this.pictureBoxAds1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAds1_MouseClick);
            // 
            // pictureBoxAds2
            // 
            this.pictureBoxAds2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAds2.Location = new System.Drawing.Point(1261, 698);
            this.pictureBoxAds2.Name = "pictureBoxAds2";
            this.pictureBoxAds2.Size = new System.Drawing.Size(160, 500);
            this.pictureBoxAds2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAds2.TabIndex = 7;
            this.pictureBoxAds2.TabStop = false;
            this.pictureBoxAds2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAds2_MouseClick);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 0);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1497, 1055);
            this.Controls.Add(this.pictureBoxAds2);
            this.Controls.Add(this.pictureBoxAds1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxBannerMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBoxSlider);
            this.Controls.Add(this.panelheader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBannerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAds2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxSlider;
        private System.Windows.Forms.PictureBox pictureBoxBannerMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxAds1;
        private System.Windows.Forms.PictureBox pictureBoxAds2;
    }
}