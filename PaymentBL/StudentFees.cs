using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public class StudentFees
    {
        public int Id { get; set; }
        public long PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
    }
}
