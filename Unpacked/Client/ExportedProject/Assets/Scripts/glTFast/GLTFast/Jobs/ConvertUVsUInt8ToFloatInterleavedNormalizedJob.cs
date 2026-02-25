namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200011C")]
internal struct ConvertUVsUInt8ToFloatInterleavedNormalizedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003DC")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003DD")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003DE")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003DF")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108C290", Offset = "0x108B490", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034E")]
	public override void Execute(int i) { }

}

