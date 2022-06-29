namespace TTS_poc_text_to_speach.Models
{
    public class PersonInput
    {
        public PersonInput(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
