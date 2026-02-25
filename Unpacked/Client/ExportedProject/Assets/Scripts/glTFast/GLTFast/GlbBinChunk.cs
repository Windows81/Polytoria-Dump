namespace GLTFast;

[IsReadOnly]
[Token(Token = "0x2000010")]
internal struct GlbBinChunk
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002E")]
	private readonly int <Start>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400002F")]
	private readonly uint <Length>k__BackingField; //Field offset: 0x4

	[Token(Token = "0x17000004")]
	public int Start
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public GlbBinChunk(int start, uint length) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public int get_Start() { }

}

