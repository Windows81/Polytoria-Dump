namespace UnityEngine;

[Token(Token = "0x2000150")]
internal static class ManagedStreamHelpers
{

	[Address(RVA = "0x1963890", Offset = "0x1962A90", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedStreamHelpers), Member = "ValidateLoadFromStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60009A8")]
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

	[Address(RVA = "0x1963950", Offset = "0x1962B50", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedStreamHelpers), Member = "ValidateLoadFromStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60009A6")]
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[Address(RVA = "0x1963A50", Offset = "0x1962C50", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedStreamHelpers), Member = "ValidateLoadFromStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60009A7")]
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[Address(RVA = "0x1963B30", Offset = "0x1962D30", Length = "0x166")]
	[CalledBy(Type = typeof(ManagedStreamHelpers), Member = "ManagedStreamRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Stream), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManagedStreamHelpers), Member = "ManagedStreamSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(uint), typeof(Stream), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManagedStreamHelpers), Member = "ManagedStreamLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009A5")]
	internal static void ValidateLoadFromStream(Stream stream) { }

}

