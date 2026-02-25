namespace RLD;

[Token(Token = "0x200002A")]
public interface IGizmoCap
{

	[Token(Token = "0x17000051")]
	public Priority GenericHoverPriority
	{
		[Token(Token = "0x600015B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004D")]
	public Gizmo Gizmo
	{
		[Token(Token = "0x6000157")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004E")]
	public int HandleId
	{
		[Token(Token = "0x6000158")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000050")]
	public Priority HoverPriority2D
	{
		[Token(Token = "0x600015A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004F")]
	public Priority HoverPriority3D
	{
		[Token(Token = "0x6000159")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600015B")]
	public Priority get_GenericHoverPriority() { }

	[Token(Token = "0x6000157")]
	public Gizmo get_Gizmo() { }

	[Token(Token = "0x6000158")]
	public int get_HandleId() { }

	[Token(Token = "0x600015A")]
	public Priority get_HoverPriority2D() { }

	[Token(Token = "0x6000159")]
	public Priority get_HoverPriority3D() { }

	[Token(Token = "0x600015E")]
	public void Render(Camera camera) { }

	[Token(Token = "0x600015C")]
	public void SetHoverable(bool isHoverable) { }

	[Token(Token = "0x600015D")]
	public void SetVisible(bool isVisible) { }

}

