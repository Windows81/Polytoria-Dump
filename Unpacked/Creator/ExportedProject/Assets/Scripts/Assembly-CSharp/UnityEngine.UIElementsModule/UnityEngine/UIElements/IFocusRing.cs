namespace UnityEngine.UIElements;

[Token(Token = "0x200024F")]
public interface IFocusRing
{

	[Token(Token = "0x6000FE4")]
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[Token(Token = "0x6000FE5")]
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

}

