using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpelt_spil.Music
{
    class Music
    {
        public static void Player(string playSwitch)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = $"{AppDomain.CurrentDomain.BaseDirectory}\\Music\\{playSwitch}.wav";
            player.PlayLooping();
        }
    }
}
