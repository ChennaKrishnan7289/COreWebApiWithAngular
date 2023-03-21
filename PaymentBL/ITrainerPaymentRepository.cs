using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public interface ITrainerPaymentRepository
    {
        TrainerPayment Get(int id);

        bool PostData(TrainerPayment trainerPayment);
    }
}
