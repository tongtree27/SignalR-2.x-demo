﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Web.BackCompatClients
{
    public class ShinyNewHub : Hub
    {
        public string NewMethod()
        {
            return "Result from SignalR 2.x hub!";
        }
    }
}