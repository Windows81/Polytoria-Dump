namespace Battlehub.UIControls;

[Token(Token = "0x200000F")]
public interface IUpdateFocusedHandler : IEventSystemHandler
{

	[Token(Token = "0x600003F")]
	public void OnUpdateFocused(BaseEventData eventData) { }

}

