namespace GLTFast.Schema;

[Token(Token = "0x20000D1")]
public class Texture : TextureBase<TextureExtensions>
{

	[Address(RVA = "0x107AAF0", Offset = "0x1079CF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextureBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600026D")]
	public Texture() { }

}

