using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.FileOperations.Parsers.Interfaces
{
    public interface ICsvParser<T> : IParser<T> where T : class, new()
    {
        char Separator { get; set; }
    }
}
