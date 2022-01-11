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

namespace Comp337.WebFormsUI.Forms
{
    public partial class FrmCoordinatorStudent : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorStudent()
        {
            InitializeComponent();
            _StudentService = InstanceFactory.GetInstance<IStudentService>();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private IStudentService _StudentService;
        private IUserService _userService;
        private IDepartmentService _departmentService;

        private void FrmCoordinatorStudent_Load(object sender, EventArgs e)
        {
            LoadStudent();
            LoadDepartment();
        }
        private void LoadStudent()
        {
            gcStudent.DataSource = _StudentService.GetAll();
        }

        private void LoadDepartment()
        {
            lueDepartmentUpdate.Properties.DataSource = _departmentService.GetAll();
            lueDepartmentUpdate.Properties.DisplayMember = "DepartmentName";
            lueDepartmentUpdate.Properties.ValueMember = "Id";

            lueDepartmentAdd.Properties.DataSource = _departmentService.GetAll();
            lueDepartmentAdd.Properties.DisplayMember = "DepartmentName";
            lueDepartmentAdd.Properties.ValueMember = "Id";
            //lueSemester.Properties.
        }

        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            if (txtePersonalIdAdd.Text == "" || txteFirstNameAdd.Text == "" || txteLastNameAdd.Text == "" || (Department)lueDepartmentAdd.GetSelectedDataRow() == null || txteEMailAdd.Text == "" || txtePhoneNumberAdd.Text == "" ||  txteEMailAdd.Text == "")
            {
                MessageBox.Show("Please fill the boxes");
            }
            else
            {
                StudentAdd();
                LoadStudent();
                ClearAdd();
            }
        }

        private void ClearAdd()
        {
            txtePersonalIdAdd.Text = "";
            txteFirstNameAdd.Text = "";
            txteLastNameAdd.Text = "";
            lueDepartmentAdd.EditValue = null;
            txtePhoneNumberAdd.Text = "";
            txteEMailAdd.Text = "";
        }

        protected void StudentAdd()
        {
            _StudentService.Add(new Student
            {
                PersonalId = txtePersonalIdAdd.Text,
                FirstName = txteFirstNameAdd.Text,
                LastName = txteLastNameAdd.Text,
                DepartmentId = ((Department)lueDepartmentAdd.GetSelectedDataRow()).Id,
                PhoneNumber = txtePhoneNumberAdd.Text,
                Email = txteEMailAdd.Text
            });

            _userService.Add(new User
            {
                Username = txteEMailAdd.Text,
                Password = txtePersonalIdAdd.Text,
                UserAuthorizationId = 2
            });
        }

        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtePersonalIdUpdate.Text == "" || txteFirstNameUpdate.Text == "" || txteLastNameUpdate.Text == "" || (Department)lueDepartmentUpdate.GetSelectedDataRow() == null || txteEMailUpdate.Text == "" || txtePhoneNumberUpdate.Text == "" ||  txteEMailUpdate.Text == "")
            {
                MessageBox.Show("Please fill the boxes");
            }
            else
            {
                StudentUpdate();
                LoadStudent();
                ClearUpdate();
            }
        }

        private void ClearUpdate()
        {
            txtePersonalIdUpdate.Text = "";
            txteFirstNameUpdate.Text = "";
            txteLastNameUpdate.Text = "";
            lueDepartmentUpdate.EditValue = null;
            txtePhoneNumberUpdate.Text = "";
            txteEMailUpdate.Text = "";
        }

        private void StudentUpdate()
        {
            _StudentService.Update(new Student()
            {
                Id = ((Student)gvStudent.GetFocusedRow()).Id,
                PersonalId = txtePersonalIdUpdate.Text,
                FirstName = txteFirstNameUpdate.Text,
                LastName = txteLastNameUpdate.Text,
                DepartmentId = ((Department)lueDepartmentUpdate.GetSelectedDataRow()).Id,
                PhoneNumber = txtePhoneNumberUpdate.Text,
                Email = txteEMailUpdate.Text
            });
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (txtePersonalIdUpdate.Text == "" || txteFirstNameUpdate.Text == "" || txteLastNameUpdate.Text == "" || (Department)lueDepartmentUpdate.GetSelectedDataRow() == null || txteEMailUpdate.Text == "" || txtePhoneNumberUpdate.Text == "" || txteEMailUpdate.Text == "")
            {
                MessageBox.Show("Please fill the boxes");
            }
            else
            {
                StudentDelete();
                LoadStudent();
                ClearUpdate();
            }
        }

        private void StudentDelete()
        {
            _StudentService.Delete(new Student
            {
                Id = ((Student)gvStudent.GetFocusedRow()).Id,
                DepartmentId = ((Department)lueDepartmentUpdate.GetSelectedDataRow()).Id,
                Email = txteEMailUpdate.Text,
                FirstName = txteFirstNameUpdate.Text,
                LastName = txteLastNameUpdate.Text,
                PersonalId = txtePersonalIdUpdate.Text,
                PhoneNumber = txtePhoneNumberUpdate.Text
            });

            //_userService.Get( );

            _userService.Delete(new User
            {
                Id = 1
            });
        }

        private void gvStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtePersonalIdUpdate.Text = ((Student)gvStudent.GetFocusedRow()).PersonalId.TrimEnd();
            txteFirstNameUpdate.Text = ((Student)gvStudent.GetFocusedRow()).FirstName.TrimEnd();
            txteLastNameUpdate.Text = ((Student)gvStudent.GetFocusedRow()).LastName.TrimEnd();
            lueDepartmentUpdate.EditValue = ((Student)gvStudent.GetFocusedRow()).DepartmentId;
            txtePhoneNumberUpdate.Text = ((Student)gvStudent.GetFocusedRow()).PhoneNumber.TrimEnd();
            txteEMailUpdate.Text = ((Student)gvStudent.GetFocusedRow()).Email.TrimEnd();
        }
    }
}