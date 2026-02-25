namespace GLTFast.Schema;

[Token(Token = "0x20000AE")]
public abstract class MeshBase : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027E")]
	public Single[] weights; //Field offset: 0x18

	[Token(Token = "0x1700005C")]
	public abstract MeshExtras Extras
	{
		[Token(Token = "0x6000212")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700005B")]
	public abstract IReadOnlyList<MeshPrimitiveBase> Primitives
	{
		[Token(Token = "0x6000211")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000213")]
	protected MeshBase() { }

	[Token(Token = "0x6000212")]
	public abstract MeshExtras get_Extras() { }

	[Token(Token = "0x6000211")]
	public abstract IReadOnlyList<MeshPrimitiveBase> get_Primitives() { }

}

