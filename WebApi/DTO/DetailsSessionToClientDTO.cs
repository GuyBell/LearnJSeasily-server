﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.DTO
{
    public class DetailsSessionToClientDTO
    {
        public int BlockId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string CorrectCode { get; set; }
    }
}