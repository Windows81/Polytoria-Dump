namespace System.Threading;

[Token(Token = "0x200020C")]
internal struct SparselyPopulatedArrayAddInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D2")]
	private SparselyPopulatedArrayFragment<T> _source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D3")]
	private int _index; //Field offset: 0x0

	[Token(Token = "0x170001A0")]
	internal int Index
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001187")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700019F")]
	internal SparselyPopulatedArrayFragment<T> Source
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001186")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001185")]
	internal SparselyPopulatedArrayAddInfo`1(SparselyPopulatedArrayFragment<T> source, int index) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001187")]
	internal int get_Index() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001186")]
	internal SparselyPopulatedArrayFragment<T> get_Source() { }

}

