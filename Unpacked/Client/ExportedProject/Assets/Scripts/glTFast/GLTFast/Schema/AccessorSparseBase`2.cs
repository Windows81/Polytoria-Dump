namespace GLTFast.Schema;

[Token(Token = "0x200007E")]
public abstract class AccessorSparseBase : AccessorSparseBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021D")]
	public TIndices indices; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021E")]
	public TValues values; //Field offset: 0x0

	[Token(Token = "0x17000032")]
	public virtual AccessorSparseIndices Indices
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000033")]
	public virtual AccessorSparseValues Values
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B6")]
	protected AccessorSparseBase`2() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B4")]
	public virtual AccessorSparseIndices get_Indices() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B5")]
	public virtual AccessorSparseValues get_Values() { }

}

