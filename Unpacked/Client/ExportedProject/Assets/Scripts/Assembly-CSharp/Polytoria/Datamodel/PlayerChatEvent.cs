namespace Polytoria.Datamodel
{
	public class PlayerChatEvent
	{
		public Player Player { get; private set; }

		public string Message { get; private set; }

		public bool Canceled { get; set; }

		public PlayerChatEvent(Player player, string message)
		{
		}
	}
}
