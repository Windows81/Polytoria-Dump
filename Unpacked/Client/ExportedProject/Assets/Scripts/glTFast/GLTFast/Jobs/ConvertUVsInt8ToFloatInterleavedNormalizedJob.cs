namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000122")]
internal struct ConvertUVsInt8ToFloatInterleavedNormalizedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003F4")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003F5")]
	public SByte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003F6")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003F7")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108C080", Offset = "0x108B280", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000354")]
	public override void Execute(int i, int count) { }

}

