using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkAlbion
{

    public class InfoJogador
    {
        public object[] guilds { get; set; }
        public Player[] players { get; set; }
    }

    public class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GuildId { get; set; }
        public string GuildName { get; set; }
        public string AllianceId { get; set; }
        public string AllianceName { get; set; }
        public string Avatar { get; set; }
        public string AvatarRing { get; set; }
        public int KillFame { get; set; }
        public int DeathFame { get; set; }
        public float FameRatio { get; set; }
        public object totalKills { get; set; }
        public object gvgKills { get; set; }
        public object gvgWon { get; set; }
    }
}

