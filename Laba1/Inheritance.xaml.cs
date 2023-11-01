using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laba1
{
    public partial class Inheritance : Window
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Перевірка коректності введення кількості сторінок
            if (!string.IsNullOrEmpty(Pages.Text) && int.TryParse(Pages.Text, out int count))
            {
                // Перевірка чекбоксу на наявність обкладинки
                bool isCover = Cover.IsChecked.HasValue && Cover.IsChecked.Value;

                // Створення об'єкту класу Загальна та розрахунок вартості
                General copybook = new General("Зошит з обкладинкою", count, isCover);

                // Виведення вартості зошита в елемент Label
                Result.Content = $"Вартість зошита: {copybook.Cost()} грн";
            }
            else
            {
                // Виведення повідомлення про помилку в елемент Label
                Result.Content = "Введіть коректну кількість сторінок!";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}