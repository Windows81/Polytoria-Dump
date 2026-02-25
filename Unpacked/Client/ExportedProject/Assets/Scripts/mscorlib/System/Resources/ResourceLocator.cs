namespace System.Resources;

[Token(Token = "0x20004B3")]
internal struct ResourceLocator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012CB")]
	internal object _value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40012CC")]
	internal int _dataPos; //Field offset: 0x8

	[Token(Token = "0x17000413")]
	internal int DataPosition
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002109")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000414")]
	internal object Value
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x600210A")]
		internal get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600210B")]
		internal set { } //Length: 8
	}

	[Address(RVA = "0x13AA500", Offset = "0x13A9700", Length = "0xE")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002108")]
	internal ResourceLocator(int dataPos, object value) { }

	[Address(RVA = "0x13C1FF0", Offset = "0x13C11F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600210C")]
	internal static bool CanCache(ResourceTypeCode value) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002109")]
	internal int get_DataPosition() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600210A")]
	internal object get_Value() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600210B")]
	internal void set_Value(object value) { }

}

