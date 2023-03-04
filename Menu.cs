using System;
using System.Windows.Forms;

namespace Ucheb_5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            // Фиксированный размер маленького окна
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // Запуск формы окна посередине
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        //Кнопка "Выход".
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Переход на форму "Корзина".
        private void cort_btn_Click(object sender, EventArgs e)
        {
            Cort cort = new Cort(); // Обращение к форме, на которую будет совершаться переход.
            cort.Owner = this;
            this.Hide();
            cort.Show(); // Запуск окна перехода.
        }

        //Переход на форму "Товары".
        private void items_btn_Click(object sender, EventArgs e)
        {
            Items items = new Items(); // Обращение к форме, на которую будет совершаться переход.
            items.Owner = this;
            this.Hide();
            items.Show(); // Запуск окна перехода.
        }

        //Переход на форму "Администрирование".
        private void relog_Click(object sender, EventArgs e)
        {
            if (ClassAvtorizaciya.auth_role == "Администратор")
            {
                Users users = new Users(); // Обращение к форме, на которую будет совершаться переход.
                users.Owner = this;
                this.Hide();
                users.Show(); // Запуск окна перехода.
            }
            else if (ClassAvtorizaciya.auth_role == "Пользователь")
            {
                MessageBox.Show("Вам запрещен вход в данный раздел!", "Сообщение");
            }
        }

        //Переходим в окно авторизации
        private void avt_btn_Click(object sender, EventArgs e)
        {
            Avtorizaciya avtorizaciya = new Avtorizaciya(); // Обращение к форме, на которую будет совершаться переход.
            avtorizaciya.Owner = this;
            this.Hide();
            avtorizaciya.Show(); // Запуск окна перехода.
        }
    }
}
