﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ruta40.Site.Models;

namespace Ruta40.Site.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}