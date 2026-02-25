namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x200012B")]
internal struct ConvertRotationsFloatToFloatJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x400040F")]
	public float4* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000410")]
	public float4* result; //Field offset: 0x8

	[Address(RVA = "0x108B480", Offset = "0x108A680", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600035D")]
	public override void Execute(int i) { }

}

