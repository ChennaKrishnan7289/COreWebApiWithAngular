using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public class TrainerBatchDto
    {
        public int TrainerId { get; set; }
        public int BatchId { get; set; }
        public int TotalAmount { get; set; }
        public int RemainingAmount { get; set; }
        public DateTime DueDate { get; set; }
    }
}
