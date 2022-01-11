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

namespace Comp337.WebFormsUI.Forms
{
    public partial class FrmCoordinatorAssignmentOfInstructorToCourse : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorAssignmentOfInstructorToCourse()
        {
            InitializeComponent();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
            _instructorService = InstanceFactory.GetInstance<IInstructorService>();
        }

        private ICourseService _courseService;
        private IInstructorService _instructorService;

        private void FrmCoordinatorAssignmentOfInstructorToCourse_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadInstructor();
        }

        private void LoadInstructor()
        {
            gcInstructor.DataSource = _instructorService.GetAll();
        }

        private void LoadInstructorOfCourse()
        {
            gcInstructorOfCourse.DataSource = _instructorService.GetAll(/*p => p.DepartmentId == 1*/);
        }

        private void LoadCourses()
        {
            gcCourse.DataSource = _courseService.GetAll();
            //this.coursesTableAdapter.Fill(this.comp337DataSet.Courses);
            //gvCourse.DataSource = ;
        }

        private void gvCourse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
    }
}