namespace ClipboardMagic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.listWavs = new System.Windows.Forms.ListBox();
            this.listUrls = new System.Windows.Forms.ListBox();
            this.listClipboardSnippets = new System.Windows.Forms.ListBox();
            this.lblText = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnPython = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFilterDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.filterAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lviewImages = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanelMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.listWavs, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.listUrls, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.listClipboardSnippets, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.lviewImages, 2, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(9, 78);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1093, 371);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // listWavs
            // 
            this.listWavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWavs.FormattingEnabled = true;
            this.listWavs.ItemHeight = 20;
            this.listWavs.Location = new System.Drawing.Point(822, 3);
            this.listWavs.Name = "listWavs";
            this.listWavs.Size = new System.Drawing.Size(268, 290);
            this.listWavs.TabIndex = 4;
            // 
            // listUrls
            // 
            this.listUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUrls.FormattingEnabled = true;
            this.listUrls.ItemHeight = 20;
            this.listUrls.Location = new System.Drawing.Point(276, 3);
            this.listUrls.Name = "listUrls";
            this.listUrls.Size = new System.Drawing.Size(267, 290);
            this.listUrls.TabIndex = 3;
            this.listUrls.Click += new System.EventHandler(this.listUrls_Click);
            this.listUrls.DoubleClick += new System.EventHandler(this.listUrls_DoubleClick);
            // 
            // listClipboardSnippets
            // 
            this.listClipboardSnippets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listClipboardSnippets.FormattingEnabled = true;
            this.listClipboardSnippets.ItemHeight = 20;
            this.listClipboardSnippets.Location = new System.Drawing.Point(3, 3);
            this.listClipboardSnippets.Name = "listClipboardSnippets";
            this.listClipboardSnippets.Size = new System.Drawing.Size(267, 290);
            this.listClipboardSnippets.TabIndex = 1;
            this.listClipboardSnippets.Click += new System.EventHandler(this.listClipboardSnippets_Click);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Location = new System.Drawing.Point(5, 48);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.lblText.Size = new System.Drawing.Size(1097, 27);
            this.lblText.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1114, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPython,
            this.tsbtnFilterDropdown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1114, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnPython
            // 
            this.tsbtnPython.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPython.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPython.Image")));
            this.tsbtnPython.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPython.Name = "tsbtnPython";
            this.tsbtnPython.Size = new System.Drawing.Size(73, 33);
            this.tsbtnPython.Text = "python";
            this.tsbtnPython.ToolTipText = "Create and run python scripts";
            this.tsbtnPython.Click += new System.EventHandler(this.tsbtnPython_Click);
            // 
            // tsbtnFilterDropdown
            // 
            this.tsbtnFilterDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnFilterDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAToolStripMenuItem,
            this.filterBToolStripMenuItem});
            this.tsbtnFilterDropdown.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFilterDropdown.Image")));
            this.tsbtnFilterDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFilterDropdown.Name = "tsbtnFilterDropdown";
            this.tsbtnFilterDropdown.Size = new System.Drawing.Size(65, 33);
            this.tsbtnFilterDropdown.Text = "filter";
            this.tsbtnFilterDropdown.ToolTipText = "Run filter (python script)";
            // 
            // filterAToolStripMenuItem
            // 
            this.filterAToolStripMenuItem.Name = "filterAToolStripMenuItem";
            this.filterAToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.filterAToolStripMenuItem.Text = "filter A";
            this.filterAToolStripMenuItem.Click += new System.EventHandler(this.filterAToolStripMenuItem_Click);
            // 
            // filterBToolStripMenuItem
            // 
            this.filterBToolStripMenuItem.Name = "filterBToolStripMenuItem";
            this.filterBToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.filterBToolStripMenuItem.Text = "filter B";
            // 
            // lviewImages
            // 
            this.lviewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewImages.HideSelection = false;
            this.lviewImages.LargeImageList = this.imageList1;
            this.lviewImages.Location = new System.Drawing.Point(549, 3);
            this.lviewImages.Name = "lviewImages";
            this.lviewImages.Size = new System.Drawing.Size(267, 290);
            this.lviewImages.TabIndex = 5;
            this.lviewImages.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 483);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Clipboard Magic";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ListBox listClipboardSnippets;
        private System.Windows.Forms.ListBox listWavs;
        private System.Windows.Forms.ListBox listUrls;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnPython;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnFilterDropdown;
        private System.Windows.Forms.ToolStripMenuItem filterAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterBToolStripMenuItem;
        private System.Windows.Forms.ListView lviewImages;
        private System.Windows.Forms.ImageList imageList1;
    }
}

