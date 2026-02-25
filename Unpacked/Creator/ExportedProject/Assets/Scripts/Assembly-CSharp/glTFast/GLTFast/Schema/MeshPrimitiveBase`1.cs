namespace GLTFast.Schema;

[Token(Token = "0x20000B4")]
public class MeshPrimitiveBase : MeshPrimitiveBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028C")]
	public TExtensions extensions; //Field offset: 0x0

	[Token(Token = "0x1700005D")]
	public virtual MeshPrimitiveExtensions Extensions
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000218")]
		 get { } //Length: 95
	}

	[Address(RVA = "0xE0A960", Offset = "0xE09B60", Length = "0x7")]
	[CalledBy(Type = typeof(MeshPrimitive), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshPrimitiveBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000219")]
	public MeshPrimitiveBase`1() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000218")]
	public virtual MeshPrimitiveExtensions get_Extensions() { }

}

