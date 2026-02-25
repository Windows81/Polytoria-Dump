namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000089")]
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle
{

	[Token(Token = "0x17000035")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x12FCE70", Offset = "0x12FC070", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000252")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x12FCE20", Offset = "0x12FC020", Length = "0x4A")]
	[CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6000251")]
	protected SafeHandleMinusOneIsInvalid(bool ownsHandle) { }

	[Address(RVA = "0x12FCE70", Offset = "0x12FC070", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000252")]
	public virtual bool get_IsInvalid() { }

}

