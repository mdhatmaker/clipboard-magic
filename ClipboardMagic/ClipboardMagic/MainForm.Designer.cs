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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.listWavs = new System.Windows.Forms.ListBox();
            this.listUrls = new System.Windows.Forms.ListBox();
            this.listClipboardSnippets = new System.Windows.Forms.ListBox();
            this.picImages = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnPython = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).BeginInit();
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
            this.tableLayoutPanelMain.Controls.Add(this.picImages, 2, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(5, 78);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1090, 380);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // listWavs
            // 
            this.listWavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWavs.FormattingEnabled = true;
            this.listWavs.ItemHeight = 20;
            this.listWavs.Location = new System.Drawing.Point(819, 3);
            this.listWavs.Name = "listWavs";
            this.listWavs.Size = new System.Drawing.Size(268, 298);
            this.listWavs.TabIndex = 4;
            // 
            // listUrls
            // 
            this.listUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUrls.FormattingEnabled = true;
            this.listUrls.ItemHeight = 20;
            this.listUrls.Location = new System.Drawing.Point(275, 3);
            this.listUrls.Name = "listUrls";
            this.listUrls.Size = new System.Drawing.Size(266, 298);
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
            this.listClipboardSnippets.Size = new System.Drawing.Size(266, 298);
            this.listClipboardSnippets.TabIndex = 1;
            this.listClipboardSnippets.Click += new System.EventHandler(this.listClipboardSnippets_Click);
            // 
            // picImages
            // 
            this.picImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImages.Location = new System.Drawing.Point(547, 3);
            this.picImages.Name = "picImages";
            this.picImages.Size = new System.Drawing.Size(266, 298);
            this.picImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImages.TabIndex = 2;
            this.picImages.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Location = new System.Drawing.Point(5, 48);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(1090, 27);
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
            this.tsbtnPython});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1114, 34);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnPython
            // 
            this.tsbtnPython.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPython.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPython.Image")));
            this.tsbtnPython.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPython.Name = "tsbtnPython";
            this.tsbtnPython.Size = new System.Drawing.Size(73, 29);
            this.tsbtnPython.Text = "python";
            this.tsbtnPython.ToolTipText = "Create and run python scripts";
            this.tsbtnPython.Click += new System.EventHandler(this.tsbtnPython_Click);
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
            this.Name = "MainForm";
            this.Text = "Clipboard Magic";
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.ListBox listClipboardSnippets;
        private System.Windows.Forms.PictureBox picImages;
        private System.Windows.Forms.ListBox listWavs;
        private System.Windows.Forms.ListBox listUrls;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnPython;
    }
}

