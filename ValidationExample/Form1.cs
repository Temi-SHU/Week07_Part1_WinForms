namespace ValidationExample
{
    public partial class Form1 : Form
    {
        private List<Person> _people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        // This helps ensure the user cannot enter none numeric numbers
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validation events are raised when the control looses focus
        // Also, the control's CauseValidation property must be
        // set to true (the default value) for this to happen.
        // this one validates the Name is not blank
        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                errpName.SetError((Control)sender, "Name must be provided.");
                btnAdd.Enabled = false;
                return;
            }

            if (errpName.GetError(txtAge) == "" && txtAge.Text.Trim().Length != 0) btnAdd.Enabled = true;
            errpName.Clear();
        }

        // This validates that the age is not blank and within valid range
        private void txtAge_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtAge.Text.Trim().Length == 0)
            {
                errpAge.SetError((Control)sender, "Age must be provided.");
                btnAdd.Enabled = false;
                return;
            }

            int age = Convert.ToInt32(txtAge.Text);
            if (age <= 0 || age > 100)
            {
                errpAge.SetError((Control)sender, "Your age must be greater than 0 and less than 100.");
                btnAdd.Enabled = false;
                return;
            }

            if (errpName.GetError(txtName) == "" && txtName.Text.Trim().Length != 0) btnAdd.Enabled = true;
            errpAge.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (errpAge.GetError(txtAge).Length != 0 || errpName.GetError(txtName).Length != 0) return;

            if (!PersonExists())
            {
                int age = Convert.ToInt32(txtAge.Text);
                Person p = new Person(txtName.Text, age);
                _people.Add(p);


                lstbPersons.Items.Add(p.ToString());
                lstbPersons.SelectedIndex = lstbPersons.Items.Count - 1;
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show($"{txtName.Text} with age {txtAge.Text} exists already.", "Duplicates not allowed here!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstbPersons.SelectedIndex != -1)
            {
                int index = lstbPersons.SelectedIndex;
                lstbPersons.Items.RemoveAt(index);
                _people.RemoveAt(index);

                ClearTextBoxes();

                if (lstbPersons.Items.Count > 0)
                {
                    // Select the previous item, or current item if the first item
                    if (index > 0) index--;
                    lstbPersons.SelectedIndex = 0;
                }
                else
                {
                    btnRemove.Enabled = false;
                    btnUpdate.Enabled = false;
                }

            }
            else
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (errpAge.GetError(txtAge).Length != 0 || errpName.GetError(txtName).Length != 0) return;

            if (lstbPersons.SelectedIndex != -1)
            {
                int index = lstbPersons.SelectedIndex;

                Person p = new Person(txtName.Text, txtAge.Text);
                _people[index] = p;

                lstbPersons.Items[index] = p.ToString();

                ClearTextBoxes();

            }
            else
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void lstbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbPersons.SelectedIndex != -1) // An item was selected, will be -1 if there was no selection
            {
                int index = lstbPersons.SelectedIndex;

                txtName.Text = _people[index].Name;
                txtAge.Text = _people[index].Age.ToString();

                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        // Checks the item does not already exist, this checks in the _people variable
        private bool PersonExists()
        {
            int age = Convert.ToInt32(txtAge.Text);
            foreach (Person person in _people)
            {
                if (person.Name == txtName.Text && person.Age == age) return true;
            }
            return false;
        }

        // This checks in the listbox
        private bool PersonExists2()
        {
            Person p = new Person(txtName.Text, txtAge.Text);
            if (lstbPersons.Items.Contains(p.ToString())) return true;
            return false;
        }

        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
        }
    }
}