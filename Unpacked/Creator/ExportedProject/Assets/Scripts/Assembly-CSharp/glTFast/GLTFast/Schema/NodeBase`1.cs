namespace GLTFast.Schema;

[Token(Token = "0x20000BB")]
public abstract class NodeBase : NodeBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A6")]
	public TExtensions extensions; //Field offset: 0x0

	[Token(Token = "0x1700005F")]
	public virtual NodeExtensions Extensions
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000228")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE2B080", Offset = "0xE2A280", Length = "0x7")]
	[CalledBy(Type = typeof(Node), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NodeBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600022A")]
	protected NodeBase`1() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000228")]
	public virtual NodeExtensions get_Extensions() { }

	[Address(RVA = "0x80BED0", Offset = "0x80B0D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000229")]
	internal virtual void UnsetExtensions() { }

}

