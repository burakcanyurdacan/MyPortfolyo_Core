namespace MyPortfolyo_Core.DAL.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}