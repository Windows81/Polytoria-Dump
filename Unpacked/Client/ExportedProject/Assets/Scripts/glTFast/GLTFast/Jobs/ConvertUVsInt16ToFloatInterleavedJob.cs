namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200011F")]
internal struct ConvertUVsInt16ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003E8")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003E9")]
	public Int16* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003EA")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003EB")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108BED0", Offset = "0x108B0D0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000351")]
	public override void Execute(int i, int count) { }

}

