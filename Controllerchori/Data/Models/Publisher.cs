﻿using System.Collections.Generic;

namespace Controllerchori.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegación
        public List<Books> Books { get; set; }
    }
}
