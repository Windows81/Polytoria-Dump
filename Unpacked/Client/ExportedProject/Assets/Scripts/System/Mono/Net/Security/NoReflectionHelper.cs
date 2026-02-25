namespace Mono.Net.Security;

[Token(Token = "0x2000064")]
internal static class NoReflectionHelper
{

	[Address(RVA = "0x15FC8C0", Offset = "0x15FBAC0", Length = "0x71")]
	[CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
	[Token(Token = "0x6000185")]
	internal static object GetProvider() { }

}

