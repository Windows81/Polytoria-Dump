namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000125")]
internal struct ConvertColorsRgbUInt16ToRGBAFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003FE")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003FF")]
	public UInt16* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000400")]
	[WriteOnly]
	public NativeArray<float4> result; //Field offset: 0x10

	[Address(RVA = "0x108A740", Offset = "0x1089940", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000357")]
	public override void Execute(int i) { }

}

