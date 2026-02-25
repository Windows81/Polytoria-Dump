namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200012D")]
internal struct ConvertRotationsInt8ToFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000413")]
	public SByte* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000414")]
	public Single* result; //Field offset: 0x8

	[Address(RVA = "0x108B5E0", Offset = "0x108A7E0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035F")]
	public override void Execute(int i) { }

}

