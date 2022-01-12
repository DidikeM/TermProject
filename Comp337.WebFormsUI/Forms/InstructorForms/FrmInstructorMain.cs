using Comp337.Entities.Concrete;
using DevExpress.XtraBars;
using Comp337.WebFormsUI.Forms.InstructorForms;

namespace Comp337.WebFormsUI.Forms.InstructorsForms
{
    public partial class FrmInstructorMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmInstructorMain(Instructor instructor)
        {
            InitializeComponent();
            _instructor = instructor;
        }

        Instructor _instructor;

        private FrmInstructorAddCourseToStudents frmInstructorCourseInfoAndAddStudent;
        private FrmInstructorCourseInformation frmInstructorCourseInformation;

        private void btnAddStudents_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmInstructorCourseInfoAndAddStudent == null)
            {
                frmInstructorCourseInfoAndAddStudent = new FrmInstructorAddCourseToStudents(_instructor);
                frmInstructorCourseInfoAndAddStudent.MdiParent = this;
                frmInstructorCourseInfoAndAddStudent.Show();
            }
        }

        private void btnCourseInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmInstructorCourseInformation == null)
            {
                frmInstructorCourseInformation = new FrmInstructorCourseInformation(_instructor);
                frmInstructorCourseInformation.MdiParent = this;
                frmInstructorCourseInformation.Show();
            }
        }
    }
}