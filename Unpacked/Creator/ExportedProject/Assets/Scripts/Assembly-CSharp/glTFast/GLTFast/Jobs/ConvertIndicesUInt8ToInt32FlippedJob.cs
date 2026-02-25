namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000116")]
internal struct ConvertIndicesUInt8ToInt32FlippedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003CE")]
	public Byte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003CF")]
	public int3* result; //Field offset: 0x8

	[Address(RVA = "0x108AAB0", Offset = "0x1089CB0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000348")]
	public override void Execute(int i) { }

}

