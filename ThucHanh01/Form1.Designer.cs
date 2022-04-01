namespace ThucHanh01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mediaTrailer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTrailer)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaTrailer
            // 
            this.mediaTrailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaTrailer.Enabled = true;
            this.mediaTrailer.Location = new System.Drawing.Point(0, 0);
            this.mediaTrailer.Name = "mediaTrailer";
            this.mediaTrailer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaTrailer.OcxState")));
            this.mediaTrailer.Size = new System.Drawing.Size(1268, 677);
            this.mediaTrailer.TabIndex = 0;
            this.mediaTrailer.Enter += new System.EventHandler(this.mediaTrailer_Enter);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Cyan;
            this.buttonBack.Location = new System.Drawing.Point(1140, 642);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 35);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "TRỞ VỀ";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonBack_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 677);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.mediaTrailer);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mediaTrailer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaTrailer;
        private System.Windows.Forms.Button buttonBack;
    }
}