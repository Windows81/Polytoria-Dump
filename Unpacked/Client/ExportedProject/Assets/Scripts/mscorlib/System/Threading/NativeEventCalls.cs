namespace System.Threading;

[Token(Token = "0x200023E")]
internal static class NativeEventCalls
{

	[Address(RVA = "0x152B070", Offset = "0x152A270", Length = "0x5")]
	[CalledBy(Type = typeof(SafeWaitHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D520")]
	[Token(Token = "0x60012E0")]
	public static void CloseEvent_internal(IntPtr handle) { }

	[Address(RVA = "0x152B080", Offset = "0x152A280", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D5A0")]
	[Token(Token = "0x60012DB")]
	private static IntPtr CreateEvent_icall(bool manual, bool initial, Char* name, int name_length, out int errorCode) { }

	[Address(RVA = "0x152B090", Offset = "0x152A290", Length = "0x61")]
	[CalledBy(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D5A0")]
	[Token(Token = "0x60012DA")]
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	[Address(RVA = "0x152B110", Offset = "0x152A310", Length = "0xC4")]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D8D0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60012DE")]
	public static bool ResetEvent(SafeWaitHandle handle) { }

	[Address(RVA = "0x152B100", Offset = "0x152A300", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D8D0")]
	[Token(Token = "0x60012DF")]
	private static bool ResetEvent_internal(IntPtr handle) { }

	[Address(RVA = "0x152B1F0", Offset = "0x152A3F0", Length = "0xC4")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D8F0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60012DC")]
	public static bool SetEvent(SafeWaitHandle handle) { }

	[Address(RVA = "0x152B1E0", Offset = "0x152A3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D8F0")]
	[Token(Token = "0x60012DD")]
	private static bool SetEvent_internal(IntPtr handle) { }

}

