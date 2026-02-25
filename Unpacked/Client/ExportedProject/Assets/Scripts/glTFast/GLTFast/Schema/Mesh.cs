namespace GLTFast.Schema;

[Token(Token = "0x20000AC")]
public class Mesh : MeshBase<MeshExtras, MeshPrimitive>
{

	[Address(RVA = "0x1076C20", Offset = "0x1075E20", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600020C")]
	public Mesh() { }

}

