namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x2000034")]
internal struct NativeStreamDispose
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006E")]
	public UnsafeStream m_StreamData; //Field offset: 0x0

	[Address(RVA = "0x1820880", Offset = "0x181FA80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public void Dispose() { }

}

