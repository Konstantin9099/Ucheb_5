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
    public partial class Cort : Form
    {
        public Cort()
        {
            InitializeComponent();
            GetInfo();
            // Фиксированный размер маленького окна
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // Запуск формы окна посередине
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            if (ClassAvtorizaciya.auth_role == "Администратор")
            {
 
            }
            else if (ClassAvtorizaciya.auth_role == "Пользователь")
            {

            }
        }

        public void GetInfo()
        {
            string query = "select order_id as 'Код заказа', item_name as 'Наименование товара', item_desc as 'Описание товара', item_cost as 'Стоимость', amount as 'Количество' from cort, items where cort.item_id=items.item_id;";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                this.dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[0].Width = 100;
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].Width = 370;
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[3].Width = 150;
                this.dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[4].Width = 150;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        public void Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Переход в "Меню".
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); // Обращение к форме, на которую будет совершаться переход.
            menu.Owner = this;
            this.Hide();
            menu.Show(); // Запуск окна перехода.
        }

        private void Cort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Items_btn_Click(object sender, EventArgs e)
        {
            Items items = new Items(); // Обращение к форме, на которую будет совершаться переход.
            items.Owner = this;
            this.Hide();
            items.Show(); // Запуск окна перехода.
        }

        //Заполнение полей формы данными из строки , выбранной в таблице.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }

        //Изменение количества товара в корзине.
        private void amountChange_btn_Click(object sender, EventArgs e)
        {
            if (ClassAvtorizaciya.auth_role == "Администратор")
            {
                MessageBox.Show("Администратор не может изменять количество товара!", "Сообщение");
            }
            else if (ClassAvtorizaciya.auth_role == "Пользователь")
            {
                // Проверяем, чтобы были заполнены поля ввода/вывода данных.
                if (textBox1.Text == null || textBox1.Text == "" || textBox2.Text == null || textBox2.Text == "" || textBox3.Text == null || textBox3.Text == "")
                {
                    MessageBox.Show("Выберете товар, количество которого надо изменить - нажмите на нужную строку таблицы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult res = MessageBox.Show("Изменить количество товара?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        string query = "UPDATE cort SET amount='" + (int)numericUpDown1.Value + "' WHERE order_id=" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "; ";
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
                        GetInfo();
                        MessageBox.Show("Количество товара изменено.", "Операция выполнена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        //Удаление заказа.
        private void deleteChange_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (textBox1.Text == null || textBox1.Text == "" || textBox2.Text == null || textBox2.Text == "" || textBox3.Text == null || textBox3.Text == "")
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
                DialogResult res = MessageBox.Show("Удалить заказ товара?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string valueCell = dataGridView1.CurrentCell.Value != null ? dataGridView1.CurrentCell.Value.ToString() : "";
                    string del = "DELETE FROM cort WHERE order_id = " + valueCell + ";";
                    Action(del);
                    GetInfo();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    numericUpDown1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Удаление записи отменено!");
                }
            }
        }
    }
}
