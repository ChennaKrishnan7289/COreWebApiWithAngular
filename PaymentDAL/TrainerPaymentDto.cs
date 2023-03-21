using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public class TrainerPaymentDto
    {
        [Key]
        public int BatchId { get; set; }
        public int Payment { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
