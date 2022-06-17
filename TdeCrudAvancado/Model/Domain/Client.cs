namespace TdeCrudAvancado.Model.Domain
{
    public class Client
    {
        public Client(){}
        public Client(int id, string name, string phoneNumber, DateTime birthDay)
        {
            Id = id;
            Name = name;
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; } 
    }
}