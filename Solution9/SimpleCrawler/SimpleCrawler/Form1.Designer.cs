namespace SimpleCrawler
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.url_infor_panel = new System.Windows.Forms.Panel();
            this.url_dataGridView = new System.Windows.Forms.DataGridView();
            this.url_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Start_button = new System.Windows.Forms.Button();
            this.URL_textBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url_infor_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.url_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.url_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // url_infor_panel
            // 
            this.url_infor_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url_infor_panel.Controls.Add(this.url_dataGridView);
            this.url_infor_panel.Location = new System.Drawing.Point(32, 92);
            this.url_infor_panel.Name = "url_infor_panel";
            this.url_infor_panel.Size = new System.Drawing.Size(1017, 608);
            this.url_infor_panel.TabIndex = 4;
            // 
            // url_dataGridView
            // 
            this.url_dataGridView.AutoGenerateColumns = false;
            this.url_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.url_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.url_dataGridView.DataSource = this.url_bindingSource;
            this.url_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.url_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.url_dataGridView.Name = "url_dataGridView";
            this.url_dataGridView.RowHeadersWidth = 51;
            this.url_dataGridView.RowTemplate.Height = 27;
            this.url_dataGridView.Size = new System.Drawing.Size(1017, 608);
            this.url_dataGridView.TabIndex = 0;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(500, 12);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(70, 58);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // URL_textBox
            // 
            this.URL_textBox.Location = new System.Drawing.Point(35, 27);
            this.URL_textBox.Name = "URL_textBox";
            this.URL_textBox.Size = new System.Drawing.Size(443, 25);
            this.URL_textBox.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "index";
            this.Column1.HeaderText = "Index";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "url";
            this.Column2.HeaderText = "URL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "status";
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 721);
            this.Controls.Add(this.url_infor_panel);
            this.Controls.Add(this.URL_textBox);
            this.Controls.Add(this.Start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.url_infor_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.url_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.url_bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource url_bindingSource;
        private System.Windows.Forms.Panel url_infor_panel;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.TextBox URL_textBox;
        private System.Windows.Forms.DataGridView url_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

