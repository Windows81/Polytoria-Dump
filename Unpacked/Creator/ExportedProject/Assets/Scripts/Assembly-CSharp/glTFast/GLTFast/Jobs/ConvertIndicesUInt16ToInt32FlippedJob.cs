namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000117")]
internal struct ConvertIndicesUInt16ToInt32FlippedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D0")]
	public UInt16* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D1")]
	public int3* result; //Field offset: 0x8

	[Address(RVA = "0x108A9B0", Offset = "0x1089BB0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000349")]
	public override void Execute(int i) { }

}

