namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000119")]
internal struct ConvertIndicesUInt32ToInt32Job : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D4")]
	public UInt32* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D5")]
	public Int32* result; //Field offset: 0x8

	[Address(RVA = "0x108AA90", Offset = "0x1089C90", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034B")]
	public override void Execute(int i) { }

}

