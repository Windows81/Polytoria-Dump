namespace GLTFast.Schema;

[Token(Token = "0x200009D")]
public class Material : MaterialBase<MaterialExtensions, NormalTextureInfo, OcclusionTextureInfo, PbrMetallicRoughness, TextureInfo, TextureInfoExtensions>
{

	[Address(RVA = "0x1076170", Offset = "0x1075370", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaterialBase`6), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001E8")]
	public Material() { }

}

