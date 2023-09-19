
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.dgArticles = new System.Windows.Forms.DataGridView();
            this.cbxCriterion = new System.Windows.Forms.ComboBox();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSerch = new System.Windows.Forms.TextBox();
            this.btnSerch = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAddField = new System.Windows.Forms.Button();
            this.pbBackward = new System.Windows.Forms.PictureBox();
            this.pbfoward = new System.Windows.Forms.PictureBox();
            this.ImagesCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoward)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 73);
            this.panel1.TabIndex = 0;
            // 
            // tituleUser
            // 
            this.tituleUser.AutoSize = true;
            this.tituleUser.BackColor = System.Drawing.Color.Transparent;
            this.tituleUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.tituleUser.Location = new System.Drawing.Point(762, 31);
            this.tituleUser.Name = "tituleUser";
            this.tituleUser.Size = new System.Drawing.Size(58, 13);
            this.tituleUser.TabIndex = 1;
            this.tituleUser.Text = "User guest";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.Transparent;
            this.pbxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUser.BackgroundImage")));
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUser.Location = new System.Drawing.Point(749, 30);
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
            this.tituleMain1.Location = new System.Drawing.Point(92, 23);
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
            this.tituleMain.Location = new System.Drawing.Point(3, 23);
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
            this.bExit.TabIndex = 11;
            this.bExit.Text = "Close";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbDescription.Location = new System.Drawing.Point(517, 331);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(302, 49);
            this.rtbDescription.TabIndex = 12;
            this.rtbDescription.Text = "";
            // 
            // tituleDescription
            // 
            this.tituleDescription.AutoSize = true;
            this.tituleDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tituleDescription.Location = new System.Drawing.Point(514, 315);
            this.tituleDescription.Name = "tituleDescription";
            this.tituleDescription.Size = new System.Drawing.Size(63, 13);
            this.tituleDescription.TabIndex = 13;
            this.tituleDescription.Text = "Description ";
            // 
            // pbImgArticles
            // 
            this.pbImgArticles.Location = new System.Drawing.Point(540, 97);
            this.pbImgArticles.Name = "pbImgArticles";
            this.pbImgArticles.Size = new System.Drawing.Size(250, 205);
            this.pbImgArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgArticles.TabIndex = 14;
            this.pbImgArticles.TabStop = false;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAdd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAdd.Location = new System.Drawing.Point(517, 401);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 22);
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
            this.bEdit.Location = new System.Drawing.Point(599, 401);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(58, 22);
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
            this.bDelete.Location = new System.Drawing.Point(680, 401);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(60, 22);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dgArticles
            // 
            this.dgArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArticles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgArticles.ColumnHeadersHeight = 29;
            this.dgArticles.Location = new System.Drawing.Point(36, 134);
            this.dgArticles.Margin = new System.Windows.Forms.Padding(2);
            this.dgArticles.Name = "dgArticles";
            this.dgArticles.RowHeadersWidth = 51;
            this.dgArticles.RowTemplate.Height = 24;
            this.dgArticles.Size = new System.Drawing.Size(436, 289);
            this.dgArticles.TabIndex = 19;
            this.dgArticles.SelectionChanged += new System.EventHandler(this.dgArticles_SelectionChanged);
            // 
            // cbxCriterion
            // 
            this.cbxCriterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxCriterion.FormattingEnabled = true;
            this.cbxCriterion.Location = new System.Drawing.Point(218, 96);
            this.cbxCriterion.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCriterion.Name = "cbxCriterion";
            this.cbxCriterion.Size = new System.Drawing.Size(92, 21);
            this.cbxCriterion.TabIndex = 22;
            // 
            // cbxField
            // 
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Location = new System.Drawing.Point(65, 96);
            this.cbxField.Margin = new System.Windows.Forms.Padding(2);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(92, 21);
            this.cbxField.TabIndex = 23;
            this.cbxField.SelectedIndexChanged += new System.EventHandler(this.cbxField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Criterion";
            // 
            // txbSerch
            // 
            this.txbSerch.Location = new System.Drawing.Point(355, 97);
            this.txbSerch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSerch.Name = "txbSerch";
            this.txbSerch.Size = new System.Drawing.Size(98, 20);
            this.txbSerch.TabIndex = 26;
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.Transparent;
            this.btnSerch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSerch.ImageLocation = "https://th.bing.com/th/id/R.0c415a07d7ed354ac0ef10f6c0bbed62?rik=BTw%2bmrKbK9FUOg" +
    "&pid=ImgRaw&r=0";
            this.btnSerch.Location = new System.Drawing.Point(453, 97);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(18, 20);
            this.btnSerch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSerch.TabIndex = 27;
            this.btnSerch.TabStop = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filter";
            // 
            // bAddField
            // 
            this.bAddField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bAddField.Location = new System.Drawing.Point(762, 401);
            this.bAddField.Name = "bAddField";
            this.bAddField.Size = new System.Drawing.Size(60, 22);
            this.bAddField.TabIndex = 29;
            this.bAddField.Text = "Edit Field";
            this.bAddField.UseVisualStyleBackColor = false;
            this.bAddField.Visible = false;
            this.bAddField.Click += new System.EventHandler(this.bAddField_Click);
            // 
            // pbBackward
            // 
            this.pbBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBackward.BackgroundImage")));
            this.pbBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackward.Location = new System.Drawing.Point(511, 189);
            this.pbBackward.Name = "pbBackward";
            this.pbBackward.Size = new System.Drawing.Size(31, 33);
            this.pbBackward.TabIndex = 30;
            this.pbBackward.TabStop = false;
            this.pbBackward.Click += new System.EventHandler(this.pbBackward_Click);
            // 
            // pbfoward
            // 
            this.pbfoward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbfoward.BackgroundImage")));
            this.pbfoward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbfoward.Location = new System.Drawing.Point(788, 189);
            this.pbfoward.Name = "pbfoward";
            this.pbfoward.Size = new System.Drawing.Size(31, 33);
            this.pbfoward.TabIndex = 31;
            this.pbfoward.TabStop = false;
            this.pbfoward.Click += new System.EventHandler(this.pbfoward_Click);
            // 
            // ImagesCount
            // 
            this.ImagesCount.AutoSize = true;
            this.ImagesCount.Location = new System.Drawing.Point(655, 305);
            this.ImagesCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImagesCount.Name = "ImagesCount";
            this.ImagesCount.Size = new System.Drawing.Size(24, 13);
            this.ImagesCount.TabIndex = 32;
            this.ImagesCount.Text = "0/0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.ImagesCount);
            this.Controls.Add(this.pbfoward);
            this.Controls.Add(this.pbBackward);
            this.Controls.Add(this.bAddField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.txbSerch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxField);
            this.Controls.Add(this.cbxCriterion);
            this.Controls.Add(this.dgArticles);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.pbImgArticles);
            this.Controls.Add(this.tituleDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog Management";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSerch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoward)).EndInit();
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
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dgArticles;
        private System.Windows.Forms.ComboBox cbxCriterion;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSerch;
        private System.Windows.Forms.PictureBox btnSerch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddField;
        private System.Windows.Forms.PictureBox pbBackward;
        private System.Windows.Forms.PictureBox pbfoward;
        private System.Windows.Forms.Label ImagesCount;
    }
}