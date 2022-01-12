
namespace Comp337.WebFormsUI.Forms.StudentsForms
{
    partial class FrmRStudentsegisteredCourses
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
            this.grcRegisteredCourses = new DevExpress.XtraGrid.GridControl();
            this.gvRegisteredCourses = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcRegisteredCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisteredCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // grcRegisteredCourses
            // 
            this.grcRegisteredCourses.Location = new System.Drawing.Point(1, 37);
            this.grcRegisteredCourses.MainView = this.gvRegisteredCourses;
            this.grcRegisteredCourses.Name = "grcRegisteredCourses";
            this.grcRegisteredCourses.Size = new System.Drawing.Size(651, 302);
            this.grcRegisteredCourses.TabIndex = 0;
            this.grcRegisteredCourses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRegisteredCourses});
            // 
            // gvRegisteredCourses
            // 
            this.gvRegisteredCourses.GridControl = this.grcRegisteredCourses;
            this.gvRegisteredCourses.Name = "gvRegisteredCourses";
            // 
            // FrmRStudentsegisteredCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 338);
            this.Controls.Add(this.grcRegisteredCourses);
            this.Name = "FrmRStudentsegisteredCourses";
            this.Text = "FrmRegisteredCourses";
            this.Load += new System.EventHandler(this.FrmRStudentsegisteredCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcRegisteredCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisteredCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcRegisteredCourses;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRegisteredCourses;
    }
}