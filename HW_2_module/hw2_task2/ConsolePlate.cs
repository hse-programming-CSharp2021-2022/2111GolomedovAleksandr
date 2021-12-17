using System;

namespace hw2_task2
{
    public class ConsolePlate
    {
        private char _plateChar; // символ

        private ConsoleColor _plateColor = ConsoleColor.White; // цвет символа
        private ConsoleColor _backColour = ConsoleColor.Black;

        // конструкторы
        public ConsolePlate()
        {
            _plateChar = 'A';
        }

        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor backColour)
        {
            this.PlateChar = plateChar; // используем свойства 
            this.PlateColor = plateColor;
            this.BackColour = backColour;
        }

        public char PlateChar
        {
            set
            {
                if (value >= 'A' && value <= 'Z') // отбрасываем командные символы
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
            get { return _plateChar; }
        }

        public ConsoleColor PlateColor
        {
            set
            {
                if (value == _backColour)
                {
                    _plateColor = ConsoleColor.White;
                    _backColour = ConsoleColor.Black;
                }
                else
                {
                    _plateColor = value; 
                }
            }
            get { return _plateColor; }
        }
        
        public ConsoleColor BackColour
        {
            set
            {
                if (value == _plateColor)
                {
                    _plateColor = ConsoleColor.White;
                    _backColour = ConsoleColor.Black;
                }
                else
                {
                    _backColour = value; 
                }
            }
            get { return _backColour; }
        }
    }
}