namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000131")]
internal struct ConvertTangentsFloatToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000424")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000425")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000426")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000427")]
	public float4* result; //Field offset: 0x18

	[Address(RVA = "0x108B7E0", Offset = "0x108A9E0", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000363")]
	public override void Execute(int i, int count) { }

}

