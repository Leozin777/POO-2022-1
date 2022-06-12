namespace TdeCrudAvancado.Model.Domain
{
    public class Client
    {
        public Client(){}
        public Client(int id, string name, string phoneNumber, DateTime birthDay, double balance)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            BirthDay = birthDay;
            Balance = balance;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public double Balance { get; set; }
        
    }
}