﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceLayer.Controllers
{
    public class HelloController : ApiController
    {
        [HttpGet]
        public string SayHello(string nome)
        {
            return "Hello "+nome;
        }
    }
}
