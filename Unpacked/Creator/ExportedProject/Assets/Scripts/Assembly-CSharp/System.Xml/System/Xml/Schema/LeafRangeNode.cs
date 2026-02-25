namespace System.Xml.Schema;

[Token(Token = "0x20000DD")]
internal sealed class LeafRangeNode : LeafNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000482")]
	private decimal min; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000483")]
	private decimal max; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000484")]
	private BitSet nextIteration; //Field offset: 0x38

	[Token(Token = "0x17000207")]
	public decimal Max
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C1")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000208")]
	public decimal Min
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C2")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000209")]
	public BitSet NextIteration
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C1")]
	public decimal get_Max() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C2")]
	public decimal get_Min() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C3")]
	public BitSet get_NextIteration() { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C4")]
	public void set_NextIteration(BitSet value) { }

}

