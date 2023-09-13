
namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituleUser = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.tituleMain1 = new System.Windows.Forms.Label();
            this.tituleMain = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tituleDescription = new System.Windows.Forms.Label();
            this.pbImgArticles = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.dgArticles = new System.Windows.Forms.DataGridView();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.rBName = new System.Windows.Forms.RadioButton();
            this.rBCategory = new System.Windows.Forms.RadioButton();
            this.rBBrand = new System.Windows.Forms.RadioButton();
            this.rBPrice = new System.Windows.Forms.RadioButton();
            this.cbxMinNum = new System.Windows.Forms.NumericUpDown();
            this.cbxMaxNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMaxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tituleUser);
            this.panel1.Controls.Add(this.pbxUser);
            this.panel1.Controls.Add(this.tituleMain1);
            this.panel1.Controls.Add(this.tituleMain);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 80);
            this.panel1.TabIndex = 0;
            // 
            // tituleUser
            // 
            this.tituleUser.AutoSize = true;
            this.tituleUser.BackColor = System.Drawing.Color.Transparent;
            this.tituleUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.tituleUser.Location = new System.Drawing.Point(1016, 31);
            this.tituleUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituleUser.Name = "tituleUser";
            this.tituleUser.Size = new System.Drawing.Size(72, 16);
            this.tituleUser.TabIndex = 1;
            this.tituleUser.Text = "User guest";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.Transparent;
            this.pbxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUser.BackgroundImage")));
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUser.Location = new System.Drawing.Point(999, 30);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(20, 18);
            this.pbxUser.TabIndex = 10;
            this.pbxUser.TabStop = false;
            // 
            // tituleMain1
            // 
            this.tituleMain1.AutoSize = true;
            this.tituleMain1.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain1.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain1.Location = new System.Drawing.Point(123, 21);
            this.tituleMain1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituleMain1.Name = "tituleMain1";
            this.tituleMain1.Size = new System.Drawing.Size(181, 31);
            this.tituleMain1.TabIndex = 9;
            this.tituleMain1.Text = "Management";
            // 
            // tituleMain
            // 
            this.tituleMain.AutoSize = true;
            this.tituleMain.BackColor = System.Drawing.Color.Transparent;
            this.tituleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituleMain.ForeColor = System.Drawing.SystemColors.Window;
            this.tituleMain.Location = new System.Drawing.Point(4, 21);
            this.tituleMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituleMain.Name = "tituleMain";
            this.tituleMain.Size = new System.Drawing.Size(115, 31);
            this.tituleMain.TabIndex = 8;
            this.tituleMain.Text = "Catalog";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bExit.Location = new System.Drawing.Point(983, 549);
            this.bExit.Margin = new System.Windows.Forms.Padding(4);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(113, 27);
            this.bExit.TabIndex = 11;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbDescription.Location = new System.Drawing.Point(717, 377);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(344, 73);
            this.rtbDescription.TabIndex = 12;
            this.rtbDescription.Text = "";
            // 
            // tituleDescription
            // 
            this.tituleDescription.AutoSize = true;
            this.tituleDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tituleDescription.Location = new System.Drawing.Point(713, 357);
            this.tituleDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituleDescription.Name = "tituleDescription";
            this.tituleDescription.Size = new System.Drawing.Size(78, 16);
            this.tituleDescription.TabIndex = 13;
            this.tituleDescription.Text = "Description ";
            // 
            // pbImgArticles
            // 
            this.pbImgArticles.Location = new System.Drawing.Point(717, 101);
            this.pbImgArticles.Margin = new System.Windows.Forms.Padding(4);
            this.pbImgArticles.Name = "pbImgArticles";
            this.pbImgArticles.Size = new System.Drawing.Size(345, 252);
            this.pbImgArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgArticles.TabIndex = 14;
            this.pbImgArticles.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSearch.Location = new System.Drawing.Point(9, 101);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(348, 22);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAdd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAdd.Location = new System.Drawing.Point(717, 475);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(80, 27);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Visible = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEdit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bEdit.Location = new System.Drawing.Point(852, 475);
            this.bEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(77, 27);
            this.bEdit.TabIndex = 17;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Visible = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bDelete.Location = new System.Drawing.Point(983, 475);
            this.bDelete.Margin = new System.Windows.Forms.Padding(4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(80, 27);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dgArticles
            // 
            this.dgArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticles.Location = new System.Drawing.Point(13, 208);
            this.dgArticles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgArticles.Name = "dgArticles";
            this.dgArticles.RowHeadersWidth = 51;
            this.dgArticles.RowTemplate.Height = 24;
            this.dgArticles.Size = new System.Drawing.Size(599, 358);
            this.dgArticles.TabIndex = 19;
            this.dgArticles.SelectionChanged += new System.EventHandler(this.dgArticles_SelectionChanged);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar.Location = new System.Drawing.Point(1069, 151);
            this.btnAvanzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(25, 106);
            this.btnAvanzar.TabIndex = 20;
            this.btnAvanzar.Text = ">";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(685, 151);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(25, 106);
            this.btnRetroceder.TabIndex = 21;
            this.btnRetroceder.Text = "<";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(527, 101);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 24);
            this.cbxBrand.TabIndex = 22;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(389, 101);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory.TabIndex = 23;
            // 
            // rBName
            // 
            this.rBName.AutoSize = true;
            this.rBName.Location = new System.Drawing.Point(23, 160);
            this.rBName.Name = "rBName";
            this.rBName.Size = new System.Drawing.Size(93, 20);
            this.rBName.TabIndex = 24;
            this.rBName.TabStop = true;
            this.rBName.Text = "Item Name";
            this.rBName.UseVisualStyleBackColor = true;
            // 
            // rBCategory
            // 
            this.rBCategory.AutoSize = true;
            this.rBCategory.Location = new System.Drawing.Point(149, 160);
            this.rBCategory.Name = "rBCategory";
            this.rBCategory.Size = new System.Drawing.Size(83, 20);
            this.rBCategory.TabIndex = 25;
            this.rBCategory.TabStop = true;
            this.rBCategory.Text = "Category";
            this.rBCategory.UseVisualStyleBackColor = true;
            // 
            // rBBrand
            // 
            this.rBBrand.AutoSize = true;
            this.rBBrand.Location = new System.Drawing.Point(268, 160);
            this.rBBrand.Name = "rBBrand";
            this.rBBrand.Size = new System.Drawing.Size(64, 20);
            this.rBBrand.TabIndex = 26;
            this.rBBrand.TabStop = true;
            this.rBBrand.Text = "Brand";
            this.rBBrand.UseVisualStyleBackColor = true;
            // 
            // rBPrice
            // 
            this.rBPrice.AutoSize = true;
            this.rBPrice.Location = new System.Drawing.Point(386, 160);
            this.rBPrice.Name = "rBPrice";
            this.rBPrice.Size = new System.Drawing.Size(59, 20);
            this.rBPrice.TabIndex = 27;
            this.rBPrice.TabStop = true;
            this.rBPrice.Text = "Price";
            this.rBPrice.UseVisualStyleBackColor = true;
            // 
            // cbxMinNum
            // 
            this.cbxMinNum.Location = new System.Drawing.Point(528, 151);
            this.cbxMinNum.Name = "cbxMinNum";
            this.cbxMinNum.Size = new System.Drawing.Size(120, 22);
            this.cbxMinNum.TabIndex = 28;
            // 
            // cbxMaxNum
            // 
            this.cbxMaxNum.Location = new System.Drawing.Point(527, 179);
            this.cbxMaxNum.Name = "cbxMaxNum";
            this.cbxMaxNum.Size = new System.Drawing.Size(120, 22);
            this.cbxMaxNum.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Between";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "And";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Search by :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1139, 591);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMaxNum);
            this.Controls.Add(this.cbxMinNum);
            this.Controls.Add(this.rBPrice);
            this.Controls.Add(this.rBBrand);
            this.Controls.Add(this.rBCategory);
            this.Controls.Add(this.rBName);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.dgArticles);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbImgArticles);
            this.Controls.Add(this.tituleDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMaxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituleMain1;
        private System.Windows.Forms.Label tituleMain;
        private System.Windows.Forms.Label tituleUser;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label tituleDescription;
        private System.Windows.Forms.PictureBox pbImgArticles;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dgArticles;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.RadioButton rBName;
        private System.Windows.Forms.RadioButton rBCategory;
        private System.Windows.Forms.RadioButton rBBrand;
        private System.Windows.Forms.RadioButton rBPrice;
        private System.Windows.Forms.NumericUpDown cbxMinNum;
        private System.Windows.Forms.NumericUpDown cbxMaxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}