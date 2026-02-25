namespace GLTFast.Schema;

[Token(Token = "0x20000D2")]
public abstract class TextureBase : TextureBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E9")]
	public TExtensions extensions; //Field offset: 0x0

	[Token(Token = "0x17000085")]
	public virtual TextureExtensions Extensions
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xFF7D80", Offset = "0xFF6F80", Length = "0x7")]
	[CalledBy(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026F")]
	protected TextureBase`1() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026E")]
	public virtual TextureExtensions get_Extensions() { }

}

