using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public class TrainerDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public Int64 MobileNo { get; set; }
        public Int64 GPayNo { get; set; }
        public Int64 AccountNo { get; set; }
        public string? IFSCCode { get; set; }
        public string? AccountPayeeName { get; set; }
        public int AccountType { get; set; }
    }
}
