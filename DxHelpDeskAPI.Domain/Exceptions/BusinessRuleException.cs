using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Exceptions
{
    public class BusinessRuleException : Exception
    {
        public string Details { get; }

        public BusinessRuleException(string message) : base(message)
        {
        }

        public BusinessRuleException(string message, string details) : base(message)
        {
            Details = details;
        }
    }
}
