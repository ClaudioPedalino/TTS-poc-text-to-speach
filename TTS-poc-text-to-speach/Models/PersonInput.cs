namespace TTS_poc_text_to_speach.Models
{
    internal class PersonInput
    {
        internal PersonInput(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }

        internal string FullName { get; set; }
        internal string Email { get; set; }
    }
}
