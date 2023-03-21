using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaymentBL
{

    public interface ITrainerService
    {
        Trainer Get(int id);

        bool PostData(Trainer batch);
    }

    public class TrainerService : ITrainerService
    {
        private readonly ITrainerRepository repository;
        public TrainerService(ITrainerRepository repository)
        {
            this.repository = repository;
        }
        public Trainer Get(int id)
        {
            return repository.Get(id);
        }

        public bool PostData(Trainer batch)
        {
            return repository.PostData(batch);
        }
    }
}



