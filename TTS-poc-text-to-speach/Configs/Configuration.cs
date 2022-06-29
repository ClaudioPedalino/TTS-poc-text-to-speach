namespace TTS_poc_text_to_speach.Configs
{
    internal class Configuration
    {
        internal static Configuration Build(VoiceGender gender, int rateSpeed)
            => new Configuration()
            {
                Gender = gender,
                Rate = rateSpeed,
            };

        internal VoiceGender Gender { get; private set; } = VoiceGender.Neutral;
        internal int Rate { get; private set; } = 0;

    }
}
