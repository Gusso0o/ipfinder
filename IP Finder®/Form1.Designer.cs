
namespace IP_Finder_
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteIPGrabberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myIPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpWithIPFinderPROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsMySubnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpWithToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howMyIPWorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howWebsiteIPGrabberWorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.iPPingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subnet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 370);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IP Address";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HostName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveRecordToolStripMenuItem,
            this.openRecordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveRecordToolStripMenuItem
            // 
            this.saveRecordToolStripMenuItem.Name = "saveRecordToolStripMenuItem";
            this.saveRecordToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveRecordToolStripMenuItem.Text = "Save record";
            // 
            // openRecordToolStripMenuItem
            // 
            this.openRecordToolStripMenuItem.Name = "openRecordToolStripMenuItem";
            this.openRecordToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.openRecordToolStripMenuItem.Text = "Open record";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteIPGrabberToolStripMenuItem,
            this.myIPToolStripMenuItem1,
            this.iPPingToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem1.Text = "Tools";
            this.toolsToolStripMenuItem1.Click += new System.EventHandler(this.toolsToolStripMenuItem1_Click);
            // 
            // websiteIPGrabberToolStripMenuItem
            // 
            this.websiteIPGrabberToolStripMenuItem.Name = "websiteIPGrabberToolStripMenuItem";
            this.websiteIPGrabberToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.websiteIPGrabberToolStripMenuItem.Text = "Website IP Grabber";
            this.websiteIPGrabberToolStripMenuItem.Click += new System.EventHandler(this.websiteIPGrabberToolStripMenuItem_Click_1);
            // 
            // myIPToolStripMenuItem1
            // 
            this.myIPToolStripMenuItem1.Name = "myIPToolStripMenuItem1";
            this.myIPToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.myIPToolStripMenuItem1.Text = "My IP";
            this.myIPToolStripMenuItem1.Click += new System.EventHandler(this.myIPToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpWithIPFinderPROToolStripMenuItem,
            this.helpWithToolsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpWithIPFinderPROToolStripMenuItem
            // 
            this.helpWithIPFinderPROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatsMySubnetToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpWithIPFinderPROToolStripMenuItem.Name = "helpWithIPFinderPROToolStripMenuItem";
            this.helpWithIPFinderPROToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.helpWithIPFinderPROToolStripMenuItem.Text = "Help with IP Finder®";
            // 
            // whatsMySubnetToolStripMenuItem
            // 
            this.whatsMySubnetToolStripMenuItem.Name = "whatsMySubnetToolStripMenuItem";
            this.whatsMySubnetToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.whatsMySubnetToolStripMenuItem.Text = "What\'s my subnet?";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // helpWithToolsToolStripMenuItem
            // 
            this.helpWithToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howMyIPWorksToolStripMenuItem,
            this.howWebsiteIPGrabberWorksToolStripMenuItem});
            this.helpWithToolsToolStripMenuItem.Name = "helpWithToolsToolStripMenuItem";
            this.helpWithToolsToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.helpWithToolsToolStripMenuItem.Text = "Help with tools";
            // 
            // howMyIPWorksToolStripMenuItem
            // 
            this.howMyIPWorksToolStripMenuItem.Name = "howMyIPWorksToolStripMenuItem";
            this.howMyIPWorksToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.howMyIPWorksToolStripMenuItem.Text = "How My IP works?";
            // 
            // howWebsiteIPGrabberWorksToolStripMenuItem
            // 
            this.howWebsiteIPGrabberWorksToolStripMenuItem.Name = "howWebsiteIPGrabberWorksToolStripMenuItem";
            this.howWebsiteIPGrabberWorksToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.howWebsiteIPGrabberWorksToolStripMenuItem.Text = "How Website IP grabber works?";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // iPPingToolStripMenuItem
            // 
            this.iPPingToolStripMenuItem.Name = "iPPingToolStripMenuItem";
            this.iPPingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iPPingToolStripMenuItem.Text = "IP Ping";
            this.iPPingToolStripMenuItem.Click += new System.EventHandler(this.iPPingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Finder®";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem websiteIPGrabberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myIPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpWithIPFinderPROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsMySubnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpWithToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howMyIPWorksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howWebsiteIPGrabberWorksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPPingToolStripMenuItem;
    }
}

