namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000138")]
internal struct ConvertPositionsUInt16ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000440")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000441")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000442")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000443")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108B170", Offset = "0x108A370", Length = "0x1F8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600036A")]
	public override void Execute(int i, int count) { }

}

