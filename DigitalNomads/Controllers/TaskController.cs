using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalNomads.Data;
using DigitalNomads.Models.Task;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using DigitalNomads.Models.Account;

namespace DigitalNomads.Controllers
{
    public class TaskController : Controller
    {
        private CtrlAltDefeatDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
  
        public TaskController(CtrlAltDefeatDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this._dbContext = dbContext;
            this._httpContextAccessor = httpContextAccessor;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> AllTasks()
        {
            TaskList list = await GetAllTasksByIdAsync();

            return View(list);
        }

        public async Task<int> GetAccountIdByUserIdAsync(string UserId)
        {
            AccountGetDetailsRes res = await _dbContext.Accounts
                .Where(a => a.UserId == UserId)
                .Select(a => new AccountGetDetailsRes
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Lat = a.Lat,
                    Long = a.Long

                }).FirstOrDefaultAsync();

            return res.Id;
        }

        public async Task<TaskList> GetAllTasksByIdAsync ()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int accId = await GetAccountIdByUserIdAsync(userId);

            IList<TaskRes> res = await _dbContext.Tasks
                .Where(t => t.UserId == accId)
                .Select(t => new TaskRes
                {
                    Id = t.Id,
                    Title = t.Title,
                    IsFinished = t.IsFinished,
                    Deadline = t.Deadline,
                    Description = t.Description,
                    UserId = t.UserId
                }).ToListAsync();

            return new TaskList { Tasks = res };
        }


    }
}
