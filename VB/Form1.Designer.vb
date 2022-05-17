Namespace PivotGridEditor
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldRow = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldData = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRow, Me.fieldData})
            Me.pivotGridControl1.Location = New System.Drawing.Point(13, 13)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1})
            Me.pivotGridControl1.Size = New System.Drawing.Size(486, 390)
            Me.pivotGridControl1.TabIndex = 0
            '
            'fieldRow
            '
            Me.fieldRow.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldRow.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "row"
            Me.fieldRow.DataBinding = DataSourceColumnBinding1
            Me.fieldRow.Name = "fieldRow"
            '
            'fieldData
            '
            Me.fieldData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldData.AreaIndex = 0
            DataSourceColumnBinding2.ColumnName = "data"
            Me.fieldData.DataBinding = DataSourceColumnBinding2
            Me.fieldData.FieldEdit = Me.repositoryItemTextEdit1
            Me.fieldData.Name = "fieldData"
            Me.fieldData.Options.ShowGrandTotal = False
            Me.fieldData.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(511, 415)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private fieldRow As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldData As DevExpress.XtraPivotGrid.PivotGridField
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    End Class
End Namespace