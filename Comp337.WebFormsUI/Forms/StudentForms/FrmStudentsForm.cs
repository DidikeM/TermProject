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

namespace Comp337.WebFormsUI.Forms.StudentsForms
{
    public partial class FrmStudentsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmStudentsForm()
        {
            InitializeComponent();
        }

        private FrmStudentRegisteredStudents frmStudentRegisteredStudents;
        private FrmRStudentsegisteredCourses frmRStudentsegisteredCourses;


        private void FrmStudentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}