namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000121")]
internal struct ConvertUVsInt8ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003F0")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003F1")]
	public SByte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003F2")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003F3")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108C010", Offset = "0x108B210", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000353")]
	public override void Execute(int i, int count) { }

}

