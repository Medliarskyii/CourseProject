﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShipperDTO
    {
        public int ShipperID { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public string EMail { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
