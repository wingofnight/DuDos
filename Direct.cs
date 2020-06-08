using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
namespace DuDos
{
    class Direct:Paint
    {       

        public void GO()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string choice = ReadLine();

            DirectoryInfo disk = new DirectoryInfo(@choice);
            foreach (var fi in disk.GetFiles())
            {
                WriteLine(fi.Name);
            }
            foreach (var fi in disk.GetDirectories())
            {
                WriteLine(fi.Name);
            }

        }
             

        public string DirMenu()
        {
            char[] Z = new char[2];
            const string DarkGray = "DarkGray";
            const string DarkBlue = "DarkBlue";
            const string DarkYellow = "DarkYellow";
            int x = 0;
            int y = 0;
            List<string> DirName = new List<string>();
            
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                DirName.Add(d.Name);
                x++;
            }
            LogoPrint Print = new LogoPrint();
           
            do
            {
                Clear();
                Print.ALL_PRINT();
                if (y == 0) { Z[0] = '►'; Z[1] = ' '; } else if (y == 1) { Z[0] = ' '; Z[1] = '►'; }
                ColorString(DarkYellow, "Выберите директорию\n");
           
            WriteLine("\n");
            Write(" ");            
            ColorString(DarkBlue, DarkGray ,"╔═════╗\n");
            
            for (int i = 0; i < x; i++)
            {
                Write(" ");
                if(Z[i] == '►') { BackgroundColor = ConsoleColor.Black; ForegroundColor = ConsoleColor.DarkYellow; } else
                {
                    BackgroundColor = ConsoleColor.DarkGray; ForegroundColor = ConsoleColor.DarkBlue;
                }           
                             
                Write("║"+Z[i]);
                Write(DirName[i]);
                WriteLine(" ║");
                ResetColor();
            }
            Write(" ");
            ColorString(DarkBlue, DarkGray, "╚═════╝\n");
            WriteLine();
            ColorString(DarkYellow, "Осуществите выбор стрелками, и подтвердите его нажатием клавижи «Enter»\n");
                
                ConsoleKeyInfo getch = ReadKey(true);//хватает стрелки
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
                else if (getch.Key == ConsoleKey.Enter) { return DirName[y]; }//при нажатии Энтр, завершаем цикл и возвращаем координаты для меню со свичем.
            } while (true);
            
        }
          
           
        
    }
    
}
