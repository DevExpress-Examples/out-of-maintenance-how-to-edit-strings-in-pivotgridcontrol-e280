using System.Data;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace PivotGridEditor {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			DataTable data = new DataTable();
			data.Columns.Add("row", typeof(string));
			data.Columns.Add("data", typeof(string));
			data.Rows.Add("1", "aaa");
			data.Rows.Add("2", "bbb");
			data.Rows.Add("3", "ccc");
			data.Rows.Add("4", "ddd");
			pivotGridControl1.DataSource = data.DefaultView;
		}

		private void pivotGridControl1_EditValueChanged(object sender, EditValueChangedEventArgs e) {
			PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
			ds.SetValue(0, "data", e.Editor.EditValue);
		}
	}
}