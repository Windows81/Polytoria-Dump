namespace UnityEngine;

[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
[Token(Token = "0x200007E")]
internal class BootConfigData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017E")]
	private IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x191ED80", Offset = "0x191DF80", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600019D")]
	private BootConfigData(IntPtr nativeHandle) { }

	[Address(RVA = "0x191ECD0", Offset = "0x191DED0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600019C")]
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

}

