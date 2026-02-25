namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A3")]
internal class TempAllocator : IDisposable
{
	[Token(Token = "0x20005A4")]
	private struct Page
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001454")]
		public NativeArray<T> array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001455")]
		public int used; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400144E")]
	private readonly int m_ExcessMinCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400144F")]
	private readonly int m_ExcessMaxCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001450")]
	private Page<T> m_Pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001451")]
	private List<Page<T>> m_Excess; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001452")]
	private int m_NextExcessSize; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001453")]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000A23")]
	protected private bool disposed
	{
		[Address(RVA = "0x599160", Offset = "0x598360", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600284D")]
		 get { } //Length: 5
		[Address(RVA = "0x5991B0", Offset = "0x5983B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600284E")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xF96190", Offset = "0xF95390", Length = "0x13E")]
	[CalledBy(Type = typeof(DetachedAllocator), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600284C")]
	public TempAllocator`1(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }

	[Address(RVA = "0xF94D50", Offset = "0xF93F50", Length = "0x4A")]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TempAllocator`1), Member = "DoAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002851")]
	public NativeSlice<T> Alloc(int count) { }

	[Address(RVA = "0xF95000", Offset = "0xF94200", Length = "0xC3")]
	[CalledBy(Type = typeof(DetachedAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DetachedAllocator), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TempAllocator`1), Member = "ReleaseExcess", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600284F")]
	public override void Dispose() { }

	[Address(RVA = "0xF94EB0", Offset = "0xF940B0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TempAllocator`1), Member = "ReleaseExcess", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002850")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xF950D0", Offset = "0xF942D0", Length = "0x43C")]
	[CalledBy(Type = typeof(TempAllocator`1), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002852")]
	private NativeSlice<T> DoAlloc(int count) { }

	[Address(RVA = "0x599160", Offset = "0x598360", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600284D")]
	protected bool get_disposed() { }

	[Address(RVA = "0xF95DA0", Offset = "0xF94FA0", Length = "0x170")]
	[CalledBy(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempAllocator`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempAllocator`1), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002854")]
	private void ReleaseExcess() { }

	[Address(RVA = "0xF96150", Offset = "0xF95350", Length = "0x33")]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TempAllocator`1), Member = "ReleaseExcess", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002853")]
	public void Reset() { }

	[Address(RVA = "0x5991B0", Offset = "0x5983B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600284E")]
	private void set_disposed(bool value) { }

}

