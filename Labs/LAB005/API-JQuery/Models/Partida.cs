﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_JQuery.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }
        public string TimeA { get; set; }
        public string TimeB { get; set; }
    }
}