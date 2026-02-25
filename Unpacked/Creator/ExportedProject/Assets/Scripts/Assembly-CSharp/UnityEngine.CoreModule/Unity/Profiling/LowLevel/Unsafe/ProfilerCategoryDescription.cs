namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[Token(Token = "0x2000025")]
public struct ProfilerCategoryDescription
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005B")]
	public readonly ushort Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400005C")]
	public readonly ushort Flags; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400005D")]
	public readonly Color32 Color; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400005E")]
	private readonly int reserved0; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400005F")]
	public readonly int NameUtf8Len; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000060")]
	public readonly Byte* NameUtf8; //Field offset: 0x10

}

