namespace Car.Models
{
    public class Model
    {
        public int Id { get; set; }

        public string Mname { get; set; } = string.Empty;

        public int BrandId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
