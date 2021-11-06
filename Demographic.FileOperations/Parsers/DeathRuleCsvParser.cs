using Demographic.Core.Exceptions;
using Demographic.FileOperations.Parsers.Interfaces;
using Demographic.Core.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.FileOperations.Parsers
{
    public class DeathRuleCsvParser : CsvParser<DeathRule>, ICsvParser<DeathRule>
    {
        public DeathRuleCsvParser(string filePath, char separator = ',') : base(filePath, separator)
        {
        }

        /// <summary>
        /// Метод Parse для вероятностей смерти по возрастам
        /// </summary>
        /// <exception cref="InvalidFileContentException"></exception>
        public override void Parse()
        {
            ValidateParamsFile();
            try
            {
                var lines = File.ReadAllLines(FilePath, Encoding.UTF8).ToList(); // Получаем все строки файла
                _headers = lines.ElementAtOrDefault(0)?.Split(Separator).ToList(); // Получаем заголовки csv файла

                _records = lines
                    .Skip(1) // Пропускаем первую строку (это заголовок)
                    .Select(p => p.Split(Separator)) // Делим строку на ячейки 
                    .Select(p => new DeathRule // Из ячеек делаем ирис
                    {
                        LeftLimit = uint.Parse(p[0]),
                        RightLimit = uint.Parse(p[1]),
                        ProbabilityDeathMale = double.Parse(p[2], _formatter),
                        ProbabilityDeathFemale = double.Parse(p[3], _formatter)
                    })
                    .ToList();
                _successfullyParsed = true;
            }
            catch
            {
                _successfullyParsed = false;
                throw new InvalidFileContentException();
            }
        }
    }
}
