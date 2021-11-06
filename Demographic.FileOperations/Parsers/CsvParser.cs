using Demographic.FileOperations.Parsers.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.FileOperations.Parsers
{
    /// <summary>
    /// Абстрактный Csv парсер
    /// </summary>
    /// <typeparam name="T">Объекты какого класса необходимо "парсить"</typeparam>
    public abstract class CsvParser<T> : AbstractParser<T>, ICsvParser<T> where T : class, new()
    {
        protected IFormatProvider _formatter;
        public CsvParser(string filePath, char separator = ',') : base(filePath)
        {
            Separator = separator;
            _formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        }

        /// <summary>
        /// Символ, отделяющий ячейки в строке
        /// </summary>
        public char Separator { get; set; }

        /// <inheritdoc cref="AbstractParser{T}.Parse()"/>
        public abstract override void Parse();
    }
}
