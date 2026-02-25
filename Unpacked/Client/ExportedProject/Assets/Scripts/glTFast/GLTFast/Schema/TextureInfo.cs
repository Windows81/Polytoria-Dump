namespace GLTFast.Schema;

[Token(Token = "0x20000D6")]
public class TextureInfo : TextureInfoBase<TextureInfoExtensions>
{

	[Address(RVA = "0x107AA00", Offset = "0x1079C00", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextureInfoBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000278")]
	public TextureInfo() { }

}

