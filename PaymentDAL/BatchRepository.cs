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
    public class BatchRepository : IBatchRepository
    {
        private readonly HtContext _htContext;

        public BatchRepository(HtContext htContext) 
        {
            this._htContext = htContext;
        }

        private BatchDto GetData(int id)
        {
            var batch = _htContext.Batch.Find(id);
            return batch;
        }

        public bool PostData(Batch batch)
        {
            BatchDto batchDto = 
            new BatchDto
            {
                CourseName = batch.CourseName,
                Name = batch.Name,
                StartDate = batch.StartDate,
                EndDate = batch.EndDate,
                TrainerId = batch.TrainerId,
                CompletedPercentage = batch.CompletedPercentage,
                BatchComments = batch.BatchComments,
            };
            var tches = _htContext.Batch.Add(batchDto);
            _htContext.SaveChanges();
            return true;
        }

        Batch IBatchRepository.Get(int id)
        {
            BatchDto dto = GetData(id);
            return new Batch
            {
                Id = dto.Id,
                CourseName = dto.CourseName,
                Name = dto.Name,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                TrainerId = dto.TrainerId,
                CompletedPercentage = dto.CompletedPercentage,
                BatchComments = dto.BatchComments
            };
        }
    }
}
