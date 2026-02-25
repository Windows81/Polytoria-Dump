namespace GLTFast.Schema;

[Token(Token = "0x20000B5")]
public abstract class MeshPrimitiveBase : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028D")]
	public Attributes attributes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400028E")]
	public int indices; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400028F")]
	public int material; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000290")]
	public DrawMode mode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000291")]
	public MorphTarget[] targets; //Field offset: 0x28

	[Token(Token = "0x1700005E")]
	public abstract MeshPrimitiveExtensions Extensions
	{
		[Token(Token = "0x600021A")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1076B70", Offset = "0x1075D70", Length = "0x16")]
	[CalledBy(Type = typeof(MeshPrimitiveBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	protected MeshPrimitiveBase() { }

	[Address(RVA = "0x1076940", Offset = "0x1075B40", Length = "0x7")]
	[CallerCount(Count = 134)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021D")]
	public override object Clone() { }

	[Address(RVA = "0x1076950", Offset = "0x1075B50", Length = "0x1A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021B")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x600021A")]
	public abstract MeshPrimitiveExtensions get_Extensions() { }

	[Address(RVA = "0x1076B00", Offset = "0x1075D00", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600021C")]
	public virtual int GetHashCode() { }

}

