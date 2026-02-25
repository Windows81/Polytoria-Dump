namespace GLTFast.Schema;

[Token(Token = "0x20000BC")]
public abstract class NodeBase : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A7")]
	public UInt32[] children; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A8")]
	public int mesh; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A9")]
	public Single[] matrix; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002AA")]
	public Single[] rotation; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002AB")]
	public Single[] scale; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002AC")]
	public Single[] translation; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002AD")]
	public int skin; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40002AE")]
	public int camera; //Field offset: 0x4C

	[Token(Token = "0x17000060")]
	public abstract NodeExtensions Extensions
	{
		[Token(Token = "0x600022B")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x10782D0", Offset = "0x10774D0", Length = "0x16")]
	[CalledBy(Type = typeof(NodeBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600022E")]
	protected NodeBase() { }

	[Token(Token = "0x600022B")]
	public abstract NodeExtensions get_Extensions() { }

	[Address(RVA = "0x1078230", Offset = "0x1077430", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600022D")]
	public override void JsonUtilityCleanup() { }

	[Token(Token = "0x600022C")]
	internal abstract void UnsetExtensions() { }

}

