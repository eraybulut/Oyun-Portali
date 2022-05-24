
namespace nesneodev
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gri = new System.Windows.Forms.PictureBox();
            this.siyah = new System.Windows.Forms.PictureBox();
            this.kirmizi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siyah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirmizi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(745, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 431);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(271, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "homepage.png");
            this.imageList1.Images.SetKeyName(1, "racing-flag.png");
            // 
            // gri
            // 
            this.gri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gri.BackgroundImage")));
            this.gri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gri.Location = new System.Drawing.Point(12, 234);
            this.gri.Name = "gri";
            this.gri.Size = new System.Drawing.Size(118, 73);
            this.gri.TabIndex = 7;
            this.gri.TabStop = false;
            // 
            // siyah
            // 
            this.siyah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siyah.BackgroundImage")));
            this.siyah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siyah.Location = new System.Drawing.Point(12, 376);
            this.siyah.Name = "siyah";
            this.siyah.Size = new System.Drawing.Size(118, 73);
            this.siyah.TabIndex = 6;
            this.siyah.TabStop = false;
            // 
            // kirmizi
            // 
            this.kirmizi.BackColor = System.Drawing.SystemColors.Control;
            this.kirmizi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kirmizi.BackgroundImage")));
            this.kirmizi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kirmizi.InitialImage = null;
            this.kirmizi.Location = new System.Drawing.Point(12, 101);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(118, 73);
            this.kirmizi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kirmizi.TabIndex = 5;
            this.kirmizi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "homepage.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(441, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "             Anasayfaya Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gri);
            this.Controls.Add(this.siyah);
            this.Controls.Add(this.kirmizi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siyah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirmizi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox gri;
        private System.Windows.Forms.PictureBox siyah;
        private System.Windows.Forms.PictureBox kirmizi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}