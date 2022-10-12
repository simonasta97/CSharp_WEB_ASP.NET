﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.ViewModels
{
    public class PlayerViewModel
    {
        public int PlayerId { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }

        public byte Speed { get; set; }

        public byte Endurance { get; set; }
    }
}
