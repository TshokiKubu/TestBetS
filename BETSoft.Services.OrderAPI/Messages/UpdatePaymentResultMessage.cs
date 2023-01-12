using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BETSoft.Services.OrderAPI.Messages
{
    public class UpdatePaymentResultMessage
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
