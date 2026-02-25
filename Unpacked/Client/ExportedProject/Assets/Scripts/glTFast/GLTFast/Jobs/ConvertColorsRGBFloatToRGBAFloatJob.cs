namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000123")]
internal struct ConvertColorsRGBFloatToRGBAFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003F8")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003F9")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003FA")]
	[WriteOnly]
	public float4* result; //Field offset: 0x10

	[Address(RVA = "0x108A6D0", Offset = "0x10898D0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000355")]
	public override void Execute(int i) { }

}

