using System.Linq;

namespace MyApplication
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
            

        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            LoginForm F = new LoginForm();
            F.Show();
            Hide();
        }

        private void SignUp_MouseEnter(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btnCurrent =
                (System.Windows.Forms.Button)sender;
            btnCurrent.BackColor = System.Drawing.Color.Tomato;
        }

        private void SignUp_DragLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btnCurrent =
               (System.Windows.Forms.Button)sender;
            btnCurrent.BackColor = System.Drawing.SystemColors.Control;
        }

        private void SignUp_Click(object sender, System.EventArgs e)
        {
            RegisterForm R = new RegisterForm();
            R.Show();
            Hide();
        }

    }
}
