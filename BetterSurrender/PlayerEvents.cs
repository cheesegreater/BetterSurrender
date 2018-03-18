using Rocket.Unturned.Player;
using static Rocket.Unturned.Events.UnturnedPlayerEvents;

namespace BetterSurrender
{
    class PlayerEvents
    {
        public static void GestureHandler(UnturnedPlayer player, PlayerGesture gesture)
        {
            if (gesture == PlayerGesture.SurrenderStart)
            {
                player.GodMode = true;
            }
            else
            {
                player.GodMode = false;
            }
        }
    }
}
