using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.IListBinding
{
	public partial class BindIListToDataGridSample
	{
	  
		#region Windows Form Designer generated code
	   
	   
		private System.Windows.Forms.Button btnGenerateReport;
private System.Windows.Forms.Label label1;
private DataGridView dataGridView1;
private DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
private DataGridViewCheckBoxColumn discontinuedDataGridViewCheckBoxColumn;
private DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn unitsOnOrderDataGridViewTextBoxColumn;
private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindIListToDataGridSample));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this._productCollection = new GrapeCity.ActiveReports.Samples.IListBinding.DataLayer.ProductCollection();
			this.btnGenerateReport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  
			this.SuspendLayout();
			// 
			// _productCollection
			// 
			this._productCollection.Capacity = 128;
			// 
			// btnGenerateReport
			// 
			resources.ApplyResources(this.btnGenerateReport, "btnGenerateReport");
			this.btnGenerateReport.Name = "btnGenerateReport";
			this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// dataGridView1
			// 
			resources.ApplyResources(this.dataGridView1, "dataGridView1");
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.supplierIDDataGridViewTextBoxColumn,
			this.discontinuedDataGridViewCheckBoxColumn,
			this.categoryIDDataGridViewTextBoxColumn,
			this.reorderLevelDataGridViewTextBoxColumn,
			this.productNameDataGridViewTextBoxColumn,
			this.productIDDataGridViewTextBoxColumn,
			this.quantityPerUnitDataGridViewTextBoxColumn,
			this.unitsInStockDataGridViewTextBoxColumn,
			this.unitsOnOrderDataGridViewTextBoxColumn,
			this.unitPriceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this._productCollection;
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.RowTemplate.Height = 21;
			// 
			// supplierIDDataGridViewTextBoxColumn
			// 
			this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
			resources.ApplyResources(this.supplierIDDataGridViewTextBoxColumn, "supplierIDDataGridViewTextBoxColumn");
			this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
			// 
			// discontinuedDataGridViewCheckBoxColumn
			// 
			this.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued";
			resources.ApplyResources(this.discontinuedDataGridViewCheckBoxColumn, "discontinuedDataGridViewCheckBoxColumn");
			this.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn";
			// 
			// categoryIDDataGridViewTextBoxColumn
			// 
			this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
			resources.ApplyResources(this.categoryIDDataGridViewTextBoxColumn, "categoryIDDataGridViewTextBoxColumn");
			this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
			// 
			// reorderLevelDataGridViewTextBoxColumn
			// 
			this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
			resources.ApplyResources(this.reorderLevelDataGridViewTextBoxColumn, "reorderLevelDataGridViewTextBoxColumn");
			this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			resources.ApplyResources(this.productNameDataGridViewTextBoxColumn, "productNameDataGridViewTextBoxColumn");
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// productIDDataGridViewTextBoxColumn
			// 
			this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
			resources.ApplyResources(this.productIDDataGridViewTextBoxColumn, "productIDDataGridViewTextBoxColumn");
			this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
			// 
			// quantityPerUnitDataGridViewTextBoxColumn
			// 
			this.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit";
			resources.ApplyResources(this.quantityPerUnitDataGridViewTextBoxColumn, "quantityPerUnitDataGridViewTextBoxColumn");
			this.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn";
			// 
			// unitsInStockDataGridViewTextBoxColumn
			// 
			this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
			resources.ApplyResources(this.unitsInStockDataGridViewTextBoxColumn, "unitsInStockDataGridViewTextBoxColumn");
			this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
			// 
			// unitsOnOrderDataGridViewTextBoxColumn
			// 
			this.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder";
			resources.ApplyResources(this.unitsOnOrderDataGridViewTextBoxColumn, "unitsOnOrderDataGridViewTextBoxColumn");
			this.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn";
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			resources.ApplyResources(this.unitPriceDataGridViewTextBoxColumn, "unitPriceDataGridViewTextBoxColumn");
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			// 
			// BindIListToDataGridSample
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGenerateReport);
			this.Name = "BindIListToDataGridSample";
			this.Load += new System.EventHandler(this.BindIListToDataGridSample_Load);
		   
			this.ResumeLayout(false);
		}
		
		#endregion
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
	}
}
