
namespace Comp337.WebFormsUI.Forms.StudentsForms
{
    partial class FrmStudentRegisteredStudents
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
            this.grcRegisteredStudent = new DevExpress.XtraGrid.GridControl();
            this.gvRegisteredStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcRegisteredStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisteredStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // grcRegisteredStudent
            // 
            this.grcRegisteredStudent.Location = new System.Drawing.Point(2, 12);
            this.grcRegisteredStudent.MainView = this.gvRegisteredStudent;
            this.grcRegisteredStudent.Name = "grcRegisteredStudent";
            this.grcRegisteredStudent.Size = new System.Drawing.Size(641, 355);
            this.grcRegisteredStudent.TabIndex = 0;
            this.grcRegisteredStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRegisteredStudent});
            // 
            // gvRegisteredStudent
            // 
            this.gvRegisteredStudent.GridControl = this.grcRegisteredStudent;
            this.gvRegisteredStudent.Name = "gvRegisteredStudent";
            // 
            // FrmStudentRegisteredStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 368);
            this.Controls.Add(this.grcRegisteredStudent);
            this.Name = "FrmStudentRegisteredStudents";
            this.Text = "FrmStudentRegisteredStudents";
            ((System.ComponentModel.ISupportInitialize)(this.grcRegisteredStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisteredStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcRegisteredStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRegisteredStudent;
    }
}