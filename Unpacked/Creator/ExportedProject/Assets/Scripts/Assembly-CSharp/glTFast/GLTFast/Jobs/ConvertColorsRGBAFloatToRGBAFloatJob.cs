namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000127")]
internal struct ConvertColorsRGBAFloatToRGBAFloatJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000404")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000405")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000406")]
	[WriteOnly]
	public float4* result; //Field offset: 0x10

	[Address(RVA = "0x108A680", Offset = "0x1089880", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000359")]
	public override void Execute(int i, int count) { }

}

