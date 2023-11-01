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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Зчитування даних з TextBox`a
            double x1, x2, y1, y2, z1, z2;
            x1 = Convert.ToDouble(this.x1.Text);
            y1 = Convert.ToDouble(this.y1.Text);
            z1 = Convert.ToDouble(this.z1.Text);
            x2 = Convert.ToDouble(this.x2.Text);
            y2 = Convert.ToDouble(this.y2.Text);
            z2 = Convert.ToDouble(this.z2.Text);

            // Створення векторів 1 і 2
            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);
            
            // Розрахунок довжин векторів 1 і 2
            Length_vector1.Content = Convert.ToString(Convert.ToSingle(vector1.Length()));
            Length_vector2.Content = Convert.ToString(Convert.ToSingle(vector2.Length()));

            // Додавання векторів
            Vector vector3 = new Vector();
            vector3 = vector1 + vector2;
            x3.Content = Convert.ToString(Convert.ToSingle(vector3.get_X()));
            y3.Content = Convert.ToString(Convert.ToSingle(vector3.get_Y()));
            z3.Content = Convert.ToString(Convert.ToSingle(vector3.get_Z()));
            Length_vector3.Content = Convert.ToString(Convert.ToSingle(vector3.Length()));

            // Віднімання векторів
            Vector vector4 = new Vector();
            vector4 = vector1 - vector2;
            x4.Content = Convert.ToString(Convert.ToSingle(vector4.get_X()));
            y4.Content = Convert.ToString(Convert.ToSingle(vector4.get_Y()));
            z4.Content = Convert.ToString(Convert.ToSingle(vector4.get_Z()));
            Length_vector4.Content = Convert.ToString(Convert.ToSingle(vector4.Length()));

            // Скалярний добуток векторів
            double product = Vector.DotProduct(vector1, vector2);
            prod.Content = Convert.ToString(Convert.ToDouble(product));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var InheritanceWindow = new Inheritance();
            InheritanceWindow.Show();
        }
    }
}
