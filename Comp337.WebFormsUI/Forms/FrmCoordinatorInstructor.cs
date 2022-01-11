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
    public partial class FrmCoordinatorInstructor : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorInstructor()
        {
            InitializeComponent();
            _instructorService = InstanceFactory.GetInstance<IInstructorService>();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private IInstructorService _instructorService;
        private IUserService _userService;
        private IDepartmentService _departmentService;

        private void FrmCoordinatorInstructor_Load(object sender, EventArgs e)
        {
            LoadInstructor();
            LoadDepartment();
        }

        private void LoadInstructor()
        {
            gcInstructor.DataSource = _instructorService.GetAll();
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
            if (txtePersonalIdAdd.Text == "" || txteFirstNameAdd.Text == "" || txteLastNameAdd.Text == "" || (Department)lueDepartmentAdd.GetSelectedDataRow() == null || txteEMailAdd.Text == "" || txtePhoneNumberAdd.Text == "" || txteExtensionNumberAdd.Text == "" || txteEMailAdd.Text == "")
            {
                MessageBox.Show("Please fill the boxes");
            }
            else
            {
                InstructorAdd();
                LoadInstructor();
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
            txteExtensionNumberAdd.Text = "";
            txteEMailAdd.Text = "";
        }

        protected void InstructorAdd()
        {
            _instructorService.Add(new Instructor
            {
                PersonalId = txtePersonalIdAdd.Text,
                FirstName = txteFirstNameAdd.Text,
                LastName = txteLastNameAdd.Text,
                DepartmentId = ((Department)lueDepartmentAdd.GetSelectedDataRow()).Id,
                PhoneNumber = txtePhoneNumberAdd.Text,
                ExtensionNumber = txteExtensionNumberAdd.Text,
                Email = txteEMailAdd.Text
            });
        }

        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtePersonalIdUpdate.Text == "" || txteFirstNameUpdate.Text == "" || txteLastNameUpdate.Text == "" || (Department)lueDepartmentUpdate.GetSelectedDataRow() == null || txteEMailUpdate.Text == "" || txtePhoneNumberUpdate.Text == "" || txteExtensionNumberUpdate.Text == "" || txteEMailUpdate.Text == "")
            {
                MessageBox.Show("Please fill the boxes");
            }
            else
            {
                InstructorUpdate();
                LoadInstructor();
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
            txteExtensionNumberUpdate.Text = "";
            txteEMailUpdate.Text = "";
        }

        private void InstructorUpdate()
        {
            _instructorService.Update(new Instructor
            {
                Id = ((Instructor)gvInstructor.GetFocusedRow()).Id,
                PersonalId = txtePersonalIdUpdate.Text,
                FirstName = txteFirstNameUpdate.Text,
                LastName = txteLastNameUpdate.Text,
                DepartmentId = ((Department)lueDepartmentUpdate.GetSelectedDataRow()).Id,
                PhoneNumber = txtePhoneNumberUpdate.Text,
                ExtensionNumber = txteExtensionNumberUpdate.Text,
                Email = txteEMailUpdate.Text
            });
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            InstructorDelete();
            LoadInstructor();
            ClearUpdate();
        }

        private void InstructorDelete()
        {
            _instructorService.Delete(new Instructor    
            {
                Id = ((Instructor)gvInstructor.GetFocusedRow()).Id,
                DepartmentId = ((Department)lueDepartmentUpdate.GetSelectedDataRow()).Id,
                Email = txteEMailUpdate.Text,
                ExtensionNumber = txteExtensionNumberUpdate.Text,
                FirstName = txteFirstNameUpdate.Text,
                LastName = txteLastNameUpdate.Text,
                PersonalId = txtePersonalIdUpdate.Text,
                PhoneNumber = txtePhoneNumberUpdate.Text
            });
        }

        private void gvInstructor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtePersonalIdUpdate.Text = ((Instructor) gvInstructor.GetFocusedRow()).PersonalId.TrimEnd();
            txteFirstNameUpdate.Text = ((Instructor) gvInstructor.GetFocusedRow()).FirstName.TrimEnd();
            txteLastNameUpdate.Text = ((Instructor) gvInstructor.GetFocusedRow()).LastName.TrimEnd();
            lueDepartmentUpdate.EditValue = ((Instructor) gvInstructor.GetFocusedRow()).DepartmentId;
            txtePhoneNumberUpdate.Text = ((Instructor) gvInstructor.GetFocusedRow()).PhoneNumber.TrimEnd();
            txteExtensionNumberUpdate.Text = ((Instructor) gvInstructor.GetFocusedRow()).ExtensionNumber.TrimEnd();
            txteEMailUpdate.Text = ((Instructor) gvInstructor.GetFocusedRow()).Email.TrimEnd();
        }
    }
}