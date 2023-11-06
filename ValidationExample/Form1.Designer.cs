namespace ValidationExample
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtAge = new TextBox();
            btnAdd = new Button();
            lstbPersons = new ListBox();
            btnRemove = new Button();
            btnUpdate = new Button();
            errpName = new ErrorProvider(components);
            errpAge = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errpName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpAge).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 15);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your name here";
            txtName.Size = new Size(296, 27);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(16, 57);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Enter your age here";
            txtAge.Size = new Size(296, 27);
            txtAge.TabIndex = 2;
            txtAge.KeyPress += txtAge_KeyPress;
            txtAge.Validating += txtAge_Validating;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(16, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstbPersons
            // 
            lstbPersons.FormattingEnabled = true;
            lstbPersons.ItemHeight = 20;
            lstbPersons.Location = new Point(16, 143);
            lstbPersons.Name = "lstbPersons";
            lstbPersons.Size = new Size(296, 224);
            lstbPersons.TabIndex = 4;
            lstbPersons.SelectedIndexChanged += lstbPersons_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.Enabled = false;
            btnRemove.Location = new Point(120, 99);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(224, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errpName
            // 
            errpName.ContainerControl = this;
            // 
            // errpAge
            // 
            errpAge.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 383);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(lstbPersons);
            Controls.Add(btnAdd);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validation Example";
            ((System.ComponentModel.ISupportInitialize)errpName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private Button btnAdd;
        private ListBox lstbPersons;
        private Button btnRemove;
        private Button btnUpdate;
        private ErrorProvider errpName;
        private ErrorProvider errpAge;
    }
}