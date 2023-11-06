namespace MultiForm1
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
            label1 = new Label();
            btnShowForm2 = new Button();
            txtMessage = new TextBox();
            lblMsgFromForm2 = new Label();
            btnGetFromF2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 48);
            label1.TabIndex = 1;
            label1.Text = "I am form 1";
            // 
            // btnShowForm2
            // 
            btnShowForm2.Location = new Point(183, 60);
            btnShowForm2.Name = "btnShowForm2";
            btnShowForm2.Size = new Size(109, 29);
            btnShowForm2.TabIndex = 2;
            btnShowForm2.Text = "Show Form 2";
            btnShowForm2.UseVisualStyleBackColor = true;
            btnShowForm2.Click += btnShowForm2_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(81, 106);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(312, 27);
            txtMessage.TabIndex = 3;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // lblMsgFromForm2
            // 
            lblMsgFromForm2.BorderStyle = BorderStyle.FixedSingle;
            lblMsgFromForm2.Location = new Point(80, 191);
            lblMsgFromForm2.Name = "lblMsgFromForm2";
            lblMsgFromForm2.Size = new Size(314, 25);
            lblMsgFromForm2.TabIndex = 5;
            lblMsgFromForm2.Text = "Message From Form 2 Will Appear here";
            // 
            // btnGetFromF2
            // 
            btnGetFromF2.Location = new Point(181, 219);
            btnGetFromF2.Name = "btnGetFromF2";
            btnGetFromF2.Size = new Size(113, 29);
            btnGetFromF2.TabIndex = 11;
            btnGetFromF2.Text = "Get From F2";
            btnGetFromF2.UseVisualStyleBackColor = true;
            btnGetFromF2.Click += btnGetFromF2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 273);
            Controls.Add(btnGetFromF2);
            Controls.Add(lblMsgFromForm2);
            Controls.Add(txtMessage);
            Controls.Add(btnShowForm2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnShowForm2;
        private TextBox txtMessage;
        private Label lblMsgFromForm2;
        private Button btnGetFromF2;
    }
}