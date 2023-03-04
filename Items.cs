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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            Get_Info();
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public void Get_Info()
        {
            string query = "select  item_id as 'Код товара', item_name as 'Наименование товара', item_desc as 'Описание товара', item_cost as 'Стоимость' from items order by item_name;";
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
                this.dataGridView1.Columns[0].Width = 90;
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].Width = 320;
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[3].Width = 100;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        //Функция, позволяющая отправить команду на сервер БД для оптимизации кода.
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

        //Создаем столбцы с кнопками - "Удалить" и "Изменить".
        public void Cort()
        {
            DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn();
            DeleteButton.Width = 110;
            DeleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DeleteButton.Visible = true;
            DeleteButton.ToolTipText = "Удалить товар";
            DeleteButton.Text = "Удалить";
            DeleteButton.Name = "DeleteButtonColumn";
            DeleteButton.HeaderText = "Удаление";
            DeleteButton.UseColumnTextForButtonValue = true;
            if (dataGridView1.Columns["Удаление"] == null)
            {
                dataGridView1.Columns.Insert(4, DeleteButton);
            }

            DataGridViewButtonColumn ChngeButton = new DataGridViewButtonColumn();
            ChngeButton.Width = 110;
            ChngeButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChngeButton.Visible = true;
            ChngeButton.ToolTipText = "Изменить данные товара";
            ChngeButton.Text = "Изменить";
            ChngeButton.Name = "ChngeButtonColumn";
            ChngeButton.HeaderText = "Редактирование";
            ChngeButton.UseColumnTextForButtonValue = true;

            if (dataGridView1.Columns["Редактирование"] == null)
            {
                dataGridView1.Columns.Insert(5, ChngeButton);
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {
            Cort();
        }

        //Переход в "Корзину".
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Cort cort = new Cort(); // Обращение к форме, на которую будет совершаться переход.
            cort.Owner = this;
            this.Hide();
            cort.Show(); // Запуск окна перехода.
        }

        //Переход в "Меню".
        private void menu_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); // Обращение к форме, на которую будет совершаться переход.
            menu.Owner = this;
            this.Hide();
            menu.Show(); // Запуск окна перехода.
        }

        //Кнопка "Добавить товар".
        private void itemAdd_btn_Click(object sender, EventArgs e)
        {
            if (ClassAvtorizaciya.auth_role == "Администратор")
            {
                ItemsAdd itemsAdd = new ItemsAdd(); // Обращение к форме, на которую будет совершаться переход.
                itemsAdd.Owner = this;
                this.Hide();
                itemsAdd.Show(); // Запуск окна перехода.
            }
            else if (ClassAvtorizaciya.auth_role == "Пользователь")
            {
                MessageBox.Show("Вы не имеете полномочий добавлять товар!", "Сообщение");
            }
        }

        //Получаем данный из строки, выбранной в таблице.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassItems.item_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ClassItems.item_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ClassItems.item_desc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ClassItems.item_cost = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            item_name_box.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            item_desc_box.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            item_cost_box.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        //Добавление товара в корзину.
        private void cortAdd_btn_Click(object sender, EventArgs e)
        {
            if (ClassAvtorizaciya.auth_role == "Администратор")
            {
                MessageBox.Show("Администратор не может добавлять товар в корзину!", "Сообщение");
            }
            else if (ClassAvtorizaciya.auth_role == "Пользователь")
            {
                // Проверяем, чтобы были заполнены все поля.
                if (item_name_box.Text == null || item_name_box.Text == "" || item_desc_box.Text == null || item_desc_box.Text == "" || item_cost_box.Text == null || item_cost_box.Text == "")
                {
                    MessageBox.Show("Введите полные данные.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if ((int)numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Введите количество товара.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    int amount = (int)numericUpDown1.Value;
                    DialogResult res = MessageBox.Show($"Положить в корзину  {item_name_box.Text} по цене {item_cost_box.Text} руб. в количестве {amount} шт.?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            string query = "INSERT INTO cort (item_id, amount) VALUES ('" + ClassItems.item_id + "', '" + amount + "'); ";
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
                            item_name_box.Clear();
                            item_desc_box.Clear();
                            item_cost_box.Clear();
                            numericUpDown1.Value = 0;
                            MessageBox.Show("Товар успешно добавлен!");
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                    }
                }
            }
        }

        //Удаляем товар или изменяем его данные при помощи кнопок в таблице dataGridView.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (ClassAvtorizaciya.auth_role == "Администратор")
                {
                    DialogResult res = MessageBox.Show("Удалить данные?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            // Проверяем - существуют ли в системе данные связанные с товаром.
                            string count = "SELECT COUNT(*) FROM cort WHERE cort.item_id=" + ClassItems.item_id + ";";
                            MySqlConnection conn = DBUtils.GetDbConnection();
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(count, conn);
                            int result = Int32.Parse(command.ExecuteScalar().ToString());
                            conn.Close();

                            if (result == 0)
                            {
                                string del = "DELETE FROM items WHERE item_id = " + ClassItems.item_id + ";";
                                Action(del);
                                this.Controls.Clear();
                                this.InitializeComponent();
                                Get_Info();
                                Cort();
                            }
                            if (result == 1)
                            {
                                MessageBox.Show("Удаление невозможно, так есть зависимые данные.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Удаление записи отменено!");
                    }
                }
                else if (ClassAvtorizaciya.auth_role == "Пользователь")
                {
                    MessageBox.Show("Вы не имеете полномочий удалять товар!", "Сообщение");
                }
            }

            if (e.ColumnIndex == 5)
            {
                if (ClassAvtorizaciya.auth_role == "Администратор")
                {
                    DialogResult res = MessageBox.Show("Изменить данные товара?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        ItemsChange itemsChange = new ItemsChange();
                        itemsChange.Owner = this;
                        this.Hide();
                        itemsChange.Show();
                    }
                }
                else if (ClassAvtorizaciya.auth_role == "Пользователь")
                {
                    MessageBox.Show("Вы не имеете полномочий изменять данные товара!", "Сообщение");
                }
            }
        }

        private void Items_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    static class ClassItems
    {
        public static string item_id { get; set; } // ClassItems.item_id
        public static string item_name { get; set; } // ClassItems.item_name
        public static string item_desc { get; set; } // ClassItems.item_desc
        public static string item_cost { get; set; } // ClassItems.item_cost
    }
}
