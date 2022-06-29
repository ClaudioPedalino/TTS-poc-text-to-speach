using Bogus;
using System.Speech.Synthesis;
using TTS_poc_text_to_speach.Configs;
using TTS_poc_text_to_speach.Extensions;
using TTS_poc_text_to_speach.Models;

var configuration = Configuration.Build(VoiceGender.Female, rateSpeed: default);
var peopleData = GenerateData(5);


using (SpeechSynthesizer synth = new SpeechSynthesizer())
{
    synth.Rate = configuration.Rate;
    synth.SelectVoiceByHints(configuration.Gender);

    foreach (var person in peopleData)
    {
        var personInput = new PersonInput($"{person.FirstName} {person.LastName}", person.Email);

        PrintInput(person);

        synth.Speak($"Name: {personInput.FullName}");
        synth.Speak($"Email: {personInput.Email}");

        synth.SetSpeed(0);
        //synth.SpellName(personInput);
        synth.SpellEmail(personInput);

        synth.Speak($"Repeat:");
        synth.SetSpeed(-2);
        synth.SpellName(personInput);
        synth.SpellEmail(personInput);

    }


}

static List<Person> GenerateData(int quantity)
{
    return new Faker<Person>()
        .CustomInstantiator(f => new Person())
        .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
        .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
        .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
        .Generate(quantity);
}

static void PrintInput(Person item)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Name: {item.FirstName} {item.LastName}");
    Console.WriteLine($"Email: {item.Email}\n");
    Console.ResetColor();
}


Console.WriteLine("Press any key to exit...");
Console.ReadKey();