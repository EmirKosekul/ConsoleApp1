using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(123,"Emir");
            myDictionary.PrintValues();
            Console.WriteLine(myDictionary.Count);
        }
    }

    class MyDictionary<T1, T2>
    {

        T1[] _studentNumber;
        T2[] _studentName;
        public MyDictionary()
        {
        _studentNumber = new T1[0];
        _studentName= new T2[0];
        }
        
        public  void Add(T1 number, T2 name)
        {
            T1[] tempNumbers = _studentNumber;
            T2[] tempNames = _studentName;
            _studentNumber = new T1[_studentNumber.Length + 1];
            _studentName = new T2[_studentName.Length + 1];
            for (int i = 0; i < _studentName.Length-1; i++)
            {
                _studentName[i] = tempNames[i];
            }
            for (int i = 0; i < _studentNumber.Length-1; i++)
            {
                _studentNumber[i] = tempNumbers[i];
            }
            _studentNumber[_studentNumber.Length-1] = number;
            _studentName[_studentName.Length-1] = name;
        }
        public int Count 
        { 
            get { return _studentNumber.Length; } 
        }
        public void PrintValues()
        {
            for (int i = 0; i < _studentName.Length; i++)
            {
                Console.WriteLine("Student Number={0} Student Name={1}", _studentNumber[i], _studentName[i]);
            }
        }
    }
}






