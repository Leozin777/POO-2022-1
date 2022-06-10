namespace Aula11CrudPeople.Models.Domains
{
    public class City
    {
        public City(){}
        public City(int id, string name, string state)
        {
            Id = id;
            Name = name;
            State = state;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}