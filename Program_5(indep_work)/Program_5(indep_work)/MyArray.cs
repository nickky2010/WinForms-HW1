using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_indep_work_
{
    //Создать класс «Одномерный массив», в котором описать следующие элементы: 
    //закрытое поле – массив целых чисел, свойство для определения длины массива, 
    //индексатор для доступа к элементам поля-массива,  конструктор с параметрами, 
    //метод для вычисления суммы элементов массива, метод для вычисления произведения элементов массива.

    public class MyArray
    {
        int[] arr;
        public MyArray(int n)
        {
            arr = new int[n];
        }
        public int Count { get => arr.Count(); }
        public int this [int index]
        {
            get
            {
                if (index >= 0 && index < arr.Count())
                    return arr[index];
                else
                    throw new Exception("Неправильно задано количество элементов массива");
            }
            set
            {
                arr[index] = Convert.ToInt32(value);
            }
        } 
        public int Sum ()
        {
            return arr.Sum();
        }

        public int Mult()
        {
            int count = arr.Count();
            int mult = arr[0];
            for (int i = 1; i < count; i++)
            {
                mult *= arr[i];
            }
            return mult;
        }
    }
}
