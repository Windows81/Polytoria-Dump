namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200013E")]
internal struct ConvertNormalsInt8ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000458")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000459")]
	public SByte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400045A")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400045B")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108AE60", Offset = "0x108A060", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000370")]
	public override void Execute(int i, int count) { }

}

