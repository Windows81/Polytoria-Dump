namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200013F")]
internal struct ConvertPositionsUInt8ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400045C")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400045D")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400045E")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400045F")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108B370", Offset = "0x108A570", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000371")]
	public override void Execute(int i, int count) { }

}

