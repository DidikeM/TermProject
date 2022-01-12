using System;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Comp337.WebFormsUI.Forms.CoordinatorForms
{
    public partial class FrmCoordinatorMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmCoordinatorMain()
        {
            InitializeComponent();

        }

        void OpenForm(Form form)
        {
            form.ShowDialog();
        }

        private FrmCoordinatorCourse frmCoordinatorCourse;
        private FrmCoordinatorInstructor frmCoordinatorInstructor;
        private FrmCoordinatorStudent frmCoordinatorStudent;
        private FrmCoordinatorAssignmentOfInstructorToCourse frmCoordinatorAssignmentOfInstructorToCourse;
        private FrmCoordinatorAssignmentOfAdvisorToStudent frmCoordinatorAssignmentOfAdvisorToStudent;

        private void btnCourses_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCoordinatorCourse == null)
            {
                frmCoordinatorCourse = new FrmCoordinatorCourse();
                frmCoordinatorCourse.MdiParent = this;
                frmCoordinatorCourse.Show();
            }
        }

        private void FrmCoordinatorMain_Load(object sender, EventArgs e)
        {

        }

        private void btnInstructors_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCoordinatorInstructor == null)
            {
                frmCoordinatorInstructor = new FrmCoordinatorInstructor();
                frmCoordinatorInstructor.MdiParent = this;
                frmCoordinatorInstructor.Show();
            }
        }

        private void btnStudents_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCoordinatorStudent == null)
            {
                frmCoordinatorStudent = new FrmCoordinatorStudent();
                frmCoordinatorStudent.MdiParent = this;
                frmCoordinatorStudent.Show();
            }
        }

        private void btnAssignmentOfInstructorToCourse_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCoordinatorAssignmentOfInstructorToCourse == null)
            {
                frmCoordinatorAssignmentOfInstructorToCourse = new FrmCoordinatorAssignmentOfInstructorToCourse();
                frmCoordinatorAssignmentOfInstructorToCourse.MdiParent = this;
                frmCoordinatorAssignmentOfInstructorToCourse.Show();
            }
        }

        private void btnAssignmentOfAdvisorToStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCoordinatorAssignmentOfAdvisorToStudent == null)
            {
                frmCoordinatorAssignmentOfAdvisorToStudent = new FrmCoordinatorAssignmentOfAdvisorToStudent();
                frmCoordinatorAssignmentOfAdvisorToStudent.MdiParent = this;
                frmCoordinatorAssignmentOfAdvisorToStudent.Show();
            }
        }
    }
}