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

namespace Comp337.WebFormsUI.Forms.InstructorForms
{
    public partial class FrmInstructorCourseInformation : DevExpress.XtraEditors.XtraForm
    {
        public FrmInstructorCourseInformation(Instructor instructor)
        {
            InitializeComponent();
            _courseInstructorService = InstanceFactory.GetInstance<ICourseInstructorService>();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
            _courseRegistrationService = InstanceFactory.GetInstance<ICourseRegistrationService>();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _instructor = instructor;
            _courses = new List<Course>();
            _students = new List<Student>();
            //_courseInstructors = new List<CourseInstructor>();
        }

        private Instructor _instructor;
        private List<CourseInstructor> _courseInstructors;
        private List<Course> _courses;
        private List<CourseRegistration> _courseRegistrations;
        private List<Student> _students;
        private ICourseInstructorService _courseInstructorService;
        private ICourseService _courseService;
        private ICourseRegistrationService _courseRegistrationService;
        private IStudentService _studentService;

        private void FrmInstructorCourseInformation_Load(object sender, EventArgs e)
        {
            LoadCourseOfInstructor();
        }

        private void LoadCourseOfInstructor()
        {
            _courseInstructors = _courseInstructorService.GetByInstructorId(_instructor.Id);
            _courses.Clear();
            foreach (var courseInstructor in _courseInstructors)
            {
                _courses.Add(_courseService.GetById(courseInstructor.CourseId));
            }
            gcCourseOfInstructor.DataSource = null;
            gcCourseOfInstructor.DataSource = _courses;
        }

        private void gvCourseOfInstructor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadStudentOfCourse(((Course)gvCourseOfInstructor.GetFocusedRow()).Id);
        }

        private void LoadStudentOfCourse(int id)
        {
            _courseRegistrations = _courseRegistrationService.GetByCourseId(id);
            _students.Clear();
            foreach (var courseRegistration in _courseRegistrations)
            {
                _students.Add(_studentService.GetById(courseRegistration.StudentId));
            }
            gcStudentOfCourse.DataSource = null;
            gcStudentOfCourse.DataSource = _students;
        }
    }
}