using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalNomads.Data;
using DigitalNomads.Models.Meditation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalNomads.Controllers
{
    public class MeditationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        private CtrlAltDefeatDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MeditationController(CtrlAltDefeatDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this._dbContext = dbContext;
            this._httpContextAccessor = httpContextAccessor;
        }

        public async Task<IList<MeditationRes>> GetAllMeditationDetailsAsync()
        {
            IList<MeditationRes> res = await _dbContext.Meditations
                .Select(m => new MeditationRes
                {
                    Sound = m.Sound,
                    BackgroundURL = m.BackgroundURL
                }).ToListAsync();

            return res;
        }

        public async Task<IActionResult> StartMeditation()
        {
            IList<MeditationRes> res = await GetAllMeditationDetailsAsync();
            MeditationAndDurationModel model = new MeditationAndDurationModel
            {
                MeditationRes = res,
                Minutes = 1
            };
            return View(model);
        }

        public async Task<IActionResult> FiveMinutesMeditation()
        {
            IList<MeditationRes> res = await GetAllMeditationDetailsAsync();
            MeditationAndDurationModel model = new MeditationAndDurationModel
            {
                MeditationRes = res,
                Minutes = 5
            };
            return View(model);
        }

        public async Task<IActionResult> TenMinutesMeditation()
        {
            IList<MeditationRes> res = await GetAllMeditationDetailsAsync();
            MeditationAndDurationModel model = new MeditationAndDurationModel
            {
                MeditationRes = res,
                Minutes = 10
            };
            return View(model);
        }


    }
}
