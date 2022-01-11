
namespace Comp337.WebFormsUI.Forms
{
    partial class FrmCoordinatorAssignmentOfInstructorToCourse
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
            this.gcCourse = new DevExpress.XtraGrid.GridControl();
            this.gvCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcInstructorOfCourse = new DevExpress.XtraGrid.GridControl();
            this.gvInstructorOfCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcInstructor = new DevExpress.XtraGrid.GridControl();
            this.gvInstructor = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructorOfCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructorOfCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCourse
            // 
            this.gcCourse.Location = new System.Drawing.Point(12, 12);
            this.gcCourse.MainView = this.gvCourse;
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.Size = new System.Drawing.Size(451, 226);
            this.gcCourse.TabIndex = 1;
            this.gcCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourse});
            // 
            // gvCourse
            // 
            this.gvCourse.GridControl = this.gcCourse;
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.OptionsBehavior.Editable = false;
            this.gvCourse.OptionsView.ShowGroupPanel = false;
            this.gvCourse.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCourse_RowClick);
            // 
            // gcInstructorOfCourse
            // 
            this.gcInstructorOfCourse.Location = new System.Drawing.Point(12, 244);
            this.gcInstructorOfCourse.MainView = this.gvInstructorOfCourse;
            this.gcInstructorOfCourse.Name = "gcInstructorOfCourse";
            this.gcInstructorOfCourse.Size = new System.Drawing.Size(451, 226);
            this.gcInstructorOfCourse.TabIndex = 2;
            this.gcInstructorOfCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstructorOfCourse});
            // 
            // gvInstructorOfCourse
            // 
            this.gvInstructorOfCourse.GridControl = this.gcInstructorOfCourse;
            this.gvInstructorOfCourse.Name = "gvInstructorOfCourse";
            this.gvInstructorOfCourse.OptionsBehavior.Editable = false;
            this.gvInstructorOfCourse.OptionsView.ShowGroupPanel = false;
            // 
            // gcInstructor
            // 
            this.gcInstructor.Location = new System.Drawing.Point(469, 244);
            this.gcInstructor.MainView = this.gvInstructor;
            this.gcInstructor.Name = "gcInstructor";
            this.gcInstructor.Size = new System.Drawing.Size(449, 226);
            this.gcInstructor.TabIndex = 3;
            this.gcInstructor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstructor});
            // 
            // gvInstructor
            // 
            this.gvInstructor.GridControl = this.gcInstructor;
            this.gvInstructor.Name = "gvInstructor";
            this.gvInstructor.OptionsBehavior.Editable = false;
            this.gvInstructor.OptionsView.ShowGroupPanel = false;
            // 
            // FrmCoordinatorAssignmentOfInstructorToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 500);
            this.Controls.Add(this.gcInstructor);
            this.Controls.Add(this.gcInstructorOfCourse);
            this.Controls.Add(this.gcCourse);
            this.Name = "FrmCoordinatorAssignmentOfInstructorToCourse";
            this.Text = "FrmCoordinatorAssignmentOfInstructorToCourse";
            this.Load += new System.EventHandler(this.FrmCoordinatorAssignmentOfInstructorToCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructorOfCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructorOfCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourse;
        private DevExpress.XtraGrid.GridControl gcInstructorOfCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstructorOfCourse;
        private DevExpress.XtraGrid.GridControl gcInstructor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstructor;
    }
}