namespace System.Xml;

[DefaultMember("ItemOf")]
[Token(Token = "0x2000087")]
public abstract class XmlNodeList : IEnumerable, IDisposable
{

	[Token(Token = "0x17000191")]
	public abstract int Count
	{
		[Token(Token = "0x600066B")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600066F")]
	protected XmlNodeList() { }

	[Token(Token = "0x600066B")]
	public abstract int get_Count() { }

	[Token(Token = "0x600066C")]
	public abstract IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600066E")]
	protected override void PrivateDisposeNodeList() { }

	[Address(RVA = "0x14EC920", Offset = "0x14EBB20", Length = "0x14")]
	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600066D")]
	private override void System.IDisposable.Dispose() { }

}

