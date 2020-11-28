﻿using System;

namespace Fillwords
{
    class Program
    {
        static void Main(string[] args)
        {
            DataWorker.ReadWordsFromFile("../../../words.txt");

            //Главный цикл
            do
            {
                Printer.DrawMenu();
                KeyInteractions.DoMenuActions();
            } while (true);
        }
    }
}
