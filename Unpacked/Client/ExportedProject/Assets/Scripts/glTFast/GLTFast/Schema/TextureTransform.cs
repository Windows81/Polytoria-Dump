namespace GLTFast.Schema;

[Token(Token = "0x20000DA")]
public class TextureTransform
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F2")]
	public Single[] offset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F3")]
	public float rotation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F4")]
	public Single[] scale; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F5")]
	public int texCoord; //Field offset: 0x28

	[Address(RVA = "0x107AA40", Offset = "0x1079C40", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600027E")]
	public TextureTransform() { }

}

