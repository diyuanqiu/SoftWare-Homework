namespace OrderSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Implement_panel = new System.Windows.Forms.Panel();
            this.Exportbutton = new System.Windows.Forms.Button();
            this.Importbutton = new System.Windows.Forms.Button();
            this.QuerytextBox = new System.Windows.Forms.TextBox();
            this.QuerybyPricebutton = new System.Windows.Forms.Button();
            this.QuerybyGoodbutton = new System.Windows.Forms.Button();
            this.QuerybyClientbutton = new System.Windows.Forms.Button();
            this.QuerybyNobutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.OrderdataGridView = new System.Windows.Forms.DataGridView();
            this.GooddataGridView = new System.Windows.Forms.DataGridView();
            this.orderdedGoodSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderedGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Implement_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GooddataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Implement_panel
            // 
            this.Implement_panel.Controls.Add(this.Exportbutton);
            this.Implement_panel.Controls.Add(this.Importbutton);
            this.Implement_panel.Controls.Add(this.QuerytextBox);
            this.Implement_panel.Controls.Add(this.QuerybyPricebutton);
            this.Implement_panel.Controls.Add(this.QuerybyGoodbutton);
            this.Implement_panel.Controls.Add(this.QuerybyClientbutton);
            this.Implement_panel.Controls.Add(this.QuerybyNobutton);
            this.Implement_panel.Controls.Add(this.Updatebutton);
            this.Implement_panel.Controls.Add(this.Removebutton);
            this.Implement_panel.Controls.Add(this.Addbutton);
            this.Implement_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Implement_panel.Location = new System.Drawing.Point(581, 0);
            this.Implement_panel.Name = "Implement_panel";
            this.Implement_panel.Size = new System.Drawing.Size(219, 450);
            this.Implement_panel.TabIndex = 0;
            // 
            // Exportbutton
            // 
            this.Exportbutton.Location = new System.Drawing.Point(61, 258);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(102, 41);
            this.Exportbutton.TabIndex = 9;
            this.Exportbutton.Text = "export";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
            // 
            // Importbutton
            // 
            this.Importbutton.Location = new System.Drawing.Point(61, 196);
            this.Importbutton.Name = "Importbutton";
            this.Importbutton.Size = new System.Drawing.Size(102, 41);
            this.Importbutton.TabIndex = 8;
            this.Importbutton.Text = "import";
            this.Importbutton.UseVisualStyleBackColor = true;
            this.Importbutton.Click += new System.EventHandler(this.Importbutton_Click);
            // 
            // QuerytextBox
            // 
            this.QuerytextBox.Location = new System.Drawing.Point(61, 319);
            this.QuerytextBox.Name = "QuerytextBox";
            this.QuerytextBox.Size = new System.Drawing.Size(100, 25);
            this.QuerytextBox.TabIndex = 7;
            // 
            // QuerybyPricebutton
            // 
            this.QuerybyPricebutton.Location = new System.Drawing.Point(123, 397);
            this.QuerybyPricebutton.Name = "QuerybyPricebutton";
            this.QuerybyPricebutton.Size = new System.Drawing.Size(75, 41);
            this.QuerybyPricebutton.TabIndex = 6;
            this.QuerybyPricebutton.Text = "Price";
            this.QuerybyPricebutton.UseVisualStyleBackColor = true;
            this.QuerybyPricebutton.Click += new System.EventHandler(this.QuerybyPricebutton_Click);
            // 
            // QuerybyGoodbutton
            // 
            this.QuerybyGoodbutton.Location = new System.Drawing.Point(31, 397);
            this.QuerybyGoodbutton.Name = "QuerybyGoodbutton";
            this.QuerybyGoodbutton.Size = new System.Drawing.Size(75, 41);
            this.QuerybyGoodbutton.TabIndex = 5;
            this.QuerybyGoodbutton.Text = "Good";
            this.QuerybyGoodbutton.UseVisualStyleBackColor = true;
            this.QuerybyGoodbutton.Click += new System.EventHandler(this.QuerybyGoodbutton_Click);
            // 
            // QuerybyClientbutton
            // 
            this.QuerybyClientbutton.Location = new System.Drawing.Point(123, 350);
            this.QuerybyClientbutton.Name = "QuerybyClientbutton";
            this.QuerybyClientbutton.Size = new System.Drawing.Size(75, 41);
            this.QuerybyClientbutton.TabIndex = 4;
            this.QuerybyClientbutton.Text = "Client";
            this.QuerybyClientbutton.UseVisualStyleBackColor = true;
            this.QuerybyClientbutton.Click += new System.EventHandler(this.QuerybyClientbutton_Click);
            // 
            // QuerybyNobutton
            // 
            this.QuerybyNobutton.Location = new System.Drawing.Point(31, 350);
            this.QuerybyNobutton.Name = "QuerybyNobutton";
            this.QuerybyNobutton.Size = new System.Drawing.Size(75, 41);
            this.QuerybyNobutton.TabIndex = 3;
            this.QuerybyNobutton.Text = "No";
            this.QuerybyNobutton.UseVisualStyleBackColor = true;
            this.QuerybyNobutton.Click += new System.EventHandler(this.QuerybyNobutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(61, 137);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(102, 41);
            this.Updatebutton.TabIndex = 2;
            this.Updatebutton.Text = "update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(61, 78);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(102, 41);
            this.Removebutton.TabIndex = 1;
            this.Removebutton.Text = "remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(61, 21);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(102, 41);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // OrderdataGridView
            // 
            this.OrderdataGridView.AutoGenerateColumns = false;
            this.OrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn});
            this.OrderdataGridView.DataSource = this.OrderbindingSource;
            this.OrderdataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderdataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderdataGridView.Name = "OrderdataGridView";
            this.OrderdataGridView.RowHeadersWidth = 51;
            this.OrderdataGridView.RowTemplate.Height = 27;
            this.OrderdataGridView.Size = new System.Drawing.Size(581, 196);
            this.OrderdataGridView.TabIndex = 1;
            // 
            // GooddataGridView
            // 
            this.GooddataGridView.AutoGenerateColumns = false;
            this.GooddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GooddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderedGoodDataGridViewTextBoxColumn,
            this.orderedNumDataGridViewTextBoxColumn,
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn,
            this.orderdedGoodSumPrice});
            this.GooddataGridView.DataSource = this.GoodbindingSource;
            this.GooddataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GooddataGridView.Location = new System.Drawing.Point(0, 196);
            this.GooddataGridView.Name = "GooddataGridView";
            this.GooddataGridView.RowHeadersWidth = 51;
            this.GooddataGridView.RowTemplate.Height = 27;
            this.GooddataGridView.Size = new System.Drawing.Size(581, 254);
            this.GooddataGridView.TabIndex = 2;
            // 
            // orderdedGoodSumPrice
            // 
            this.orderdedGoodSumPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderdedGoodSumPrice.DataPropertyName = "orderdedGoodSumPrice";
            this.orderdedGoodSumPrice.HeaderText = "SumPrice";
            this.orderdedGoodSumPrice.MinimumWidth = 6;
            this.orderdedGoodSumPrice.Name = "orderdedGoodSumPrice";
            this.orderdedGoodSumPrice.ReadOnly = true;
            // 
            // GoodbindingSource
            // 
            this.GoodbindingSource.DataMember = "orderDetails";
            this.GoodbindingSource.DataSource = this.OrderbindingSource;
            // 
            // orderedGoodDataGridViewTextBoxColumn
            // 
            this.orderedGoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderedGoodDataGridViewTextBoxColumn.DataPropertyName = "orderedGood";
            this.orderedGoodDataGridViewTextBoxColumn.HeaderText = "Good";
            this.orderedGoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderedGoodDataGridViewTextBoxColumn.Name = "orderedGoodDataGridViewTextBoxColumn";
            // 
            // orderedNumDataGridViewTextBoxColumn
            // 
            this.orderedNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderedNumDataGridViewTextBoxColumn.DataPropertyName = "orderedNum";
            this.orderedNumDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.orderedNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderedNumDataGridViewTextBoxColumn.Name = "orderedNumDataGridViewTextBoxColumn";
            // 
            // orderdedGoodSumPriceDataGridViewTextBoxColumn
            // 
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn.DataPropertyName = "orderdedGoodPrice";
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn.HeaderText = "GoodPrice";
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn.Name = "orderdedGoodSumPriceDataGridViewTextBoxColumn";
            this.orderdedGoodSumPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderbindingSource
            // 
            this.OrderbindingSource.DataSource = typeof(Order1.Order);
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "orderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "No";
            this.orderNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.orderPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderPriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GooddataGridView);
            this.Controls.Add(this.OrderdataGridView);
            this.Controls.Add(this.Implement_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Implement_panel.ResumeLayout(false);
            this.Implement_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GooddataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Implement_panel;
        private System.Windows.Forms.TextBox QuerytextBox;
        private System.Windows.Forms.Button QuerybyPricebutton;
        private System.Windows.Forms.Button QuerybyGoodbutton;
        private System.Windows.Forms.Button QuerybyClientbutton;
        private System.Windows.Forms.Button QuerybyNobutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DataGridView OrderdataGridView;
        private System.Windows.Forms.DataGridView GooddataGridView;
        public System.Windows.Forms.BindingSource OrderbindingSource;
        public System.Windows.Forms.BindingSource GoodbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdedGoodSumPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdedGoodSumPrice;
        private System.Windows.Forms.Button Exportbutton;
        private System.Windows.Forms.Button Importbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
    }
}