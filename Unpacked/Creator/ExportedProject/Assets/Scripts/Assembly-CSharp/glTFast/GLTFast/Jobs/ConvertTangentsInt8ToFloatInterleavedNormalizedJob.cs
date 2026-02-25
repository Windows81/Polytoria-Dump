namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000136")]
internal struct ConvertTangentsInt8ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000438")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000439")]
	public SByte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400043A")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400043B")]
	public float4* result; //Field offset: 0x18

	[Address(RVA = "0x108BB80", Offset = "0x108AD80", Length = "0x20F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000368")]
	public override void Execute(int i, int count) { }

}

