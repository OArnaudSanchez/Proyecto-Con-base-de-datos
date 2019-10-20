namespace CPresentacion
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tFecha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bSalir = new System.Windows.Forms.Button();
			this.bModificar = new System.Windows.Forms.Button();
			this.bEliminar = new System.Windows.Forms.Button();
			this.bCrear = new System.Windows.Forms.Button();
			this.tNombre = new System.Windows.Forms.TextBox();
			this.tId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tCategoria = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.productionDataSet = new CPresentacion.ProductionDataSet();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new CPresentacion.ProductionDataSetTableAdapters.ProductTableAdapter();
			this.data = new System.Windows.Forms.DataGridView();
			this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.safetyStockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reorderPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.daysToManufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.data2 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productionDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
			this.SuspendLayout();
			// 
			// tFecha
			// 
			this.tFecha.Location = new System.Drawing.Point(472, 95);
			this.tFecha.Name = "tFecha";
			this.tFecha.Size = new System.Drawing.Size(242, 20);
			this.tFecha.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(387, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Fecha:";
			// 
			// bSalir
			// 
			this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bSalir.Location = new System.Drawing.Point(581, 200);
			this.bSalir.Name = "bSalir";
			this.bSalir.Size = new System.Drawing.Size(177, 37);
			this.bSalir.TabIndex = 8;
			this.bSalir.Text = "Salir";
			this.bSalir.UseVisualStyleBackColor = true;
			this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
			// 
			// bModificar
			// 
			this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bModificar.Location = new System.Drawing.Point(215, 200);
			this.bModificar.Name = "bModificar";
			this.bModificar.Size = new System.Drawing.Size(177, 37);
			this.bModificar.TabIndex = 5;
			this.bModificar.Text = "Modificar";
			this.bModificar.UseVisualStyleBackColor = true;
			this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
			// 
			// bEliminar
			// 
			this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bEliminar.Location = new System.Drawing.Point(398, 200);
			this.bEliminar.Name = "bEliminar";
			this.bEliminar.Size = new System.Drawing.Size(177, 37);
			this.bEliminar.TabIndex = 7;
			this.bEliminar.Text = "Eliminar";
			this.bEliminar.UseVisualStyleBackColor = true;
			this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
			// 
			// bCrear
			// 
			this.bCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bCrear.Location = new System.Drawing.Point(32, 200);
			this.bCrear.Name = "bCrear";
			this.bCrear.Size = new System.Drawing.Size(177, 37);
			this.bCrear.TabIndex = 6;
			this.bCrear.Text = "Crear";
			this.bCrear.UseVisualStyleBackColor = true;
			this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
			// 
			// tNombre
			// 
			this.tNombre.Location = new System.Drawing.Point(121, 142);
			this.tNombre.Name = "tNombre";
			this.tNombre.Size = new System.Drawing.Size(242, 20);
			this.tNombre.TabIndex = 2;
			// 
			// tId
			// 
			this.tId.Location = new System.Drawing.Point(121, 95);
			this.tId.Name = "tId";
			this.tId.Size = new System.Drawing.Size(242, 20);
			this.tId.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(335, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 29);
			this.label3.TabIndex = 15;
			this.label3.Text = "Productos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Id:";
			// 
			// tCategoria
			// 
			this.tCategoria.Location = new System.Drawing.Point(472, 138);
			this.tCategoria.Name = "tCategoria";
			this.tCategoria.Size = new System.Drawing.Size(242, 20);
			this.tCategoria.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(383, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Categoria:";
			// 
			// productionDataSet
			// 
			this.productionDataSet.DataSetName = "ProductionDataSet";
			this.productionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "Product";
			this.productBindingSource.DataSource = this.productionDataSet;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// data
			// 
			this.data.AllowUserToAddRows = false;
			this.data.AutoGenerateColumns = false;
			this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.safetyStockLevelDataGridViewTextBoxColumn,
            this.reorderPointDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.daysToManufactureDataGridViewTextBoxColumn,
            this.sellStartDateDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
			this.data.DataSource = this.productBindingSource;
			this.data.Location = new System.Drawing.Point(32, 254);
			this.data.Name = "data";
			this.data.ReadOnly = true;
			this.data.Size = new System.Drawing.Size(741, 115);
			this.data.TabIndex = 25;
			this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
			// 
			// productIDDataGridViewTextBoxColumn
			// 
			this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
			this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
			this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
			this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.productIDDataGridViewTextBoxColumn.Width = 80;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 60;
			// 
			// productNumberDataGridViewTextBoxColumn
			// 
			this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
			this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
			this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.productNumberDataGridViewTextBoxColumn.Width = 106;
			// 
			// colorDataGridViewTextBoxColumn
			// 
			this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
			this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
			this.colorDataGridViewTextBoxColumn.ReadOnly = true;
			this.colorDataGridViewTextBoxColumn.Width = 56;
			// 
			// safetyStockLevelDataGridViewTextBoxColumn
			// 
			this.safetyStockLevelDataGridViewTextBoxColumn.DataPropertyName = "SafetyStockLevel";
			this.safetyStockLevelDataGridViewTextBoxColumn.HeaderText = "SafetyStockLevel";
			this.safetyStockLevelDataGridViewTextBoxColumn.Name = "safetyStockLevelDataGridViewTextBoxColumn";
			this.safetyStockLevelDataGridViewTextBoxColumn.ReadOnly = true;
			this.safetyStockLevelDataGridViewTextBoxColumn.Width = 116;
			// 
			// reorderPointDataGridViewTextBoxColumn
			// 
			this.reorderPointDataGridViewTextBoxColumn.DataPropertyName = "ReorderPoint";
			this.reorderPointDataGridViewTextBoxColumn.HeaderText = "ReorderPoint";
			this.reorderPointDataGridViewTextBoxColumn.Name = "reorderPointDataGridViewTextBoxColumn";
			this.reorderPointDataGridViewTextBoxColumn.ReadOnly = true;
			this.reorderPointDataGridViewTextBoxColumn.Width = 94;
			// 
			// standardCostDataGridViewTextBoxColumn
			// 
			this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
			this.standardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost";
			this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
			this.standardCostDataGridViewTextBoxColumn.ReadOnly = true;
			this.standardCostDataGridViewTextBoxColumn.Width = 96;
			// 
			// listPriceDataGridViewTextBoxColumn
			// 
			this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
			this.listPriceDataGridViewTextBoxColumn.ReadOnly = true;
			this.listPriceDataGridViewTextBoxColumn.Width = 72;
			// 
			// sizeDataGridViewTextBoxColumn
			// 
			this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
			this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
			this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
			this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
			this.sizeDataGridViewTextBoxColumn.Width = 52;
			// 
			// daysToManufactureDataGridViewTextBoxColumn
			// 
			this.daysToManufactureDataGridViewTextBoxColumn.DataPropertyName = "DaysToManufacture";
			this.daysToManufactureDataGridViewTextBoxColumn.HeaderText = "DaysToManufacture";
			this.daysToManufactureDataGridViewTextBoxColumn.Name = "daysToManufactureDataGridViewTextBoxColumn";
			this.daysToManufactureDataGridViewTextBoxColumn.ReadOnly = true;
			this.daysToManufactureDataGridViewTextBoxColumn.Width = 129;
			// 
			// sellStartDateDataGridViewTextBoxColumn
			// 
			this.sellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate";
			this.sellStartDateDataGridViewTextBoxColumn.HeaderText = "SellStartDate";
			this.sellStartDateDataGridViewTextBoxColumn.Name = "sellStartDateDataGridViewTextBoxColumn";
			this.sellStartDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.sellStartDateDataGridViewTextBoxColumn.Width = 94;
			// 
			// rowguidDataGridViewTextBoxColumn
			// 
			this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
			this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
			this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
			this.rowguidDataGridViewTextBoxColumn.ReadOnly = true;
			this.rowguidDataGridViewTextBoxColumn.Width = 69;
			// 
			// modifiedDateDataGridViewTextBoxColumn
			// 
			this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
			this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
			this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
			this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.modifiedDateDataGridViewTextBoxColumn.Width = 95;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			this.categoryDataGridViewTextBoxColumn.Width = 74;
			// 
			// data2
			// 
			this.data2.AllowUserToAddRows = false;
			this.data2.AllowUserToDeleteRows = false;
			this.data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.data2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data2.Location = new System.Drawing.Point(32, 423);
			this.data2.Name = "data2";
			this.data2.ReadOnly = true;
			this.data2.Size = new System.Drawing.Size(741, 89);
			this.data2.TabIndex = 26;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(213, 396);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(412, 24);
			this.label6.TabIndex = 27;
			this.label6.Text = "Lista de Productos Por Nombre y Categoria";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 524);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.data2);
			this.Controls.Add(this.data);
			this.Controls.Add(this.tCategoria);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bSalir);
			this.Controls.Add(this.bModificar);
			this.Controls.Add(this.bEliminar);
			this.Controls.Add(this.bCrear);
			this.Controls.Add(this.tNombre);
			this.Controls.Add(this.tId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenimiento De Productos";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.productionDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tFecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bSalir;
		private System.Windows.Forms.Button bModificar;
		private System.Windows.Forms.Button bEliminar;
		private System.Windows.Forms.Button bCrear;
		private System.Windows.Forms.TextBox tNombre;
		private System.Windows.Forms.TextBox tId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tCategoria;
		private System.Windows.Forms.Label label5;
		private ProductionDataSet productionDataSet;
		private System.Windows.Forms.BindingSource productBindingSource;
		private ProductionDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn safetyStockLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reorderPointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn daysToManufactureDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellStartDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView data2;
		private System.Windows.Forms.Label label6;
	}
}

