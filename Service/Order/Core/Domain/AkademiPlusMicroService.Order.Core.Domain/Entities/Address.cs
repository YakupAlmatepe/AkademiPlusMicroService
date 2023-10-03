using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroService.Order.Core.Domain.Entities
{
    public class Address
    {
        public int AdressId { get; set; }
        public string UserId { get; set; }
        public string Disctrit { get; set; }
        public string Detail { get; set; }
        public string City { get; set; }
    }
}
