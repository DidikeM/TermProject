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
    public partial class FrmCoordinatorAssignmentOfAdvisorToStudent : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorAssignmentOfAdvisorToStudent()
        {
            InitializeComponent();
            _instructorService = InstanceFactory.GetInstance<IInstructorService>();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            _advisorService = InstanceFactory.GetInstance<IAdvisorService>();
            _students = new List<Student>();

        }

        private IInstructorService _instructorService;
        private IStudentService _studentService;
        private IDepartmentService _departmentService;
        private IAdvisorService _advisorService;
        private List<Advisor> _advisors;
        private List<Student> _students;

        private void FrmCoordinatorAssignmentOfAdvisorToStudent_Load(object sender, EventArgs e)
        {
            LoadAdvisor();
            LoadStudent();
            ClearTxtes();
        }

        private void LoadAdvisor()
        {
            gcAdvisor.DataSource = _instructorService.GetAll();
        }

        private void LoadStudent()
        {
            gcStudent.DataSource = _studentService.GetAll();
            //this.coursesTableAdapter.Fill(this.comp337DataSet.Courses);
            //gvCourse.DataSource = ;
        }

        private void ClearTxtes()
        {
            txtePersonalId.Text = "";
            txteFirstName.Text = "";
            txteLastName.Text = "";
            txteDepartment.Text = "";
            txteEMail.Text = "";
        }

        private void gvAdvisor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadStudentOfAdvisor(((Instructor)gvAdvisor.GetFocusedRow()).Id);
        }

        private void LoadStudentOfAdvisor(int instructoId)
        {
            _advisors = _advisorService.GetByInstructoreId(instructoId);
            _students.Clear();
            foreach (var advisor in _advisors)
            {
                _students.Add(_studentService.GetById(advisor.StudentId));
            }

            gcStudentOfAdvisor.DataSource = null;
            gcStudentOfAdvisor.DataSource = _students;
        }

        private void gvStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!sbtnAdd.Enabled)
            {
                sbtnAdd.Enabled = true;
                sbtnDelete.Enabled = false;
            }
            txtePersonalId.Text = ((Student)gvStudent.GetFocusedRow()).PersonalId;
            txteFirstName.Text = ((Student)gvStudent.GetFocusedRow()).FirstName;
            txteLastName.Text = ((Student)gvStudent.GetFocusedRow()).LastName;
            txteDepartment.Text = _departmentService.GetById(((Student)gvStudent.GetFocusedRow()).DepartmentId).DepartmentName;
            txteEMail.Text = ((Student)gvStudent.GetFocusedRow()).Email;
        }

        private void gvStudentOfAdvisor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!sbtnDelete.Enabled)
            {
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = true;
            }
            txtePersonalId.Text = ((Student)gvStudentOfAdvisor.GetFocusedRow()).PersonalId;
            txteFirstName.Text = ((Student)gvStudentOfAdvisor.GetFocusedRow()).FirstName;
            txteLastName.Text = ((Student)gvStudentOfAdvisor.GetFocusedRow()).LastName;
            txteDepartment.Text = _departmentService.GetById(((Student)gvStudentOfAdvisor.GetFocusedRow()).DepartmentId).DepartmentName;
            txteEMail.Text = ((Student)gvStudentOfAdvisor.GetFocusedRow()).Email;
        }

        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            if (txteDepartment.Text == "")
            {
                MessageBox.Show("Önce eçiniz");
            }
            else if (_advisorService.ControlByStudentIdandInstructorId(new Advisor { InstructorId = ((Instructor)gvAdvisor.GetFocusedRow()).Id, StudentId = ((Student)gvStudent.GetFocusedRow()).Id }))
            {
                MessageBox.Show("Bu öğrencinin danışmanı zaten bu hocadır");
            }
            else if (_advisorService.ControlByStudentId(new Advisor { StudentId = ((Student)gvStudent.GetFocusedRow()).Id }))
            {
                MessageBox.Show("Bu öğrencinin danışmanı vardır");
            }
            else
            {
                _advisorService.Add(new Advisor()
                {
                    StudentId = ((Student)gvStudent.GetFocusedRow()).Id,
                    InstructorId = ((Instructor)gvAdvisor.GetFocusedRow()).Id
                });
                ClearTxtes();
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = false;
                LoadStudentOfAdvisor(((Instructor)gvAdvisor.GetFocusedRow()).Id);
            }
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (txteDepartment.Text == "")
            {
                MessageBox.Show("Önce eçiniz");
            }
            else
            {
                _advisorService.DeleteByStudentIdandInstructorId(new Advisor
                {
                    StudentId = ((Student)gvStudentOfAdvisor.GetFocusedRow()).Id,
                    InstructorId = ((Instructor)gvAdvisor.GetFocusedRow()).Id
                });
                ClearTxtes();
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = false;
                LoadStudentOfAdvisor(((Instructor)gvAdvisor.GetFocusedRow()).Id);
            }
        }
    }
}