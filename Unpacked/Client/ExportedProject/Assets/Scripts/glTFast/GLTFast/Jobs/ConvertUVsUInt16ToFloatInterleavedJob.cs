namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200011D")]
internal struct ConvertUVsUInt16ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003E0")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003E1")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003E2")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003E3")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108C150", Offset = "0x108B350", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034F")]
	public override void Execute(int i, int count) { }

}

