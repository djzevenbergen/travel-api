namespace TravelApi.Models
{
  public class Rating
  {
    public int RatingId { get; set; }
    public int Stars { get; set; }
    public int PlaceId { get; set; }
    public int UserId { get; set; }
    public string Comments { get; set; }

  }
}
