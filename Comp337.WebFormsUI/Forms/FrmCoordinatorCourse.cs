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
using DevExpress.XtraBars.Ribbon.BackstageView.Accessible;

namespace Comp337.WebFormsUI.Forms
{
    public partial class FrmCoordinatorCourse : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorCourse()
        {
            InitializeComponent();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
            _semesterService = InstanceFactory.GetInstance<ISemesterService>();
        }

        private ISemesterService _semesterService;
        private ICourseService _courseService;

        private void FrmCoordinatorCourse_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadSemester();
            //MessageBox.Show(_semesterService.GetAll().ToString());
        }

        private void LoadSemester()
        {
            lueSemesterUpdate.Properties.DataSource = _semesterService.GetAll();
            lueSemesterUpdate.Properties.DisplayMember = "Name";
            lueSemesterUpdate.Properties.ValueMember = "Id";

            lueSemesterAdd.Properties.DataSource = _semesterService.GetAll();
            lueSemesterAdd.Properties.DisplayMember = "Name";
            lueSemesterAdd.Properties.ValueMember = "Id";
            //lueSemester.Properties.
        }

        private void LoadCourses()
        {
            gcCourse.DataSource = _courseService.GetAll();
            //this.coursesTableAdapter.Fill(this.comp337DataSet.Courses);
            //gvCourse.DataSource = ;
        }

        private void gvCourse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txteCourseCodeUpdate.Text = ((Course)gvCourse.GetFocusedRow()).CourseCode;
            txteCourseCreditUpdate.Text = ((Course)gvCourse.GetFocusedRow()).CourseCredit.ToString();
            txteCourseNameUpdate.Text = ((Course) gvCourse.GetFocusedRow()).CourseName;
            lueSemesterUpdate.EditValue = ((Course) gvCourse.GetFocusedRow()).SemesterId;
        }


        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            //Semester semester = (Semester)lueSemester.GetSelectedDataRow();
            if (txteCourseCodeAdd.Text == "" || txteCourseCreditAdd.Text == "" || txteCourseNameAdd.Text == "" || (Semester)lueSemesterAdd.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Please fill the boxes");
            }
            else
            {
                //MessageBox.Show(semester.Id.ToString());
                CourseAdd();
                LoadCourses();
                ClearAdd();
            }
        }

        protected void CourseAdd()
        {
            _courseService.Add(new Course
            {
                CourseCode = txteCourseCodeAdd.Text,
                CourseCredit = Convert.ToInt32(txteCourseCreditAdd.Text),
                CourseName = txteCourseNameAdd.Text,
                SemesterId = ((Semester)lueSemesterAdd.GetSelectedDataRow()).Id
            });
        }

        private void ClearAdd()
        {
            txteCourseCodeAdd.Text = "";
            txteCourseCreditAdd.Text = "";
            txteCourseNameAdd.Text = "";
            lueSemesterAdd.EditValue = null;
        }

        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            if (txteCourseCodeUpdate.Text == "" || txteCourseCreditUpdate.Text == "" || txteCourseNameUpdate.Text == "" || (Semester)lueSemesterUpdate.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Please choose from the list above");
            }
            else
            {
                //MessageBox.Show(semester.Id.ToString());
                CourseUpdate();
                LoadCourses();
                ClearUpdate();
            }
        }

        private void ClearUpdate()
        {
            txteCourseCodeUpdate.Text = "";
            txteCourseCreditUpdate.Text = "";
            txteCourseNameUpdate.Text = "";
            lueSemesterUpdate.EditValue = null;
        }

        protected void CourseUpdate()
        {
            _courseService.update(new Course
            {
                Id = ((Course)gvCourse.GetFocusedRow()).Id,
                CourseCode = txteCourseCodeUpdate.Text,
                CourseCredit = Convert.ToInt32(txteCourseCreditUpdate.Text),
                CourseName = txteCourseNameUpdate.Text,
                SemesterId = ((Semester)lueSemesterUpdate.GetSelectedDataRow()).Id
            });
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (txteCourseCodeUpdate.Text == "" || txteCourseCreditUpdate.Text == "" || txteCourseNameUpdate.Text == "" || (Semester)lueSemesterUpdate.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Please choose from the list above");
            }
            else
            {
                //MessageBox.Show(semester.Id.ToString());
                CourseDelete();
                LoadCourses();
                ClearUpdate();
            }
        }

        private void CourseDelete()
        {
            _courseService.Delete(new Course
            {
                Id = ((Course)gvCourse.GetFocusedRow()).Id,
                CourseCode = txteCourseCodeUpdate.Text,
                CourseCredit = Convert.ToInt32(txteCourseCreditUpdate.Text),
                CourseName = txteCourseNameUpdate.Text,
                SemesterId = ((Semester)lueSemesterUpdate.GetSelectedDataRow()).Id
            });
        }
    }
}