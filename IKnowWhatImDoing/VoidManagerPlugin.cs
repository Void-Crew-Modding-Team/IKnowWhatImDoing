using VoidManager.MPModChecks;

namespace IKnowWhatImDoing
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107";

        public override string Description => "Skips all confirmation popups";
    }
}
