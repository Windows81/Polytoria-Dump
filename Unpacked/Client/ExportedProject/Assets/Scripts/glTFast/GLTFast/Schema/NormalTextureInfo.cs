namespace GLTFast.Schema;

[Token(Token = "0x20000BF")]
public class NormalTextureInfo : NormalTextureInfoBase<TextureInfoExtensions>
{

	[Address(RVA = "0x1078850", Offset = "0x1077A50", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000231")]
	public NormalTextureInfo() { }

}

