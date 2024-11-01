
using System.Windows;

namespace Lib3
{
    public class Man
    {
        //�������������� �������� Name
        public string Name { get; }

        //�������������� �������� Gender
        public string Gender { get; }

        int age; //���� �������

        int weight; //���� ���

        //��������� Age
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 100 && value > 0) age = value;
                else  MessageBox.Show("������� �� ���������"); 
            }
        }
        //�������� Weight
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 3 && value < 150) weight = value;
                else MessageBox.Show("������� ���������� ���"); 
            }
        }


        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="name">���</param>
        /// <param name="gender">���</param>
        /// <param name="age">�������</param>
        /// <param name="weight">���</param>
        public Man(string name, string gender, int age, int weight)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Weight = weight;
        }

        /// <summary>
        /// ����� ��� ���������� ����
        /// </summary>
        /// <returns>��� - 1</returns>
        public int MinusWeight()
        {
            return Weight -= 1;
        }

        /// <summary>
        /// ����� ��� ���������� ����
        /// </summary>
        /// <returns>��� + 1</returns>
        public void SetParams()
        {
             Weight += 1;
        }

        /// <summary>
        /// ������������� ����� ��� ��������� ���� � ��������
        /// </summary>
        /// <param name="weight">���</param>
        /// <param name="age">�������</param>
        public void SetParams(int weight, int age)
        {
            Weight = weight;
            Age = age;
        }

        /// <summary>
        /// ����� ��� ���������� ��������
        /// </summary>
        /// <returns>������� + 1</returns>
        public void PlusAge()
        {
            Age += 1;
        }

        

        /// <summary>
        /// ������������� ����� ��������� ���� >
        /// </summary>
        /// <param name="a">������ �������</param>
        /// <param name="b">������ �������</param>
        /// <returns></returns>
        public static bool operator >(Man a, Man b)
        {
            bool result;
            if (a.Weight > b.Weight) result = true;
            else result = false;
            return result;
        }

        /// <summary>
        /// ������������� ����� ��������� ���� <
        /// </summary>
        /// <param name="a">������ �������</param>
        /// <param name="b">������ �������</param>
        /// <returns></returns>
        public static bool operator <(Man a, Man b)
        {
            return a.Weight < b.Weight;
        }
    }
}
