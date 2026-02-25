namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x20005E4")]
internal struct LayoutList : IDisposable
{
	[Token(Token = "0x20005E5")]
	private struct Data
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001581")]
		public int Capacity; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001582")]
		public int Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001583")]
		public T* Values; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400157F")]
	private readonly Allocator m_Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001580")]
	private Data<T>* m_Data; //Field offset: 0x0

	[Token(Token = "0x17000A84")]
	public int Count
	{
		[Address(RVA = "0xCE7390", Offset = "0xCE6590", Length = "0x1A")]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002989")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A85")]
	public bool IsCreated
	{
		[Address(RVA = "0xCE73B0", Offset = "0xCE65B0", Length = "0x9")]
		[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
		[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(LayoutNode), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LayoutNode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600298A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000A86")]
	public T Item
	{
		[Address(RVA = "0xCE7470", Offset = "0xCE6670", Length = "0x6E")]
		[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600298B")]
		 get { } //Length: 110
	}

	[Address(RVA = "0xCE71F0", Offset = "0xCE63F0", Length = "0x9")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600298C")]
	public LayoutList`1() { }

	[Address(RVA = "0xCE7100", Offset = "0xCE6300", Length = "0xEE")]
	[CalledBy(Type = typeof(LayoutNode), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LayoutNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600298D")]
	public LayoutList`1(int initialCapacity, Allocator allocator) { }

	[Address(RVA = "0xCE6410", Offset = "0xCE5610", Length = "0x45")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600298E")]
	public override void Dispose() { }

	[Address(RVA = "0xCE6460", Offset = "0xCE5660", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(LayoutList`1), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002992")]
	private void EnsureCapacity(int capacity) { }

	[Address(RVA = "0xCE7390", Offset = "0xCE6590", Length = "0x1A")]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002989")]
	public int get_Count() { }

	[Address(RVA = "0xCE73B0", Offset = "0xCE65B0", Length = "0x9")]
	[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryRecycleNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LayoutNode), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LayoutNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600298A")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xCE7470", Offset = "0xCE6670", Length = "0x6E")]
	[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600298B")]
	public T get_Item(int index) { }

	[Address(RVA = "0xCE6550", Offset = "0xCE5750", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(LayoutList`1), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002991")]
	private void IncreaseCapacity() { }

	[Address(RVA = "0xCE6670", Offset = "0xCE5870", Length = "0x129")]
	[CalledBy(Type = typeof(LayoutNode), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LayoutNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800C9EB0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600298F")]
	public void Insert(int index, T value) { }

	[Address(RVA = "0xCE6B60", Offset = "0xCE5D60", Length = "0xF4")]
	[CalledBy(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002990")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xCE6C60", Offset = "0xCE5E60", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002994")]
	private static Void* ResizeArray(Void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator) { }

	[Address(RVA = "0xCE6F90", Offset = "0xCE6190", Length = "0x161")]
	[CalledBy(Type = typeof(LayoutList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutList`1), Member = "IncreaseCapacity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002993")]
	private void ResizeCapacity(int capacity) { }

}

