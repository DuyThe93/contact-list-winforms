namespace ContactList
{
    partial class AddContactForm
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
            savebtn = new Button();
            label1 = new Label();
            nametxt = new TextBox();
            label2 = new Label();
            phonetxt = new TextBox();
            txtEmail = new TextBox();
            Email = new Label();
            SuspendLayout();
            // 
            // savebtn
            // 
            savebtn.Location = new Point(27, 206);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(94, 29);
            savebtn.TabIndex = 0;
            savebtn.Text = "Lưu";
            savebtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 108);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Số điện thoại";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(342, 37);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(125, 27);
            nametxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 37);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên";
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(342, 105);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(125, 27);
            phonetxt.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(342, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(195, 167);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Email);
            Controls.Add(txtEmail);
            Controls.Add(phonetxt);
            Controls.Add(label2);
            Controls.Add(nametxt);
            Controls.Add(label1);
            Controls.Add(savebtn);
            Name = "AddContactForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button savebtn;
        private Label label1;
        private TextBox nametxt;
        private Label label2;
        private TextBox phonetxt;
        private TextBox txtEmail;
        private Label Email;
    }
}