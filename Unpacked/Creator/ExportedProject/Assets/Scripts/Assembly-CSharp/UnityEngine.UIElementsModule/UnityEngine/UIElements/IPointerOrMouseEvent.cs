namespace UnityEngine.UIElements;

[Token(Token = "0x200021B")]
internal interface IPointerOrMouseEvent
{

	[Token(Token = "0x170002A5")]
	public Vector3 deltaPosition
	{
		[Token(Token = "0x6000EA5")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170002A4")]
	public Vector3 position
	{
		[Token(Token = "0x6000EA4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000EA4")]
	public Vector3 get_position() { }

	[Token(Token = "0x6000EA5")]
	public void set_deltaPosition(Vector3 value) { }

}

