namespace ScoreService.API
{
    public class ApplicantRequest
    {
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Country { get; set; }


        public int Income { get; set; }
        public bool Mortgage { get; set; }

    }
}