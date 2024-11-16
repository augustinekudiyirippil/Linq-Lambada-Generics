using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lambada_Generics
{
    internal class Class_Generics
    {

        public void genericsMethod()
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Bristol");
            cities.AddOrUpdate(1, "Manchester");
            cities.AddOrUpdate(2, "London");

            for(int i=0; i< 3; i++)
            {
                Console.WriteLine(cities.GetData(i));

            }

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(cities.GetData(i));

            }


        }


    }



    class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }



}
