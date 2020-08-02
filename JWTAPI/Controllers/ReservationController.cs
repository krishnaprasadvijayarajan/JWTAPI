﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

//https://www.yogihosting.com/jwt-api-aspnet-core/#api-project
namespace JWTAPI.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IEnumerable<Reservation> Get() => CreateDummyReservations();

        private IEnumerable<Reservation> CreateDummyReservations()
        {
            List<Reservation> rList = new List<Reservation>
            {
                new Reservation {Id=1, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=2, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=3, Name = "Jacky", StartLocation = "London", EndLocation="Paris" }
            };
            return rList;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}