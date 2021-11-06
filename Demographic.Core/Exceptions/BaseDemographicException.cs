using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.Core.Exceptions
{
    public class BaseDemographicException : Exception
    {
        private const string _description = "Базовый класс исключений сборки";
        public virtual string Description
        {
            get { return _description; }
        }
        public BaseDemographicException(string message = _description) : base(message)
        {

        }
    }
}
