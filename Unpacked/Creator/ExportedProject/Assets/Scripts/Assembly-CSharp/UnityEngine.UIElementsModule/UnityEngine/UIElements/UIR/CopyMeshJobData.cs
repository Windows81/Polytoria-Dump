namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000570")]
internal struct CopyMeshJobData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012C9")]
	public IntPtr vertSrc; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40012CA")]
	public IntPtr vertDst; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012CB")]
	public int vertCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012CC")]
	public IntPtr indexSrc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012CD")]
	public IntPtr indexDst; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012CE")]
	public int indexCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40012CF")]
	public int indexOffset; //Field offset: 0x2C

}

