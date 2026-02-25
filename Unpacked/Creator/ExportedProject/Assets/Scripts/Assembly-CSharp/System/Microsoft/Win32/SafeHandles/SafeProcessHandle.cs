namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x20000AC")]
public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[Token(Token = "0x4000201")]
	internal static SafeProcessHandle InvalidHandle; //Field offset: 0x0

	[Address(RVA = "0x1745F30", Offset = "0x1745130", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600034C")]
	private static SafeProcessHandle() { }

	[Address(RVA = "0x1745FB0", Offset = "0x17451B0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000349")]
	internal SafeProcessHandle(IntPtr handle) { }

	[Address(RVA = "0x1745FE0", Offset = "0x17451E0", Length = "0x2E")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600034A")]
	public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) { }

	[Address(RVA = "0x1745F20", Offset = "0x1745120", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802256E0")]
	[Token(Token = "0x600034B")]
	protected virtual bool ReleaseHandle() { }

}

