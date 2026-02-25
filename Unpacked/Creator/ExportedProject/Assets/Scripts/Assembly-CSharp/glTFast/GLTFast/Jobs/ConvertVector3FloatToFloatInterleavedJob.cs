namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200012F")]
internal struct ConvertVector3FloatToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000419")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400041A")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400041B")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400041C")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108C2F0", Offset = "0x108B4F0", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000361")]
	public override void Execute(int i, int count) { }

}

