namespace DBServerClient.Models
{
    public class QuestionAndAnswer
    {
        public int Slno { get; set; }
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int CorrectAnswer { get; set; }
        public int LockedAnswer { get; set; } = -1;
    }
}
