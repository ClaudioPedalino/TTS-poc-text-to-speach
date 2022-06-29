var configuration = Configuration.Build(
    VoiceGender.Female,
    rateSpeed: default);

var peopleData = DataGeneratorService.GenerateData(5);

SpeechSynthesizerService.SpellUsers(configuration, peopleData);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

