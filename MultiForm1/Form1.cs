namespace MultiForm1
{
    public partial class Form1 : Form
    {
        public delegate void MessageChangeDelegate(object sender, string message);
        public event MessageChangeDelegate MessageChanged;

        Form2 form2;
        public string Form1message = "Form 1 Message not yet set";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Owner = this;
            form2.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);

            form2.VisibleChanged += new EventHandler(Form2_VisibleChanged);

            form2.Show();
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            this.Visible = !form2.Visible;
        }

        private void btnGetFromF2_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                lblMsgFromForm2.Text = form2.Form2message;
            }
        }

        private void btnShowForm2_Click2(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Owner = this;
            form2.Location = new Point(this.Location.X, this.Location.Y);

            form2.MessageChanged += new Form2.MessageChangeDelegate(Form2_MessageChanged);

            form2.Show();
        }
        private void Form2_MessageChanged(object sender, string msg)
        {
            lblMsgFromForm2.Text = msg;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            this.Form1message = txtMessage.Text;
            if (this.MessageChanged != null)
            {
                this.MessageChanged(txtMessage, txtMessage.Text);
            }
        }
    }
}