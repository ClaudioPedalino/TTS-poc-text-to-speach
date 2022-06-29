using System.Speech.Synthesis;

namespace TTS_poc_text_to_speach.Configs
{
    public class Configuration
    {
        public static Configuration Build(VoiceGender gender, int rateSpeed)
            => new Configuration()
            {
                Gender = gender,
                Rate = rateSpeed,
            };

        public VoiceGender Gender { get; private set; } = VoiceGender.Neutral;
        public int Rate { get; private set; } = 0;

    }
}
