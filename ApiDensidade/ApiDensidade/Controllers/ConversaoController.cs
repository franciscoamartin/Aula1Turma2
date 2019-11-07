using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDensidade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversaoController : ControllerBase
    {
        [HttpPost]
        public ConversaoController Post (ConversaoController item)
        {
            return item;
        }
    }
}