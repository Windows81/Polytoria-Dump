namespace System.Xml.Linq;

[Token(Token = "0x2000017")]
internal class XObjectChangeAnnotation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000036")]
	internal EventHandler<XObjectChangeEventArgs> changing; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000037")]
	internal EventHandler<XObjectChangeEventArgs> changed; //Field offset: 0x18

}

