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
    public partial class ItemsChange : Form
    {
        public ItemsChange()
        {
            InitializeComponent();
            // Фиксированный размер маленького окна
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // Запуск формы окна посередине
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void ItemsChange_FormClosed(object sender, FormClosedEventArgs e)
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

        //Сохранение внесенных изменений.
        private void itemChange_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены поля ввода/вывода данных.
            if (textBox1.Text == null || textBox1.Text == "" || textBox2.Text == null || textBox2.Text == "" || textBox3.Text == null || textBox3.Text == "") // проверяем все поля - сколько надо на форме.
            {
                MessageBox.Show("Введите полные данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Изменить данные?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string query = "UPDATE items SET item_name='" + textBox1.Text + "', item_desc='" + textBox2.Text + "', item_cost='" + textBox3.Text + "' WHERE item_id=" + ClassItems.item_id + "; ";
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
                    MessageBox.Show("Данные изменены.", "Операция выполнена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ItemsChange_Load(object sender, EventArgs e)
        {
            textBox1.Text = ClassItems.item_name;
            textBox2.Text = ClassItems.item_desc;
            textBox3.Text = ClassItems.item_cost;
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
