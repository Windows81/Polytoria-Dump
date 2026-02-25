namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeListTDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000047")]
public struct UnsafeList : IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400009C")]
	public T* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009D")]
	public int m_length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009E")]
	public int m_capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009F")]
	public AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A0")]
	private readonly int padding; //Field offset: 0x0

	[Token(Token = "0x17000014")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600007D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000013")]
	public override int Length
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600007B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x844F60", Offset = "0x844160", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180034E90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), "T*", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public static void Destroy(UnsafeList<T>* listData) { }

	[Address(RVA = "0x845250", Offset = "0x844450", Length = "0xE7")]
	[CalledBy(Type = typeof(NativeTextDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeText), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeText), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CollectionHelper), Member = "ShouldDeallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	public override void Dispose() { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600007D")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600007B")]
	public override int get_Length() { }

	[Address(RVA = "0x827680", Offset = "0x826880", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0x827680", Offset = "0x826880", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007F")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

