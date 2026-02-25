namespace UnityEngine.Bindings;

[Token(Token = "0x20001D3")]
[VisibleToOtherModules]
internal static class ThrowHelper
{

	[Address(RVA = "0x1990CB0", Offset = "0x198FEB0", Length = "0x76")]
	[CallerCount(Count = 172)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DoesNotReturn]
	[Token(Token = "0x6000C7C")]
	public static void ThrowArgumentNullException(object obj, string parameterName) { }

	[Address(RVA = "0x1990D30", Offset = "0x198FF30", Length = "0x6A")]
	[CallerCount(Count = 1618)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DoesNotReturn]
	[Token(Token = "0x6000C7D")]
	public static void ThrowNullReferenceException(object obj) { }

}

