namespace MS.Internal.Xml.Cache;

[Token(Token = "0x200017F")]
internal sealed class XPathNodePageInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E8")]
	private int _pageNum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006E9")]
	private int _nodeCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006EA")]
	private XPathNode[] _pageNext; //Field offset: 0x18

	[Token(Token = "0x17000368")]
	public XPathNode[] NextPage
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D42")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000367")]
	public int NodeCount
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D41")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000366")]
	public int PageNumber
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D40")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D42")]
	public XPathNode[] get_NextPage() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D41")]
	public int get_NodeCount() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D40")]
	public int get_PageNumber() { }

}

