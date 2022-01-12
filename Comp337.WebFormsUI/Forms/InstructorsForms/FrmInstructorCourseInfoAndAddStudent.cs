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

namespace Comp337.WebFormsUI.Forms.InstructorsForms
{
    public partial class FrmInstructorCourseInfoAndAddStudent : DevExpress.XtraEditors.XtraForm
    {
        public FrmInstructorCourseInfoAndAddStudent()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _advisorService = InstanceFactory.GetInstance<IAdvisorService>();
            //_customer = customer;
            _instructor = new Instructor {Id = 1};
            _students = new List<Student>();
        }

        private Instructor _instructor;
        private IStudentService _studentService;
        private IAdvisorService _advisorService;
        private List<Advisor> _advisors;
        private List<Student> _students;

        private void FrmInstructorCourseInfoAndAddStudent_Load(object sender, EventArgs e)
        {
            LoadStudentOfAdvisor();
        }

        private void LoadStudentOfAdvisor()
        {
            _advisors = _advisorService.GetByInstructoreId(_instructor.Id);
            _students.Clear();
            foreach (var advisor in _advisors)
            {
                _students.Add(_studentService.GetById(advisor.StudentId));
            }
            gcStudentOfAdvisor.DataSource = null;
            gcStudentOfAdvisor.DataSource = _students;
            //gcAdvisor.DataSource = _instructorService.GetAll();
        }
    }
}