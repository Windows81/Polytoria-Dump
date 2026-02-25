namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000113")]
internal struct CreateIndicesInt32Job : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003CA")]
	public Int32* result; //Field offset: 0x0

	[Address(RVA = "0x108C7C0", Offset = "0x108B9C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000345")]
	public override void Execute(int i) { }

}

