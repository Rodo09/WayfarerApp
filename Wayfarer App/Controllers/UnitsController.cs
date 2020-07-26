using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wayfarer_App.Models;
using Newtonsoft.Json.Linq;

namespace Wayfarer_App.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UnitsController : Controller
    {
        [HttpGet]
        public JsonResult GetUnitVMList()
        {
            try
            {
                WayfarerDBContext db = new WayfarerDBContext();
                List<OwnedUnitsGridVM> unitsGridVMs = db.OwnedUnits.Select(x => new OwnedUnitsGridVM
                {
                    Faction = x.Unit.Faction,
                    Job1 = x.Unit.Job1,
                    Job2 = x.Unit.Job2,
                    Job3 = x.Unit.Job3,
                    Name = x.Unit.Name,
                    OwnedUnitId = x.OwnedUnitId,
                    RarityImage = "/Images/Rarities/"+x.Unit.Rarity.RarityImage,
                    UnitAwakening = x.UnitAwakening,
                    UnitImage = x.Unit.UnitImage,
                    UnitJob1Level = x.UnitJob1Level,
                    UnitJob2Level = x.UnitJob2Level,
                    UnitJob3Level = x.UnitJob3Level,
                    UnitLevel = x.UnitLevel,
                    UnitLimitBreak = x.UnitLimitBreak,
                    UserId = x.UserId
                }).ToList();
                return Json(unitsGridVMs);
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
    }
}
