namespace SoftMasking;

[Token(Token = "0x200000E")]
public static class MaskChannel
{
	[Token(Token = "0x4000016")]
	public static Color alpha; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	public static Color red; //Field offset: 0x10
	[Token(Token = "0x4000018")]
	public static Color green; //Field offset: 0x20
	[Token(Token = "0x4000019")]
	public static Color blue; //Field offset: 0x30
	[Token(Token = "0x400001A")]
	public static Color gray; //Field offset: 0x40

	[Address(RVA = "0x1562210", Offset = "0x1561410", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600002B")]
	private static MaskChannel() { }

}

