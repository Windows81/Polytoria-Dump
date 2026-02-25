namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005D3")]
internal struct LayoutDataStore : IDisposable
{
	[Token(Token = "0x20005D4")]
	private struct Chunk
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4001518")]
		public Byte* Buffer; //Field offset: 0x0

	}

	[Token(Token = "0x20005D5")]
	private struct ComponentDataStore : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001519")]
		public Allocator Allocator; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400151A")]
		public int Size; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400151B")]
		public int ComponentCountPerChunk; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400151C")]
		public int ChunkCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x400151D")]
		private Chunk* m_Chunks; //Field offset: 0x10

		[Address(RVA = "0x1BA4550", Offset = "0x1BA3750", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600297A")]
		public ComponentDataStore(int size, Allocator allocator) { }

		[Address(RVA = "0x1BA4300", Offset = "0x1BA3500", Length = "0x8B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600297B")]
		public override void Dispose() { }

		[Address(RVA = "0x1BA4390", Offset = "0x1BA3590", Length = "0x2F")]
		[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetTypedNodeDataRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutNodeDataType)}, ReturnType = "T&")]
		[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetTypedConfigDataRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutConfigDataType)}, ReturnType = "T&")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600297C")]
		public Byte* GetComponentDataPtr(int index) { }

		[Address(RVA = "0x1BA43C0", Offset = "0x1BA35C0", Length = "0x187")]
		[CalledBy(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(LayoutDataStore), Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600297D")]
		public void ResizeCapacity(int capacity) { }

	}

	[Token(Token = "0x20005D6")]
	private struct Data
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400151E")]
		public int Capacity; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400151F")]
		public int NextFreeIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001520")]
		public int ComponentCount; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4001521")]
		public Int32* Versions; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4001522")]
		public ComponentDataStore* Components; //Field offset: 0x18

	}

	[Token(Token = "0x4001515")]
	private const int k_ChunkSize = 32768; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001516")]
	private readonly Allocator m_Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4001517")]
	private Data* m_Data; //Field offset: 0x8

	[Address(RVA = "0x1BA9570", Offset = "0x1BA8770", Length = "0x24B")]
	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600296D")]
	public LayoutDataStore(ComponentType[] components, int initialCapacity, Allocator allocator) { }

	[Address(RVA = "0x1BA8CB0", Offset = "0x1BA7EB0", Length = "0x23F")]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&"}, ReturnType = typeof(LayoutHandle))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(LayoutHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002971")]
	private LayoutHandle Allocate(Byte** data, int count) { }

	[Address(RVA = "0x6EA850", Offset = "0x6E9A50", Length = "0x32")]
	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateConfig", ReturnType = typeof(LayoutConfig))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(int)}, ReturnType = typeof(LayoutHandle))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002978")]
	public LayoutHandle Allocate(in T0 component0) { }

	[Address(RVA = "0x6EA800", Offset = "0x6E9A00", Length = "0x43")]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(int)}, ReturnType = typeof(LayoutHandle))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002979")]
	public LayoutHandle Allocate(in T0 component0, in T1 component1, in T2 component2, in T3 component3) { }

	[Address(RVA = "0x1BA8EF0", Offset = "0x1BA80F0", Length = "0x136")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600296E")]
	public override void Dispose() { }

	[Address(RVA = "0x1BA9030", Offset = "0x1BA8230", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600296F")]
	public bool Exists(in LayoutHandle handle) { }

	[Address(RVA = "0x1BA9070", Offset = "0x1BA8270", Length = "0x12F")]
	[CalledBy(Type = typeof(LayoutManager), Member = "DestroyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002972")]
	public void Free(in LayoutHandle handle) { }

	[Address(RVA = "0x1BA91A0", Offset = "0x1BA83A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	[Token(Token = "0x6002970")]
	internal Void* GetComponentDataPtr(int index, int componentIndex) { }

	[Address(RVA = "0x1BA91F0", Offset = "0x1BA83F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002974")]
	private static int GetNextFreeIndex(ComponentDataStore* ptr, int index) { }

	[Address(RVA = "0x1BA9230", Offset = "0x1BA8430", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002975")]
	private void IncreaseCapacity() { }

	[Address(RVA = "0x1BA9270", Offset = "0x1BA8470", Length = "0xDA")]
	[CalledBy(Type = typeof(ComponentDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002977")]
	private static Void* ResizeArray(Void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator) { }

	[Address(RVA = "0x1BA9350", Offset = "0x1BA8550", Length = "0x1D0")]
	[CalledBy(Type = typeof(LayoutDataStore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComponentType[]), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(int)}, ReturnType = typeof(LayoutHandle))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "IncreaseCapacity", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ComponentDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002976")]
	private void ResizeCapacity(int capacity) { }

	[Address(RVA = "0x1BA9530", Offset = "0x1BA8730", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002973")]
	private static void SetNextFreeIndex(ComponentDataStore* ptr, int index, int value) { }

}

