namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x2000035")]
internal struct NativeStreamDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006F")]
	public NativeStreamDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1820880", Offset = "0x181FA80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public override void Execute() { }

}

