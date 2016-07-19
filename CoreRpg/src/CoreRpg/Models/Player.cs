using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRpg.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Registered { get; set; }
        public DateTime LastLogin { get; set; }
        public string LastIP { get; set; }
        public uint Level { get; set; }
        public uint Strength { get; set; }
        public uint Intelligence { get; set; }
        public uint Agility { get; set; }
        public uint Elo { get; set; }
        public uint Money { get; set; }
        public IList<Skill> Skills { get; set; }
        public IList<Item> Items { get; set; }
        public IList<Player> Friends { get; set; }
        public IList<Message> Messages { get; set; }
        public IList<Archievement> Archievements { get; set; }
        public IList<Battle> Battles { get; set; }
        public IList<Mission> Missions { get; set; }
    }
}
