using Comp337.Entities.Concrete;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnAddStudents_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmInstructorCourseInfoAndAddStudent == null)
            {
                frmInstructorCourseInfoAndAddStudent = new FrmInstructorAddCourseToStudents(_instructor);
                frmInstructorCourseInfoAndAddStudent.MdiParent = this;
                frmInstructorCourseInfoAndAddStudent.Show();
            }
        }
    }
}