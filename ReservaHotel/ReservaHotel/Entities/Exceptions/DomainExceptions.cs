using System;
using System.Collections.Generic;
using System.Text;

namespace ReservaHotel.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }

    }
}
