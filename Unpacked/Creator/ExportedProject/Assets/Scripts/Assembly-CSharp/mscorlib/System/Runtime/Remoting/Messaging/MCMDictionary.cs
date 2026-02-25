namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AF")]
internal class MCMDictionary : MessageDictionary
{
	[Token(Token = "0x4000ECC")]
	public static String[] InternalKeys; //Field offset: 0x0

	[Address(RVA = "0x1383810", Offset = "0x1382A10", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001C42")]
	private static MCMDictionary() { }

	[Address(RVA = "0x1383990", Offset = "0x1382B90", Length = "0x86")]
	[CalledBy(Type = typeof(MethodCall), Member = "InitDictionary", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C41")]
	public MCMDictionary(IMethodMessage message) { }

}

