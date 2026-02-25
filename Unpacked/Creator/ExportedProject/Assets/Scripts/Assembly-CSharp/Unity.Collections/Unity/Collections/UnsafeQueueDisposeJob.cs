namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x200003F")]
internal struct UnsafeQueueDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000083")]
	public UnsafeQueueDispose Data; //Field offset: 0x0

	[Address(RVA = "0x1821330", Offset = "0x1820530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x600006F")]
	public override void Execute() { }

}

