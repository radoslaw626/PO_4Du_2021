﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PODuSl01.Data.Interfaces
{
    interface IStudent : IOsoba     
    {
         string Uczelnia { get; set; }
         string Kierunek { get; set; }
         string Rok { get; set; }
         string Semestr { get; set; }
                
    }
}