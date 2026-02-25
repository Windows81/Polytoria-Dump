namespace System.Threading.Tasks;

[Token(Token = "0x200026C")]
internal class StackGuard
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B24")]
	private int m_inliningDepth; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001428")]
	public StackGuard() { }

	[Address(RVA = "0x152D0B0", Offset = "0x152C2B0", Length = "0xE")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001427")]
	internal void EndInliningScope() { }

	[Address(RVA = "0x152D0C0", Offset = "0x152C2C0", Length = "0x2B")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001426")]
	internal bool TryBeginInliningScope() { }

}

