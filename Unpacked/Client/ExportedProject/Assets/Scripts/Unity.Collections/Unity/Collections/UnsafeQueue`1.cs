namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200003D")]
public struct UnsafeQueue : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400007F")]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000080")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x1700000F")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600006C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x8453E0", Offset = "0x8445E0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeQueueData), Member = "DeallocateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	public override void Dispose() { }

	[Address(RVA = "0x845420", Offset = "0x844620", Length = "0xE3")]
	[CalledBy(Type = typeof(NativeQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeQueueDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeQueueData), Member = "DeallocateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	internal static void Free(UnsafeQueue<T>* data) { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600006C")]
	public bool get_IsCreated() { }

}

