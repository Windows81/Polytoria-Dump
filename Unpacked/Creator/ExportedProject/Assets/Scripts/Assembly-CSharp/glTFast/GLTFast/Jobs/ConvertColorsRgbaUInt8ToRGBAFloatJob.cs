namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000128")]
internal struct ConvertColorsRgbaUInt8ToRGBAFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000407")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000408")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000409")]
	[WriteOnly]
	public NativeArray<float4> result; //Field offset: 0x10

	[Address(RVA = "0x108A920", Offset = "0x1089B20", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035A")]
	public override void Execute(int i) { }

}

