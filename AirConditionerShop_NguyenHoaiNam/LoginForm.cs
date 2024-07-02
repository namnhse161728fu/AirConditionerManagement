using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Services;

namespace AirConditionerShop_NguyenHoaiNam
{
    public partial class LoginForm : Form
    {
        private StaffMemberService _service = new();
        private bool isClosingConfirmed = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var acc = _service.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Invalid Email or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AirConditionerManagementForm form = new();
            form.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosingConfirmed)
            {
                e.Cancel = true;
                ConfirmExit();
            }
        }

        private void ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isClosingConfirmed = true;
                Application.Exit();
            }
        }
    }
}
