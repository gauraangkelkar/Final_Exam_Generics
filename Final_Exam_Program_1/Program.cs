using System;
using System.Collections.Generic;
using System.Linq;
namespace Final_Exam_Program_1
{
    class SampleList<T>{
        private List<T> sampleList;

        public SampleList()
        {
            this.sampleList = new List<T>();
        }
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
            sampleList.OrderByDescending<T, List<T>>(key =>
            {
                sampleList.Sort();
                return sampleList;
                
            });
            return sampleList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SampleList<string> list = new SampleList<string>();
            list.Add("Gauraang");
            list.Add("Kelkar");
            Console.WriteLine(list.find(0));
            //list.sort();
            foreach(var item in list.sort())
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
