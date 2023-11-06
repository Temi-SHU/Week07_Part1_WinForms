namespace MultiForm1
{
    partial class Form2
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
            label1 = new Label();
            lblMsgFromForm1 = new Label();
            txtMessage = new TextBox();
            btnShowForm1 = new Button();
            btnGetFromF1 = new Button();
            btnListenToForm1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 48);
            label1.TabIndex = 0;
            label1.Text = "I am form 2";
            // 
            // lblMsgFromForm1
            // 
            lblMsgFromForm1.BorderStyle = BorderStyle.FixedSingle;
            lblMsgFromForm1.Location = new Point(91, 187);
            lblMsgFromForm1.Name = "lblMsgFromForm1";
            lblMsgFromForm1.Size = new Size(314, 25);
            lblMsgFromForm1.TabIndex = 9;
            lblMsgFromForm1.Text = "Message From Form 1 Will Appear here";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(91, 106);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(312, 27);
            txtMessage.TabIndex = 7;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // btnShowForm1
            // 
            btnShowForm1.Location = new Point(193, 60);
            btnShowForm1.Name = "btnShowForm1";
            btnShowForm1.Size = new Size(109, 29);
            btnShowForm1.TabIndex = 6;
            btnShowForm1.Text = "Show Form 1";
            btnShowForm1.UseVisualStyleBackColor = true;
            btnShowForm1.Click += btnShowForm1_Click;
            // 
            // btnGetFromF1
            // 
            btnGetFromF1.Location = new Point(192, 215);
            btnGetFromF1.Name = "btnGetFromF1";
            btnGetFromF1.Size = new Size(113, 29);
            btnGetFromF1.TabIndex = 10;
            btnGetFromF1.Text = "Get From F1";
            btnGetFromF1.UseVisualStyleBackColor = true;
            btnGetFromF1.Click += btnGetFromF1_Click;
            // 
            // btnListenToForm1
            // 
            btnListenToForm1.Location = new Point(180, 139);
            btnListenToForm1.Name = "btnListenToForm1";
            btnListenToForm1.Size = new Size(144, 29);
            btnListenToForm1.TabIndex = 11;
            btnListenToForm1.Text = "Listen To Form 1";
            btnListenToForm1.UseVisualStyleBackColor = true;
            btnListenToForm1.Click += btnListenToForm1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 273);
            Controls.Add(btnListenToForm1);
            Controls.Add(btnGetFromF1);
            Controls.Add(lblMsgFromForm1);
            Controls.Add(txtMessage);
            Controls.Add(btnShowForm1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Message for Form 2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMsgFromForm1;
        private TextBox txtMessage;
        private Button btnShowForm1;
        private Button btnGetFromF1;
        private Button btnListenToForm1;
    }
}