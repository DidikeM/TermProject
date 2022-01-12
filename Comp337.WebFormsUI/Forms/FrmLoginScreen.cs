using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comp337.Business.Abstract;
using Comp337.Business.DependencyResolvers.Ninject;
using Comp337.Entities.Concrete;
using Comp337.WebFormsUI.Forms.InstructorsForms;
using Comp337.WebFormsUI.Forms.StudentsForms;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;

namespace Comp337.WebFormsUI.Forms
{
    public partial class FrmLoginScreen : DevExpress.XtraEditors.XtraForm
    {
        public FrmLoginScreen()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }



        private IUserService _userService;
        private void FrmLoginScreen_Load(object sender, EventArgs e)
        {

        }

        private User _user;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_userService.ControlLogin(new User { Username = txtUserName.Text, Password = txtPassword.Text }))
            {
                _user = _userService.GetByUsername(new User { Username = txtUserName.Text });
                LoadForms(_user);
            }
            else
            {
                MessageBox.Show("Invalid Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void OpenForm(Form form)
        {
            form.Show();
        }

        private void LoadForms(User user)
        {
            if (user.UserAuthorizationId == 1)
            {
                OpenForm(new FrmCoordinatorMain());
                this.Hide();
            }
            else if (user.UserAuthorizationId == 2)
            {
                OpenForm(new FrmInstructorMain());
                this.Hide();

            }
            else if (_user.UserAuthorizationId == 3)
            {
                OpenForm(new FrmStudentsForm());
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}