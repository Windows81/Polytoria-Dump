namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000180")]
internal sealed class XPathNodeInfoAtom
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EB")]
	private string _localName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006EC")]
	private string _namespaceUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006ED")]
	private string _prefix; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006EE")]
	private XPathNode[] _pageParent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006EF")]
	private XPathNode[] _pageSibling; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006F0")]
	private XPathDocument _doc; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006F1")]
	private XPathNodePageInfo _pageInfo; //Field offset: 0x40

	[Token(Token = "0x1700036F")]
	public XPathDocument Document
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D49")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036A")]
	public string LocalName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D44")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036B")]
	public string NamespaceUri
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D45")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000369")]
	public XPathNodePageInfo PageInfo
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D43")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036E")]
	public XPathNode[] ParentPage
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D48")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036C")]
	public string Prefix
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D46")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036D")]
	public XPathNode[] SiblingPage
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D47")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D49")]
	public XPathDocument get_Document() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D44")]
	public string get_LocalName() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D45")]
	public string get_NamespaceUri() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D43")]
	public XPathNodePageInfo get_PageInfo() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D48")]
	public XPathNode[] get_ParentPage() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D46")]
	public string get_Prefix() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D47")]
	public XPathNode[] get_SiblingPage() { }

}

