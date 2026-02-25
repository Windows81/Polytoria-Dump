namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000114")]
internal struct CreateIndicesInt32FlippedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003CB")]
	public Int32* result; //Field offset: 0x0

	[Address(RVA = "0x108C790", Offset = "0x108B990", Length = "0x28")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000346")]
	public override void Execute(int i) { }

}

