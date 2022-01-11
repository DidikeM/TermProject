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
    public partial class FrmCoordinatorCourse : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorCourse()
        {
            InitializeComponent();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
        }

        private ICourseService _courseService;

        private void FrmCoordinatorCourse_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            gcCourse.DataSource = _courseService.GetAll();
            //this.coursesTableAdapter.Fill(this.comp337DataSet.Courses);
            //gvCourse.DataSource = ;
        }
    }
}