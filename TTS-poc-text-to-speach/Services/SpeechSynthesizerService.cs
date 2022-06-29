namespace TTS_poc_text_to_speach.Services
{
    internal static class SpeechSynthesizerService
    {
        internal static void SpellUsers(Configuration configuration, List<Person> peopleData)
        {
            using SpeechSynthesizer synth = new();

            synth.Rate = configuration.Rate;
            synth.SelectVoiceByHints(configuration.Gender);

            foreach (var person in peopleData)
            {
                var personInput = new PersonInput($"{person.FirstName} {person.LastName}", person.Email);

                PrinterHelper.PrintInput(person);

                synth.Speak($"{nameof(PersonInput.FullName)}: {personInput.FullName}");
                synth.Speak($"{nameof(PersonInput.Email)}: {personInput.Email}");

                synth.SetSpeed(0);
                synth.SpellName(personInput);
                synth.SpellEmail(personInput);

                synth.Speak("Repeat:");
                synth.SetSpeed(-2);
                synth.SpellName(personInput);
                synth.SpellEmail(personInput);
            }
        }
    }
}
