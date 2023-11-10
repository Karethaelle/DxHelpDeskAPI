using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Exceptions
{
    public class CustomExceptionInvalidModel : Exception
    {
        public CustomExceptionInvalidModel(string message) : base(message) { }
        // Additional constructors or properties can be added here
    }
}
