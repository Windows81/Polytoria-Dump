namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x2000037")]
internal struct NativeTextDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000071")]
	public NativeTextDispose Data; //Field offset: 0x0

	[Address(RVA = "0x18208A0", Offset = "0x181FAA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeTextDispose), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6000061")]
	public override void Execute() { }

}

