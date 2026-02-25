namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200011E")]
internal struct ConvertUVsUInt16ToFloatInterleavedNormalizedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003E4")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003E5")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003E6")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003E7")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108C1C0", Offset = "0x108B3C0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000350")]
	public override void Execute(int i) { }

}

