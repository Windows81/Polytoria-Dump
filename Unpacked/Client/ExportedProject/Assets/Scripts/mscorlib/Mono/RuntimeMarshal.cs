namespace Mono;

[Token(Token = "0x2000037")]
internal static class RuntimeMarshal
{

	[Address(RVA = "0x12DDBF0", Offset = "0x12DCDF0", Length = "0x22")]
	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000073")]
	internal static int AsciHexDigitValue(int c) { }

	[Address(RVA = "0x12DDC20", Offset = "0x12DCE20", Length = "0xF2")]
	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000072")]
	internal static Byte[] DecodeBlobArray(IntPtr ptr) { }

	[Address(RVA = "0x12DDD20", Offset = "0x12DCF20", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000071")]
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	[Address(RVA = "0x12DDDA0", Offset = "0x12DCFA0", Length = "0x5")]
	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A2E0")]
	[Token(Token = "0x6000074")]
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

	[Address(RVA = "0x12DDDB0", Offset = "0x12DCFB0", Length = "0x2A")]
	[CalledBy(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000070")]
	internal static SafeStringMarshal MarshalString(string str) { }

	[Address(RVA = "0x12DDDE0", Offset = "0x12DCFE0", Length = "0xF0")]
	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600006F")]
	internal static string PtrToUtf8String(IntPtr ptr) { }

}

