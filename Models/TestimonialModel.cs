namespace NPLubricants.Models
{
    public class TestimonialModel
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? CompanyName { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Description { get; set; }
    }

    public class TestimonialList
    {
        public List<TestimonialModel> GetTestimonials()
        {
            return new List<TestimonialModel>
            {
                new TestimonialModel{
                    Id = 1,CustomerName="Ram Dhakal", CompanyName="RD Services",PhotoUrl="RamDhakal.jpg",
                    Description="I am using their product for a long time. I am really impressed!"},
                new TestimonialModel{
                    Id = 2,CustomerName="Hari Bhattarai", CompanyName="All In One Services",PhotoUrl="HariBhattarai.jpg",
                    Description="Their engine oil is awesome and smooth."},
                new TestimonialModel{
                    Id = 3,CustomerName="Utsav Baral", CompanyName="Baral Interprises",PhotoUrl="UtsavBaral.jpg",
                    Description="I am regularly using their varities of products. I have no complaints."},
            };

        }

        public List<TestimonialModel> MostValuableTestimonials()
        {
            return new List<TestimonialModel>
            {
                new TestimonialModel
                {
                    CustomerName = "Rajendra Shrestha",
                    CompanyName = "Shrestha Automobiles",
                    PhotoUrl = "RajendraShrestha.jpg",
                    Description = "NP Lubricants have significantly improved engine efficiency and reduced wear and tear."
                },
                new TestimonialModel
                {
                    CustomerName = "Mina Karki",
                    CompanyName = "Karki Transport Services",
                    PhotoUrl = "MinaKarki.jpg",
                    Description = "Superior performance and customer support. Highly recommend NP Lubricants."
                }
            };
        }


    }
}
