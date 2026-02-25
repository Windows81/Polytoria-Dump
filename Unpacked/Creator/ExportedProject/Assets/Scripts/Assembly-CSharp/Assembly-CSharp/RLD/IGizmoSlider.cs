namespace RLD;

[Token(Token = "0x20000FF")]
public interface IGizmoSlider
{

	[Token(Token = "0x170002E8")]
	public Priority GenericHoverPriority
	{
		[Token(Token = "0x600093B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E4")]
	public Gizmo Gizmo
	{
		[Token(Token = "0x6000937")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E5")]
	public int HandleId
	{
		[Token(Token = "0x6000938")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E7")]
	public Priority HoverPriority2D
	{
		[Token(Token = "0x600093A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E6")]
	public Priority HoverPriority3D
	{
		[Token(Token = "0x6000939")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600093B")]
	public Priority get_GenericHoverPriority() { }

	[Token(Token = "0x6000937")]
	public Gizmo get_Gizmo() { }

	[Token(Token = "0x6000938")]
	public int get_HandleId() { }

	[Token(Token = "0x600093A")]
	public Priority get_HoverPriority2D() { }

	[Token(Token = "0x6000939")]
	public Priority get_HoverPriority3D() { }

	[Token(Token = "0x600093F")]
	public void Render(Camera camera) { }

	[Token(Token = "0x600093C")]
	public void SetHoverable(bool isHoverable) { }

	[Token(Token = "0x600093E")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Token(Token = "0x600093D")]
	public void SetVisible(bool isVisible) { }

}

