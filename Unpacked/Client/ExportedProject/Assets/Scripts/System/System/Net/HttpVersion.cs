namespace System.Net;

[Token(Token = "0x2000208")]
public class HttpVersion
{
	[Token(Token = "0x40007E4")]
	public static readonly Version Unknown; //Field offset: 0x0
	[Token(Token = "0x40007E5")]
	public static readonly Version Version10; //Field offset: 0x8
	[Token(Token = "0x40007E6")]
	public static readonly Version Version11; //Field offset: 0x10
	[Token(Token = "0x40007E7")]
	public static readonly Version Version20; //Field offset: 0x18

	[Address(RVA = "0x17C1340", Offset = "0x17C0540", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000CF0")]
	private static HttpVersion() { }

}

