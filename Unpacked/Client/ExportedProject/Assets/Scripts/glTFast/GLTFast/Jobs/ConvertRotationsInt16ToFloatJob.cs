namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200012C")]
internal struct ConvertRotationsInt16ToFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000411")]
	public Int16* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000412")]
	public Single* result; //Field offset: 0x8

	[Address(RVA = "0x108B4E0", Offset = "0x108A6E0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035E")]
	public override void Execute(int i) { }

}

