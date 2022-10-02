using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }

        public string Number { get; private set; }
    }
}
