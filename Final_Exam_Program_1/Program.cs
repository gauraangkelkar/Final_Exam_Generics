using System;
using System.Collections.Generic;
using System.Linq;
namespace Final_Exam_Program_1
{
    class SampleList<T>{
        private List<T> sampleList;

        public void Add(T data)
        {
            sampleList.Add(data);
        }

        public T find(int index)
        {
            return sampleList[index];
        }

        public List<T> sort()
        {
            sampleList.OrderByDescending<T,T>(key => {
                return sampleList;
            })
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
