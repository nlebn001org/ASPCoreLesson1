namespace WebApplication1
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int WorkerAmount { get; set; }

        public override string ToString() => $"ID: {ID}, Name: {Name}, WorkerAmount: {WorkerAmount}";
        
    }
}
