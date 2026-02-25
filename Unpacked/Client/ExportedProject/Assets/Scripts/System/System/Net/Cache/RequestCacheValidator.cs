namespace System.Net.Cache;

[Token(Token = "0x20002D8")]
internal class RequestCacheValidator
{

	[Address(RVA = "0x1701180", Offset = "0x1700380", Length = "0x3E")]
	[CalledBy(Type = typeof(WebRequest), Member = "set_CachePolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestCachePolicy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "InternalSetCachePolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestCachePolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600121C")]
	public object CreateValidator() { }

}

