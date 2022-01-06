using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку"); // вводим строку
            string str = Console.ReadLine();// считываем 
            Console.WriteLine(Check(str));// проверяем, вызываем метод Check
            Console.ReadKey();
        }
        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>(); //конструкция stack
            Dictionary<char, char> bracket = new Dictionary<char, char> //структура данных, словарь 
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },

            };
            foreach (char c in str) // перебераем всю строку по символьно
            {
                if (c == '(' || c == '{' || c == '[')// C - это символ "скобки"
                    stack.Push(bracket[c]);// по этому индексу находим в словаре соответсвующую закрытую скобку и укладываем в stack
                if (c==')'|| c=='}'|| c==']')
                {
                    if (stack.Count==0 || stack.Pop()!=c)// если stack пустой, а он должен быть сейчас не пустым
                    {
                        return false; // прерываем этот метод и возвращаем в false
                    }

                }
            }
            if (stack.Count == 0)// если stack пустой вернули true
                return true;
            else
                return false; // если не пустой вернули false
        }
    }
}
