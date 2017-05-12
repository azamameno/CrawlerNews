namespace WindowsFormsApp1
{
    partial class Management
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
            this.gbLink = new System.Windows.Forms.GroupBox();
            this.lvCrawlerLink = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSubLink = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSubName = new System.Windows.Forms.Label();
            this.lbSubID = new System.Windows.Forms.Label();
            this.lvSubLink = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.cbRun = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbSubName = new System.Windows.Forms.TextBox();
            this.tbSubURL = new System.Windows.Forms.TextBox();
            this.cbSubRun = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXPathTitle = new System.Windows.Forms.TextBox();
            this.tbXPathDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbXPathImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXPathDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXPathContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSubSave = new System.Windows.Forms.Button();
            this.btSubDelete = new System.Windows.Forms.Button();
            this.gbLink.SuspendLayout();
            this.gbSubLink.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLink
            // 
            this.gbLink.Controls.Add(this.lvCrawlerLink);
            this.gbLink.Location = new System.Drawing.Point(13, 13);
            this.gbLink.Name = "gbLink";
            this.gbLink.Size = new System.Drawing.Size(229, 467);
            this.gbLink.TabIndex = 0;
            this.gbLink.TabStop = false;
            this.gbLink.Text = "Crawler Link";
            // 
            // lvCrawlerLink
            // 
            this.lvCrawlerLink.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.colName,
            this.colRun});
            this.lvCrawlerLink.FullRowSelect = true;
            this.lvCrawlerLink.Location = new System.Drawing.Point(7, 20);
            this.lvCrawlerLink.Name = "lvCrawlerLink";
            this.lvCrawlerLink.Size = new System.Drawing.Size(216, 441);
            this.lvCrawlerLink.TabIndex = 0;
            this.lvCrawlerLink.UseCompatibleStateImageBehavior = false;
            this.lvCrawlerLink.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Width = 0;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 150;
            // 
            // colRun
            // 
            this.colRun.Text = "Run";
            // 
            // gbSubLink
            // 
            this.gbSubLink.Controls.Add(this.btSubDelete);
            this.gbSubLink.Controls.Add(this.btSubSave);
            this.gbSubLink.Controls.Add(this.groupBox3);
            this.gbSubLink.Controls.Add(this.cbSubRun);
            this.gbSubLink.Controls.Add(this.tbSubURL);
            this.gbSubLink.Controls.Add(this.tbSubName);
            this.gbSubLink.Controls.Add(this.label1);
            this.gbSubLink.Controls.Add(this.lbSubName);
            this.gbSubLink.Controls.Add(this.lbSubID);
            this.gbSubLink.Controls.Add(this.lvSubLink);
            this.gbSubLink.Location = new System.Drawing.Point(248, 106);
            this.gbSubLink.Name = "gbSubLink";
            this.gbSubLink.Size = new System.Drawing.Size(710, 374);
            this.gbSubLink.TabIndex = 1;
            this.gbSubLink.TabStop = false;
            this.gbSubLink.Text = "Crawler Sub Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub URL";
            // 
            // lbSubName
            // 
            this.lbSubName.AutoSize = true;
            this.lbSubName.Location = new System.Drawing.Point(241, 34);
            this.lbSubName.Name = "lbSubName";
            this.lbSubName.Size = new System.Drawing.Size(57, 13);
            this.lbSubName.TabIndex = 2;
            this.lbSubName.Text = "Sub Name";
            // 
            // lbSubID
            // 
            this.lbSubID.AutoSize = true;
            this.lbSubID.Location = new System.Drawing.Point(241, 20);
            this.lbSubID.Name = "lbSubID";
            this.lbSubID.Size = new System.Drawing.Size(35, 13);
            this.lbSubID.TabIndex = 1;
            this.lbSubID.Text = "label1";
            this.lbSubID.Visible = false;
            // 
            // lvSubLink
            // 
            this.lvSubLink.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSubLink.FullRowSelect = true;
            this.lvSubLink.Location = new System.Drawing.Point(7, 20);
            this.lvSubLink.Name = "lvSubLink";
            this.lvSubLink.Size = new System.Drawing.Size(217, 348);
            this.lvSubLink.TabIndex = 0;
            this.lvSubLink.UseCompatibleStateImageBehavior = false;
            this.lvSubLink.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Run";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(266, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(35, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "label1";
            this.lbID.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(266, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(266, 53);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(29, 13);
            this.lbURL.TabIndex = 4;
            this.lbURL.Text = "URL";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(307, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(307, 50);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(343, 20);
            this.tbURL.TabIndex = 6;
            // 
            // cbRun
            // 
            this.cbRun.AutoSize = true;
            this.cbRun.Location = new System.Drawing.Point(593, 30);
            this.cbRun.Name = "cbRun";
            this.cbRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRun.Size = new System.Drawing.Size(57, 17);
            this.cbRun.TabIndex = 8;
            this.cbRun.Text = "Is Run";
            this.cbRun.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbSubName
            // 
            this.tbSubName.Location = new System.Drawing.Point(307, 31);
            this.tbSubName.Name = "tbSubName";
            this.tbSubName.Size = new System.Drawing.Size(311, 20);
            this.tbSubName.TabIndex = 4;
            // 
            // tbSubURL
            // 
            this.tbSubURL.Location = new System.Drawing.Point(307, 56);
            this.tbSubURL.Name = "tbSubURL";
            this.tbSubURL.Size = new System.Drawing.Size(374, 20);
            this.tbSubURL.TabIndex = 5;
            // 
            // cbSubRun
            // 
            this.cbSubRun.AutoSize = true;
            this.cbSubRun.Location = new System.Drawing.Point(624, 33);
            this.cbSubRun.Name = "cbSubRun";
            this.cbSubRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSubRun.Size = new System.Drawing.Size(57, 17);
            this.cbSubRun.TabIndex = 6;
            this.cbSubRun.Text = "Is Run";
            this.cbSubRun.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbXPathContent);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbXPathDescription);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbXPathImage);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbXPathDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbXPathTitle);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(244, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 153);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // tbXPathTitle
            // 
            this.tbXPathTitle.Location = new System.Drawing.Point(75, 17);
            this.tbXPathTitle.Name = "tbXPathTitle";
            this.tbXPathTitle.Size = new System.Drawing.Size(348, 20);
            this.tbXPathTitle.TabIndex = 1;
            // 
            // tbXPathDate
            // 
            this.tbXPathDate.Location = new System.Drawing.Point(75, 43);
            this.tbXPathDate.Name = "tbXPathDate";
            this.tbXPathDate.Size = new System.Drawing.Size(348, 20);
            this.tbXPathDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // tbXPathImage
            // 
            this.tbXPathImage.Location = new System.Drawing.Point(75, 69);
            this.tbXPathImage.Name = "tbXPathImage";
            this.tbXPathImage.Size = new System.Drawing.Size(348, 20);
            this.tbXPathImage.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Image";
            // 
            // tbXPathDescription
            // 
            this.tbXPathDescription.Location = new System.Drawing.Point(75, 95);
            this.tbXPathDescription.Name = "tbXPathDescription";
            this.tbXPathDescription.Size = new System.Drawing.Size(348, 20);
            this.tbXPathDescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // tbXPathContent
            // 
            this.tbXPathContent.Location = new System.Drawing.Point(75, 121);
            this.tbXPathContent.Name = "tbXPathContent";
            this.tbXPathContent.Size = new System.Drawing.Size(348, 20);
            this.tbXPathContent.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Content";
            // 
            // btSubSave
            // 
            this.btSubSave.Location = new System.Drawing.Point(307, 255);
            this.btSubSave.Name = "btSubSave";
            this.btSubSave.Size = new System.Drawing.Size(75, 23);
            this.btSubSave.TabIndex = 8;
            this.btSubSave.Text = "Save";
            this.btSubSave.UseVisualStyleBackColor = true;
            // 
            // btSubDelete
            // 
            this.btSubDelete.Location = new System.Drawing.Point(398, 255);
            this.btSubDelete.Name = "btSubDelete";
            this.btSubDelete.Size = new System.Drawing.Size(75, 23);
            this.btSubDelete.TabIndex = 9;
            this.btSubDelete.Text = "Delete";
            this.btSubDelete.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 492);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbRun);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.gbSubLink);
            this.Controls.Add(this.gbLink);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.gbLink.ResumeLayout(false);
            this.gbSubLink.ResumeLayout(false);
            this.gbSubLink.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLink;
        private System.Windows.Forms.ListView lvCrawlerLink;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colRun;
        private System.Windows.Forms.GroupBox gbSubLink;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.CheckBox cbRun;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvSubLink;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSubName;
        private System.Windows.Forms.Label lbSubID;
        private System.Windows.Forms.CheckBox cbSubRun;
        private System.Windows.Forms.TextBox tbSubURL;
        private System.Windows.Forms.TextBox tbSubName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbXPathContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbXPathDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbXPathImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXPathDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbXPathTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSubDelete;
        private System.Windows.Forms.Button btSubSave;
    }
}