using System.Windows.Forms.VisualStyles;

namespace MdiFormExample
{
    public partial class MainForm : Form
    {
        string mdiFormTitle;
        public MainForm()
        {
            InitializeComponent();
            mdiFormTitle = this.Text;
            UpdateStatusInfo();
        }

        private void makeOwnedChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = $"I am the OWNED child form #{this.OwnedForms.Length + 1}";
            Form form = MakeForm(text, false, true, false, 450, 450);

            UpdateStatusInfo();
            form.Show();
        }

        private void makeDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = $"I am the OWNED child form #{this.OwnedForms.Length + 1}, displayed Modally";
            Form form = MakeForm(text, true, true, false, 450, 250);

            UpdateStatusInfo();
            form.ShowDialog(); // Show Dialog retains control on this form
        }

        private void makeMdiChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = $"I am the MDI child form #{this.MdiChildren.Length + 1}";
            Form form = MakeForm(text, false, false, true, this.Width - 100, 200);

            UpdateStatusInfo();
            form.Show();
        }

        private void makeNoneOwnedChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = $"I am the none child form #{this.OwnedForms.Length + 1}";
            Form form = MakeForm(text, false, false, false, 450, 250);

            UpdateStatusInfo();
            form.Show();
        }


        // Simple Factor pattern
        private Form MakeForm(string title, bool hasDialog, bool hasOwned, bool hasMdiChild, int width, int height)
        {
            Form form = new Form();
            form.Text = title;
            form.Width = width;
            form.Height = height;

            if (hasOwned) form.Owner = this;
            if (hasMdiChild)
            {
                form.MdiParent = this;
                form.Activated += Form_Activated;
            }

            if (hasDialog)
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
            }

            form.FormClosed += Form_FormClosed;
            form.FormClosing += Form_FormClosing;

            return form;
        }

        private void UpdateStatusInfo()
        {
            toolStripStatusLabel1.Text = $"MDI Children: {this.MdiChildren.Length}; None MDI Children: {this.OwnedForms.Length}";
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f = (Form)sender;
            DialogResult response = MessageBox.Show($"Closing form with title: {f.Text}.\n\nDo you want to continue?", "Form closing...", MessageBoxButtons.OKCancel);
            if (response == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            Form f = (Form) sender;
            this.Text = mdiFormTitle + $" [{f.Text}]";
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            //f.Dispose();

            UpdateStatusInfo();
        }
    }
}