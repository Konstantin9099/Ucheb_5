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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            // Фиксированный размер маленького окна
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // Запуск формы окна посередине
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Get_Info();
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

        public void Get_Info()
        {
            string query = "SELECT auth_id as 'Код пользователя', auth_log as 'Логин', auth_pwd as 'Пароль', role_name as 'Статус' FROM auth, rols where auth.auth_role=rols.role_id order by auth_id; ";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                user_list.DataSource = dt;
                user_list.ClearSelection();
                sda.Fill(dt);
                user_list.DataSource = dt;
                user_list.ClearSelection();
                this.user_list.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.user_list.Columns[0].Width = 95;
                this.user_list.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.user_list.Columns[1].Width = 120;
                this.user_list.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.user_list.Columns[2].Width = 120;
                this.user_list.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.user_list.Columns[3].Width = 125;
                user_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Кнопка "Добавить".
        private void add_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (login_box.Text == null || login_box.Text == "" || pass_box.Text == null || pass_box.Text == "" || rols_box.Text.Equals(""))
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
                        string query = "INSERT INTO auth (auth_log, auth_pwd, auth_role) VALUES ('" + login_box.Text + "', '" + pass_box.Text + "', (select role_id from rols where role_name='" + rols_box.Text + "')); ";
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
                        Get_Info();
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                    }
                }
            }
        }

        //Выводим данные из строки, выбраной в таблице, в текстовые поля формы.
        int id = 0;
        private void user_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(user_list.CurrentRow.Cells[0].Value.ToString());
            login_box.Text = user_list.CurrentRow.Cells[1].Value.ToString();
            pass_box.Text = user_list.CurrentRow.Cells[2].Value.ToString();
            rols_box.Text = user_list.CurrentRow.Cells[3].Value.ToString();
        }

        //Кнопка "Изменить".
        private void chng_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены поля ввода/вывода данных.
            if (login_box.Text == null || login_box.Text == "" || pass_box.Text == null || pass_box.Text == "" || rols_box.Text.Equals(""))
            {
                MessageBox.Show("Введите полные данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Изменить данные?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string query = "UPDATE auth SET auth_log='" + login_box.Text + "', auth_pwd='" + pass_box.Text + "', auth_role=(select role_id from rols where role_name='" + rols_box.Text + "') WHERE auth_id=" + id + "; ";
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
                    Get_Info();
                    MessageBox.Show("Данные изменены.", "Операция выполнена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Кнопка "Удалить".
        private void dlt_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (login_box.Text == null || login_box.Text == "" || pass_box.Text == null || pass_box.Text == "" || rols_box.Text.Equals(""))
            {
                MessageBox.Show(
                    "Выберете в таблице данных строку, подлежащую удалению.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Удалить данные?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string del = "DELETE FROM auth WHERE auth_id = " + id + ";";
                    Action(del);
                    Get_Info();
                    login_box.Clear();
                    pass_box.Clear();
                }
                else
                {
                    MessageBox.Show("Удаление записи отменено!");
                }
            }
        }

        //Переход на форму "Меню".
        private void men_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); // Обращение к форме, на которую будет совершаться переход.
            menu.Owner = this;
            this.Hide();
            menu.Show(); // Запуск окна перехода.
        }
    }
}
