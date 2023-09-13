
namespace GUI
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tituleUser = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.tituleMain1 = new System.Windows.Forms.Label();
            this.tituleMain = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.lPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lCategory = new System.Windows.Forms.Label();
            this.tbCodeArt = new System.Windows.Forms.TextBox();
            this.lMarc = new System.Windows.Forms.Label();
            this.bAddArticle = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lCodeArt = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.bAddImage = new System.Windows.Forms.Button();
            this.pbAddImage = new System.Windows.Forms.PictureBox();
            this.bSaveImage = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tituleUrl = new System.Windows.Forms.Label();
            this.tbUrlImage = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.tituleUser);
            this.panel3.Controls.Add(this.pbxUser);
            this.panel3.Controls.Add(this.tituleMain1);
            this.panel3.Controls.Add(this.tituleMain);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 73);
            this.panel3.TabIndex = 1;
            // 
            // tituleUser
            // 
            this.tituleUser.AutoSize = true;
            this.tituleUser.BackColor = System.Drawing.Color.Transparent;
            this.tituleUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.tituleUser.Location = new System.Drawing.Point(762, 34);
            this.tituleUser.Name = "tituleUser";
            this.tituleUser.Size = new System.Drawing.Size(77, 13);
            this.tituleUser.TabIndex = 1;
            this.tituleUser.Text = "Maxi Programa";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.Transparent;
            this.pbxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUser.BackgroundImage")));
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUser.Location = new System.Drawing.Point(749, 33);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(15, 15);
            this.pbxUser.TabIndex = 10;
            this.pbxUser.TabStop = false;
            // 
            // tituleMain1
            // 
            this.tituleMain1.AutoSize = true;
            this.tituleMain1.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain1.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain1.Location = new System.Drawing.Point(92, 26);
            this.tituleMain1.Name = "tituleMain1";
            this.tituleMain1.Size = new System.Drawing.Size(147, 25);
            this.tituleMain1.TabIndex = 9;
            this.tituleMain1.Text = "Management";
            // 
            // tituleMain
            // 
            this.tituleMain.AutoSize = true;
            this.tituleMain.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain.Location = new System.Drawing.Point(3, 26);
            this.tituleMain.Name = "tituleMain";
            this.tituleMain.Size = new System.Drawing.Size(93, 25);
            this.tituleMain.TabIndex = 8;
            this.tituleMain.Text = "Catalog";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bExit.Location = new System.Drawing.Point(737, 446);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(85, 22);
            this.bExit.TabIndex = 8;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lPrice.Location = new System.Drawing.Point(52, 301);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(31, 13);
            this.lPrice.TabIndex = 41;
            this.lPrice.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPrice.Location = new System.Drawing.Point(55, 317);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(274, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lCategory.Location = new System.Drawing.Point(52, 262);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(52, 13);
            this.lCategory.TabIndex = 39;
            this.lCategory.Text = "Category:";
            // 
            // tbCodeArt
            // 
            this.tbCodeArt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCodeArt.Location = new System.Drawing.Point(55, 122);
            this.tbCodeArt.Name = "tbCodeArt";
            this.tbCodeArt.Size = new System.Drawing.Size(274, 20);
            this.tbCodeArt.TabIndex = 0;
            // 
            // lMarc
            // 
            this.lMarc.AutoSize = true;
            this.lMarc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lMarc.Location = new System.Drawing.Point(52, 223);
            this.lMarc.Name = "lMarc";
            this.lMarc.Size = new System.Drawing.Size(35, 13);
            this.lMarc.TabIndex = 36;
            this.lMarc.Text = "Brand";
            // 
            // bAddArticle
            // 
            this.bAddArticle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddArticle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAddArticle.Location = new System.Drawing.Point(362, 399);
            this.bAddArticle.Name = "bAddArticle";
            this.bAddArticle.Size = new System.Drawing.Size(92, 23);
            this.bAddArticle.TabIndex = 7;
            this.bAddArticle.Text = "Save";
            this.bAddArticle.UseVisualStyleBackColor = false;
            this.bAddArticle.Click += new System.EventHandler(this.bAddArticle_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDescription.Location = new System.Drawing.Point(55, 200);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(274, 20);
            this.tbDescription.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(55, 161);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(274, 20);
            this.tbName.TabIndex = 1;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lDescription.Location = new System.Drawing.Point(52, 184);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 31;
            this.lDescription.Text = "Description";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lName.Location = new System.Drawing.Point(52, 145);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 30;
            this.lName.Text = "Name";
            // 
            // lCodeArt
            // 
            this.lCodeArt.AutoSize = true;
            this.lCodeArt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lCodeArt.Location = new System.Drawing.Point(52, 106);
            this.lCodeArt.Name = "lCodeArt";
            this.lCodeArt.Size = new System.Drawing.Size(64, 13);
            this.lCodeArt.TabIndex = 29;
            this.lCodeArt.Text = "Code Article";
            // 
            // cbBrand
            // 
            this.cbBrand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBrand.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(55, 240);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(274, 21);
            this.cbBrand.TabIndex = 44;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(55, 277);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(274, 21);
            this.cbCategory.TabIndex = 45;
            // 
            // bAddImage
            // 
            this.bAddImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAddImage.Location = new System.Drawing.Point(747, 116);
            this.bAddImage.Name = "bAddImage";
            this.bAddImage.Size = new System.Drawing.Size(75, 23);
            this.bAddImage.TabIndex = 46;
            this.bAddImage.Text = "Add Image";
            this.bAddImage.UseVisualStyleBackColor = false;
            this.bAddImage.Click += new System.EventHandler(this.bAddImage_Click);
            // 
            // pbAddImage
            // 
            this.pbAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAddImage.Location = new System.Drawing.Point(417, 145);
            this.pbAddImage.Name = "pbAddImage";
            this.pbAddImage.Size = new System.Drawing.Size(285, 192);
            this.pbAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddImage.TabIndex = 47;
            this.pbAddImage.TabStop = false;
            this.pbAddImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbAddImage_DragDrop);
            this.pbAddImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbAddImage_DragEnter);
            // 
            // bSaveImage
            // 
            this.bSaveImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSaveImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bSaveImage.Location = new System.Drawing.Point(747, 145);
            this.bSaveImage.Name = "bSaveImage";
            this.bSaveImage.Size = new System.Drawing.Size(75, 23);
            this.bSaveImage.TabIndex = 48;
            this.bSaveImage.Text = "Save Image";
            this.bSaveImage.UseVisualStyleBackColor = false;
            this.bSaveImage.Click += new System.EventHandler(this.bSaveImage_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBrowse.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bBrowse.Location = new System.Drawing.Point(779, 78);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 49;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Visible = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tituleUrl
            // 
            this.tituleUrl.AutoSize = true;
            this.tituleUrl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tituleUrl.Location = new System.Drawing.Point(414, 103);
            this.tituleUrl.Name = "tituleUrl";
            this.tituleUrl.Size = new System.Drawing.Size(52, 13);
            this.tituleUrl.TabIndex = 51;
            this.tituleUrl.Text = "Url Image";
            // 
            // tbUrlImage
            // 
            this.tbUrlImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUrlImage.Location = new System.Drawing.Point(417, 119);
            this.tbUrlImage.Name = "tbUrlImage";
            this.tbUrlImage.Size = new System.Drawing.Size(285, 20);
            this.tbUrlImage.TabIndex = 50;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.tituleUrl);
            this.Controls.Add(this.tbUrlImage);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bSaveImage);
            this.Controls.Add(this.pbAddImage);
            this.Controls.Add(this.bAddImage);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.tbCodeArt);
            this.Controls.Add(this.lMarc);
            this.Controls.Add(this.bAddArticle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lCodeArt);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tituleUser;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Label tituleMain1;
        private System.Windows.Forms.Label tituleMain;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.TextBox tbCodeArt;
        private System.Windows.Forms.Label lMarc;
        private System.Windows.Forms.Button bAddArticle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCodeArt;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button bAddImage;
        private System.Windows.Forms.PictureBox pbAddImage;
        private System.Windows.Forms.Button bSaveImage;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Label tituleUrl;
        private System.Windows.Forms.TextBox tbUrlImage;
    }
}