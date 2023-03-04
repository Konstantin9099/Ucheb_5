
namespace Ucheb_5
{
    partial class Items
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item_name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.item_desc_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.item_cost_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cortAdd_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.cort_btn = new System.Windows.Forms.Button();
            this.itemAdd_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item_name_box
            // 
            this.item_name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_name_box.Location = new System.Drawing.Point(13, 33);
            this.item_name_box.Margin = new System.Windows.Forms.Padding(4);
            this.item_name_box.MaxLength = 50;
            this.item_name_box.Name = "item_name_box";
            this.item_name_box.ReadOnly = true;
            this.item_name_box.Size = new System.Drawing.Size(464, 24);
            this.item_name_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование товара";
            // 
            // item_desc_box
            // 
            this.item_desc_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_desc_box.Location = new System.Drawing.Point(13, 82);
            this.item_desc_box.Margin = new System.Windows.Forms.Padding(4);
            this.item_desc_box.Multiline = true;
            this.item_desc_box.Name = "item_desc_box";
            this.item_desc_box.ReadOnly = true;
            this.item_desc_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.item_desc_box.Size = new System.Drawing.Size(736, 180);
            this.item_desc_box.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Описание товара";
            // 
            // item_cost_box
            // 
            this.item_cost_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_cost_box.Location = new System.Drawing.Point(485, 33);
            this.item_cost_box.Margin = new System.Windows.Forms.Padding(4);
            this.item_cost_box.MaxLength = 20;
            this.item_cost_box.Name = "item_cost_box";
            this.item_cost_box.ReadOnly = true;
            this.item_cost_box.Size = new System.Drawing.Size(146, 24);
            this.item_cost_box.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(485, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(638, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numericUpDown1.Location = new System.Drawing.Point(638, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 24);
            this.numericUpDown1.TabIndex = 13;
            // 
            // cortAdd_btn
            // 
            this.cortAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cortAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cortAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cortAdd_btn.Location = new System.Drawing.Point(757, 19);
            this.cortAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cortAdd_btn.Name = "cortAdd_btn";
            this.cortAdd_btn.Size = new System.Drawing.Size(250, 50);
            this.cortAdd_btn.TabIndex = 15;
            this.cortAdd_btn.Text = "Положить в корзину";
            this.cortAdd_btn.UseVisualStyleBackColor = false;
            this.cortAdd_btn.Click += new System.EventHandler(this.cortAdd_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_btn.Location = new System.Drawing.Point(757, 147);
            this.menu_btn.Margin = new System.Windows.Forms.Padding(4);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(250, 50);
            this.menu_btn.TabIndex = 16;
            this.menu_btn.Text = "Меню";
            this.menu_btn.UseVisualStyleBackColor = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // cort_btn
            // 
            this.cort_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cort_btn.Location = new System.Drawing.Point(757, 83);
            this.cort_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cort_btn.Name = "cort_btn";
            this.cort_btn.Size = new System.Drawing.Size(250, 50);
            this.cort_btn.TabIndex = 28;
            this.cort_btn.Text = "Корзина";
            this.cort_btn.UseVisualStyleBackColor = false;
            this.cort_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // itemAdd_btn
            // 
            this.itemAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemAdd_btn.Location = new System.Drawing.Point(757, 211);
            this.itemAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.itemAdd_btn.Name = "itemAdd_btn";
            this.itemAdd_btn.Size = new System.Drawing.Size(250, 50);
            this.itemAdd_btn.TabIndex = 29;
            this.itemAdd_btn.Text = "Добавить товар";
            this.itemAdd_btn.UseVisualStyleBackColor = false;
            this.itemAdd_btn.Click += new System.EventHandler(this.itemAdd_btn_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 734);
            this.Controls.Add(this.itemAdd_btn);
            this.Controls.Add(this.cort_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.cortAdd_btn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.item_cost_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item_desc_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_name_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Items";
            this.Text = "Товары";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Items_FormClosed);
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox item_name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_desc_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox item_cost_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button cortAdd_btn;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button cort_btn;
        private System.Windows.Forms.Button itemAdd_btn;
    }
}