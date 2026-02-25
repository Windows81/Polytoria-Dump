namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200011B")]
internal struct ConvertUVsUInt8ToFloatInterleavedJob : IJobParallelForBatch
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40003D8")]
	public int inputByteStride; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D9")]
	public Byte* input; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40003DA")]
	public int outputByteStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003DB")]
	public float2* result; //Field offset: 0x18

	[Address(RVA = "0x108C220", Offset = "0x108B420", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034D")]
	public override void Execute(int index, int count) { }

}

