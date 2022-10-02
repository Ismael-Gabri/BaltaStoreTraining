using BaltaStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreationDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.awaiting;
        }
        public DateTime CreationDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }
    }
}
