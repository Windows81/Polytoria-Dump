namespace GLTFast.Schema;

[Token(Token = "0x200007B")]
public abstract class AccessorBase : AccessorBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000213")]
	public TSparse sparse; //Field offset: 0x0

	[Token(Token = "0x1700002F")]
	public virtual AccessorSparseBase Sparse
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x80BEE0", Offset = "0x80B0E0", Length = "0x7")]
	[CalledBy(Type = typeof(Accessor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AccessorBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AB")]
	protected AccessorBase`1() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A9")]
	public virtual AccessorSparseBase get_Sparse() { }

	[Address(RVA = "0x80BED0", Offset = "0x80B0D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AA")]
	internal virtual void UnsetSparse() { }

}

