using Rocket.Core.Plugins;
using Rocket.API;
using Rocket.Unturned;
using Rocket.Unturned.Player;

namespace BetterSurrender
{
    public class Main : RocketPlugin
    {
        public static Main Instance;

        protected override void Load()
        {
            base.Load();
            Instance = this;

            U.Events.OnPlayerConnected += (UnturnedPlayer player) =>
            {
                if (player.HasPermission("bettersurrender"))
                {
                    player.Events.OnUpdateGesture += PlayerEvents.GestureHandler;
                }
            };
        }

        protected override void Unload()
        {
            base.Unload();
        }

        private void FixedUpdate()
        {
            if (this.State != PluginState.Loaded)
            {
                return;
            }
        }
    }
}
