
namespace Comp337.WebFormsUI.Forms.InstructorForms
{
    partial class FrmInstructorCourseInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcCourseOfInstructor = new DevExpress.XtraGrid.GridControl();
            this.gvCourseOfInstructor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcStudentOfCourse = new DevExpress.XtraGrid.GridControl();
            this.gvStudentOfCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourseOfInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseOfInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentOfCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentOfCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCourseOfInstructor
            // 
            this.gcCourseOfInstructor.Location = new System.Drawing.Point(12, 12);
            this.gcCourseOfInstructor.MainView = this.gvCourseOfInstructor;
            this.gcCourseOfInstructor.Name = "gcCourseOfInstructor";
            this.gcCourseOfInstructor.Size = new System.Drawing.Size(408, 442);
            this.gcCourseOfInstructor.TabIndex = 14;
            this.gcCourseOfInstructor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourseOfInstructor});
            // 
            // gvCourseOfInstructor
            // 
            this.gvCourseOfInstructor.GridControl = this.gcCourseOfInstructor;
            this.gvCourseOfInstructor.Name = "gvCourseOfInstructor";
            this.gvCourseOfInstructor.OptionsBehavior.Editable = false;
            this.gvCourseOfInstructor.OptionsView.ShowGroupPanel = false;
            this.gvCourseOfInstructor.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCourseOfInstructor_RowClick);
            // 
            // gcStudentOfCourse
            // 
            this.gcStudentOfCourse.Location = new System.Drawing.Point(426, 12);
            this.gcStudentOfCourse.MainView = this.gvStudentOfCourse;
            this.gcStudentOfCourse.Name = "gcStudentOfCourse";
            this.gcStudentOfCourse.Size = new System.Drawing.Size(408, 442);
            this.gcStudentOfCourse.TabIndex = 15;
            this.gcStudentOfCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentOfCourse});
            // 
            // gvStudentOfCourse
            // 
            this.gvStudentOfCourse.GridControl = this.gcStudentOfCourse;
            this.gvStudentOfCourse.Name = "gvStudentOfCourse";
            this.gvStudentOfCourse.OptionsBehavior.Editable = false;
            this.gvStudentOfCourse.OptionsView.ShowGroupPanel = false;
            // 
            // FrmInstructorCourseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 466);
            this.Controls.Add(this.gcStudentOfCourse);
            this.Controls.Add(this.gcCourseOfInstructor);
            this.Name = "FrmInstructorCourseInformation";
            this.Text = "FrmInstructorCourseInformation";
            this.Load += new System.EventHandler(this.FrmInstructorCourseInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCourseOfInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseOfInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentOfCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentOfCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCourseOfInstructor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourseOfInstructor;
        private DevExpress.XtraGrid.GridControl gcStudentOfCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentOfCourse;
    }
}