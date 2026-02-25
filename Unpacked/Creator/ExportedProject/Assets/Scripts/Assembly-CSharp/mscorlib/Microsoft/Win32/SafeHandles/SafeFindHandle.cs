namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000086")]
internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x12FCE10", Offset = "0x12FC010", Length = "0xD")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600024B")]
	internal SafeFindHandle() { }

	[Address(RVA = "0x12FCDC0", Offset = "0x12FBFC0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "FindCloseFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600024C")]
	protected virtual bool ReleaseHandle() { }

}

