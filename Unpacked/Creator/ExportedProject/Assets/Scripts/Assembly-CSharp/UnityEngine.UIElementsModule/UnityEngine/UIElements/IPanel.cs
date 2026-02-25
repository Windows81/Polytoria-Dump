namespace UnityEngine.UIElements;

[Token(Token = "0x20002AA")]
public interface IPanel : IDisposable
{

	[Token(Token = "0x1700036F")]
	public ContextType contextType
	{
		[Token(Token = "0x600122D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700036E")]
	public EventDispatcher dispatcher
	{
		[Token(Token = "0x600122C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000370")]
	public FocusController focusController
	{
		[Token(Token = "0x600122E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700036D")]
	public VisualElement visualTree
	{
		[Token(Token = "0x600122B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600122D")]
	public ContextType get_contextType() { }

	[Token(Token = "0x600122C")]
	public EventDispatcher get_dispatcher() { }

	[Token(Token = "0x600122E")]
	public FocusController get_focusController() { }

	[Token(Token = "0x600122B")]
	public VisualElement get_visualTree() { }

}

