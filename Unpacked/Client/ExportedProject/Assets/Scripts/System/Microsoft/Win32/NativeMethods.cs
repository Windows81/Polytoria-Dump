namespace Microsoft.Win32;

[Token(Token = "0x20000AB")]
internal static class NativeMethods
{

	[Address(RVA = "0x17433C0", Offset = "0x17425C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802256E0")]
	[Token(Token = "0x6000348")]
	public static bool CloseProcess(IntPtr handle) { }

	[Address(RVA = "0x17433D0", Offset = "0x17425D0", Length = "0x150")]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&), typeof(int), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.MonoIOError"}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000343")]
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	[Address(RVA = "0x1743540", Offset = "0x1742740", Length = "0x5")]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802256F0")]
	[Token(Token = "0x6000344")]
	public static IntPtr GetCurrentProcess() { }

	[Address(RVA = "0x1743530", Offset = "0x1742730", Length = "0x5")]
	[CalledBy(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180225750")]
	[Token(Token = "0x6000347")]
	public static int GetCurrentProcessId() { }

	[Address(RVA = "0x1743620", Offset = "0x1742820", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180225760")]
	[Token(Token = "0x6000345")]
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	[Address(RVA = "0x1743550", Offset = "0x1742750", Length = "0xCA")]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180225760")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000346")]
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

}

