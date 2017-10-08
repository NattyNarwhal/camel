namespace Camel
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.resultsSplitter = new System.Windows.Forms.SplitContainer();
            this.replaceSplitter = new System.Windows.Forms.SplitContainer();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.replacedBox = new System.Windows.Forms.TextBox();
            this.resultsTree = new System.Windows.Forms.TreeView();
            this.resultsImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multilineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explicitCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignorePatternWhitespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compiledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultureInvariantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCMAScriptModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regexBoxToolStrip = new System.Windows.Forms.ToolStrip();
            this.regexBoxLabel = new System.Windows.Forms.ToolStripLabel();
            this.regexBox = new Camel.ToolStripSpringTextBox();
            this.ignoreCaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.multilineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.singlelineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.explicitCapturingToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ignorePatternWhitespaceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.replaceBoxToolStrip = new System.Windows.Forms.ToolStrip();
            this.replaceBoxLabel = new System.Windows.Forms.ToolStripLabel();
            this.replaceBox = new Camel.ToolStripSpringTextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsSplitter)).BeginInit();
            this.resultsSplitter.Panel1.SuspendLayout();
            this.resultsSplitter.Panel2.SuspendLayout();
            this.resultsSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceSplitter)).BeginInit();
            this.replaceSplitter.Panel1.SuspendLayout();
            this.replaceSplitter.Panel2.SuspendLayout();
            this.replaceSplitter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.regexBoxToolStrip.SuspendLayout();
            this.replaceBoxToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.resultsSplitter);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(441, 373);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(441, 422);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.regexBoxToolStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.replaceBoxToolStrip);
            // 
            // resultsSplitter
            // 
            this.resultsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsSplitter.Location = new System.Drawing.Point(0, 0);
            this.resultsSplitter.Name = "resultsSplitter";
            // 
            // resultsSplitter.Panel1
            // 
            this.resultsSplitter.Panel1.Controls.Add(this.replaceSplitter);
            // 
            // resultsSplitter.Panel2
            // 
            this.resultsSplitter.Panel2.Controls.Add(this.resultsTree);
            this.resultsSplitter.Size = new System.Drawing.Size(441, 373);
            this.resultsSplitter.SplitterDistance = 288;
            this.resultsSplitter.TabIndex = 0;
            // 
            // replaceSplitter
            // 
            this.replaceSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceSplitter.Location = new System.Drawing.Point(0, 0);
            this.replaceSplitter.Name = "replaceSplitter";
            this.replaceSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // replaceSplitter.Panel1
            // 
            this.replaceSplitter.Panel1.Controls.Add(this.contentBox);
            // 
            // replaceSplitter.Panel2
            // 
            this.replaceSplitter.Panel2.Controls.Add(this.replacedBox);
            this.replaceSplitter.Panel2Collapsed = true;
            this.replaceSplitter.Size = new System.Drawing.Size(288, 373);
            this.replaceSplitter.SplitterDistance = 96;
            this.replaceSplitter.TabIndex = 0;
            // 
            // contentBox
            // 
            this.contentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentBox.HideSelection = false;
            this.contentBox.Location = new System.Drawing.Point(0, 0);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(288, 373);
            this.contentBox.TabIndex = 2;
            this.contentBox.TextChanged += new System.EventHandler(this.UpdateRegexStateEvent);
            // 
            // replacedBox
            // 
            this.replacedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replacedBox.HideSelection = false;
            this.replacedBox.Location = new System.Drawing.Point(0, 0);
            this.replacedBox.Multiline = true;
            this.replacedBox.Name = "replacedBox";
            this.replacedBox.ReadOnly = true;
            this.replacedBox.Size = new System.Drawing.Size(150, 46);
            this.replacedBox.TabIndex = 0;
            // 
            // resultsTree
            // 
            this.resultsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTree.FullRowSelect = true;
            this.resultsTree.ImageIndex = 0;
            this.resultsTree.ImageList = this.resultsImageList;
            this.resultsTree.Location = new System.Drawing.Point(0, 0);
            this.resultsTree.Name = "resultsTree";
            this.resultsTree.SelectedImageIndex = 0;
            this.resultsTree.ShowNodeToolTips = true;
            this.resultsTree.Size = new System.Drawing.Size(149, 373);
            this.resultsTree.TabIndex = 0;
            this.resultsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.resultsTree_AfterSelect);
            // 
            // resultsImageList
            // 
            this.resultsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("resultsImageList.ImageStream")));
            this.resultsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.resultsImageList.Images.SetKeyName(0, "Match.png");
            this.resultsImageList.Images.SetKeyName(1, "Group.png");
            this.resultsImageList.Images.SetKeyName(2, "Capture.png");
            this.resultsImageList.Images.SetKeyName(3, "SplitItem.png");
            this.resultsImageList.Images.SetKeyName(4, "Error.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.splitToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "&Mode";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Checked = true;
            this.findToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.replaceToolStripMenuItem.Text = "&Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.splitToolStripMenuItem.Text = "&Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ignoreCaseToolStripMenuItem,
            this.multilineToolStripMenuItem,
            this.singlelineToolStripMenuItem,
            this.explicitCapturingToolStripMenuItem,
            this.ignorePatternWhitespaceToolStripMenuItem,
            this.compiledToolStripMenuItem,
            this.rightToLeftToolStripMenuItem,
            this.cultureInvariantToolStripMenuItem,
            this.eCMAScriptModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // ignoreCaseToolStripMenuItem
            // 
            this.ignoreCaseToolStripMenuItem.CheckOnClick = true;
            this.ignoreCaseToolStripMenuItem.Name = "ignoreCaseToolStripMenuItem";
            this.ignoreCaseToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ignoreCaseToolStripMenuItem.Text = "&Ignore Case";
            this.ignoreCaseToolStripMenuItem.Click += new System.EventHandler(this.ignoreCaseToolStripButton_Click);
            // 
            // multilineToolStripMenuItem
            // 
            this.multilineToolStripMenuItem.CheckOnClick = true;
            this.multilineToolStripMenuItem.Name = "multilineToolStripMenuItem";
            this.multilineToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.multilineToolStripMenuItem.Text = "&Multiline";
            this.multilineToolStripMenuItem.Click += new System.EventHandler(this.multilineToolStripButton_Click);
            // 
            // singlelineToolStripMenuItem
            // 
            this.singlelineToolStripMenuItem.CheckOnClick = true;
            this.singlelineToolStripMenuItem.Name = "singlelineToolStripMenuItem";
            this.singlelineToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.singlelineToolStripMenuItem.Text = "&Singleline";
            this.singlelineToolStripMenuItem.Click += new System.EventHandler(this.singlelineToolStripButton_Click);
            // 
            // explicitCapturingToolStripMenuItem
            // 
            this.explicitCapturingToolStripMenuItem.CheckOnClick = true;
            this.explicitCapturingToolStripMenuItem.Name = "explicitCapturingToolStripMenuItem";
            this.explicitCapturingToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.explicitCapturingToolStripMenuItem.Text = "Explicit Capturi&ng";
            this.explicitCapturingToolStripMenuItem.Click += new System.EventHandler(this.explicitCapturingToolStripButton_Click);
            // 
            // ignorePatternWhitespaceToolStripMenuItem
            // 
            this.ignorePatternWhitespaceToolStripMenuItem.CheckOnClick = true;
            this.ignorePatternWhitespaceToolStripMenuItem.Name = "ignorePatternWhitespaceToolStripMenuItem";
            this.ignorePatternWhitespaceToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ignorePatternWhitespaceToolStripMenuItem.Text = "Ignore Pattern Whitespace";
            this.ignorePatternWhitespaceToolStripMenuItem.Click += new System.EventHandler(this.ignorePatternWhitespaceToolStripButton_Click);
            // 
            // compiledToolStripMenuItem
            // 
            this.compiledToolStripMenuItem.CheckOnClick = true;
            this.compiledToolStripMenuItem.Name = "compiledToolStripMenuItem";
            this.compiledToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.compiledToolStripMenuItem.Text = "&Compiled";
            this.compiledToolStripMenuItem.Click += new System.EventHandler(this.compiledToolStripMenuItem_Click);
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.CheckOnClick = true;
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.rightToLeftToolStripMenuItem.Text = "&Right to Left";
            this.rightToLeftToolStripMenuItem.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem_Click);
            // 
            // cultureInvariantToolStripMenuItem
            // 
            this.cultureInvariantToolStripMenuItem.CheckOnClick = true;
            this.cultureInvariantToolStripMenuItem.Name = "cultureInvariantToolStripMenuItem";
            this.cultureInvariantToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cultureInvariantToolStripMenuItem.Text = "C&ulture Invariant";
            this.cultureInvariantToolStripMenuItem.Click += new System.EventHandler(this.cultureInvariantToolStripMenuItem_Click);
            // 
            // eCMAScriptModeToolStripMenuItem
            // 
            this.eCMAScriptModeToolStripMenuItem.CheckOnClick = true;
            this.eCMAScriptModeToolStripMenuItem.Name = "eCMAScriptModeToolStripMenuItem";
            this.eCMAScriptModeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eCMAScriptModeToolStripMenuItem.Text = "&ECMAScript Mode";
            this.eCMAScriptModeToolStripMenuItem.Click += new System.EventHandler(this.eCMAScriptModeToolStripMenuItem_Click);
            // 
            // regexBoxToolStrip
            // 
            this.regexBoxToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.regexBoxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regexBoxLabel,
            this.regexBox,
            this.ignoreCaseToolStripButton,
            this.multilineToolStripButton,
            this.singlelineToolStripButton,
            this.explicitCapturingToolStripButton,
            this.ignorePatternWhitespaceToolStripButton});
            this.regexBoxToolStrip.Location = new System.Drawing.Point(0, 24);
            this.regexBoxToolStrip.Name = "regexBoxToolStrip";
            this.regexBoxToolStrip.Size = new System.Drawing.Size(441, 25);
            this.regexBoxToolStrip.Stretch = true;
            this.regexBoxToolStrip.TabIndex = 0;
            // 
            // regexBoxLabel
            // 
            this.regexBoxLabel.Name = "regexBoxLabel";
            this.regexBoxLabel.Size = new System.Drawing.Size(41, 22);
            this.regexBoxLabel.Text = "&Regex:";
            // 
            // regexBox
            // 
            this.regexBox.Name = "regexBox";
            this.regexBox.Size = new System.Drawing.Size(242, 25);
            this.regexBox.TextChanged += new System.EventHandler(this.UpdateRegexStateEvent);
            // 
            // ignoreCaseToolStripButton
            // 
            this.ignoreCaseToolStripButton.CheckOnClick = true;
            this.ignoreCaseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ignoreCaseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ignoreCaseToolStripButton.Image")));
            this.ignoreCaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ignoreCaseToolStripButton.Name = "ignoreCaseToolStripButton";
            this.ignoreCaseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ignoreCaseToolStripButton.Text = "i";
            this.ignoreCaseToolStripButton.ToolTipText = "Ignore Case";
            this.ignoreCaseToolStripButton.Click += new System.EventHandler(this.ignoreCaseToolStripButton_Click);
            // 
            // multilineToolStripButton
            // 
            this.multilineToolStripButton.CheckOnClick = true;
            this.multilineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.multilineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("multilineToolStripButton.Image")));
            this.multilineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.multilineToolStripButton.Name = "multilineToolStripButton";
            this.multilineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.multilineToolStripButton.Text = "m";
            this.multilineToolStripButton.ToolTipText = "Multiline";
            this.multilineToolStripButton.Click += new System.EventHandler(this.multilineToolStripButton_Click);
            // 
            // singlelineToolStripButton
            // 
            this.singlelineToolStripButton.CheckOnClick = true;
            this.singlelineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.singlelineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("singlelineToolStripButton.Image")));
            this.singlelineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.singlelineToolStripButton.Name = "singlelineToolStripButton";
            this.singlelineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.singlelineToolStripButton.Text = "s";
            this.singlelineToolStripButton.ToolTipText = "Singleline";
            this.singlelineToolStripButton.Click += new System.EventHandler(this.singlelineToolStripButton_Click);
            // 
            // explicitCapturingToolStripButton
            // 
            this.explicitCapturingToolStripButton.CheckOnClick = true;
            this.explicitCapturingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.explicitCapturingToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("explicitCapturingToolStripButton.Image")));
            this.explicitCapturingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.explicitCapturingToolStripButton.Name = "explicitCapturingToolStripButton";
            this.explicitCapturingToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.explicitCapturingToolStripButton.Text = "n";
            this.explicitCapturingToolStripButton.ToolTipText = "Explicit Capturing";
            this.explicitCapturingToolStripButton.Click += new System.EventHandler(this.explicitCapturingToolStripButton_Click);
            // 
            // ignorePatternWhitespaceToolStripButton
            // 
            this.ignorePatternWhitespaceToolStripButton.CheckOnClick = true;
            this.ignorePatternWhitespaceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ignorePatternWhitespaceToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ignorePatternWhitespaceToolStripButton.Image")));
            this.ignorePatternWhitespaceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ignorePatternWhitespaceToolStripButton.Name = "ignorePatternWhitespaceToolStripButton";
            this.ignorePatternWhitespaceToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ignorePatternWhitespaceToolStripButton.Text = "x";
            this.ignorePatternWhitespaceToolStripButton.ToolTipText = "Ignore Pattern Whitespace";
            this.ignorePatternWhitespaceToolStripButton.Click += new System.EventHandler(this.ignorePatternWhitespaceToolStripButton_Click);
            // 
            // replaceBoxToolStrip
            // 
            this.replaceBoxToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.replaceBoxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceBoxLabel,
            this.replaceBox});
            this.replaceBoxToolStrip.Location = new System.Drawing.Point(0, 49);
            this.replaceBoxToolStrip.Name = "replaceBoxToolStrip";
            this.replaceBoxToolStrip.Size = new System.Drawing.Size(443, 25);
            this.replaceBoxToolStrip.Stretch = true;
            this.replaceBoxToolStrip.TabIndex = 2;
            this.replaceBoxToolStrip.Visible = false;
            // 
            // replaceBoxLabel
            // 
            this.replaceBoxLabel.Name = "replaceBoxLabel";
            this.replaceBoxLabel.Size = new System.Drawing.Size(51, 22);
            this.replaceBoxLabel.Text = "R&eplace:";
            // 
            // replaceBox
            // 
            this.replaceBox.Enabled = false;
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(349, 25);
            this.replaceBox.TextChanged += new System.EventHandler(this.UpdateRegexStateEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 422);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.resultsSplitter.Panel1.ResumeLayout(false);
            this.resultsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsSplitter)).EndInit();
            this.resultsSplitter.ResumeLayout(false);
            this.replaceSplitter.Panel1.ResumeLayout(false);
            this.replaceSplitter.Panel1.PerformLayout();
            this.replaceSplitter.Panel2.ResumeLayout(false);
            this.replaceSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceSplitter)).EndInit();
            this.replaceSplitter.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.regexBoxToolStrip.ResumeLayout(false);
            this.regexBoxToolStrip.PerformLayout();
            this.replaceBoxToolStrip.ResumeLayout(false);
            this.replaceBoxToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer resultsSplitter;
        private System.Windows.Forms.ToolStrip regexBoxToolStrip;
        private System.Windows.Forms.TreeView resultsTree;
        private ToolStripSpringTextBox regexBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multilineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explicitCapturingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignorePatternWhitespaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compiledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultureInvariantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCMAScriptModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ignoreCaseToolStripButton;
        private System.Windows.Forms.ToolStripButton multilineToolStripButton;
        private System.Windows.Forms.ToolStripButton singlelineToolStripButton;
        private System.Windows.Forms.ToolStripButton explicitCapturingToolStripButton;
        private System.Windows.Forms.ToolStripButton ignorePatternWhitespaceToolStripButton;
        private System.Windows.Forms.ToolStripLabel regexBoxLabel;
        private System.Windows.Forms.ImageList resultsImageList;
        private System.Windows.Forms.ToolStrip replaceBoxToolStrip;
        private System.Windows.Forms.ToolStripLabel replaceBoxLabel;
        private ToolStripSpringTextBox replaceBox;
        private System.Windows.Forms.SplitContainer replaceSplitter;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.TextBox replacedBox;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
    }
}

