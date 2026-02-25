namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200013B")]
internal struct ConvertNormalsInt16ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400044C")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400044D")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400044E")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400044F")]
	public float3* result; //Field offset: 0x18

	[Address(RVA = "0x108ACB0", Offset = "0x1089EB0", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036D")]
	public override void Execute(int i, int count) { }

}

