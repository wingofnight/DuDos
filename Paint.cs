using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace DuDos
{
    class Paint
    {
        private static void Point(char symbol, string x, int quantity)
        {

            switch (symbol)
            {
                case 'b':
                    ForegroundColor = ConsoleColor.Blue;
                    break;
                case 'd':
                    ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 'p':
                    ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 'g':
                    ForegroundColor = ConsoleColor.Gray;
                    break;
                case 'w':
                    ForegroundColor = ConsoleColor.White;
                    break;
                case 'r':
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 'R':
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    break;
            }
            for (int i = 0; i < quantity; i++)
            {
                Write(x);
            }
            ResetColor();
        }
        public static void DarckRed(int quant)
        {
            ForegroundColor = ConsoleColor.Black; BackgroundColor = ConsoleColor.DarkRed; for (int i = 0; i < quant; i++)
            {
                Write("▓");
            }
            ResetColor();
        }

        public static void DarckRed2(int quant) { Point('r', "▓", quant); }
        public static void DarckRed()
        {
            ForegroundColor = ConsoleColor.Black; BackgroundColor = ConsoleColor.DarkRed; for (int i = 0; i < 1; i++)
            {
                Write("▓");
            }
            ResetColor();
        }
        public static void Red(int quant) { Point('r', "█", quant); }

        public static void Blue(int quant) { Point('b', "█", quant); }
        public static void Blue() { Point('b', "█", 1); }
        public static void DarckBlue(int quant) { Point('d', "▒", quant); }
        public static void Pink(int quant) { Point('p', "▒", quant); }
        public static void Gray(int quant) { Point('g', "▒", quant); }
        public static void White(int quant) { Point('w', "█", quant); }
        public static void Black(int quant) { Point(' ', " ", quant); }
        public static void Red() { Point('r', "█", 1); }

        public static void DarckBlue() { Point('d', "▒", 1); }
        public static void Pink() { Point('p', "▒", 1); }
        public static void Gray() { Point('g', "▒", 1); }
        public static void White() { Point('w', "█", 1); }
        public static void Black() { Point(' ', " ", 1); }
        public static void DarckRed2() { Point('r', "▓", 1); }

        public void ColorString(string SymbolColor, string GroundColor, string Text)
        {
            switch (SymbolColor)
            {
                case "Blue":
                    ForegroundColor = ConsoleColor.Blue;
                    break;
                case "DarkBlue":
                    ForegroundColor = ConsoleColor.DarkBlue; 
                    break;
                case "Pink":
                    ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "DarkPink":
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "Gray":
                    ForegroundColor = ConsoleColor.Gray;
                    break;
                case "DarkGray":
                    ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "White":
                    ForegroundColor = ConsoleColor.White;
                    break;
                case "Read":
                    ForegroundColor = ConsoleColor.Red;
                    break;
                case "DarkRead":
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "DarkGreen":
                    ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "Green":
                    ForegroundColor = ConsoleColor.Green;
                    break;
                case "Yellow":
                    ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "DarkYellow":
                    ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Cyan":
                    ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "DarkCyan":
                    ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                default:
                    break;
            }

            switch (GroundColor)
            {
                case "Blue":
                    BackgroundColor = ConsoleColor.Blue;
                    break;
                case "DarkBlue":
                    BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case "Pink":
                    BackgroundColor = ConsoleColor.Magenta;
                    break;
                case "DarkPink":
                    BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "Gray":
                    BackgroundColor = ConsoleColor.Gray;
                    break;
                case "DarkGray":
                    BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case "White":
                    BackgroundColor = ConsoleColor.White;
                    break;
                case "Read":
                    BackgroundColor = ConsoleColor.Red;
                    break;
                case "DarkRead":
                    BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case "DarkGreen":
                    BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case "Green":
                    BackgroundColor = ConsoleColor.Green;
                    break;
                case "Yellow":
                    BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "DarkYellow":
                    BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Cyan":
                    BackgroundColor = ConsoleColor.Cyan;
                    break;
                case "DarkCyan":
                    BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                default:
                    break;
            }

            Write(Text);
            ResetColor();
        }

        public void ColorString(string SymbolColor, string Text)
        {
            switch (SymbolColor)
            {
                case "Blue":
                    ForegroundColor = ConsoleColor.Blue;
                    break;
                case "DarkBlue":
                    ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "Pink":
                    ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "DarkPink":
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "Gray":
                    ForegroundColor = ConsoleColor.Gray;
                    break;
                case "DarkGray":
                    ForegroundColor = ConsoleColor.Gray;
                    break;
                case "White":
                    ForegroundColor = ConsoleColor.White;
                    break;
                case "Read":
                    ForegroundColor = ConsoleColor.Red;
                    break;
                case "DarkRead":
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "DarkGreen":
                    ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "Green":
                    ForegroundColor = ConsoleColor.Green;
                    break;
                case "Yellow":
                    ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "DarkYellow":
                    ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Cyan":
                    ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "DarkCyan":
                    ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                default:
                    break;
            }
            Write(Text);
            ResetColor();
        }
    }
        class LogoPrint : Paint
        {

            void line_1()
            {
                WriteLine();
                White(24); WriteLine();
                White(); White(); Red(2); White(3); Red(); White(); Red(); White(); Red(2); White(3); Red(3); White(); Red(3); White();
                ResetColor();
                WriteLine();
            }
            void line_2()
            {
                line_1();
                White(); Black(); Red(3); White(); Black(); Red(); Black(); Red(); Black(); Red(3); White(); Black(); Red(); Black(); Red(); Black(); Red(); Black(); White(2);
                ResetColor();
                WriteLine();
            }
            void line_3()
            {
                line_2();
                White(); Black(); Red(); Black(); Red(2); Black(); Red(); Black(); Red(); Black(); Red(); Black(); Red(2); Black(); Red(); Black(); Red(); Black(); Red(3); White();
                ResetColor();
                WriteLine();
            }
            void line_4()
            {
                line_3();
                White(); Black(); Red(); Black(); Red(2); Black(); Red(); Black(); Red(); Black(); Red(); Black(); Red(2); Black(); Red(); Black(); Red(); Black(3); Red(); White();
                ResetColor();
                WriteLine();
            }
            void line_5()
            {
                line_4();
                White(); Black(); Red(3); White(); Black(); Red(3); Black(); Red(3); White(); Black(); Red(3); White(); Red(3); White();
                ResetColor();
                WriteLine();
            }
            public void ALL_PRINT()
            {
                line_5();
                White(); Black(3); White(2); Black(3); White(); Black(3); White(2); Black(3); White(); Black(3); White(2);
                ResetColor();
                WriteLine();
                White(24);
                ResetColor();
                WriteLine();
                WriteLine();
                WriteLine();
            }
        }
     
}
