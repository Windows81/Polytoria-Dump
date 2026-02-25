namespace GLTFast.Schema;

[Token(Token = "0x20000C2")]
public class OcclusionTextureInfo : OcclusionTextureInfoBase<TextureInfoExtensions>
{

	[Address(RVA = "0x1078890", Offset = "0x1077A90", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000235")]
	public OcclusionTextureInfo() { }

}

