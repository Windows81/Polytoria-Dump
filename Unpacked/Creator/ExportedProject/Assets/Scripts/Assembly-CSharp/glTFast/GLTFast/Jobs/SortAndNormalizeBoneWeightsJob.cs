namespace GLTFast.Jobs;

[BurstCompile]
[Token(Token = "0x2000143")]
internal struct SortAndNormalizeBoneWeightsJob : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400046C")]
	public NativeArray<VBones> bones; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046D")]
	public int skinWeights; //Field offset: 0x10

	[Address(RVA = "0x1092F60", Offset = "0x1092160", Length = "0x2A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortAndNormalizeBoneWeightsJob), Member = "Swap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VBones&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000375")]
	public override void Execute(int index) { }

	[Address(RVA = "0x1093210", Offset = "0x1092410", Length = "0x3C")]
	[CalledBy(Type = typeof(SortAndNormalizeBoneWeightsJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000376")]
	private static void Swap(ref VBones v, int a, int b) { }

}

