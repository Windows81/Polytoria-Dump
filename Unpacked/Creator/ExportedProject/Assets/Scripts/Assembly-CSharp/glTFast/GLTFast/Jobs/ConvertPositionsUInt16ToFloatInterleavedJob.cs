namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000137")]
internal struct ConvertPositionsUInt16ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400043C")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400043D")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400043E")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400043F")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108B0F0", Offset = "0x108A2F0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000369")]
	public override void Execute(int i, int count) { }

}

