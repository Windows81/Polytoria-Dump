namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000148")]
internal struct ConvertScalarUInt16ToFloatNormalizedJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x4000476")]
	public UInt16* input; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000477")]
	[WriteOnly]
	public NativeArray<Single> result; //Field offset: 0x8

	[Address(RVA = "0x108B780", Offset = "0x108A980", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600037B")]
	public override void Execute(int i) { }

}

