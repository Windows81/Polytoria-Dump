namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000147")]
internal struct ConvertScalarInt16ToFloatNormalizedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000474")]
	public Int16* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000475")]
	[WriteOnly]
	public NativeArray<Single> result; //Field offset: 0x8

	[Address(RVA = "0x108B6E0", Offset = "0x108A8E0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600037A")]
	public override void Execute(int i) { }

}

