using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBL
{
    public interface IBatchRepository
    {
        Batch Get(int id);

        bool PostData(Batch batch);
    }
}
