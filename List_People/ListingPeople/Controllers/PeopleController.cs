using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ListingPeople.Models;

namespace ListingPeople.Controllers
{
    public class PeopleController : ApiController
    {
        ContextDB contextDB = new ContextDB();

        
        //List<People> peoplesList = new List<People>()
        //{
        //    new People(){Name="Anuxki",Age=90},
        //    new People(){Name="Nuki",Age=80},
        //    new People(){Name="Nuska",Age=70},
        //    new People(){Name="Anuzka",Age=60},
        //    new People(){Name="Anucha",Age=50},
        //    new People(){Name="Lavanda",Age=40},
        //    new People(){Name="Nuski",Age=30},

        //};


    }
}
