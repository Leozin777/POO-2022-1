namespace Aula11CrudPeople.Models.Domains
{
    public class Person
    {
        public Person(){}
        public Person(int id, string nome, string fone)
        {
            Id = id;
            Nome = nome;
            Fone = fone;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
    }
}