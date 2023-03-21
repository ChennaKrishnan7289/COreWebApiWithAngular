using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaymentBL
{

    public interface IBatchService
    {
        Batch Get(int id);

        bool PostData(Batch batch);
    }

    public class BatchService : IBatchService
    {
        private readonly IBatchRepository repository;
        public BatchService(IBatchRepository repository)
        {
            this.repository = repository;
        }
        public Batch Get(int id)
        {
            return repository.Get(id);
        }

        public bool PostData(Batch batch)
        {
            return repository.PostData(batch);
        }
    }
}



