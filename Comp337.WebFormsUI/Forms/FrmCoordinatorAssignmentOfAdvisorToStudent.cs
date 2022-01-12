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

namespace Comp337.WebFormsUI.Forms
{
    public partial class FrmCoordinatorAssignmentOfAdvisorToStudent : DevExpress.XtraEditors.XtraForm
    {
        public FrmCoordinatorAssignmentOfAdvisorToStudent()
        {
            InitializeComponent();
            _instructorService = InstanceFactory.GetInstance<IInstructorService>();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            _advisorService = InstanceFactory.GetInstance<IAdvisorService>();

        }

        private IInstructorService _instructorService;
        private IStudentService _studentService;
        private IDepartmentService _departmentService;
        private IAdvisorService _advisorService;
    }
}