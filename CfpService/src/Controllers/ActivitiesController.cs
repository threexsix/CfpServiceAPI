using CfpService.Dtos.Activity;
using CfpService.Services.Activity;
using Microsoft.AspNetCore.Mvc;

namespace CfpService.Controllers;

[ApiController]
[Route("[controller]")]
public class ActivitiesController : ControllerBase
{
    private readonly IActivityService _activityService;

    public ActivitiesController(IActivityService activityService)
    {
        _activityService = activityService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<GetActivityDto>> GetAllActivities()
    {
        var activities = _activityService.GetAllActivities();
        if (activities == null) return NotFound();
        return Ok(activities);
    }
}