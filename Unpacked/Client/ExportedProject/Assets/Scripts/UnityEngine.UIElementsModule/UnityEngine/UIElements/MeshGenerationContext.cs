namespace UnityEngine.UIElements;

[Token(Token = "0x20002C8")]
public class MeshGenerationContext
{
	[Flags]
	[Token(Token = "0x20002C9")]
	public enum MeshFlags
	{
		None = 0,
		SkipDynamicAtlas = 2,
		IsUsingVectorImageGradients = 4,
		SliceTiled = 8,
	}

	[Token(Token = "0x4000B4C")]
	private static readonly ProfilerMarker k_AllocateMarker; //Field offset: 0x0
	[Token(Token = "0x4000B4D")]
	private static readonly ProfilerMarker k_DrawVectorImageMarker; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B42")]
	private VisualElement <visualElement>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B43")]
	private RenderData <renderData>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B44")]
	private Painter2D m_Painter2D; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B45")]
	private MeshWriteDataPool m_MeshWriteDataPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B46")]
	private TempMeshAllocatorImpl m_Allocator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B47")]
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B48")]
	private MeshGenerationNodeManager m_MeshGenerationNodeManager; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B49")]
	private IMeshGenerator <meshGenerator>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B4A")]
	private EntryRecorder <entryRecorder>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B4B")]
	private Entry <parentEntry>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B4E")]
	private bool <disposed>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170003C2")]
	internal bool disposed
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001367")]
		internal get { } //Length: 5
		[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001368")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003C0")]
	internal EntryRecorder entryRecorder
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600135A")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600135B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003BE")]
	internal bool hasPainter2D
	{
		[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001357")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170003BF")]
	internal IMeshGenerator meshGenerator
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001358")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001359")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003BD")]
	public Painter2D painter2D
	{
		[Address(RVA = "0x1C883F0", Offset = "0x1C875F0", Length = "0x1BF")]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "ScheduleMeshGenerationJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Painter2D), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001356")]
		 get { } //Length: 447
	}

	[Token(Token = "0x170003C1")]
	internal Entry parentEntry
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600135C")]
		internal get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600135D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003BC")]
	internal RenderData renderData
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001354")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001355")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003BB")]
	public private VisualElement visualElement
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001352")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001353")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1C88270", Offset = "0x1C87470", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600136B")]
	private static MeshGenerationContext() { }

	[Address(RVA = "0x1C88310", Offset = "0x1C87510", Length = "0xDB")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MeshGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600135E")]
	internal MeshGenerationContext(MeshWriteDataPool meshWriteDataPool, EntryRecorder entryRecorder, TempMeshAllocatorImpl allocator, MeshGenerationDeferrer meshGenerationDeferrer, MeshGenerationNodeManager meshGenerationNodeManager) { }

	[Address(RVA = "0x1C87C00", Offset = "0x1C86E00", Length = "0x2D")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001364")]
	internal void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent) { }

	[Address(RVA = "0x1C87C30", Offset = "0x1C86E30", Length = "0x2C")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001363")]
	public void AddMeshGenerationJob(JobHandle jobHandle) { }

	[Address(RVA = "0x1C87C60", Offset = "0x1C86E60", Length = "0x24")]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "BuildRenderTreeQuadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600135F")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	[Address(RVA = "0x1C87C90", Offset = "0x1C86E90", Length = "0x1E7")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001365")]
	internal void Begin(Entry parentEntry, VisualElement ve, RenderData renderData) { }

	[Address(RVA = "0x1C87E80", Offset = "0x1C87080", Length = "0x56")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001369")]
	internal void Dispose() { }

	[Address(RVA = "0x1C87EE0", Offset = "0x1C870E0", Length = "0x1C8")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(DetachedAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MeshGenerator), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600136A")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1C880B0", Offset = "0x1C872B0", Length = "0xD9")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationDeferrer), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerationDeferrer+CallbackInfo", typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Painter2D), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001366")]
	internal void End() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001367")]
	internal bool get_disposed() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600135A")]
	internal EntryRecorder get_entryRecorder() { }

	[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001357")]
	internal bool get_hasPainter2D() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001358")]
	internal IMeshGenerator get_meshGenerator() { }

	[Address(RVA = "0x1C883F0", Offset = "0x1C875F0", Length = "0x1BF")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "ScheduleMeshGenerationJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Painter2D), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001356")]
	public Painter2D get_painter2D() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600135C")]
	internal Entry get_parentEntry() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001354")]
	internal RenderData get_renderData() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001352")]
	public VisualElement get_visualElement() { }

	[Address(RVA = "0x1C88190", Offset = "0x1C87390", Length = "0x1E")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "CreateNativeHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001360")]
	public void GetTempMeshAllocator(out TempMeshAllocator allocator) { }

	[Address(RVA = "0x1C881B0", Offset = "0x1C873B0", Length = "0x58")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EntryRecorder), Member = "InsertPlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(Entry))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(bool)}, ReturnType = typeof(MeshGenerationNodeImpl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001361")]
	public void InsertMeshGenerationNode(out MeshGenerationNode node) { }

	[Address(RVA = "0x1C88210", Offset = "0x1C87410", Length = "0x58")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BorderParams)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryRecorder), Member = "InsertPlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(Entry))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(bool)}, ReturnType = typeof(MeshGenerationNodeImpl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001362")]
	internal void InsertUnsafeMeshGenerationNode(out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001368")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600135B")]
	private void set_entryRecorder(EntryRecorder value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001359")]
	internal void set_meshGenerator(IMeshGenerator value) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600135D")]
	private void set_parentEntry(Entry value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001355")]
	private void set_renderData(RenderData value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001353")]
	private void set_visualElement(VisualElement value) { }

}

