namespace UnityEngine.UIElements;

[Token(Token = "0x20002CE")]
public class Painter2D : IDisposable
{
	[Token(Token = "0x20002D0")]
	private struct Painter2DJob : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000B6A")]
		public IntPtr painterHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4000B6B")]
		public TempMeshAllocator allocator; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x4000B6C")]
		public NativeSlice<Painter2DJobData> jobParameters; //Field offset: 0x10

		[Address(RVA = "0x1C89640", Offset = "0x1C88840", Length = "0x447")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(NativeSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
		[Calls(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001392")]
		public override void Execute(int i) { }

	}

	[Token(Token = "0x20002CF")]
	private struct Painter2DJobData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B68")]
		public UnsafeMeshGenerationNode node; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B69")]
		public int snapshotIndex; //Field offset: 0x8

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000B64")]
	private static bool <isPainterActive>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000B65")]
	private static readonly ProfilerMarker s_StrokeMarker; //Field offset: 0x8
	[Token(Token = "0x4000B66")]
	private static readonly ProfilerMarker s_FillMarker; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B5E")]
	private MeshGenerationContext m_Ctx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B5F")]
	internal DetachedAllocator m_DetachedAllocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B60")]
	internal SafeHandleAccess m_Handle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B61")]
	private List<Painter2DJobData> m_JobSnapshots; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B62")]
	private NativeArray<Painter2DJobData> m_JobParameters; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B63")]
	private bool m_Disposed; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B67")]
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0x48

	[Token(Token = "0x170003C5")]
	internal static bool isPainterActive
	{
		[Address(RVA = "0x1C8A330", Offset = "0x1C89530", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600138E")]
		internal set { } //Length: 83
	}

	[Address(RVA = "0x1C8A010", Offset = "0x1C89210", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6001391")]
	private static Painter2D() { }

	[Address(RVA = "0x1C8A0B0", Offset = "0x1C892B0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Painter2D), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001389")]
	internal Painter2D(MeshGenerationContext ctx) { }

	[Address(RVA = "0x1C8A1D0", Offset = "0x1C893D0", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DetachedAllocator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Painter2D), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600138A")]
	public Painter2D() { }

	[Address(RVA = "0x1C89B30", Offset = "0x1C88D30", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(DetachedAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600138C")]
	public override void Dispose() { }

	[Address(RVA = "0x1C89A90", Offset = "0x1C88C90", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(DetachedAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600138D")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1C89C10", Offset = "0x1C88E10", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001390")]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[Address(RVA = "0x1C89C90", Offset = "0x1C88E90", Length = "0x71")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "get_painter2D", ReturnType = typeof(Painter2D))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600138B")]
	internal void Reset() { }

	[Address(RVA = "0x1C89D10", Offset = "0x1C88F10", Length = "0x2F7")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "ScheduleMeshGenerationJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Painter2DJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Painter2DJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "CreateNativeHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600138F")]
	internal void ScheduleJobs(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1C8A330", Offset = "0x1C89530", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600138E")]
	internal static void set_isPainterActive(bool value) { }

}

