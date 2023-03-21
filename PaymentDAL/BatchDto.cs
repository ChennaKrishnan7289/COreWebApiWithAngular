using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public class BatchDto
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? Name { get; set; }           
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; }
        public int CompletedPercentage { get; set; }
        public string? BatchComments { get; set; }

    }
}
