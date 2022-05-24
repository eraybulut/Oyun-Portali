
namespace nesneodev
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.gameArea = new System.Windows.Forms.Panel();
            this.bntBasla = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.lbYem = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cmbHiz = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Tan;
            this.gameArea.Location = new System.Drawing.Point(1, 1);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(739, 531);
            this.gameArea.TabIndex = 0;
            this.gameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.gameArea_Paint);
            // 
            // bntBasla
            // 
            this.bntBasla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBasla.ImageKey = "snake.png";
            this.bntBasla.ImageList = this.imageList1;
            this.bntBasla.Location = new System.Drawing.Point(759, 88);
            this.bntBasla.Name = "bntBasla";
            this.bntBasla.Size = new System.Drawing.Size(112, 58);
            this.bntBasla.TabIndex = 1;
            this.bntBasla.Text = "Başla";
            this.bntBasla.UseVisualStyleBackColor = true;
            this.bntBasla.Click += new System.EventHandler(this.bntBasla_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSifirla.ImageKey = "ouroboros.png";
            this.btnSifirla.ImageList = this.imageList1;
            this.btnSifirla.Location = new System.Drawing.Point(759, 180);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(112, 58);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sırfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lbYem
            // 
            this.lbYem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYem.ForeColor = System.Drawing.Color.Black;
            this.lbYem.Location = new System.Drawing.Point(832, 278);
            this.lbYem.Name = "lbYem";
            this.lbYem.Size = new System.Drawing.Size(33, 31);
            this.lbYem.TabIndex = 5;
            this.lbYem.Text = "-";
            this.lbYem.Click += new System.EventHandler(this.lbYem_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "homepage.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(762, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "           Anasayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbHiz
            // 
            this.cmbHiz.FormattingEnabled = true;
            this.cmbHiz.Location = new System.Drawing.Point(744, 474);
            this.cmbHiz.Name = "cmbHiz";
            this.cmbHiz.Size = new System.Drawing.Size(121, 21);
            this.cmbHiz.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "homepage.png");
            this.imageList1.Images.SetKeyName(1, "ouroboros.png");
            this.imageList1.Images.SetKeyName(2, "snake.png");
            this.imageList1.Images.SetKeyName(3, "fishing-baits.png");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageIndex = 3;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(759, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puan :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(883, 534);
            this.Controls.Add(this.lbYem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHiz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.bntBasla);
            this.Controls.Add(this.gameArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Button bntBasla;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label lbYem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbHiz;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}