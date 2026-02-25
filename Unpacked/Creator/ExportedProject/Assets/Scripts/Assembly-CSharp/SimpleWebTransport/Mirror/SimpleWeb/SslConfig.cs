namespace Mirror.SimpleWeb;

[Token(Token = "0x2000028")]
public struct SslConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007E")]
	public readonly bool enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007F")]
	public readonly string certPath; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000080")]
	public readonly string certPassword; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000081")]
	public readonly SslProtocols sslProtocols; //Field offset: 0x18

	[Address(RVA = "0x155DD20", Offset = "0x155CF20", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000A4")]
	public SslConfig(bool enabled, string certPath, string certPassword, SslProtocols sslProtocols) { }

}

