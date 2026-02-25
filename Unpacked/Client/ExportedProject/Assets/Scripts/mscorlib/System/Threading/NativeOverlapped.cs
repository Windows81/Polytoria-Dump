namespace System.Threading;

[Token(Token = "0x20001FE")]
public struct NativeOverlapped
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009AC")]
	public IntPtr InternalLow; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009AD")]
	public IntPtr InternalHigh; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009AE")]
	public int OffsetLow; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009AF")]
	public int OffsetHigh; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009B0")]
	public IntPtr EventHandle; //Field offset: 0x18

}

