using System.Speech.Synthesis;
using TTS_poc_text_to_speach.Configs;

var configuration = Configuration.Build(VoiceGender.Female, rateSpeed: default);

using (SpeechSynthesizer synth = new SpeechSynthesizer())
{
    synth.Speak("Hello World");
}


Console.WriteLine("Press any key to exit...");
Console.ReadKey();