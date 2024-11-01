using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib3;

namespace Практическая5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Объявление человека
        private Man _people;
        private Man _people1;

        //Консипукиор
        public MainWindow()
        {
            InitializeComponent();
            _people = new Man(name, gender, 18, 53);
            tbName.Text = _people.Name;
            tbGender.Text = _people.Gender;
            tbAge.Text = _people.Age.ToString();
            tbWeight.Text = _people.Weight.ToString();

            _people1 = new Man(name1, gender1, 16, 50);
            tbName1.Text = _people1.Name;
            tbGender1.Text = _people1.Gender;
            tbAge1.Text = _people1.Age.ToString();
            tbWeight1.Text = _people1.Weight.ToString();
        }

        //Поля name and gender
        string name = "Таисия";
        string gender = "Женский";
        string name1 = "Настя";
        string gender1 = "Женский";


        //Кнопка выхода
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Кнопка инфо
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Man (человек), с полями: имя, возраст, пол и вес. \r\nСоздать необходимые методы и свойства. \r\nСоздать перегруженные методы SetParams, для\r\nустановки параметров человека.\r\nРазработчик: Гришина Таисия ИСП-31");
        }
        
        //Кнопка увеличения возраста
        private void btnAgePlus_Click(object sender, RoutedEventArgs e)
        {

            if (UpdateParams())
            {
                _people.PlusAge();
                tbAge.Text = _people.Age.ToString();
            }
        }

        //кнопка увеличения веса
        private void btnWeightPlus_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateParams())
            {
                _people.SetParams();
                tbWeight.Text = _people.Weight.ToString();
            }
        }

        //кнопка уменьшения веса
        private void btnWeightMinus_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateParams())
            {
                _people.MinusWeight();
                tbWeight.Text = _people.Weight.ToString();
            }

        }

        //метод обновления полей
        private bool UpdateParams()
        {
            bool isValid = true;

            isValid &= int.TryParse(tbAge.Text, out int age);
            isValid &= int.TryParse(tbWeight.Text, out int weight);

            if (!isValid)
            {
                MessageBox.Show("Введите корректные числа для параметров.", "Ошибка ввода");
                return false;
            }

            _people.Age = age;
            _people.Weight = weight;

            return true;
        }

        //кнопка пропуска 10 лет
        private void btnSkip10_click(object sender, RoutedEventArgs e)
        {
            int weight = Convert.ToInt32(tbWeight.Text);
            int age = Convert.ToInt32(tbAge.Text);
            int weight1 = Convert.ToInt32(tbWeight1.Text);
            int age1 = Convert.ToInt32(tbAge1.Text);
            if (UpdateParams())
            {                
                _people.SetParams(weight+=12, age+=10);
                tbAge.Text = _people.Age.ToString();
                tbWeight.Text = _people.Weight.ToString();

                _people1.SetParams(weight1 += 12, age1 += 10);
                tbAge1.Text = _people1.Age.ToString();
                tbWeight1.Text = _people1.Weight.ToString();
            }

        }

        private void btnWeightPlus1_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateParams())
            {
                _people1.SetParams();
                tbWeight1.Text = _people1.Weight.ToString();
            }
        }

        private void btnWeightMinus1_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateParams())
            {
                _people1.MinusWeight();
                tbWeight1.Text = _people1.Weight.ToString();
            }
        }

        private void btnAgePlus1_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateParams())
            {
                _people1.PlusAge();
                tbAge1.Text = _people1.Age.ToString();
            }
        }

        private void btnSravnenieVesa_Click(object sender, RoutedEventArgs e)
        {
            Man man1 = new Man(tbName.Text, tbGender.Text, int.Parse(tbAge.Text), int.Parse(tbWeight.Text));
            Man man2 = new Man(tbName1.Text, tbGender1.Text, int.Parse(tbAge1.Text), int.Parse(tbWeight1.Text));

            if (man1 > man2)
            {
                tbSravnenie.Text = $"{man1.Name} тяжелее, чем {man2.Name}";
            }
            else if (man1 < man2)
            {
                tbSravnenie.Text = $"{man2.Name} тяжелее, чем {man1.Name}";
            }
            else
            {
                tbSravnenie.Text = "Вес одинаковый";
            }
        }
    }
}