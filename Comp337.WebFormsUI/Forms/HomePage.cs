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
    public partial class HomePage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void OpenForm(Form form)
        {
            form.ShowDialog();
        }
    }
}