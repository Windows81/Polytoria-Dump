namespace Mirror.SimpleWeb;

[Token(Token = "0x2000013")]
internal static class Constants
{
	[Token(Token = "0x400003B")]
	public const int HeaderSize = 4; //Field offset: 0x0
	[Token(Token = "0x400003C")]
	public const int HeaderMinSize = 2; //Field offset: 0x0
	[Token(Token = "0x400003D")]
	public const int ShortLength = 2; //Field offset: 0x0
	[Token(Token = "0x400003E")]
	public const int LongLength = 8; //Field offset: 0x0
	[Token(Token = "0x400003F")]
	public const int MaskSize = 4; //Field offset: 0x0
	[Token(Token = "0x4000040")]
	public const int BytePayloadLength = 125; //Field offset: 0x0
	[Token(Token = "0x4000041")]
	public const int UshortPayloadLength = 126; //Field offset: 0x0
	[Token(Token = "0x4000042")]
	public const int UlongPayloadLength = 127; //Field offset: 0x0
	[Token(Token = "0x4000043")]
	public const string HandshakeGUID = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"; //Field offset: 0x0
	[Token(Token = "0x4000044")]
	public static readonly int HandshakeGUIDLength; //Field offset: 0x0
	[Token(Token = "0x4000045")]
	public static readonly Byte[] HandshakeGUIDBytes; //Field offset: 0x8
	[Token(Token = "0x4000046")]
	public static readonly Byte[] endOfHandshake; //Field offset: 0x10

	[Address(RVA = "0x1555EC0", Offset = "0x15550C0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	private static Constants() { }

}

