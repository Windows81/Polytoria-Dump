namespace GLTFast.Schema;

[Token(Token = "0x20000A3")]
public class PbrMetallicRoughness : PbrMetallicRoughnessBase<TextureInfo>
{

	[Address(RVA = "0x10789D0", Offset = "0x1077BD0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PbrMetallicRoughnessBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001FD")]
	public PbrMetallicRoughness() { }

}

