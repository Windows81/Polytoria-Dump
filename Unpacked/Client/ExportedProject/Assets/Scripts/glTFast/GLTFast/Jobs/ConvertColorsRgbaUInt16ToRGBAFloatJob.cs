namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000126")]
internal struct ConvertColorsRgbaUInt16ToRGBAFloatJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000401")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000402")]
	public UInt16* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000403")]
	[WriteOnly]
	public float4* result; //Field offset: 0x10

	[Address(RVA = "0x108A860", Offset = "0x1089A60", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000358")]
	public override void Execute(int i, int count) { }

}

