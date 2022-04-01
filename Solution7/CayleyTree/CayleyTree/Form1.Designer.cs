using System;

namespace CayleyTree
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.per2_box = new System.Windows.Forms.TextBox();
            this.per1_label = new System.Windows.Forms.Label();
            this.per2_label = new System.Windows.Forms.Label();
            this.per1_box = new System.Windows.Forms.TextBox();
            this.th1_box = new System.Windows.Forms.TextBox();
            this.length_label = new System.Windows.Forms.Label();
            this.th1_label = new System.Windows.Forms.Label();
            this.length_box = new System.Windows.Forms.TextBox();
            this.th2_box = new System.Windows.Forms.TextBox();
            this.depth_label = new System.Windows.Forms.Label();
            this.th2_label = new System.Windows.Forms.Label();
            this.depth_box = new System.Windows.Forms.TextBox();
            this.draw_button = new System.Windows.Forms.Button();
            this.color_box = new System.Windows.Forms.ComboBox();
            this.color_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 558);
            this.panel2.TabIndex = 18;
            // 
            // per2_box
            // 
            this.per2_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.per2_box.Location = new System.Drawing.Point(66, 230);
            this.per2_box.Name = "per2_box";
            this.per2_box.Size = new System.Drawing.Size(100, 25);
            this.per2_box.TabIndex = 7;
            this.per2_box.TextChanged += new System.EventHandler(this.per2_box_TextChanged);
            // 
            // per1_label
            // 
            this.per1_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.per1_label.AutoSize = true;
            this.per1_label.Location = new System.Drawing.Point(5, 194);
            this.per1_label.Name = "per1_label";
            this.per1_label.Size = new System.Drawing.Size(39, 15);
            this.per1_label.TabIndex = 6;
            this.per1_label.Text = "per1";
            this.per1_label.Click += new System.EventHandler(this.per1_label_Click);
            // 
            // per2_label
            // 
            this.per2_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.per2_label.AutoSize = true;
            this.per2_label.Location = new System.Drawing.Point(5, 240);
            this.per2_label.Name = "per2_label";
            this.per2_label.Size = new System.Drawing.Size(39, 15);
            this.per2_label.TabIndex = 8;
            this.per2_label.Text = "per2";
            this.per2_label.Click += new System.EventHandler(this.per2_label_Click);
            // 
            // per1_box
            // 
            this.per1_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.per1_box.Location = new System.Drawing.Point(66, 184);
            this.per1_box.Name = "per1_box";
            this.per1_box.Size = new System.Drawing.Size(100, 25);
            this.per1_box.TabIndex = 5;
            this.per1_box.TextChanged += new System.EventHandler(this.per1_box_TextChanged);
            // 
            // th1_box
            // 
            this.th1_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.th1_box.Location = new System.Drawing.Point(66, 277);
            this.th1_box.Name = "th1_box";
            this.th1_box.Size = new System.Drawing.Size(100, 25);
            this.th1_box.TabIndex = 9;
            this.th1_box.TextChanged += new System.EventHandler(this.th1_box_TextChanged);
            // 
            // length_label
            // 
            this.length_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(3, 149);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(55, 15);
            this.length_label.TabIndex = 4;
            this.length_label.Text = "Length";
            this.length_label.Click += new System.EventHandler(this.length_label_Click);
            // 
            // th1_label
            // 
            this.th1_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.th1_label.AutoSize = true;
            this.th1_label.Location = new System.Drawing.Point(5, 287);
            this.th1_label.Name = "th1_label";
            this.th1_label.Size = new System.Drawing.Size(31, 15);
            this.th1_label.TabIndex = 10;
            this.th1_label.Text = "th1";
            this.th1_label.Click += new System.EventHandler(this.th1_label_Click);
            // 
            // length_box
            // 
            this.length_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.length_box.Location = new System.Drawing.Point(66, 139);
            this.length_box.Name = "length_box";
            this.length_box.Size = new System.Drawing.Size(100, 25);
            this.length_box.TabIndex = 3;
            this.length_box.TextChanged += new System.EventHandler(this.length_box_TextChanged);
            // 
            // th2_box
            // 
            this.th2_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.th2_box.Location = new System.Drawing.Point(66, 324);
            this.th2_box.Name = "th2_box";
            this.th2_box.Size = new System.Drawing.Size(100, 25);
            this.th2_box.TabIndex = 11;
            this.th2_box.TextChanged += new System.EventHandler(this.th2_box_TextChanged);
            // 
            // depth_label
            // 
            this.depth_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depth_label.AutoSize = true;
            this.depth_label.Location = new System.Drawing.Point(5, 105);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(47, 15);
            this.depth_label.TabIndex = 2;
            this.depth_label.Text = "Depth";
            this.depth_label.Click += new System.EventHandler(this.depth_label_Click);
            // 
            // th2_label
            // 
            this.th2_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.th2_label.AutoSize = true;
            this.th2_label.Location = new System.Drawing.Point(5, 334);
            this.th2_label.Name = "th2_label";
            this.th2_label.Size = new System.Drawing.Size(31, 15);
            this.th2_label.TabIndex = 12;
            this.th2_label.Text = "th2";
            this.th2_label.Click += new System.EventHandler(this.th2_label_Click);
            // 
            // depth_box
            // 
            this.depth_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depth_box.Location = new System.Drawing.Point(66, 95);
            this.depth_box.Name = "depth_box";
            this.depth_box.Size = new System.Drawing.Size(100, 25);
            this.depth_box.TabIndex = 1;
            this.depth_box.TextChanged += new System.EventHandler(this.depth_box_TextChanged);
            // 
            // draw_button
            // 
            this.draw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.draw_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.draw_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.draw_button.Location = new System.Drawing.Point(87, 23);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(79, 51);
            this.draw_button.TabIndex = 0;
            this.draw_button.Text = "draw\r\n";
            this.draw_button.UseVisualStyleBackColor = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // color_box
            // 
            this.color_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color_box.FormattingEnabled = true;
            this.color_box.Items.AddRange(new object[] {
            "蓝色",
            "黑色",
            "红色",
            "绿色"});
            this.color_box.Location = new System.Drawing.Point(58, 374);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(121, 23);
            this.color_box.TabIndex = 15;
            this.color_box.SelectedIndexChanged += new System.EventHandler(this.color_box_SelectedIndexChanged);
            // 
            // color_label
            // 
            this.color_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(5, 382);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(47, 15);
            this.color_label.TabIndex = 14;
            this.color_label.Text = "color";
            this.color_label.Click += new System.EventHandler(this.color_label_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.color_label);
            this.panel1.Controls.Add(this.color_box);
            this.panel1.Controls.Add(this.draw_button);
            this.panel1.Controls.Add(this.depth_box);
            this.panel1.Controls.Add(this.th2_label);
            this.panel1.Controls.Add(this.depth_label);
            this.panel1.Controls.Add(this.th2_box);
            this.panel1.Controls.Add(this.length_box);
            this.panel1.Controls.Add(this.th1_label);
            this.panel1.Controls.Add(this.length_label);
            this.panel1.Controls.Add(this.th1_box);
            this.panel1.Controls.Add(this.per1_box);
            this.panel1.Controls.Add(this.per2_label);
            this.panel1.Controls.Add(this.per1_label);
            this.panel1.Controls.Add(this.per2_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(605, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 558);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.draw_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox per2_box;
        private System.Windows.Forms.Label per1_label;
        private System.Windows.Forms.Label per2_label;
        private System.Windows.Forms.TextBox per1_box;
        public System.Windows.Forms.TextBox th1_box;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.Label th1_label;
        private System.Windows.Forms.TextBox length_box;
        private System.Windows.Forms.TextBox th2_box;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.Label th2_label;
        private System.Windows.Forms.TextBox depth_box;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.ComboBox color_box;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Panel panel1;
    }
}

