namespace TTS_poc_text_to_speach.Extensions
{
    internal static class SpeechSynthesizerExtension
    {
        internal static void SetSpeed(this SpeechSynthesizer synth, int speed)
            => synth.Rate = speed;

        internal static void SpellEmail(this SpeechSynthesizer synth, PersonInput personInput)
        {
            var values = personInput.Email.Split('@');
            synth.Speak($"Spelling Email:");

            foreach (var emailLetter in values[0])
            {
                synth.Speak(emailLetter.ToString());
            }

            synth.Speak("@");
            synth.Speak(values[1]);
        }

        internal static void SpellName(this SpeechSynthesizer synth, PersonInput personInput)
        {
            synth.Speak($"Spelling Name:");

            foreach (var nameLetter in personInput.FullName.Select(x => x))
            {
                synth.Speak(nameLetter.ToString());
            }
        }
    }
}
