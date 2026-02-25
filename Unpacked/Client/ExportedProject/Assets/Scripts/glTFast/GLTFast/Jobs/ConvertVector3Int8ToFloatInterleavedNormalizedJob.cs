namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200013D")]
internal struct ConvertVector3Int8ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000454")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000455")]
	public SByte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000456")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000457")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108C5C0", Offset = "0x108B7C0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036F")]
	public override void Execute(int i, int count) { }

}

