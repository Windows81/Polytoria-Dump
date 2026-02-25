namespace System.Security.Principal;

[ComVisible(True)]
[Token(Token = "0x200032E")]
public class WindowsImpersonationContext : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D9B")]
	private IntPtr _token; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D9C")]
	private bool undo; //Field offset: 0x18

	[Address(RVA = "0x1354950", Offset = "0x1353B50", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C2F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C340")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001983")]
	internal WindowsImpersonationContext(IntPtr token) { }

	[Address(RVA = "0x13547A0", Offset = "0x13539A0", Length = "0x5")]
	[CalledBy(Type = typeof(WindowsImpersonationContext), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsImpersonationContext), Member = "Undo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C2D0")]
	[Token(Token = "0x6001986")]
	private static bool CloseToken(IntPtr token) { }

	[Address(RVA = "0x13547B0", Offset = "0x13539B0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C320")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C2D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WindowsImpersonationContext), Member = "CloseToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ComVisible(False)]
	[Token(Token = "0x6001984")]
	public override void Dispose() { }

	[Address(RVA = "0x1354870", Offset = "0x1353A70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C2F0")]
	[Token(Token = "0x6001987")]
	private static IntPtr DuplicateToken(IntPtr token) { }

	[Address(RVA = "0x1354880", Offset = "0x1353A80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C320")]
	[Token(Token = "0x6001989")]
	private static bool RevertToSelf() { }

	[Address(RVA = "0x1354890", Offset = "0x1353A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C340")]
	[Token(Token = "0x6001988")]
	private static bool SetCurrentToken(IntPtr token) { }

	[Address(RVA = "0x13548A0", Offset = "0x1353AA0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C320")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C2D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WindowsImpersonationContext), Member = "CloseToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001985")]
	public void Undo() { }

}

