using CfpService.Application.Entities;

namespace CfpService.Application.Repositories.Activity;

public interface IActivityRepository
{
    public IEnumerable<ApplicationActivity> GetAllActivities();
}