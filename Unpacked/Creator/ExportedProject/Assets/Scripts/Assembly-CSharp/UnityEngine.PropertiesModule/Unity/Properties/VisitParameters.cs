namespace Unity.Properties;

[Token(Token = "0x2000003")]
public struct VisitParameters
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	private VisitExceptionKind <IgnoreExceptions>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000001")]
	public VisitExceptionKind IgnoreExceptions
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000001")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000001")]
	public VisitExceptionKind get_IgnoreExceptions() { }

}

