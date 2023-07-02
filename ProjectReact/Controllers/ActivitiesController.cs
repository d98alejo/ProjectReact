using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectReact.Data;
using ProjectReact.Models;

namespace ProjectReact.Controllers
{
	public class ActivitiesController : BaseApiController
	{
		private readonly DataContext _dataContext;
		public ActivitiesController(DataContext context)
		{
			_dataContext = context;

		}

		[HttpGet] //api/activities

		public async Task<ActionResult<List<Activity>>> GetActivities()
		{
			return await _dataContext.Activities.ToListAsync();
		}

		[HttpGet("{id}")]//api/activities/fds23423
		public async Task<ActionResult<Activity>> GetActivity(Guid id)
		{
			//return await _dataContext.Activities.FirstOrDefaultAsync(a => a.Id == id);

			return await _dataContext.Activities.FindAsync(id);
		}

	}
}
