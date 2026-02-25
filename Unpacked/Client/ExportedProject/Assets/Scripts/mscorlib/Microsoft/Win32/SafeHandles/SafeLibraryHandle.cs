namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000082")]
internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x12FCE10", Offset = "0x12FC010", Length = "0xD")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600023D")]
	internal SafeLibraryHandle() { }

	[Address(RVA = "0x12FCF10", Offset = "0x12FC110", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel32), Member = "FreeLibrary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600023E")]
	protected virtual bool ReleaseHandle() { }

}

