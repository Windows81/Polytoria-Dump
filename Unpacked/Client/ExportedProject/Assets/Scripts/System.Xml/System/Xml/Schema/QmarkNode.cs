namespace System.Xml.Schema;

[Token(Token = "0x20000DB")]
internal sealed class QmarkNode : InteriorNode
{

	[Token(Token = "0x17000205")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008BC")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BD")]
	public QmarkNode() { }

	[Address(RVA = "0x16B0E50", Offset = "0x16B0050", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008BB")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BC")]
	public virtual bool get_IsNullable() { }

}

