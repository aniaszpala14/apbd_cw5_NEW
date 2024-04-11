using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("aniapi/visits")]
public class VisitsController : ControllerBase
{
    [HttpGet("{animalId:int}")]
    public IActionResult GetVisitsFor(int animalId)
    {
        var visits =MockDb.getInstance().Visits;
        List<Visit> a=visits.FindAll(a=>a.AnimalClientId==animalId);
        if (!a.Any())
        {
            return NotFound($"No Visits for {animalId}");
        }
        return Ok(a);    
    }

    [HttpPost]
    public IActionResult AddVisit([FromBody]Visit visit)
    { 
        var visits =MockDb.getInstance().Visits;
        var animals = MockDb.getInstance().Animals;
        var a = animals.FirstOrDefault(a => a.Id == visit.AnimalClientId);
        if (a == null)
        {
            return NoContent();
        }
        visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
    
}