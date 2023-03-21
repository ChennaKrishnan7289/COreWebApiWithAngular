using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public interface ITrainerRepository
    {
        Trainer Get(int id);

        bool PostData(Trainer batch);
    }
}
