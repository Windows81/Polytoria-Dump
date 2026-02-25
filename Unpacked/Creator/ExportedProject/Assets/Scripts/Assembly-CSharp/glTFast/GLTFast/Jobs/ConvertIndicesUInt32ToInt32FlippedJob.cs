namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200011A")]
internal struct ConvertIndicesUInt32ToInt32FlippedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D6")]
	public UInt32* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D7")]
	public int3* result; //Field offset: 0x8

	[Address(RVA = "0x108AA30", Offset = "0x1089C30", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034C")]
	public override void Execute(int i) { }

}

