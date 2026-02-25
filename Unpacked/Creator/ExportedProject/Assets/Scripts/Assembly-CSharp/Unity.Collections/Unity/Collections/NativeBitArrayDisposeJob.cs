namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x2000023")]
internal struct NativeBitArrayDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000059")]
	public NativeBitArrayDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1820690", Offset = "0x181F890", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeBitArrayDispose), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x600004D")]
	public override void Execute() { }

}

