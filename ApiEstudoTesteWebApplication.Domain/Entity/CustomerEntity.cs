namespace ApiEstudoTesteWebApplication.Domain.Entity
{
    public class CustomerEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }

        public CustomerEntity(string name, string document, DateTime birthDate)
        {
            Name = name;
            Document = document;
            BirthDate = birthDate;
        }
    }
}
