using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.Core.Exceptions
{
    public class InvalidFileContentException : BaseDemographicException
    {
        public InvalidFileContentException(string message = _description) : base(message)
        {

        }
        private const string _description = "Данные в файле повреждены или имеют неверный формат";
        public override string Description
        {
            get { return _description; }
        }
    }
}
