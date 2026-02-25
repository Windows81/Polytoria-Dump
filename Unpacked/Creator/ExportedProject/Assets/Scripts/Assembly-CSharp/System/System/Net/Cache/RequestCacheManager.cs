namespace System.Net.Cache;

[Token(Token = "0x20002D7")]
internal sealed class RequestCacheManager
{
	[Token(Token = "0x4000C75")]
	private static RequestCachingSectionInternal s_CacheConfigSettings; //Field offset: 0x0
	[Token(Token = "0x4000C76")]
	private static readonly RequestCacheBinding s_BypassCacheBinding; //Field offset: 0x8
	[Token(Token = "0x4000C77")]
	private static RequestCacheBinding s_DefaultGlobalBinding; //Field offset: 0x10
	[Token(Token = "0x4000C78")]
	private static RequestCacheBinding s_DefaultHttpBinding; //Field offset: 0x18
	[Token(Token = "0x4000C79")]
	private static RequestCacheBinding s_DefaultFtpBinding; //Field offset: 0x20

	[Address(RVA = "0x1700F40", Offset = "0x1700140", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600121B")]
	private static RequestCacheManager() { }

	[Address(RVA = "0x1700B40", Offset = "0x16FFD40", Length = "0x287")]
	[CalledBy(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(RequestCacheManager), Member = "LoadConfigSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001219")]
	internal static RequestCacheBinding GetBinding(string internedScheme) { }

	[Address(RVA = "0x1700DD0", Offset = "0x16FFFD0", Length = "0x160")]
	[CalledBy(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RequestCacheBinding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600121A")]
	private static void LoadConfigSettings() { }

}

