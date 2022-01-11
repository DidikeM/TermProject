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

namespace Comp337.WebFormsUI.Forms
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

        private void btnCourses_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCoordinatorCourse == null)
            {
                frmCoordinatorCourse = new FrmCoordinatorCourse();
                frmCoordinatorCourse.MdiParent = this;
                frmCoordinatorCourse.Show();
            }
        }
    }
}