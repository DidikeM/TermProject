using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comp337.Business.Abstract;
using Comp337.Business.DependencyResolvers.Ninject;
using Comp337.Entities.Concrete;

namespace Comp337.WebFormsUI.Forms
{
    public partial class FrmCoordinatorAssignmentOfInstructorToCourse : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorAssignmentOfInstructorToCourse()
        {
            InitializeComponent();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
            _instructorService = InstanceFactory.GetInstance<IInstructorService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            _courseInstructorService = InstanceFactory.GetInstance<ICourseInstructorService>();
            //_courseInstructors = new List<CourseInstructor>();
            _instructors = new List<Instructor>();
        }

        private ICourseService _courseService;
        private IInstructorService _instructorService;
        private IDepartmentService _departmentService;
        private ICourseInstructorService _courseInstructorService;
        private List<CourseInstructor> _courseInstructors;
        private List<Instructor> _instructors;

        private void FrmCoordinatorAssignmentOfInstructorToCourse_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadInstructor();
        }

        private void LoadInstructor()
        {
            gcInstructor.DataSource = _instructorService.GetAll();
        }

        private void LoadCourses()
        {
            gcCourse.DataSource = _courseService.GetAll();
            //this.coursesTableAdapter.Fill(this.comp337DataSet.Courses);
            //gvCourse.DataSource = ;
        }

        private void gvCourse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadInstructorOfCourse(((Course) gvCourse.GetFocusedRow()).Id);
        }

        private void LoadInstructorOfCourse(int courseId)
        {
            _courseInstructors = _courseInstructorService.GetByCourseId(courseId);
            //MessageBox.Show(courseId.ToString());
            _instructors.Clear();
            foreach (var courseInstructor in _courseInstructors)
            {
                _instructors.Add(_instructorService.GetById(courseInstructor.InstructorId));
                //MessageBox.Show(courseInstructor.Id.ToString());
            }

            //foreach (var instructor in _instructors)
            //{
            //    MessageBox.Show(instructor.FirstName);
            //}
            gcInstructorOfCourse.DataSource = _instructors;
        }

        private void gvInstructor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtePersonalId.Text = ((Instructor)gvInstructor.GetFocusedRow()).PersonalId;
            txteFirstName.Text = ((Instructor)gvInstructor.GetFocusedRow()).FirstName;
            txteLastName.Text = ((Instructor)gvInstructor.GetFocusedRow()).LastName;
            txteDepartment.Text = _departmentService.GetById(((Instructor)gvInstructor.GetFocusedRow()).DepartmentId).DepartmentName;
            txteEMail.Text = ((Instructor)gvInstructor.GetFocusedRow()).Email;
        }

        private void gvInstructorOfCourse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
    }
}