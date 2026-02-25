namespace UnityEngine.Rendering;

[Token(Token = "0x20002DB")]
public struct BatchDrawRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400087E")]
	public BatchDrawCommandType drawCommandsType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400087F")]
	public uint drawCommandsBegin; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000880")]
	public uint drawCommandsCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000881")]
	public BatchFilterSettings filterSettings; //Field offset: 0x10

}

