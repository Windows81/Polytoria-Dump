namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A5")]
internal class TempMeshAllocatorImpl : IDisposable
{
	[Token(Token = "0x20005A6")]
	private struct ThreadData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400145B")]
		public List<IntPtr> allocations; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001456")]
	private GCHandle m_GCHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001457")]
	private ThreadData[] m_ThreadData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001458")]
	private TempAllocator<Vertex> m_VertexPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001459")]
	private TempAllocator<UInt16> m_IndexPool; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400145A")]
	private bool <disposed>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000A24")]
	protected private bool disposed
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600285A")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600285B")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B9FD20", Offset = "0x1B9EF20", Length = "0x1DE")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TempAllocator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002855")]
	public TempMeshAllocatorImpl() { }

	[Address(RVA = "0x76C860", Offset = "0x76BA60", Length = "0x1C5")]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180769590")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002857")]
	private NativeSlice<T> Allocate(int count, int alignment) { }

	[Address(RVA = "0x1B9F740", Offset = "0x1B9E940", Length = "0x26E")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Painter2D+Painter2DJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TempAllocator`1), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002858")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	[Address(RVA = "0x1B9F9B0", Offset = "0x1B9EBB0", Length = "0x1F4")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TempMeshAllocatorImpl), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002859")]
	public void Clear() { }

	[Address(RVA = "0x1B9FBB0", Offset = "0x1B9EDB0", Length = "0xC")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "GetTempMeshAllocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002856")]
	public void CreateNativeHandle(out TempMeshAllocator allocator) { }

	[Address(RVA = "0x1B9FBC0", Offset = "0x1B9EDC0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285C")]
	public override void Dispose() { }

	[Address(RVA = "0x1B9FC80", Offset = "0x1B9EE80", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285D")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600285A")]
	protected bool get_disposed() { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600285B")]
	private void set_disposed(bool value) { }

}

