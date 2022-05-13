namespace CrudClient.Models.Domain
{
    public class Client
    {
        public Client(){} // perguntar pro cássio
        public Client(int id, string name, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}