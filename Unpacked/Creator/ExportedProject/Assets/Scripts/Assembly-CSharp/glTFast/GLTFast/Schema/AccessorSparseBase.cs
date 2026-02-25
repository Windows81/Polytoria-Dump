namespace GLTFast.Schema;

[Token(Token = "0x200007F")]
public abstract class AccessorSparseBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021F")]
	public int count; //Field offset: 0x10

	[Token(Token = "0x17000034")]
	public abstract AccessorSparseIndices Indices
	{
		[Token(Token = "0x60001B7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000035")]
	public abstract AccessorSparseValues Values
	{
		[Token(Token = "0x60001B8")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B9")]
	protected AccessorSparseBase() { }

	[Token(Token = "0x60001B7")]
	public abstract AccessorSparseIndices get_Indices() { }

	[Token(Token = "0x60001B8")]
	public abstract AccessorSparseValues get_Values() { }

}

