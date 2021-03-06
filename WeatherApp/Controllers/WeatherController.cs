﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult LondonsWeather()
        {
            return View();
        }

        public JsonResult GetLondonsWeather()
        {

            Weather forecast = new Weather();

            return Json(forecast.GetWeather(), JsonRequestBehavior.AllowGet);
        }
    }
}