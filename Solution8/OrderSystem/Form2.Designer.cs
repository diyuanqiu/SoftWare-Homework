namespace OrderSystem
{
    partial class Form2
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
            this.Action_panel = new System.Windows.Forms.Panel();
            this.Orderno_label = new System.Windows.Forms.Label();
            this.Orderno_textBox = new System.Windows.Forms.TextBox();
            this.Client_label = new System.Windows.Forms.Label();
            this.Client_textBox = new System.Windows.Forms.TextBox();
            this.Good_label = new System.Windows.Forms.Label();
            this.Good_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Action_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Action_panel
            // 
            this.Action_panel.Controls.Add(this.Next_button);
            this.Action_panel.Controls.Add(this.Price_textBox);
            this.Action_panel.Controls.Add(this.Price_label);
            this.Action_panel.Controls.Add(this.Quantity_textBox);
            this.Action_panel.Controls.Add(this.Quantity_label);
            this.Action_panel.Controls.Add(this.Good_textBox);
            this.Action_panel.Controls.Add(this.Good_label);
            this.Action_panel.Controls.Add(this.Client_textBox);
            this.Action_panel.Controls.Add(this.Client_label);
            this.Action_panel.Controls.Add(this.Orderno_textBox);
            this.Action_panel.Controls.Add(this.Orderno_label);
            this.Action_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Action_panel.Location = new System.Drawing.Point(0, 0);
            this.Action_panel.Name = "Action_panel";
            this.Action_panel.Size = new System.Drawing.Size(409, 450);
            this.Action_panel.TabIndex = 0;
            // 
            // Orderno_label
            // 
            this.Orderno_label.AutoSize = true;
            this.Orderno_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Orderno_label.Location = new System.Drawing.Point(25, 44);
            this.Orderno_label.Name = "Orderno_label";
            this.Orderno_label.Size = new System.Drawing.Size(79, 20);
            this.Orderno_label.TabIndex = 0;
            this.Orderno_label.Text = "OrderNo";
            // 
            // Orderno_textBox
            // 
            this.Orderno_textBox.Location = new System.Drawing.Point(136, 45);
            this.Orderno_textBox.Name = "Orderno_textBox";
            this.Orderno_textBox.Size = new System.Drawing.Size(196, 25);
            this.Orderno_textBox.TabIndex = 1;
            // 
            // Client_label
            // 
            this.Client_label.AutoSize = true;
            this.Client_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Client_label.Location = new System.Drawing.Point(25, 103);
            this.Client_label.Name = "Client_label";
            this.Client_label.Size = new System.Drawing.Size(69, 20);
            this.Client_label.TabIndex = 2;
            this.Client_label.Text = "Client";
            // 
            // Client_textBox
            // 
            this.Client_textBox.Location = new System.Drawing.Point(136, 104);
            this.Client_textBox.Name = "Client_textBox";
            this.Client_textBox.Size = new System.Drawing.Size(196, 25);
            this.Client_textBox.TabIndex = 3;
            // 
            // Good_label
            // 
            this.Good_label.AutoSize = true;
            this.Good_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Good_label.Location = new System.Drawing.Point(25, 164);
            this.Good_label.Name = "Good_label";
            this.Good_label.Size = new System.Drawing.Size(49, 20);
            this.Good_label.TabIndex = 4;
            this.Good_label.Text = "Good";
            // 
            // Good_textBox
            // 
            this.Good_textBox.Location = new System.Drawing.Point(136, 165);
            this.Good_textBox.Name = "Good_textBox";
            this.Good_textBox.Size = new System.Drawing.Size(196, 25);
            this.Good_textBox.TabIndex = 5;
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Quantity_label.Location = new System.Drawing.Point(25, 222);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(89, 20);
            this.Quantity_label.TabIndex = 6;
            this.Quantity_label.Text = "Quantity";
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(136, 223);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(196, 25);
            this.Quantity_textBox.TabIndex = 7;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Price_label.Location = new System.Drawing.Point(25, 279);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(59, 20);
            this.Price_label.TabIndex = 8;
            this.Price_label.Text = "Price";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(136, 280);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(196, 25);
            this.Price_textBox.TabIndex = 9;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(120, 348);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(103, 57);
            this.Next_button.TabIndex = 10;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Action_panel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Action_panel.ResumeLayout(false);
            this.Action_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Action_panel;
        private System.Windows.Forms.TextBox Client_textBox;
        private System.Windows.Forms.Label Client_label;
        private System.Windows.Forms.TextBox Orderno_textBox;
        private System.Windows.Forms.Label Orderno_label;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.TextBox Good_textBox;
        private System.Windows.Forms.Label Good_label;
        private System.Windows.Forms.Button Next_button;
    }
}