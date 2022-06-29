using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using TTS_poc_text_to_speach.Models;

namespace TTS_poc_text_to_speach.Extensions
{
    public static class SpeechSynthesizerExtension
    {
        public static void SetSpeed(this SpeechSynthesizer synth, int speed)
            => synth.Rate = speed;

        public static void SpellEmail(this SpeechSynthesizer synth, PersonInput personInput)
        {
            var values = personInput.Email.Split('@');
            synth.Speak($"Spelling Email:");

            foreach (var emailLetter in values[0])
            {
                synth.Speak(emailLetter.ToString());
            }

            synth.Speak(values[1]);
        }

        public static void SpellName(this SpeechSynthesizer synth, PersonInput personInput)
        {
            synth.Speak($"Spelling Name:");

            foreach (var nameLetter in personInput.FullName.Select(x => x))
            {
                synth.Speak(nameLetter.ToString());
            }
        }
    }
}
