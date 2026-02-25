namespace System;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000E5")]
internal struct DTSubString
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400037A")]
	internal ReadOnlySpan<Char> s; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037B")]
	internal int index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400037C")]
	internal int length; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400037D")]
	internal DTSubStringType type; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400037E")]
	internal int value; //Field offset: 0x1C

	[Token(Token = "0x17000087")]
	internal char Item
	{
		[Address(RVA = "0x149A840", Offset = "0x1499A40", Length = "0x25")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000743")]
		internal get { } //Length: 37
	}

	[Address(RVA = "0x149A840", Offset = "0x1499A40", Length = "0x25")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000743")]
	internal char get_Item(int relativeIndex) { }

}

