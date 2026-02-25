namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200013A")]
internal struct ConvertVector3Int16ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000448")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000449")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400044A")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400044B")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108C4B0", Offset = "0x108B6B0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036C")]
	public override void Execute(int i, int count) { }

}

