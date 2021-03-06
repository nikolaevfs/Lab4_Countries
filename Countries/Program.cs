﻿using System;

namespace lab4
{
    /// <summary>
    /// Класс программы
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главная функция, принимает на вход название страны и выполняет настройки приложения
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название страны на английском");
            string input = Console.ReadLine();
            Settings settings = new RussianSetting();
            bool check = true;
            switch (input.ToLower())
            {
                case "russia":
                    settings = new RussianSetting();
                    break;
                case "germany":
                    settings = new GermanySetting();
                    break;
                case "china":
                    settings = new ChinaSetting();
                    break;
                default:
                    Console.WriteLine("error in input");
                    check = false;
                    break;
            }
            if (check)
            {
                Display disp = new Display(settings);
            }
            Console.ReadKey();
        }
    }
}
