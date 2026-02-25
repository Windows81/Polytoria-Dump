namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056E")]
internal struct NudgeJobData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012AD")]
	public IntPtr headSrc; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40012AE")]
	public IntPtr headDst; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012AF")]
	public int headCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012B0")]
	public IntPtr tailSrc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012B1")]
	public IntPtr tailDst; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012B2")]
	public int tailCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40012B3")]
	public Matrix4x4 transform; //Field offset: 0x2C

}

