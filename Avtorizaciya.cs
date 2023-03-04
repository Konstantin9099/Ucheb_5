using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ucheb_5
{
    public partial class Avtorizaciya : Form
    {
        public Avtorizaciya()
        {
            InitializeComponent();
            // Фиксированный размер маленького окна
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // Запуск формы окна посередине
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
        // Кнопка "Вход".
        private void button1_Click(object sender, EventArgs e)
        {
            if (log_box.Text == "" && pass_box.Text == "")
            {
                MessageBox.Show(
                    "Не введены логин и/или пароль!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Запрос к таблице Auth.
                string query = "select auth_id, role_name from auth, rols where auth_log ='" + log_box.Text + "' and auth_pwd ='" + pass_box.Text + "' and auth.auth_role = rols.role_id;";
                MySqlConnection conn = DBUtils.GetDbConnection();
                // Объект для выполнения SQL-запроса.
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            ClassAvtorizaciya.auth_id = rd.GetString(0);
                            ClassAvtorizaciya.auth_role = rd.GetString(1);
                            if (ClassAvtorizaciya.auth_id != null)
                            {
                                Menu men = new Menu();
                                men.Owner = this;
                                men.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        log_box.Clear();
                        pass_box.Clear();
                        MessageBox.Show("Введенные данные неверны!", "Ошибка авторизации");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }

        //Кнока "Выход".
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Avtorizaciya_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    static class ClassAvtorizaciya
    {
        public static string auth_id { get; set; } // ClassAvtorizaciya.auth_id
        public static string auth_role { get; set; } // ClassAvtorizaciya.auth_role
    }
}
