using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaymentBL
{

    public interface ITrainerPaymentService
    {
        TrainerPayment Get(int id);

        bool PostData(TrainerPayment trainerPayment);
    }

    public class TrainerPaymentService : ITrainerPaymentService
    {
        private readonly ITrainerPaymentRepository repository;
        public TrainerPaymentService(ITrainerPaymentRepository repository)
        {
            this.repository = repository;
        }
        public TrainerPayment Get(int id)
        {
            return repository.Get(id);
        }

        public bool PostData(TrainerPayment trainerPayment)
        {
            return repository.PostData(trainerPayment);
        }
    }
}



