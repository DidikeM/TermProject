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
            LoadSemester();
        }

        private void LoadInstructor()
        {
            gcInstructor.DataSource = _instructorService.GetAll();
        }

        private void LoadSemester()
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
            if (false)
            {
                
            }
            InstructorAdd();
        }

        protected void InstructorAdd()
        {
            _instructorService.Add( new Instructor
            {
                DepartmentId = ((Department)lueDepartmentAdd.GetSelectedDataRow()).Id,
                Email = txteEMailAdd.Text,
                ExtensionNumber = txteExtensionNumberUpdate.Text,
                FirstName = txteFirsNameAdd.Text,
                LastName = txtelastNameAdd.Text,
                PersonalId = txtePersonalIdAdd.Text,
                PhoneNumber = txtePhoneNumberAdd.Text
            });
        }
    }
}