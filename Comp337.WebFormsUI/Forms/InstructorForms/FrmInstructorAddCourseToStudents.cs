using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Comp337.Business.Abstract;
using Comp337.Business.DependencyResolvers.Ninject;
using Comp337.Entities.Concrete;

namespace Comp337.WebFormsUI.Forms.InstructorsForms
{
    public partial class FrmInstructorAddCourseToStudents : DevExpress.XtraEditors.XtraForm
    {
        public FrmInstructorAddCourseToStudents(Instructor instructor)
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _advisorService = InstanceFactory.GetInstance<IAdvisorService>();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
            _courseRegistrationService = InstanceFactory.GetInstance<ICourseRegistrationService>();
            _semesterService = InstanceFactory.GetInstance<ISemesterService>();
            //_customer = customer;
            _instructor = instructor;
            _students = new List<Student>();
            _courses = new List<Course>();
        }

        private Instructor _instructor;
        private IStudentService _studentService;
        private IAdvisorService _advisorService;
        private ICourseService _courseService;
        private ICourseRegistrationService _courseRegistrationService;
        private ISemesterService _semesterService;
        private List<Advisor> _advisors;
        private List<Student> _students;
        private List<CourseRegistration> _courseRegistrations;
        private List<Course> _courses;

        private void FrmInstructorCourseInfoAndAddStudent_Load(object sender, EventArgs e)
        {
            LoadStudentOfAdvisor();
            LoadCourse();
            ClearTxtes();
        }

        private void LoadStudentOfAdvisor()
        {
            _advisors = _advisorService.GetByInstructoreId(_instructor.Id);
            _students.Clear();
            foreach (var advisor in _advisors)
            {
                _students.Add(_studentService.GetById(advisor.StudentId));
            }
            gcStudentOfAdvisor.DataSource = null;
            gcStudentOfAdvisor.DataSource = _students;
            //gcAdvisor.DataSource = _instructorService.GetAll();
        }

        private void LoadCourse()
        {
            gcCourse.DataSource = _courseService.GetAll();
        }

        private void ClearTxtes()
        {
            txteCourseCode.Text = "";
            txteCourseName.Text = "";
            txteCourseCredit.Text = "";
            txteSemester.Text = "";
        }

        private void gvStudentOfAdvisor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadCourseOfStudent(((Student)gvStudentOfAdvisor.GetFocusedRow()).Id);
        }

        private void LoadCourseOfStudent(int id)
        {
            _courseRegistrations = _courseRegistrationService.GetByStudentId(id);
            _courses.Clear();
            foreach (var courseRegistration in _courseRegistrations)
            {
                _courses.Add(_courseService.GetById(courseRegistration.CourseId));
            }
            gcCourseOfStudent.DataSource = null;
            gcCourseOfStudent.DataSource = _courses;
        }

        private void gvCourse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!sbtnAdd.Enabled)
            {
                sbtnAdd.Enabled = true;
                sbtnDelete.Enabled = false;
            }
            txteCourseCode.Text = ((Course)gvCourse.GetFocusedRow()).CourseCode;
            txteCourseName.Text = ((Course)gvCourse.GetFocusedRow()).CourseName;
            txteCourseCredit.Text = ((Course)gvCourse.GetFocusedRow()).CourseCredit.ToString();
            txteSemester.Text = _semesterService.GetById(((Course)gvCourse.GetFocusedRow()).SemesterId).Name;
        }

        private void gvCourseOfStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!sbtnDelete.Enabled)
            {
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = true;
            }
            txteCourseCode.Text = ((Course)gvCourseOfStudent.GetFocusedRow()).CourseCode;
            txteCourseName.Text = ((Course)gvCourseOfStudent.GetFocusedRow()).CourseName;
            txteCourseCredit.Text = ((Course)gvCourseOfStudent.GetFocusedRow()).CourseCredit.ToString();
            txteSemester.Text = _semesterService.GetById(((Course)gvCourseOfStudent.GetFocusedRow()).SemesterId).Name;
        }

        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            if (txteCourseCode.Text == "")
            {
                MessageBox.Show("Önce eçiniz");
            }
            else if (_courseRegistrationService.ControlByStudentIdandCourseId(new CourseRegistration { CourseId = ((Course)gvCourse.GetFocusedRow()).Id, StudentId = ((Student)gvStudentOfAdvisor.GetFocusedRow()).Id }))
            {
                MessageBox.Show("Bu öğrenci bu dersi zaten almaktadır!");
            }
            //else if (_courseRegistrationService.ControlByStudentId(new Advisor { StudentId = ((Student)gvStudent.GetFocusedRow()).Id }))
            //{
            //    MessageBox.Show("Bu öğrencinin danışmanı vardır");
            //}
            else
            {
                _courseRegistrationService.Add(new CourseRegistration
                {
                    StudentId = ((Student)gvStudentOfAdvisor.GetFocusedRow()).Id,
                    CourseId = ((Course)gvCourse.GetFocusedRow()).Id
                });
                ClearTxtes();
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = false;
                LoadCourseOfStudent(((Student)gvStudentOfAdvisor.GetFocusedRow()).Id);
            }
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (txteCourseCode.Text == "")
            {
                MessageBox.Show("Önce eçiniz");
            }
            else
            {
                _courseRegistrationService.DeleteByStudentIdandCourseId(new CourseRegistration()
                {
                    StudentId = ((Student)gvStudentOfAdvisor.GetFocusedRow()).Id,
                    CourseId = ((Course)gvCourse.GetFocusedRow()).Id
                });
                ClearTxtes();
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = false;
                LoadCourseOfStudent(((Student)gvStudentOfAdvisor.GetFocusedRow()).Id);
            }
        }
    }
}