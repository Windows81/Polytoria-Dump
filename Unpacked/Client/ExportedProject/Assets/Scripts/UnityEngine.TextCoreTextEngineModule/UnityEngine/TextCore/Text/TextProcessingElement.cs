namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
[Token(Token = "0x200004F")]
internal struct TextProcessingElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F2")]
	public TextProcessingElementType elementType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002F3")]
	public uint unicode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002F4")]
	public int stringIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002F5")]
	public int length; //Field offset: 0xC

}

