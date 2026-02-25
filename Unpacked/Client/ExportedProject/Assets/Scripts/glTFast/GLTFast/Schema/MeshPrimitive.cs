namespace GLTFast.Schema;

[Token(Token = "0x20000B3")]
public class MeshPrimitive : MeshPrimitiveBase<MeshPrimitiveExtensions>
{

	[Address(RVA = "0x1076B90", Offset = "0x1075D90", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshPrimitiveBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000217")]
	public MeshPrimitive() { }

}

