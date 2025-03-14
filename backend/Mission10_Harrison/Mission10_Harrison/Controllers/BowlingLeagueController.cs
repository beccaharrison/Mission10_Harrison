using System.Collections;
using Mission10_Harrison.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Harrison.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private BowlerLeagueContext _bowlerContext;

        public BowlingLeagueController(BowlerLeagueContext bowlerContext)
        {
            _bowlerContext = bowlerContext;
        }

        [HttpGet(Name = "GetBowlingLeague")]
        public IEnumerable<object> Get()
        {
            var bowlerList = _bowlerContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .Select(b => new
                {
                    b.BowlerId,
                    b.BowlerFirstName,
                    b.BowlerMiddleInit,
                    b.BowlerLastName,
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber,
                    TeamName = b.Team.TeamName
                })
                .ToList();

            return (bowlerList);
        }

    }
}

