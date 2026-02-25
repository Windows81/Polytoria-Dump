namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200013C")]
internal struct ConvertPositionsInt8ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000450")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000451")]
	public SByte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000452")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000453")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108B080", Offset = "0x108A280", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600036E")]
	public override void Execute(int i, int count) { }

}

