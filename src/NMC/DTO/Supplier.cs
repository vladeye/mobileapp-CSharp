using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Supplier : ItemGeneral
    {
        public decimal Ranking { get; set; }
        public int Votos { get; set; }
    }
}