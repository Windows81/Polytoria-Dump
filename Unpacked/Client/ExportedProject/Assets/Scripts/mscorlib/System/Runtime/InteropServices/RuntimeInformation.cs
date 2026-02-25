namespace System.Runtime.InteropServices;

[Token(Token = "0x200044C")]
public static class RuntimeInformation
{
	[Token(Token = "0x4001221")]
	private static readonly Architecture _osArchitecture; //Field offset: 0x0
	[Token(Token = "0x4001222")]
	private static readonly Architecture _processArchitecture; //Field offset: 0x4
	[Token(Token = "0x4001223")]
	private static readonly OSPlatform _osPlatform; //Field offset: 0x8

	[Address(RVA = "0x13C7B50", Offset = "0x13C6D50", Length = "0x7E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(OSPlatform), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(OSPlatform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[Token(Token = "0x6001F95")]
	private static RuntimeInformation() { }

	[Address(RVA = "0x13C7A30", Offset = "0x13C6C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAE0")]
	[Token(Token = "0x6001F97")]
	private static string GetOSName() { }

	[Address(RVA = "0x13C7A40", Offset = "0x13C6C40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAF0")]
	[Token(Token = "0x6001F96")]
	private static string GetRuntimeArchitecture() { }

	[Address(RVA = "0x13C7A50", Offset = "0x13C6C50", Length = "0xF4")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "get_ExitCode", ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpServer", Member = "CreateServerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ushort)}, ReturnType = "System.Net.Sockets.Socket")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001F98")]
	public static bool IsOSPlatform(OSPlatform osPlatform) { }

}

