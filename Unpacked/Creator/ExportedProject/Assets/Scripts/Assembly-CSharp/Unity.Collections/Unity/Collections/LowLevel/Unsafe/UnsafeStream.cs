namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000053")]
public struct UnsafeStream : IDisposable
{
	[BurstCompile]
	[Token(Token = "0x2000056")]
	private struct ConstructJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C4")]
		public UnsafeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x40000C5")]
		public NativeArray<Int32> Length; //Field offset: 0x20

		[Address(RVA = "0x1820410", Offset = "0x181F610", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		public override void Execute() { }

	}

	[BurstCompile]
	[Token(Token = "0x2000055")]
	private struct ConstructJobList : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C2")]
		public UnsafeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		[Token(Token = "0x40000C3")]
		public UntypedUnsafeList* List; //Field offset: 0x20

		[Address(RVA = "0x18203E0", Offset = "0x181F5E0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600008E")]
		public override void Execute() { }

	}

	[BurstCompile]
	[Token(Token = "0x2000054")]
	private struct DisposeJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C1")]
		public UnsafeStream Container; //Field offset: 0x0

		[Address(RVA = "0x1820420", Offset = "0x181F620", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
		[Token(Token = "0x600008D")]
		public override void Execute() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000C0")]
	internal Block m_BlockData; //Field offset: 0x0

	[Token(Token = "0x17000016")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600008A")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1821420", Offset = "0x1820620", Length = "0xD8")]
	[CalledBy(Type = "Unity.Collections.NativeStream+ConstructJobList", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeStream+ConstructJob", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstructJobList), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstructJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000089")]
	internal void AllocateForEach(int forEachCount) { }

	[Address(RVA = "0x1821500", Offset = "0x1820700", Length = "0x132")]
	[CalledBy(Type = typeof(NativeStream), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStreamDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStreamDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStream), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeStreamBlockData), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	private void Deallocate() { }

	[Address(RVA = "0x1820880", Offset = "0x181FA80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public override void Dispose() { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600008A")]
	public bool get_IsCreated() { }

}

