using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskFromNikita.Repositories.PaymentsRepository.Models
{
    public class PaymentSearchResponse
    {
        public bool Found { get; set; }
        public payments Payment;
    }
}
