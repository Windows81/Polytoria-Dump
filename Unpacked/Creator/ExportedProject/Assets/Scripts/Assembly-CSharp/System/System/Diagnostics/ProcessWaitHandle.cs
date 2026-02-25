namespace System.Diagnostics;

[Token(Token = "0x2000109")]
internal class ProcessWaitHandle : WaitHandle
{

	[Address(RVA = "0x17802A0", Offset = "0x177F4A0", Length = "0x5F")]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000660")]
	internal ProcessWaitHandle(SafeProcessHandle processHandle) { }

}

