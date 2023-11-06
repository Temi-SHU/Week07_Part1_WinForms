namespace MdiFormExample
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            formsToolStripMenuItem = new ToolStripMenuItem();
            makeOwnedChildToolStripMenuItem = new ToolStripMenuItem();
            makeNoneOwnedChildToolStripMenuItem = new ToolStripMenuItem();
            makeDialogToolStripMenuItem = new ToolStripMenuItem();
            makeMdiChildToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1240, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            formsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { makeOwnedChildToolStripMenuItem, makeNoneOwnedChildToolStripMenuItem, makeDialogToolStripMenuItem, makeMdiChildToolStripMenuItem });
            formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            formsToolStripMenuItem.Size = new Size(63, 24);
            formsToolStripMenuItem.Text = "Forms";
            // 
            // makeOwnedChildToolStripMenuItem
            // 
            makeOwnedChildToolStripMenuItem.Name = "makeOwnedChildToolStripMenuItem";
            makeOwnedChildToolStripMenuItem.Size = new Size(257, 26);
            makeOwnedChildToolStripMenuItem.Text = "Make Owned Child";
            makeOwnedChildToolStripMenuItem.Click += makeOwnedChildToolStripMenuItem_Click;
            // 
            // makeNoneOwnedChildToolStripMenuItem
            // 
            makeNoneOwnedChildToolStripMenuItem.Name = "makeNoneOwnedChildToolStripMenuItem";
            makeNoneOwnedChildToolStripMenuItem.Size = new Size(257, 26);
            makeNoneOwnedChildToolStripMenuItem.Text = "Make None Owned Child";
            makeNoneOwnedChildToolStripMenuItem.Click += makeNoneOwnedChildToolStripMenuItem_Click;
            // 
            // makeDialogToolStripMenuItem
            // 
            makeDialogToolStripMenuItem.Name = "makeDialogToolStripMenuItem";
            makeDialogToolStripMenuItem.Size = new Size(257, 26);
            makeDialogToolStripMenuItem.Text = "Make Dialog";
            makeDialogToolStripMenuItem.Click += makeDialogToolStripMenuItem_Click;
            // 
            // makeMdiChildToolStripMenuItem
            // 
            makeMdiChildToolStripMenuItem.Name = "makeMdiChildToolStripMenuItem";
            makeMdiChildToolStripMenuItem.Size = new Size(257, 26);
            makeMdiChildToolStripMenuItem.Text = "Make MDI Child";
            makeMdiChildToolStripMenuItem.Click += makeMdiChildToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 745);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1240, 26);
            statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 771);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "I'm the MDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formsToolStripMenuItem;
        private ToolStripMenuItem makeOwnedChildToolStripMenuItem;
        private ToolStripMenuItem makeMdiChildToolStripMenuItem;
        private ToolStripMenuItem makeDialogToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem makeNoneOwnedChildToolStripMenuItem;
    }
}