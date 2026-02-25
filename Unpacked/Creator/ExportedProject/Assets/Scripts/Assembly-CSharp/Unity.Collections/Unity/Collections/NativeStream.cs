namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x2000031")]
public struct NativeStream : IDisposable
{
	[BurstCompile]
	[Token(Token = "0x2000033")]
	private struct ConstructJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		public NativeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x400006D")]
		public NativeArray<Int32> Length; //Field offset: 0x20

		[Address(RVA = "0x1820410", Offset = "0x181F610", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		public override void Execute() { }

	}

	[BurstCompile]
	[Token(Token = "0x2000032")]
	private struct ConstructJobList : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		public NativeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		[Token(Token = "0x400006B")]
		public UntypedUnsafeList* List; //Field offset: 0x20

		[Address(RVA = "0x18203E0", Offset = "0x181F5E0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600005C")]
		public override void Execute() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000069")]
	private UnsafeStream m_Stream; //Field offset: 0x0

	[Token(Token = "0x1700000D")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000059")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1820890", Offset = "0x181FA90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600005B")]
	private void AllocateForEach(int forEachCount) { }

	[Address(RVA = "0x1820880", Offset = "0x181FA80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	public override void Dispose() { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000059")]
	public bool get_IsCreated() { }

}

