using Microsoft.EntityFrameworkCore;
using PaymentBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDAL
{
    public class HtContext : DbContext
    {
        public HtContext(DbContextOptions<HtContext> options): base(options)
        {

        }

        public DbSet<BatchDto> Batch { get; set; } = null!;

        public DbSet<TrainerDto> Trainer { get; set; } = null!;

        public DbSet<TrainerPaymentDto> TrainerPayment { get; set; } = null!;
    }
}
