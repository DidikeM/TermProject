
namespace Comp337.WebFormsUI.Forms
{
    partial class FrmCoordinatorCourse
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
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCourse
            // 
            this.gcCourse.Location = new System.Drawing.Point(12, 12);
            this.gcCourse.MainView = this.gvCourse;
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.Size = new System.Drawing.Size(937, 210);
            this.gcCourse.TabIndex = 0;
            this.gcCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourse});
            // 
            // gvCourse
            // 
            this.gvCourse.GridControl = this.gcCourse;
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.OptionsView.ShowGroupPanel = false;
            // 
            // FrmCoordinatorCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 424);
            this.Controls.Add(this.gcCourse);
            this.Name = "FrmCoordinatorCourse";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.FrmCoordinatorCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourse;
    }
}