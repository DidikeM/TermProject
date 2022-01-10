using System;
using System.Windows.Forms;
using Comp337.Business.Abstract;
using Comp337.Business.DependencyResolvers.Ninject;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.WebFormsUI.Forms
{
    public partial class BaseForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseForm()
        {
            InitializeComponent();
            _courseService = InstanceFactory.GetInstance<ICourseService>();
        }


        private ICourseService _courseService;
        private void BaseForm_Load(object sender, EventArgs e)
        {
            
            LoadCourses();
            LoadSection();
        }

        private void LoadSection()
        {
            // TODO: This line of code loads data into the 'comp337DataSet1.Sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.comp337DataSet1.Sections);
        }

        private void LoadCourses()
        {
            // TODO: This line of code loads data into the 'comp337DataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.comp337DataSet.Courses);
        }

        void Save()
        {
            DialogResult Confirmation = MessageBox.Show("Bilgileri kaydetmek istediğinize Emin misiniz ?",
                "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {

                _courseService.Add(new Course
                {
                    CourseName = txtCourseName.Text,
                    CourseCredit = Convert.ToInt16(txtCourseCredit.Text),
                    SectionId = Convert.ToInt32(txtSectionId.EditValue),
                    DeleteFlag = false

                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}