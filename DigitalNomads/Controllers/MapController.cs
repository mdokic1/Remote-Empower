using DigitalNomads.Data;
using DigitalNomads.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalNomads.Controllers
{
    public class MapController : Controller
    {
        private readonly CtrlAltDefeatDbContext _context;

        public MapController(CtrlAltDefeatDbContext context)
        {
            _context = context;
        }
        public IActionResult Map()
        {
            List<Place> places = _context.Places.ToList();



            string markeri = "[";
            int vel = 0;
            foreach (Place place in places)
            {
                markeri += "{";
                double lat = place.Lat;
                double lng = place.Long;
                markeri += String.Format("'lat': '{0}',", lat.ToString(System.Globalization.CultureInfo.InvariantCulture));
                markeri += String.Format("'long': '{0}',", lng.ToString(System.Globalization.CultureInfo.InvariantCulture));
                markeri += string.Format("'name': '{0}',", place.Name);
                markeri += string.Format("'address': '{0}',", place.Address);
                markeri += string.Format("'begin': '{0}',", place.Start.Hour);
                markeri += string.Format("'end': '{0}'", place.End.Hour);
                if (vel < places.Count - 1)
                {
                    markeri += "},";
                }
                else
                {
                    markeri += "}";
                }
                vel++;
            }
            markeri += "];";
            ViewBag.Markeri = markeri;

            ViewBag.Latitude = places.ElementAt(0).Lat.ToString(System.Globalization.CultureInfo.InvariantCulture);
            ViewBag.Longitude = places.ElementAt(0).Long.ToString(System.Globalization.CultureInfo.InvariantCulture);

            return View();
        }
    }
}
