namespace UnityEngine;

[Token(Token = "0x2000007")]
internal static class SubsystemDescriptorBindings
{

	[Address(RVA = "0x1A19C50", Offset = "0x1A18E50", Length = "0xAC")]
	[CalledBy(Type = typeof(IntegratedSubsystemDescriptor), Member = "get_id", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public static string GetId(IntPtr descriptorPtr) { }

	[Address(RVA = "0x1A19C00", Offset = "0x1A18E00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	private static void GetId_Injected(IntPtr descriptorPtr, out ManagedSpanWrapper ret) { }

}

