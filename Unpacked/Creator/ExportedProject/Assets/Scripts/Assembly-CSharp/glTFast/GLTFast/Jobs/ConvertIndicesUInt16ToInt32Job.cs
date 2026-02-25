namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000118")]
internal struct ConvertIndicesUInt16ToInt32Job : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D2")]
	public UInt16* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40003D3")]
	public Int32* result; //Field offset: 0x8

	[Address(RVA = "0x108AA10", Offset = "0x1089C10", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034A")]
	public override void Execute(int i) { }

}

