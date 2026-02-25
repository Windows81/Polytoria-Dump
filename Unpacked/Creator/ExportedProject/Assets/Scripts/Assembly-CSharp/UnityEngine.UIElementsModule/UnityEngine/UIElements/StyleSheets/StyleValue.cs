namespace UnityEngine.UIElements.StyleSheets;

[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
[Token(Token = "0x200060A")]
internal struct StyleValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001680")]
	public StylePropertyId id; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001681")]
	public StyleKeyword keyword; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001682")]
	public float number; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001683")]
	public Length length; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001684")]
	public Color color; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001685")]
	public GCHandle resource; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001686")]
	public BackgroundPosition position; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001687")]
	public BackgroundRepeat repeat; //Field offset: 0x8

}

