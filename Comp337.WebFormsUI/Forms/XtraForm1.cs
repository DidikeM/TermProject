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
using Comp337.Business.Concrete;
using Comp337.Business.DependencyResolvers.Ninject;

namespace Comp337.WebFormsUI.Forms
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
        }

        private IStudentService _studentService;
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _studentService.GetAll();
        }
    }
}