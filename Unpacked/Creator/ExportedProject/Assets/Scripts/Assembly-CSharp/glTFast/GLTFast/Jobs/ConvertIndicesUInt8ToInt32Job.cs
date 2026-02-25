namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000115")]
internal struct ConvertIndicesUInt8ToInt32Job : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003CC")]
	public Byte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003CD")]
	public Int32* result; //Field offset: 0x8

	[Address(RVA = "0x108AB10", Offset = "0x1089D10", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000347")]
	public override void Execute(int i) { }

}

