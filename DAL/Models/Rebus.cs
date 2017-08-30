namespace DAL.Models
{
    public class Rebus : BaseModel
    {
        public string СorrectAnswer { get; set; }
        public string ImagePath { get; set; }
        public int Level { get; set; }
    }
}
