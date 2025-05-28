namespace ContactList
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
            lblTitle = new Label();
            btnAddContact = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(251, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách liên hệ";
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(38, 238);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(136, 29);
            btnAddContact.TabIndex = 1;
            btnAddContact.Text = "Thêm liên hệ";
            btnAddContact.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddContact);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddContact;
    }
}
