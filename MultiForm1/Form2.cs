using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm1
{
    public partial class Form2 : Form
    {
        public delegate void MessageChangeDelegate(object sender, string message);
        public event MessageChangeDelegate MessageChanged;

        public string Form2message = "Form 2 Message not yet set";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }

        private void btnGetFromF1_Click(object sender, EventArgs msg)
        {
            Form1 form1 = (Form1)this.Owner;
            lblMsgFromForm1.Text = form1.Form1message;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            Form2message = txtMessage.Text;
            this.MessageChanged(this, Form2message);
        }

        private void btnListenToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;

            form1.MessageChanged += new Form1.MessageChangeDelegate(Form1_MessageChanged);
        }

        private void Form1_MessageChanged(object sender, string msg)
        {
            lblMsgFromForm1.Text = msg;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult response = MessageBox.Show($"You are closing this form.\n\nAre you sure?", "Form closing...", MessageBoxButtons.OKCancel);
            if (response == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
