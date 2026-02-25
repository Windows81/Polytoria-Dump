namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000133")]
internal struct ConvertBoneWeightsUInt8ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400042C")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400042D")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400042E")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400042F")]
	public float4* result; //Field offset: 0x18

	[Address(RVA = "0x108A5D0", Offset = "0x10897D0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000365")]
	public override void Execute(int i, int count) { }

}

