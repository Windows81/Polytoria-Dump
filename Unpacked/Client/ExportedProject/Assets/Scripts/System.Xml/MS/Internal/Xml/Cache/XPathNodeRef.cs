namespace MS.Internal.Xml.Cache;

[Token(Token = "0x200017D")]
internal struct XPathNodeRef
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E6")]
	private XPathNode[] _page; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006E7")]
	private int _idx; //Field offset: 0x8

	[Token(Token = "0x17000365")]
	public int Index
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D38")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000364")]
	public XPathNode[] Page
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D37")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D36")]
	public XPathNodeRef(XPathNode[] page, int idx) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D38")]
	public int get_Index() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D37")]
	public XPathNode[] get_Page() { }

	[Address(RVA = "0x16E5230", Offset = "0x16E4430", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D39")]
	public virtual int GetHashCode() { }

}

