namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000088")]
public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
{

	[Token(Token = "0x17000034")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x12FCEC0", Offset = "0x12FC0C0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000250")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x12FCEB0", Offset = "0x12FC0B0", Length = "0xE")]
	[CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), "Microsoft.Win32.SafeHandles.SafeProcessHandle&", typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeProcessHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeProcessHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeProcessHandle", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600024F")]
	protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) { }

	[Address(RVA = "0x12FCEC0", Offset = "0x12FC0C0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000250")]
	public virtual bool get_IsInvalid() { }

}

