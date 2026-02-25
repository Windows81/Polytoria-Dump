namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000124")]
internal struct ConvertColorsRgbUInt8ToRGBAFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003FB")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003FC")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003FD")]
	[WriteOnly]
	public NativeArray<float4> result; //Field offset: 0x10

	[Address(RVA = "0x108A7D0", Offset = "0x10899D0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000356")]
	public override void Execute(int i) { }

}

