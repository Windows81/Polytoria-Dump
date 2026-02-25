namespace System.Xml.Schema;

[Token(Token = "0x20000D3")]
internal abstract class SyntaxTreeNode
{

	[Token(Token = "0x170001FB")]
	public abstract bool IsNullable
	{
		[Token(Token = "0x6000899")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001FC")]
	public override bool IsRangeNode
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600089A")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600089B")]
	protected SyntaxTreeNode() { }

	[Token(Token = "0x6000898")]
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Token(Token = "0x6000897")]
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Token(Token = "0x6000899")]
	public abstract bool get_IsNullable() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600089A")]
	public override bool get_IsRangeNode() { }

}

