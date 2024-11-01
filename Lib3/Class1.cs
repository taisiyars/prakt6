
using System.Windows;

namespace Lib3
{
    public class Man
    {
        //Автоматическое свойство Name
        public string Name { get; }

        //Автоматическое свойство Gender
        public string Gender { get; }

        int age; //Поле возраст

        int weight; //Поле вес

        //Ссвойство Age
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 100 && value > 0) age = value;
                else  MessageBox.Show("Возраст не корректен"); 
            }
        }
        //Свойство Weight
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 3 && value < 150) weight = value;
                else MessageBox.Show("Введите корректный вес"); 
            }
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="age">Возраст</param>
        /// <param name="weight">Вес</param>
        public Man(string name, string gender, int age, int weight)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Weight = weight;
        }

        /// <summary>
        /// Метод для уменьшения веса
        /// </summary>
        /// <returns>Вес - 1</returns>
        public int MinusWeight()
        {
            return Weight -= 1;
        }

        /// <summary>
        /// Метод для увеличения веса
        /// </summary>
        /// <returns>Вес + 1</returns>
        public void SetParams()
        {
             Weight += 1;
        }

        /// <summary>
        /// Перегруженный метод для изменения веса и возраста
        /// </summary>
        /// <param name="weight">вес</param>
        /// <param name="age">возраст</param>
        public void SetParams(int weight, int age)
        {
            Weight = weight;
            Age = age;
        }

        /// <summary>
        /// Метод для увеличения возраста
        /// </summary>
        /// <returns>Возраст + 1</returns>
        public void PlusAge()
        {
            Age += 1;
        }

        

        /// <summary>
        /// Перегруженный метод сравнения веса >
        /// </summary>
        /// <param name="a">первый человек</param>
        /// <param name="b">второй человек</param>
        /// <returns></returns>
        public static bool operator >(Man a, Man b)
        {
            bool result;
            if (a.Weight > b.Weight) result = true;
            else result = false;
            return result;
        }

        /// <summary>
        /// Перегруженный метод сравнения веса <
        /// </summary>
        /// <param name="a">первый человек</param>
        /// <param name="b">второй человек</param>
        /// <returns></returns>
        public static bool operator <(Man a, Man b)
        {
            return a.Weight < b.Weight;
        }
    }
}
