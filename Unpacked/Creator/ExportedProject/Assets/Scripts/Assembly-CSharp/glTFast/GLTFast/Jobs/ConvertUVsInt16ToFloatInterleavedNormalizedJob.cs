namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000120")]
internal struct ConvertUVsInt16ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003EC")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003ED")]
	public Int16* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003EE")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003EF")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108BF40", Offset = "0x108B140", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000352")]
	public override void Execute(int i, int count) { }

}

