namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000141")]
internal struct ConvertBoneJointsUInt8ToUInt32Job : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000464")]
	public Byte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[ReadOnly]
	[Token(Token = "0x4000465")]
	public int inputByteStride; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000466")]
	[WriteOnly]
	public uint4* result; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Token(Token = "0x4000467")]
	public int outputByteStride; //Field offset: 0x18

	[Address(RVA = "0x108A480", Offset = "0x1089680", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000373")]
	public override void Execute(int i) { }

}

