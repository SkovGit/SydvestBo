using System;
namespace SydvestBo
{
    public class Feriebolig_status
    {
        public int Id { get; set; }
        public byte Passiv { get; set; }
        public byte Aktiv { get; set; }
        public DateTime Ændringsdato { get; set; }
        public DateTime Udløbsdato { get; set; }

        public Feriebolig_status()
        {
        }
    }
}
