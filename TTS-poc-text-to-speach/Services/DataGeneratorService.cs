namespace TTS_poc_text_to_speach.Services
{
    internal static class DataGeneratorService
    {
        internal static List<Person> GenerateData(int quantity)
        {
            return new Faker<Person>()
                .CustomInstantiator(f => new Person())
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .Generate(quantity);
        }
    }
}
