namespace System.Globalization;

[Token(Token = "0x2000569")]
internal struct InternalCodePageDataItem
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016FB")]
	internal ushort codePage; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40016FC")]
	internal ushort uiFamilyCodePage; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40016FD")]
	internal uint flags; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40016FE")]
	internal string Names; //Field offset: 0x8

}

