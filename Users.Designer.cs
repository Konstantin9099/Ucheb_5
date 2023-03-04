
namespace Ucheb_5
{
    partial class Users
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
            this.rols_box = new System.Windows.Forms.ComboBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.user_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.men_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_list)).BeginInit();
            this.SuspendLayout();
            // 
            // rols_box
            // 
            this.rols_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rols_box.FormattingEnabled = true;
            this.rols_box.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.rols_box.Location = new System.Drawing.Point(423, 37);
            this.rols_box.Margin = new System.Windows.Forms.Padding(4);
            this.rols_box.Name = "rols_box";
            this.rols_box.Size = new System.Drawing.Size(200, 26);
            this.rols_box.TabIndex = 9;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pass_box.Location = new System.Drawing.Point(219, 38);
            this.pass_box.Margin = new System.Windows.Forms.Padding(4);
            this.pass_box.MaxLength = 25;
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(200, 24);
            this.pass_box.TabIndex = 8;
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.login_box.Location = new System.Drawing.Point(15, 38);
            this.login_box.Margin = new System.Windows.Forms.Padding(4);
            this.login_box.MaxLength = 25;
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(200, 24);
            this.login_box.TabIndex = 7;
            // 
            // user_list
            // 
            this.user_list.AllowUserToAddRows = false;
            this.user_list.AllowUserToDeleteRows = false;
            this.user_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_list.Location = new System.Drawing.Point(14, 129);
            this.user_list.Margin = new System.Windows.Forms.Padding(4);
            this.user_list.Name = "user_list";
            this.user_list.RowHeadersVisible = false;
            this.user_list.RowHeadersWidth = 51;
            this.user_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_list.Size = new System.Drawing.Size(609, 526);
            this.user_list.TabIndex = 6;
            this.user_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_list_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(216, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(420, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Location = new System.Drawing.Point(16, 71);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(145, 50);
            this.add_btn.TabIndex = 13;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chng_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.chng_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chng_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.chng_btn.ForeColor = System.Drawing.Color.Black;
            this.chng_btn.Location = new System.Drawing.Point(170, 71);
            this.chng_btn.Margin = new System.Windows.Forms.Padding(4);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(145, 50);
            this.chng_btn.TabIndex = 14;
            this.chng_btn.Text = "Изменить";
            this.chng_btn.UseVisualStyleBackColor = false;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // dlt_btn
            // 
            this.dlt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dlt_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.dlt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dlt_btn.ForeColor = System.Drawing.Color.Black;
            this.dlt_btn.Location = new System.Drawing.Point(324, 71);
            this.dlt_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(145, 50);
            this.dlt_btn.TabIndex = 15;
            this.dlt_btn.Text = "Удалить";
            this.dlt_btn.UseVisualStyleBackColor = false;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // men_btn
            // 
            this.men_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.men_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.men_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.men_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.men_btn.ForeColor = System.Drawing.Color.Black;
            this.men_btn.Location = new System.Drawing.Point(478, 71);
            this.men_btn.Margin = new System.Windows.Forms.Padding(4);
            this.men_btn.Name = "men_btn";
            this.men_btn.Size = new System.Drawing.Size(145, 50);
            this.men_btn.TabIndex = 16;
            this.men_btn.Text = "Меню";
            this.men_btn.UseVisualStyleBackColor = false;
            this.men_btn.Click += new System.EventHandler(this.men_btn_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 668);
            this.Controls.Add(this.men_btn);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rols_box);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.user_list);
            this.Name = "Users";
            this.Text = "Администрирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.user_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rols_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.DataGridView user_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.Button dlt_btn;
        private System.Windows.Forms.Button men_btn;
    }
}