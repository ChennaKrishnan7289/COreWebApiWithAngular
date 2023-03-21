namespace PaymentBL
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long PhoneNo { get; set; }
        public string? EmailId { get; set; }
        public int BatchId { get; set; }
        public int CompletedPercentage { get; set; }
        public string? TrainingComments { get; set; }
        public int TotalAmount { get; set; }
        public int RemainingAmount { get; set; }
    }
}