using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaStore.Domain.StoreContext.Enums
{
    public enum EOrderStatus
    {
        Created = 1,
        paid = 2,
        shipped = 3,
        Canceled = 4
    }
}
