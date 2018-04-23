namespace PivotGridEditor {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldRow = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldData = new DevExpress.XtraPivotGrid.PivotGridField();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldRow,
            this.fieldData});
			this.pivotGridControl1.Location = new System.Drawing.Point(13, 13);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
			this.pivotGridControl1.Size = new System.Drawing.Size(486, 390);
			this.pivotGridControl1.TabIndex = 0;
			this.pivotGridControl1.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.pivotGridControl1_EditValueChanged);
			// 
			// fieldRow
			// 
			this.fieldRow.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldRow.AreaIndex = 0;
			this.fieldRow.FieldName = "row";
			this.fieldRow.Name = "fieldRow";
			// 
			// fieldData
			// 
			this.fieldData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldData.AreaIndex = 0;
			this.fieldData.FieldEdit = this.repositoryItemTextEdit1;
			this.fieldData.FieldName = "data";
			this.fieldData.Name = "fieldData";
			this.fieldData.Options.ShowGrandTotal = false;
			this.fieldData.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 415);
			this.Controls.Add(this.pivotGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
		private DevExpress.XtraPivotGrid.PivotGridField fieldRow;
		private DevExpress.XtraPivotGrid.PivotGridField fieldData;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
	}
}