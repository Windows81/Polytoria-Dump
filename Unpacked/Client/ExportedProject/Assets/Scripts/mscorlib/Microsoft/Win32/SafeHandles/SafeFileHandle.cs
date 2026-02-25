namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000085")]
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x12FCD90", Offset = "0x12FBF90", Length = "0x29")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[Address(RVA = "0x12FCD20", Offset = "0x12FBF20", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600024A")]
	protected virtual bool ReleaseHandle() { }

}

