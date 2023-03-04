using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ucheb_5
{
    public partial class ItemsAdd : Form
    {
        public ItemsAdd()
        {
            InitializeComponent();
            // Фиксированный размер маленького окна
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // Запуск формы окна посередине
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void ItemsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Функция, позволяющая отправить команду на сервер БД для оптимизации кода.
        public void Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void itemAdd_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (textBox1.Text == null || textBox1.Text == "" || textBox2.Text == null || textBox2.Text == "" || textBox3.Text == null || textBox3.Text == "")
            {
                MessageBox.Show("Введите полные данные.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Добавить данные?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        string query = "INSERT INTO items (item_name, item_desc, item_cost) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "'); ";
                        MySqlConnection conn = DBUtils.GetDbConnection();
                        MySqlCommand cmDB = new MySqlCommand(query, conn);
                        try
                        {
                            conn.Open();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                        Action(query);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        MessageBox.Show("Товар успешно добавлен!");
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                    }
                }
            }
        }

        //Переход на форму "Товары".
        private void backItem_btn_Click(object sender, EventArgs e)
        {
            Items items = new Items(); // Обращение к форме, на которую будет совершаться переход.
            items.Owner = this;
            this.Hide();
            items.Show(); // Запуск окна перехода.
        }

        //Запрет на ввод букв, символов и запятой.
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(".")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
