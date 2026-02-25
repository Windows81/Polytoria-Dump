namespace System.Net;

[Token(Token = "0x2000250")]
internal class NetRes
{

	[Address(RVA = "0x17DEE70", Offset = "0x17DE070", Length = "0x143")]
	[CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpStatusCode), typeof(string), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Token(Token = "0x6000ED2")]
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

	[Address(RVA = "0x17DEFC0", Offset = "0x17DE1C0", Length = "0x51")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ED1")]
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	[Address(RVA = "0x17DF020", Offset = "0x17DE220", Length = "0xA6")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000ED0")]
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

}

