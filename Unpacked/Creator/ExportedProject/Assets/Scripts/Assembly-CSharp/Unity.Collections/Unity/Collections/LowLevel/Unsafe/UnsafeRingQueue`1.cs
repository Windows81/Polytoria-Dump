namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeRingQueueDebugView`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200004D")]
public struct UnsafeRingQueue : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000AD")]
	public T* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AE")]
	public AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AF")]
	internal readonly int m_Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B0")]
	internal int m_Filled; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B1")]
	internal int m_Write; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B2")]
	internal int m_Read; //Field offset: 0x0

	[Token(Token = "0x17000015")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000086")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x845760", Offset = "0x844960", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CollectionHelper), Member = "ShouldDeallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000087")]
	public override void Dispose() { }

	[Address(RVA = "0x845950", Offset = "0x844B50", Length = "0xBA")]
	[CalledBy(Type = typeof(NativeRingQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeRingQueueDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180034F80")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000085")]
	internal static void Free(UnsafeRingQueue<T>* data) { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000086")]
	public bool get_IsCreated() { }

}

