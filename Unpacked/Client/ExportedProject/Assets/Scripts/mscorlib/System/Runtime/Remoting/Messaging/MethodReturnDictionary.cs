namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003B3")]
internal class MethodReturnDictionary : MessageDictionary
{
	[Token(Token = "0x4000EE3")]
	public static String[] InternalReturnKeys; //Field offset: 0x0
	[Token(Token = "0x4000EE4")]
	public static String[] InternalExceptionKeys; //Field offset: 0x8

	[Address(RVA = "0x13896A0", Offset = "0x13888A0", Length = "0x207")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001C76")]
	private static MethodReturnDictionary() { }

	[Address(RVA = "0x13898B0", Offset = "0x1388AB0", Length = "0xD7")]
	[CalledBy(Type = typeof(ConstructionResponse), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C75")]
	public MethodReturnDictionary(IMethodReturnMessage message) { }

}

