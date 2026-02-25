namespace System.Reflection;

[Token(Token = "0x2000509")]
internal struct MonoEventInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001468")]
	public Type declaring_type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001469")]
	public Type reflected_type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400146A")]
	public string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400146B")]
	public MethodInfo add_method; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400146C")]
	public MethodInfo remove_method; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400146D")]
	public MethodInfo raise_method; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400146E")]
	public EventAttributes attrs; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400146F")]
	public MethodInfo[] other_methods; //Field offset: 0x38

}

