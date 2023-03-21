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
    public class TrainerRepository : ITrainerRepository
    {
        private readonly HtContext _htContext;

        public TrainerRepository(HtContext htContext) 
        {
            this._htContext = htContext;
        }

        private TrainerDto GetData(int id)
        {
            var trainer = _htContext.Trainer.Find(id);
            return trainer;
        }

        public bool PostData(Trainer trainer)
        {
            TrainerDto trainerDto = 
            new TrainerDto
            {
                Name = trainer.Name,
                MobileNo = trainer.MobileNo,
                GPayNo = trainer.GPayNo,
                AccountNo = trainer.AccountNo,
                IFSCCode = trainer.IFSCCode,
                AccountPayeeName = trainer.AccountPayeeName,
                AccountType = trainer.AccountType
            };
            var tches = _htContext.Trainer.Add(trainerDto);
            _htContext.SaveChanges();
            return true;
        }

        Trainer ITrainerRepository.Get(int id)
        {
            TrainerDto dto = GetData(id);
            return new Trainer
            {
                ID= dto.ID,
                Name = dto.Name,
                MobileNo = dto.MobileNo,
                GPayNo = dto.GPayNo,
                AccountNo = dto.AccountNo,
                IFSCCode = dto.IFSCCode,
                AccountPayeeName = dto.AccountPayeeName,
                AccountType = dto.AccountType
            };
        }
    }
}
