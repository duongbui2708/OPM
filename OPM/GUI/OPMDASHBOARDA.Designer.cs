
namespace OPM.GUI
{
    partial class OPMDASHBOARDA
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
            this.panHeader = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContent = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panCatalog = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.panContent = new System.Windows.Forms.Panel();
            this.panDescription = new System.Windows.Forms.Panel();
            this.panHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panCatalog.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panHeader.Controls.Add(this.tabControl1);
            this.panHeader.Location = new System.Drawing.Point(5, 5);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(250, 100);
            this.panHeader.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabContent);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabContent
            // 
            this.tabContent.Location = new System.Drawing.Point(4, 27);
            this.tabContent.Name = "tabContent";
            this.tabContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabContent.Size = new System.Drawing.Size(251, 69);
            this.tabContent.TabIndex = 0;
            this.tabContent.Text = "Content";
            this.tabContent.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.textBox1);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.btnEnter);
            this.tabSearch.Location = new System.Drawing.Point(4, 27);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(251, 69);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the word ";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(185, 24);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(54, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // panCatalog
            // 
            this.panCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panCatalog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panCatalog.Controls.Add(this.treeView1);
            this.panCatalog.Location = new System.Drawing.Point(9, 100);
            this.panCatalog.Name = "panCatalog";
            this.panCatalog.Size = new System.Drawing.Size(246, 465);
            this.panCatalog.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip;
            this.treeView1.ItemHeight = 20;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(246, 465);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRefresh,
            this.toolStripMenuNew,
            this.toolStripMenuEdit,
            this.toolStripMenuDelete,
            this.toolStripMenuExport});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 114);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // toolStripMenuRefresh
            // 
            this.toolStripMenuRefresh.Name = "toolStripMenuRefresh";
            this.toolStripMenuRefresh.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuRefresh.Text = "Refresh";
            // 
            // toolStripMenuNew
            // 
            this.toolStripMenuNew.Name = "toolStripMenuNew";
            this.toolStripMenuNew.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuNew.Text = "New";
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.CheckOnClick = true;
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuEdit.Text = "Edit";
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuDelete.Text = "Delete";
            // 
            // toolStripMenuExport
            // 
            this.toolStripMenuExport.Name = "toolStripMenuExport";
            this.toolStripMenuExport.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuExport.Text = "Export Document";
            // 
            // panContent
            // 
            this.panContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panContent.Location = new System.Drawing.Point(261, 5);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(488, 560);
            this.panContent.TabIndex = 2;
            // 
            // panDescription
            // 
            this.panDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDescription.Location = new System.Drawing.Point(738, 5);
            this.panDescription.Name = "panDescription";
            this.panDescription.Size = new System.Drawing.Size(262, 560);
            this.panDescription.TabIndex = 3;
            // 
            // OPMDASHBOARDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 571);
            this.Controls.Add(this.panDescription);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panCatalog);
            this.Controls.Add(this.panHeader);
            this.Name = "OPMDASHBOARDA";
            this.Text = "OPMDASHBOARDA";
            this.Load += new System.EventHandler(this.OPMDASHBOARDA_Load);
            this.panHeader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.panCatalog.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panCatalog;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Panel panDescription;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContent;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
    }
}