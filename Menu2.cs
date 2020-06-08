using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;
//int size = DirName[0].Length;
namespace DuDos
{
    class Menu2:Paint
    {
        int y = 0;
        int x = 0;
        char[] point = new char[2] { '►', ' ' };
        char[] line_0 = new char[52] { '╔', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '╗' };
        char[] line_99 = new char[52] { '╚', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '═', '╝' };
        Direct Dir = new Direct();
       public int Menu() {
            List<string> Directoryes = new List<string>();
            List<string> Files = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            DirectoryInfo disk = new DirectoryInfo(@Dir.DirMenu());
           
            foreach (var item in disk.GetDirectories())
            {
                Directoryes.Add(item.Name);
                x++;
                //WriteLine(item.Name);
            }
            foreach (var item in disk.GetFiles())
            {
                Files.Add(item.Name);
                y++;
                //WriteLine(item.Name);
            }
            LogoPrint Print = new LogoPrint();
            do
            {
                Clear();
                Print.ALL_PRINT();
                ColorString("DarkYellow", "Сделайте выбор\n");
                WriteLine("\n");
                Write(" ");
            foreach (var item in line_0)
            {
                BackgroundColor = ConsoleColor.DarkGray; ForegroundColor = ConsoleColor.DarkBlue;
                Write(item);
                ResetColor();
             }
             for (int i = 0; i < x; i++)
             {

                ResetColor();
                WriteLine();
                Write(" ");
                BackgroundColor = ConsoleColor.DarkGray; ForegroundColor = ConsoleColor.DarkBlue;
                Write("║   ");
                 Write(Directoryes[i]);
                for (int j = 0; j < ( 25 - Directoryes[i].Length); j++)
                {
                    Write(" ");
                }
                 Write("║   ");
                if ( i < Files.Count)
                {
                    Write(Files[i]);
                    for (int j = 0; j < (18 - Files[i].Length); j++)
                    {
                        Write(" ");
                    }
                    Write("║");
                }
                else
                {
                    for (int j = 0; j < 18; j++)
                    {
                        Write(" ");
                    }
                    Write("║");
                }               

            }
            ResetColor();
            WriteLine();
            Write(" ");
            foreach (var item in line_99)
            {
                BackgroundColor = ConsoleColor.DarkGray; ForegroundColor = ConsoleColor.DarkBlue;
                Write(item);
                ResetColor();
            }
                WriteLine("\n");
                ColorString("DarkYellow", "Осуществите выбор стрелками, и подтвердите его нажатием клавижи «Enter»\n");
                ConsoleKeyInfo getch = ReadKey(true);
                if (getch.Key == ConsoleKey.UpArrow)
                {
                    y++;
                    if (y > 1) { y = 0; }
                }
                else if (getch.Key == ConsoleKey.DownArrow)
                {
                    y--;
                    if (y < 0) { y = 1; }//стрелка вниз(курсор перескакивает вверх, когда достигает дна

                }
                else if (getch.Key == ConsoleKey.Enter) { return 0; }//при нажатии Энтр, завершаем цикл и возвращаем координаты для меню со свичем.
            } while (true);
        }

    }
}
