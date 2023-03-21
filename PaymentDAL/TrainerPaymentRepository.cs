using Microsoft.EntityFrameworkCore;
using PaymentBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace PaymentDAL
{
    public class TrainerPaymentRepository : ITrainerPaymentRepository
    {
        private readonly HtContext _htContext;

        public TrainerPaymentRepository(HtContext htContext) 
        {
            this._htContext = htContext;
        }

        private TrainerPaymentDto GetData(int id)
        {
            var trainerPayment = _htContext.TrainerPayment.Find(id);
            return trainerPayment;
        }

        public bool PostData(TrainerPayment trainerPayment)
        {
            TrainerPaymentDto trainerPaymentDto = 
            new TrainerPaymentDto
            {
               BatchId= trainerPayment.BatchId,
               Payment = trainerPayment.Payment,
               PaymentDate= trainerPayment.PaymentDate
    };
            var tches = _htContext.TrainerPayment.Add(trainerPaymentDto);
            _htContext.SaveChanges();
            return true;
        }

        TrainerPayment ITrainerPaymentRepository.Get(int id)
        {
            TrainerPaymentDto dto = GetData(id);
            return new TrainerPayment
            {
                BatchId = dto.BatchId,
                Payment = dto.Payment,
                PaymentDate = dto.PaymentDate
            };
        }
    }
}
