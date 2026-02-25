namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200012E")]
internal struct ConvertUVsFloatToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000415")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000416")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000417")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000418")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108BD90", Offset = "0x108AF90", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000360")]
	public override void Execute(int i, int count) { }

}

