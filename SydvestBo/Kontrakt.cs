﻿using System;
namespace SydvestBo
{
    public class Kontrakt
    {
        public int Id { get; set; }
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public int UdlejerID { get; set; }
        public string Kontrakttype { get; set; }

        public Kontrakt()
        {
        }
    }
}