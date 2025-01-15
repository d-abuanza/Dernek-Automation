using Dernek.Business.Abstract;
using Dernek.Business.Concrete;
using Dernek.DataAccess.Concrete.AdoNet;
using Dernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Dernek
{
    public partial class LoginPage : Form
    {
        private IMemberService _memberService;
        private IAuthService _authService;
        private string conString = @"Provider=Microsoft.ACE.Oledb.12.0; Data Source=" +
     Path.Combine(Application.StartupPath, "MyDernekDb.accdb");

        public LoginPage()
        {
            InitializeComponent();
            _memberService = new MemberManager(conString);
            _authService = new AuthManager(new AuthDal(conString));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                Member member = _authService.Login(userName, password);
                if (member != null)
                {
                       if (_authService.IsAdmin(member.TcKimlik))
                    {
                        AdminPage adminPage = new AdminPage(member);
                        adminPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MemberPage userPage = new MemberPage(member);
                        userPage.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
