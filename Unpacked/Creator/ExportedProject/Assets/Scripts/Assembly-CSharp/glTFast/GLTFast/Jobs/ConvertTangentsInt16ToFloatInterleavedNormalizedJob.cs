namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000135")]
internal struct ConvertTangentsInt16ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000434")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000435")]
	public Int16* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000436")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000437")]
	public float4* result; //Field offset: 0x18

	[Address(RVA = "0x108B970", Offset = "0x108AB70", Length = "0x20F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000367")]
	public override void Execute(int i, int count) { }

}

