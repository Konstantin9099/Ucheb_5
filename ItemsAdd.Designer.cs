
namespace Ucheb_5
{
    partial class ItemsAdd
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemAdd_btn = new System.Windows.Forms.Button();
            this.backItem_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(608, 35);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 24);
            this.textBox3.TabIndex = 19;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(608, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Стоимость";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(17, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(758, 209);
            this.textBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Описание товара";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(17, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 24);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование товара";
            // 
            // itemAdd_btn
            // 
            this.itemAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemAdd_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.itemAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.itemAdd_btn.ForeColor = System.Drawing.Color.Black;
            this.itemAdd_btn.Location = new System.Drawing.Point(575, 299);
            this.itemAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.itemAdd_btn.Name = "itemAdd_btn";
            this.itemAdd_btn.Size = new System.Drawing.Size(200, 50);
            this.itemAdd_btn.TabIndex = 20;
            this.itemAdd_btn.Text = "Добавить";
            this.itemAdd_btn.UseVisualStyleBackColor = false;
            this.itemAdd_btn.Click += new System.EventHandler(this.itemAdd_btn_Click);
            // 
            // backItem_btn
            // 
            this.backItem_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backItem_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.backItem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.backItem_btn.ForeColor = System.Drawing.Color.Black;
            this.backItem_btn.Location = new System.Drawing.Point(367, 299);
            this.backItem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.backItem_btn.Name = "backItem_btn";
            this.backItem_btn.Size = new System.Drawing.Size(200, 50);
            this.backItem_btn.TabIndex = 21;
            this.backItem_btn.Text = "Назад";
            this.backItem_btn.UseVisualStyleBackColor = false;
            this.backItem_btn.Click += new System.EventHandler(this.backItem_btn_Click);
            // 
            // ItemsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 363);
            this.Controls.Add(this.backItem_btn);
            this.Controls.Add(this.itemAdd_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ItemsAdd";
            this.Text = "Добавление товара";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemsAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button itemAdd_btn;
        private System.Windows.Forms.Button backItem_btn;
    }
}