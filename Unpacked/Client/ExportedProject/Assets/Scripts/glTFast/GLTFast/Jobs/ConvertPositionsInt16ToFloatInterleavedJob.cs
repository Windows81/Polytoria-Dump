namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000139")]
internal struct ConvertPositionsInt16ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000444")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000445")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000446")]
	public float3* result; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Token(Token = "0x4000447")]
	public int outputByteStride; //Field offset: 0x18

	[Address(RVA = "0x108B010", Offset = "0x108A210", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600036B")]
	public override void Execute(int i, int count) { }

}

