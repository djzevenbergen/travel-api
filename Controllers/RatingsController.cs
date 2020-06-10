
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;


namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RatingsController : ControllerBase
  {
    private TravelApiContext _db;

    public RatingsController(TravelApiContext db)
    {
      _db = db;
    }

    // POST api/Remedies
    [HttpPost]
    public void Post([FromBody] Rating rating)
    {
      _db.Ratings.Add(rating);
      _db.SaveChanges();
    }

    // GET api/Remedies
    [HttpGet]
    public ActionResult<IEnumerable<Rating>> Get(int placeId, int ratingId, int userId)
    {
      var query = _db.Ratings.AsQueryable();

      if (placeId != 0)
      {
        query = query.Where(entry => entry.PlaceId == placeId);
      }

      if (ratingId != 0)
      {
        query = query.Where(entry => entry.RatingId == ratingId);
      }

      if (userId != 0)
      {
        query = query.Where(entry => entry.UserId == userId);
      }
      return query.ToList();
    }

  }
}