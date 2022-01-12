using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Comp337.Business.Abstract;
using Comp337.Business.DependencyResolvers.Ninject;
using Comp337.Entities.Concrete;

namespace Comp337.WebFormsUI.Forms.CoordinatorForms
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
            ClearTxtes();
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

        private void ClearTxtes()
        {
            txtePersonalId.Text = "";
            txteFirstName.Text = "";
            txteLastName.Text = "";
            txteDepartment.Text = "";
            txteEMail.Text = "";
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
            //_instructors = new List<Instructor>();
            //gcInstructorOfCourse.DataSource = _instructors;
            foreach (var courseInstructor in _courseInstructors)
            {
                _instructors.Add(_instructorService.GetById(courseInstructor.InstructorId));
                //MessageBox.Show(courseInstructor.Id.ToString());
            }

            //foreach (var instructor in _instructors)
            //{
            //    MessageBox.Show(instructor.FirstName);
            //}
            gcInstructorOfCourse.DataSource = null;
            gcInstructorOfCourse.DataSource = _instructors;

            ////Burda kaldım data source güncellenmiyo
            ////Email kısmında hata ver data updatelenmiyo
        }

        private void gvInstructor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if (!sbtnAdd.Enabled)
            {
                sbtnAdd.Enabled = true;
                sbtnDelete.Enabled = false;
            }
            txtePersonalId.Text = ((Instructor)gvInstructor.GetFocusedRow()).PersonalId;
            txteFirstName.Text = ((Instructor)gvInstructor.GetFocusedRow()).FirstName;
            txteLastName.Text = ((Instructor)gvInstructor.GetFocusedRow()).LastName;
            txteDepartment.Text = _departmentService.GetById(((Instructor)gvInstructor.GetFocusedRow()).DepartmentId).DepartmentName;
            txteEMail.Text = ((Instructor)gvInstructor.GetFocusedRow()).Email;
        }

        private void gvInstructorOfCourse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!sbtnDelete.Enabled)
            {
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = true;
            }
            txtePersonalId.Text = ((Instructor)gvInstructorOfCourse.GetFocusedRow()).PersonalId;
            txteFirstName.Text = ((Instructor)gvInstructorOfCourse.GetFocusedRow()).FirstName;
            txteLastName.Text = ((Instructor)gvInstructorOfCourse.GetFocusedRow()).LastName;
            txteDepartment.Text = _departmentService.GetById(((Instructor)gvInstructorOfCourse.GetFocusedRow()).DepartmentId).DepartmentName;
            txteEMail.Text = ((Instructor)gvInstructorOfCourse.GetFocusedRow()).Email;
        }

        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            if (txteDepartment.Text == "")
            {
                MessageBox.Show("Önce eçiniz");
            }
            else if (_courseInstructorService.ControlByCourseIdandInstructorId(new CourseInstructor {CourseId = ((Course)gvCourse.GetFocusedRow()).Id, InstructorId = ((Instructor)gvInstructor.GetFocusedRow()).Id }))
            {
                MessageBox.Show("Bu hoca bu derse zaten eklidir.");
            }
            else
            {
                //((Course)gvCourse.GetFocusedRow()).Id.ToString()
                //((Instructor)gvInstructor.GetFocusedRow()).Id;
                _courseInstructorService.Add(new CourseInstructor
                {
                    CourseId = ((Course)gvCourse.GetFocusedRow()).Id,
                    InstructorId = ((Instructor)gvInstructor.GetFocusedRow()).Id
                });
                ClearTxtes();
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = false;
                LoadInstructorOfCourse(((Course)gvCourse.GetFocusedRow()).Id);
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
                _courseInstructorService.DeleteByCourseIdandInstructorId(new CourseInstructor
                {
                    CourseId = ((Course)gvCourse.GetFocusedRow()).Id,
                    InstructorId = ((Instructor)gvInstructorOfCourse.GetFocusedRow()).Id
                });
                ClearTxtes();
                sbtnAdd.Enabled = false;
                sbtnDelete.Enabled = false;
                LoadInstructorOfCourse(((Course)gvCourse.GetFocusedRow()).Id);
            }
        }
    }
}