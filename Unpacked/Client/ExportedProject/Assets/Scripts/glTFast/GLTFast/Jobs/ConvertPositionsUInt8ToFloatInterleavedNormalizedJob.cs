namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000140")]
internal struct ConvertPositionsUInt8ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000460")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000461")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000462")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000463")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108B3F0", Offset = "0x108A5F0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000372")]
	public override void Execute(int i, int count) { }

}

