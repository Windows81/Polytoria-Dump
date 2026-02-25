namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000083")]
public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x12FCE10", Offset = "0x12FC010", Length = "0xD")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000240")]
	internal SafeRegistryHandle() { }

	[Address(RVA = "0x12FCD90", Offset = "0x12FBF90", Length = "0x29")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000241")]
	public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[Address(RVA = "0x12FD190", Offset = "0x12FC390", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Advapi32), Member = "RegCloseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600023F")]
	protected virtual bool ReleaseHandle() { }

}

