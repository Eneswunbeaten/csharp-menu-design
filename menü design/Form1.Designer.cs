namespace menü_design
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ıconButton5 = new FontAwesome.Sharp.IconButton();
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelMenu.Controls.Add(this.ıconButton5);
            this.panelMenu.Controls.Add(this.ıconButton4);
            this.panelMenu.Controls.Add(this.ıconButton3);
            this.panelMenu.Controls.Add(this.ıconButton2);
            this.panelMenu.Controls.Add(this.ıconButton1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 388);
            this.panelMenu.TabIndex = 0;
            // 
            // ıconButton5
            // 
            this.ıconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton5.FlatAppearance.BorderSize = 0;
            this.ıconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ıconButton5.Icon = FontAwesome.Sharp.IconChar.SunO;
            this.ıconButton5.IconColor = System.Drawing.Color.White;
            this.ıconButton5.IconSize = 32;
            this.ıconButton5.Image = ((System.Drawing.Image)(resources.GetObject("ıconButton5.Image")));
            this.ıconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.Location = new System.Drawing.Point(0, 310);
            this.ıconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.ıconButton5.Name = "ıconButton5";
            this.ıconButton5.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ıconButton5.Size = new System.Drawing.Size(165, 49);
            this.ıconButton5.TabIndex = 5;
            this.ıconButton5.Text = "Ayarlar";
            this.ıconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton5.UseVisualStyleBackColor = true;
            this.ıconButton5.Click += new System.EventHandler(this.ıconButton5_Click);
            // 
            // ıconButton4
            // 
            this.ıconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton4.FlatAppearance.BorderSize = 0;
            this.ıconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ıconButton4.Icon = FontAwesome.Sharp.IconChar.BookmarkO;
            this.ıconButton4.IconColor = System.Drawing.Color.White;
            this.ıconButton4.IconSize = 32;
            this.ıconButton4.Image = ((System.Drawing.Image)(resources.GetObject("ıconButton4.Image")));
            this.ıconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.Location = new System.Drawing.Point(0, 261);
            this.ıconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ıconButton4.Size = new System.Drawing.Size(165, 49);
            this.ıconButton4.TabIndex = 4;
            this.ıconButton4.Text = "Ürünler";
            this.ıconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton4.UseVisualStyleBackColor = true;
            this.ıconButton4.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // ıconButton3
            // 
            this.ıconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ıconButton3.Icon = FontAwesome.Sharp.IconChar.CommentsO;
            this.ıconButton3.IconColor = System.Drawing.Color.White;
            this.ıconButton3.IconSize = 32;
            this.ıconButton3.Image = ((System.Drawing.Image)(resources.GetObject("ıconButton3.Image")));
            this.ıconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.Location = new System.Drawing.Point(0, 212);
            this.ıconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ıconButton3.Size = new System.Drawing.Size(165, 49);
            this.ıconButton3.TabIndex = 3;
            this.ıconButton3.Text = "Müşteriler";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ıconButton2.Icon = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ıconButton2.IconColor = System.Drawing.Color.White;
            this.ıconButton2.IconSize = 32;
            this.ıconButton2.Image = ((System.Drawing.Image)(resources.GetObject("ıconButton2.Image")));
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(0, 163);
            this.ıconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ıconButton2.Size = new System.Drawing.Size(165, 49);
            this.ıconButton2.TabIndex = 2;
            this.ıconButton2.Text = "Siparişler";
            this.ıconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ıconButton1.Icon = FontAwesome.Sharp.IconChar.LineChart;
            this.ıconButton1.IconColor = System.Drawing.Color.White;
            this.ıconButton1.IconSize = 32;
            this.ıconButton1.Image = ((System.Drawing.Image)(resources.GetObject("ıconButton1.Image")));
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(0, 114);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ıconButton1.Size = new System.Drawing.Size(165, 49);
            this.ıconButton1.TabIndex = 1;
            this.ıconButton1.Text = "Ana Sayfa";
            this.ıconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 114);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 114);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(701, 388);
            this.panelDesktop.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 388);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

