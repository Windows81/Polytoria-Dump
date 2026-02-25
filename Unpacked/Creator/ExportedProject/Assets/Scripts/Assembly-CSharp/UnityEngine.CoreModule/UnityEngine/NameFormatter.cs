namespace UnityEngine;

[NativeHeader("Runtime/NameFormatter/NameFormatter.h")]
[Token(Token = "0x2000189")]
[VisibleToOtherModules]
internal sealed class NameFormatter
{

	[Address(RVA = "0x1965FF0", Offset = "0x19651F0", Length = "0x1D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction]
	[Token(Token = "0x6000B0C")]
	public static string FormatVariableName(string name) { }

	[Address(RVA = "0x1965FA0", Offset = "0x19651A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B0D")]
	private static void FormatVariableName_Injected(ref ManagedSpanWrapper name, out ManagedSpanWrapper ret) { }

}

