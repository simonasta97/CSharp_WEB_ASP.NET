﻿namespace FootballManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserPlayers = new HashSet<UserPlayer>();
        }
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Username { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 10)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<UserPlayer> UserPlayers { get; set; }
    }
}
