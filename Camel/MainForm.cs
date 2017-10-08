using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camel
{
    public partial class MainForm : Form
    {
        enum AppState
        {
            Find, Replace, Split
        }

        bool ignoreCase, multiline, singleline, explicitCapture, ignorePatternWhitespace, compiled, rtl, cultureInvariant, ecma;

        AppState state;

        public MainForm()
        {
            InitializeComponent();
            ToolStripManager.Renderer = new ToolStripAeroRenderer(ToolbarTheme.Toolbar);
            // regexBox.Text = @"(?<Outer>\b(?<Inner>\w+?)[,:;\'-]?\s?)+[?.!]";
        }

        void UpdateRegexState()
        {
            var o = RegexOptions.None;
            if (ignoreCase)
                o |= RegexOptions.IgnoreCase;
            if (multiline)
                o |= RegexOptions.Multiline;
            if (singleline)
                o |= RegexOptions.Singleline;
            if (explicitCapture)
                o |= RegexOptions.ExplicitCapture;
            if (ignorePatternWhitespace)
                o |= RegexOptions.IgnorePatternWhitespace;
            if (compiled)
                o |= RegexOptions.Compiled;
            if (rtl)
                o |= RegexOptions.RightToLeft;
            if (cultureInvariant)
                o |= RegexOptions.CultureInvariant;
            if (ecma)
                o |= RegexOptions.ECMAScript;

            Text = regexBox.Text;
            resultsTree.Nodes.Clear();
            try
            {
                var r = new Regex(regexBox.Text, o);
                foreach (Match m in r.Matches(contentBox.Text))
                {
                    var tn = new TreeNode();
                    tn.ToolTipText = string.Format("Index: {0}, Length: {1}", m.Index, m.Length);
                    tn.Text = m.Value;
                    tn.Tag = m;

                    // skip the first group because it's just cloning the match
                    var gi = 1;
                    foreach (Group g in m.Groups.Cast<Group>().Skip(1))
                    {
                        var gtn = new TreeNode(r.GroupNameFromNumber(gi++) + ": " + g.Value);
                        gtn.ToolTipText = string.Format("Index: {0}, Length: {1}", g.Index, g.Length);
                        gtn.Tag = g;
                        gtn.ImageIndex = 1;
                        gtn.SelectedImageIndex = 1;
                        tn.Nodes.Add(gtn);
                        foreach (Capture c in g.Captures)
                        {
                            var ctn = new TreeNode(c.Value);
                            ctn.Tag = c;
                            ctn.ImageIndex = 2;
                            ctn.SelectedImageIndex = 2;
                            ctn.ToolTipText = string.Format("Index: {0}, Length: {1}", c.Index, c.Length);
                            gtn.Nodes.Add(ctn);
                        }
                    }
                    resultsTree.Nodes.Add(tn);
                }

                if (state == AppState.Replace)
                {
                    replacedBox.Text = r.Replace(contentBox.Text, replaceBox.Text);
                }
                else if (state == AppState.Split)
                {
                    var split = r.Split(contentBox.Text);
                    foreach (var s in split)
                    {
                        var tn = new TreeNode(s);
                        tn.ImageIndex = 3;
                        tn.SelectedImageIndex = 3;
                        resultsTree.Nodes.Add(tn);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                var etn = new TreeNode("Error: " + ex.Message);
                etn.ImageIndex = 4;
                etn.SelectedImageIndex = 4;
                resultsTree.Nodes.Add(etn);
            }
        }

        private void UpdateRegexStateEvent(object sender, EventArgs e)
        {
            UpdateRegexState();
        }

        #region Option setting events
        private void ignoreCaseToolStripButton_Click(object sender, EventArgs e)
        {
            if (sender == ignoreCaseToolStripButton)
            {
                ignoreCaseToolStripMenuItem.Checked = ignoreCaseToolStripButton.Checked;
            }
            else
            {
                ignoreCaseToolStripButton.Checked = ignoreCaseToolStripMenuItem.Checked;
            }
            ignoreCase = ignoreCaseToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void multilineToolStripButton_Click(object sender, EventArgs e)
        {
            if (sender == multilineToolStripButton)
            {
                multilineToolStripMenuItem.Checked = multilineToolStripButton.Checked;
            }
            else
            {
                multilineToolStripButton.Checked = multilineToolStripMenuItem.Checked;
            }
            multiline = multilineToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void singlelineToolStripButton_Click(object sender, EventArgs e)
        {
            if (sender == singlelineToolStripButton)
            {
                singlelineToolStripMenuItem.Checked = singlelineToolStripButton.Checked;
            }
            else
            {
                singlelineToolStripButton.Checked = singlelineToolStripMenuItem.Checked;
            }
            singleline = singlelineToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void explicitCapturingToolStripButton_Click(object sender, EventArgs e)
        {
            if (sender == explicitCapturingToolStripButton)
            {
                explicitCapturingToolStripMenuItem.Checked = explicitCapturingToolStripButton.Checked;
            }
            else
            {
                explicitCapturingToolStripButton.Checked = explicitCapturingToolStripMenuItem.Checked;
            }
            explicitCapture = explicitCapturingToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void ignorePatternWhitespaceToolStripButton_Click(object sender, EventArgs e)
        {
            if (sender == ignorePatternWhitespaceToolStripButton)
            {
                ignorePatternWhitespaceToolStripMenuItem.Checked = ignorePatternWhitespaceToolStripButton.Checked;
            }
            else
            {
                ignorePatternWhitespaceToolStripButton.Checked = ignorePatternWhitespaceToolStripMenuItem.Checked;
            }
            ignorePatternWhitespace = singlelineToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void compiledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compiled = compiledToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void rightToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtl = rightToLeftToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void cultureInvariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cultureInvariant = cultureInvariantToolStripMenuItem.Checked;
            UpdateRegexState();
        }

        private void eCMAScriptModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecma = eCMAScriptModeToolStripMenuItem.Checked;
            UpdateRegexState();
        }
        #endregion

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = AppState.Find;

            findToolStripMenuItem.Checked = true;
            replaceToolStripMenuItem.Checked = false;
            splitToolStripMenuItem.Checked = false;

            replaceSplitter.Panel2Collapsed = true;
            replaceBoxToolStrip.Visible = false;
            replaceBox.Enabled = false;
            UpdateRegexState();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = AppState.Replace;

            findToolStripMenuItem.Checked = false;
            replaceToolStripMenuItem.Checked = true;
            splitToolStripMenuItem.Checked = false;

            replaceSplitter.Panel2Collapsed = false;
            replaceBoxToolStrip.Visible = true;
            replaceBox.Enabled = true;
            UpdateRegexState();
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = AppState.Split;

            findToolStripMenuItem.Checked = false;
            replaceToolStripMenuItem.Checked = false;
            splitToolStripMenuItem.Checked = true;

            replaceSplitter.Panel2Collapsed = true;
            replaceBoxToolStrip.Visible = false;
            replaceBox.Enabled = false;
            UpdateRegexState();
        }

        private void resultsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var c = (Capture)e.Node.Tag;
            if (c != null)
                contentBox.Select(c.Index, c.Length);
        }
    }
}
