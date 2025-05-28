namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            using (var frm = new AddContactForm())
            {
                frm.ShowDialog();
                // TODO: sau khi Lưu, có thể load lại danh sách liên hệ nếu cần
            }
        }

    }
}
