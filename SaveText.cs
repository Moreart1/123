using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ДЗ_1._1
{
    class SaveText
    {
        public void Save()
        {
            string pathToFile = @"C:\Users\Mark\source\repos\SaveText.txt";
            string readAllFile = File.ReadAllText(pathToFile);
            string[] readEveryLine = new string[6];
            readEveryLine = File.ReadAllLines(pathToFile);
            for (int i = 0; i < readEveryLine.Length; i++)
            Console.WriteLine(readEveryLine[i]);
            File.WriteAllText(pathToFile, "Урок №1 :" + "Блок-схемы,асимптотическая сложность,рекурсия\n");
            File.AppendAllText(pathToFile, "Урок №2 :" + "Массив,список,поиск\n");
            File.AppendAllText(pathToFile, "Урок №3 :" + "Класс,структура и дистанция\n");
            File.AppendAllText(pathToFile, "Урок №4 :" + "Деревья,хэш-таблицы\n");
            File.AppendAllText(pathToFile, "Урок №5 :" + "Стек,очередь,словарь и коллекции в C#\n");
            File.AppendAllText(pathToFile, "Урок №6 :" + "Графы\n");
            File.AppendAllText(pathToFile, "Урок №7 :" + "Динамическое программирование");
        }
    }
}
