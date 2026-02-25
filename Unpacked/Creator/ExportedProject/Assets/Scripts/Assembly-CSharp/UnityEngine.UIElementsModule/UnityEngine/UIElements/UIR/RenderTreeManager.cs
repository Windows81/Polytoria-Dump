namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000598")]
internal class RenderTreeManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200059D")]
	private sealed class <>c
	{
		[Token(Token = "0x400142F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001430")]
		public static Func<RenderChainCommand> <>9__37_0; //Field offset: 0x8
		[Token(Token = "0x4001431")]
		public static Func<ExtraRenderData> <>9__37_1; //Field offset: 0x10
		[Token(Token = "0x4001432")]
		public static Func<RenderData> <>9__37_2; //Field offset: 0x18
		[Token(Token = "0x4001433")]
		public static Func<RenderTree> <>9__37_3; //Field offset: 0x20

		[Address(RVA = "0x1BA21D0", Offset = "0x1BA13D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002828")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002829")]
		public <>c() { }

		[Address(RVA = "0x1BA1FB0", Offset = "0x1BA11B0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(RenderChainCommand), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600282A")]
		internal RenderChainCommand <.ctor>b__37_0() { }

		[Address(RVA = "0x1BA2000", Offset = "0x1BA1200", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600282B")]
		internal ExtraRenderData <.ctor>b__37_1() { }

		[Address(RVA = "0x1BA2070", Offset = "0x1BA1270", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600282C")]
		internal RenderData <.ctor>b__37_2() { }

		[Address(RVA = "0x1BA20C0", Offset = "0x1BA12C0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600282D")]
		internal RenderTree <.ctor>b__37_3() { }

	}

	[Token(Token = "0x2000599")]
	public struct ElementInsertionData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141E")]
		public VisualElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400141F")]
		public bool canceled; //Field offset: 0x8

	}

	[Token(Token = "0x200059A")]
	public class VisualChangesProcessor : IDisposable
	{
		[Token(Token = "0x200059C")]
		private struct EntryProcessingInfo
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400142C")]
			public RenderData renderData; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400142D")]
			public VisualsProcessingType type; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400142E")]
			public Entry rootEntry; //Field offset: 0x10

		}

		[Token(Token = "0x200059B")]
		private enum VisualsProcessingType
		{
			Head = 0,
			Tail = 1,
		}

		[Token(Token = "0x4001420")]
		private static readonly ProfilerMarker k_GenerateEntriesMarker; //Field offset: 0x0
		[Token(Token = "0x4001421")]
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; //Field offset: 0x8
		[Token(Token = "0x4001422")]
		private static readonly ProfilerMarker k_UpdateOpacityIdMarker; //Field offset: 0x10
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001423")]
		private RenderTreeManager m_RenderTreeManager; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001424")]
		private MeshGenerationContext m_MeshGenerationContext; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001425")]
		private BaseElementBuilder m_ElementBuilder; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001426")]
		private List<EntryProcessingInfo> m_EntryProcessingList; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001427")]
		private List<EntryProcessor> m_Processors; //Field offset: 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001428")]
		private bool <disposed>k__BackingField; //Field offset: 0x38

		[Token(Token = "0x17000A1C")]
		protected private bool disposed
		{
			[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002823")]
			 get { } //Length: 5
			[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002824")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000A1A")]
		public BaseElementBuilder elementBuilder
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002819")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000A1B")]
		public MeshGenerationContext meshGenerationContext
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x600281A")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1BA3080", Offset = "0x1BA2280", Length = "0xD2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
		[Token(Token = "0x6002827")]
		private static VisualChangesProcessor() { }

		[Address(RVA = "0x1BA3160", Offset = "0x1BA2360", Length = "0x60E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutManager), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MeshGenerationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshWriteDataPool), typeof(EntryRecorder), typeof(TempMeshAllocatorImpl), typeof(MeshGenerationDeferrer), typeof(MeshGenerationNodeManager)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutManager), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
		[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
		[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
		[Calls(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
		[CallsDeduplicatedMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600281B")]
		public VisualChangesProcessor(RenderTreeManager renderTreeManager) { }

		[Address(RVA = "0x1BA2320", Offset = "0x1BA1520", Length = "0x26B")]
		[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(EntryProcessor), Member = "ProcessTail", ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandManipulator), Member = "ReplaceTailCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(EntryProcessor), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryProcessor), Member = "ProcessHead", ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandManipulator), Member = "ReplaceHeadCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryProcessor), Member = "ClearReferences", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6002820")]
		public void ConvertEntriesToCommands(ref ChainBuilderStats stats) { }

		[Address(RVA = "0x1BA2590", Offset = "0x1BA1790", Length = "0x5F0")]
		[CalledBy(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ProcessOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BMPAlloc), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerationContext), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(VisualElement), typeof(RenderData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015230")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B8F490")]
		[Calls(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderData), Member = "AllocatesID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderTreeManager), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(ExtraRenderData))]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(MeshHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600281E")]
		private void DepthFirstOnVisualsChanged(RenderData renderData, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats) { }

		[Address(RVA = "0x1BA2B90", Offset = "0x1BA1D90", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002825")]
		public override void Dispose() { }

		[Address(RVA = "0x1BA2C10", Offset = "0x1BA1E10", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002826")]
		protected void Dispose(bool disposing) { }

		[Address(RVA = "0x1BA2C60", Offset = "0x1BA1E60", Length = "0x21C")]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "UpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(NativeSlice`1<Vertex>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "OpacityAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
		[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.OpacityIdAccelerator+OpacityIdUpdateJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.OpacityIdAccelerator+OpacityIdUpdateJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002822")]
		private static void DoUpdateOpacityId(RenderData renderData, RenderTreeManager renderTreeManager, MeshHandle mesh) { }

		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002823")]
		protected bool get_disposed() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002819")]
		public BaseElementBuilder get_elementBuilder() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600281A")]
		public MeshGenerationContext get_meshGenerationContext() { }

		[Address(RVA = "0x1BA2E80", Offset = "0x1BA2080", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600281D")]
		public void ProcessOnVisualsChanged(RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

		[Address(RVA = "0x1BA2ED0", Offset = "0x1BA20D0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600281C")]
		public void ScheduleMeshGenerationJobs() { }

		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002824")]
		private void set_disposed(bool value) { }

		[Address(RVA = "0x1BA2F10", Offset = "0x1BA2110", Length = "0x121")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(MeshHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderTreeManager), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(ExtraRenderData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002821")]
		public static void UpdateOpacityId(RenderData renderData, RenderTreeManager renderTreeManager) { }

		[Address(RVA = "0x1BA3040", Offset = "0x1BA2240", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600281F")]
		private static void UpdateWorldFlipsWinding(RenderData renderData) { }

	}

	[Token(Token = "0x400140B")]
	private static EntryPool s_SharedEntryPool; //Field offset: 0x0
	[Token(Token = "0x400140C")]
	private static readonly ProfilerMarker k_MarkerProcess; //Field offset: 0x8
	[Token(Token = "0x400140D")]
	private static readonly ProfilerMarker k_MarkerSerialize; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013F7")]
	private RenderTreeCompositor m_Compositor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013F8")]
	private VisualChangesProcessor m_VisualChangesProcessor; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013F9")]
	private LinkedPool<RenderChainCommand> m_CommandPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013FA")]
	private LinkedPool<ExtraRenderData> m_ExtraDataPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013FB")]
	private BasicNodePool<MeshHandle> m_MeshHandleNodePool; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013FC")]
	private BasicNodePool<TextureEntry> m_TexturePool; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013FD")]
	private Dictionary<RenderData, ExtraRenderData> m_ExtraData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013FE")]
	internal List<ElementInsertionData> m_InsertionList; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013FF")]
	private HashSet<UIRenderer> m_RenderersToReset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001400")]
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001401")]
	private Material m_DefaultMat; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001402")]
	private bool m_BlockDirtyRegistration; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001403")]
	private ChainBuilderStats m_Stats; //Field offset: 0x6C
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001404")]
	private uint m_StatsElementsAdded; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4001405")]
	private uint m_StatsElementsRemoved; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001406")]
	private TextureRegistry m_TextureRegistry; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001407")]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001408")]
	private ObjectPool<RenderData> m_RenderDataPool; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001409")]
	private ObjectPool<RenderTree> m_RenderTreePool; //Field offset: 0xE8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400140A")]
	private bool <blockDirtyRegistration>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x400140E")]
	private bool <disposed>k__BackingField; //Field offset: 0xF1
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400140F")]
	private RenderTree m_RootRenderTree; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001410")]
	private BaseVisualElementPanel <panel>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001411")]
	private UIRenderDevice <device>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001412")]
	private AtlasBase <atlas>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001413")]
	private VectorImageManager <vectorImageManager>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001414")]
	private TempMeshAllocatorImpl <tempMeshAllocator>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001415")]
	private readonly MeshWriteDataPool <meshWriteDataPool>k__BackingField; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001416")]
	public EntryRecorder entryRecorder; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001417")]
	private MeshGenerationNodeManager <meshGenerationNodeManager>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001418")]
	private JobManager <jobManager>k__BackingField; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001419")]
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; //Field offset: 0x148
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400141A")]
	private bool <drawStats>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x151")]
	[Token(Token = "0x400141B")]
	private readonly bool <drawInCameras>k__BackingField; //Field offset: 0x151
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x152")]
	[Token(Token = "0x400141C")]
	private readonly bool <isFlat>k__BackingField; //Field offset: 0x152
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x153")]
	[Token(Token = "0x400141D")]
	private readonly bool <forceGammaRendering>k__BackingField; //Field offset: 0x153

	[Token(Token = "0x17000A0E")]
	internal AtlasBase atlas
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FA")]
		internal get { } //Length: 8
		[Address(RVA = "0x507930", Offset = "0x506B30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FB")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A0C")]
	internal UIRenderDevice device
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027F7")]
		internal get { } //Length: 8
		[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027F8")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A08")]
	protected private bool disposed
	{
		[Address(RVA = "0x1B9DDF0", Offset = "0x1B9CFF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027DA")]
		 get { } //Length: 8
		[Address(RVA = "0x1B9DE80", Offset = "0x1B9D080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027DB")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000A17")]
	internal bool drawInCameras
	{
		[Address(RVA = "0x40D300", Offset = "0x40C500", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002809")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A16")]
	internal bool drawStats
	{
		[Address(RVA = "0x40D2F0", Offset = "0x40C4F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002807")]
		internal get { } //Length: 8
		[Address(RVA = "0x1B9DE90", Offset = "0x1B9D090", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002808")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000A0D")]
	public BaseElementBuilder elementBuilder
	{
		[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027F9")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000A12")]
	internal EntryPool entryPool
	{
		[Address(RVA = "0x1B9DE00", Offset = "0x1B9D000", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002801")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000A19")]
	public bool forceGammaRendering
	{
		[Address(RVA = "0x1B9DE50", Offset = "0x1B9D050", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600280B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000A18")]
	internal bool isFlat
	{
		[Address(RVA = "0x1B9DE60", Offset = "0x1B9D060", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600280A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A15")]
	internal JobManager jobManager
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002805")]
		internal get { } //Length: 8
		[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002806")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A13")]
	public MeshGenerationDeferrer meshGenerationDeferrer
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002802")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A14")]
	public private MeshGenerationNodeManager meshGenerationNodeManager
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002803")]
		 get { } //Length: 8
		[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002804")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A11")]
	internal MeshWriteDataPool meshWriteDataPool
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002800")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A07")]
	public private OpacityIdAccelerator opacityIdAccelerator
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027D3")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD560", Offset = "0x2DC760", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027D4")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A0B")]
	internal BaseVisualElementPanel panel
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027F5")]
		internal get { } //Length: 8
		[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027F6")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A0A")]
	internal RenderTree rootRenderTree
	{
		[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027E0")]
		internal get { } //Length: 8
		[Address(RVA = "0x1B9DEA0", Offset = "0x1B9D0A0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60027E1")]
		internal set { } //Length: 127
	}

	[Token(Token = "0x17000A09")]
	internal ChainBuilderStats statsByRef
	{
		[Address(RVA = "0x1B9DE70", Offset = "0x1B9D070", Length = "0x5")]
		[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60027DF")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000A10")]
	internal TempMeshAllocatorImpl tempMeshAllocator
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FE")]
		internal get { } //Length: 8
		[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FF")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A05")]
	internal TextureRegistry textureRegistry
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027D1")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A0F")]
	internal VectorImageManager vectorImageManager
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FC")]
		internal get { } //Length: 8
		[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FD")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A06")]
	internal VisualChangesProcessor visualChangesProcessor
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027D2")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1B9CB30", Offset = "0x1B9BD30", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EntryPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6002818")]
	private static RenderTreeManager() { }

	[Address(RVA = "0x1B9CC20", Offset = "0x1B9BE20", Length = "0x11C5")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "CreateRenderChain", ReturnType = typeof(RenderTreeManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VectorImageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntryRecorder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshWriteDataPool), typeof(EntryRecorder), typeof(TempMeshAllocatorImpl), typeof(MeshGenerationDeferrer), typeof(MeshGenerationNodeManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryRecorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntryPool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ImplicitPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BasicNodePool`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60027D9")]
	public RenderTreeManager(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1B99120", Offset = "0x1B98320", Length = "0x44")]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "CreateMeshDrawCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(int), typeof(int), typeof(Material), typeof(TextureId)}, ReturnType = typeof(RenderChainCommand))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280C")]
	internal RenderChainCommand AllocCommand() { }

	[Address(RVA = "0x1B99170", Offset = "0x1B98370", Length = "0x11B")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnElementRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E8")]
	public void CancelInsertion(VisualElement ve) { }

	[Address(RVA = "0x1B99290", Offset = "0x1B98490", Length = "0x5A")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E2")]
	private void DepthFirstProcessChanges(RenderTree renderTree) { }

	[Address(RVA = "0x1B992F0", Offset = "0x1B984F0", Length = "0x77")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002810")]
	private void DepthFirstRepaintTextured(RenderData renderData) { }

	[Address(RVA = "0x1B99370", Offset = "0x1B98570", Length = "0xAF")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280F")]
	private void DepthFirstRepaintTextured(RenderTree renderTree) { }

	[Address(RVA = "0x1B99480", Offset = "0x1B98680", Length = "0x72C")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "CleanupOperationTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VectorImageManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "ReverseDepthFirstDisposeRenderTrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60027DD")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x1B99420", Offset = "0x1B98620", Length = "0x56")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelIsFlatChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelAtlasChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelDrawsInCamerasChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027DC")]
	public override void Dispose() { }

	[Address(RVA = "0x1B99BB0", Offset = "0x1B98DB0", Length = "0x9BA")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderRootTree", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "GatherDrawStatistics", ReturnType = typeof(DrawStatistics))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002817")]
	private void DrawStats() { }

	[Address(RVA = "0x1B9A570", Offset = "0x1B99770", Length = "0x62")]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceHeadCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceTailCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ResetCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveSingleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderChainCommand), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280D")]
	internal void FreeCommand(RenderChainCommand cmd) { }

	[Address(RVA = "0x1B9A5E0", Offset = "0x1B997E0", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002812")]
	public void FreeExtraData(RenderData renderData) { }

	[Address(RVA = "0x1B9A6D0", Offset = "0x1B998D0", Length = "0x11D")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002814")]
	public void FreeExtraMeshes(RenderData renderData) { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027FA")]
	internal AtlasBase get_atlas() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027F7")]
	internal UIRenderDevice get_device() { }

	[Address(RVA = "0x1B9DDF0", Offset = "0x1B9CFF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027DA")]
	protected bool get_disposed() { }

	[Address(RVA = "0x40D300", Offset = "0x40C500", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002809")]
	internal bool get_drawInCameras() { }

	[Address(RVA = "0x40D2F0", Offset = "0x40C4F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002807")]
	internal bool get_drawStats() { }

	[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60027F9")]
	public BaseElementBuilder get_elementBuilder() { }

	[Address(RVA = "0x1B9DE00", Offset = "0x1B9D000", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002801")]
	internal EntryPool get_entryPool() { }

	[Address(RVA = "0x1B9DE50", Offset = "0x1B9D050", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600280B")]
	public bool get_forceGammaRendering() { }

	[Address(RVA = "0x1B9DE60", Offset = "0x1B9D060", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600280A")]
	internal bool get_isFlat() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002805")]
	internal JobManager get_jobManager() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002802")]
	public MeshGenerationDeferrer get_meshGenerationDeferrer() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002803")]
	public MeshGenerationNodeManager get_meshGenerationNodeManager() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002800")]
	internal MeshWriteDataPool get_meshWriteDataPool() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027D3")]
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027F5")]
	internal BaseVisualElementPanel get_panel() { }

	[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027E0")]
	internal RenderTree get_rootRenderTree() { }

	[Address(RVA = "0x1B9DE70", Offset = "0x1B9D070", Length = "0x5")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60027DF")]
	internal ChainBuilderStats get_statsByRef() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027FE")]
	internal TempMeshAllocatorImpl get_tempMeshAllocator() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027D1")]
	internal TextureRegistry get_textureRegistry() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027FC")]
	internal VectorImageManager get_vectorImageManager() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027D2")]
	internal VisualChangesProcessor get_visualChangesProcessor() { }

	[Address(RVA = "0x1B9A7F0", Offset = "0x1B999F0", Length = "0xC1")]
	[CalledBy(Type = typeof(RenderEvents), Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(UIRenderDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "UpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002811")]
	public ExtraRenderData GetOrAddExtraData(RenderData renderData) { }

	[Address(RVA = "0x1B9A8C0", Offset = "0x1B99AC0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(RenderData), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D5")]
	internal RenderData GetPooledRenderData() { }

	[Address(RVA = "0x1B9A920", Offset = "0x1B99B20", Length = "0x1F6")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D7")]
	internal RenderTree GetPooledRenderTree(RenderTreeManager renderTreeManager, RenderData rootRenderData) { }

	[Address(RVA = "0x1B9AB20", Offset = "0x1B99D20", Length = "0xBE")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeManager), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(ExtraRenderData))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BasicNode`1), Member = "InsertFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BasicNode`1<T>&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002813")]
	public void InsertExtraMesh(RenderData renderData, MeshHandle mesh) { }

	[Address(RVA = "0x1B9ABE0", Offset = "0x1B99DE0", Length = "0xB3")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BasicNode`1), Member = "InsertFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BasicNode`1<T>&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002815")]
	public void InsertTexture(RenderData renderData, Texture src, TextureId id, bool isAtlas) { }

	[Address(RVA = "0x1B9ACA0", Offset = "0x1B99EA0", Length = "0x2E9")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "OnFrameRenderingBegin", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "IssuePendingStorageChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(VectorImageManager), Member = "Commit", ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPool), Member = "ReturnAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ImplicitPool`1), Member = "ReturnAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "ResetAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTree), Member = "ProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "ProcessChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027E3")]
	public void ProcessChanges() { }

	[Address(RVA = "0x1B9AF90", Offset = "0x1B9A190", Length = "0x1FE")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "MarkRenderHintsClean", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027EA")]
	private void ProcessChildAdded(VisualElement ve) { }

	[Address(RVA = "0x1B8F3B0", Offset = "0x1B8E5B0", Length = "0x1CE")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027EE")]
	private void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyClasses) { }

	[Address(RVA = "0x1B9B190", Offset = "0x1B9A390", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E6")]
	private void RenderNestedTrees() { }

	[Address(RVA = "0x1B9B1C0", Offset = "0x1B9A3C0", Length = "0x158")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DrawStats", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E5")]
	public void RenderRootTree() { }

	[Address(RVA = "0x1B9B320", Offset = "0x1B9A520", Length = "0x620")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderRootTree", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "LoadProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "set_modelview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VectorImageManager), Member = "get_atlas", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "get_atlas", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "DisableScissor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProjectionUtils), Member = "Ortho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(GUIUtility), Member = "IsExitGUIException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImmediateModeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "CastToRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E7")]
	public void RenderSingleTree(RenderTree renderTree, RenderTexture nestedTreeRT, RectInt nestedTreeViewport) { }

	[Address(RVA = "0x1B9B950", Offset = "0x1B9AB50", Length = "0xB5")]
	[CalledBy(Type = typeof(AtlasBase), Member = "RepaintTexturedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "DepthFirstRepaintTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Token(Token = "0x600280E")]
	internal void RepaintTexturedElements() { }

	[Address(RVA = "0x1B9BA10", Offset = "0x1B9AC10", Length = "0x119")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "DepthFirstResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ReverseDepthFirstDisposeRenderTrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextureRegistry), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180021EE0")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002816")]
	public void ResetTextures(RenderData renderData) { }

	[Address(RVA = "0x1B9BB30", Offset = "0x1B9AD30", Length = "0x19E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180689250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D6")]
	internal void ReturnPoolRenderData(RenderData data) { }

	[Address(RVA = "0x1B9BCD0", Offset = "0x1B9AED0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180689250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D8")]
	internal void ReturnPoolRenderTree(RenderTree tree) { }

	[Address(RVA = "0x1B9BD90", Offset = "0x1B9AF90", Length = "0xC7")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ReverseDepthFirstDisposeRenderTrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTreeManager), Member = "ReverseDepthFirstDisposeRenderTrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTree), Member = "DepthFirstResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DE")]
	private static void ReverseDepthFirstDisposeRenderTrees(RenderTree renderTree) { }

	[Address(RVA = "0x1B9BE60", Offset = "0x1B9B060", Length = "0x52A")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderer), Member = "ResetDrawCallData", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderDevice), Member = "get_currentFrameCommandLists", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.CommandList>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "get_atlas", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(UIRenderer), Member = "AddDrawCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VectorImageManager), Member = "get_atlas", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIRenderDevice), Member = "SynchronizeMaterials", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E4")]
	private void SerializeRootTreeCommands() { }

	[Address(RVA = "0x507930", Offset = "0x506B30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027FB")]
	private void set_atlas(AtlasBase value) { }

	[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027F8")]
	private void set_device(UIRenderDevice value) { }

	[Address(RVA = "0x1B9DE80", Offset = "0x1B9D080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027DB")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x1B9DE90", Offset = "0x1B9D090", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002808")]
	internal void set_drawStats(bool value) { }

	[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002806")]
	private void set_jobManager(JobManager value) { }

	[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002804")]
	private void set_meshGenerationNodeManager(MeshGenerationNodeManager value) { }

	[Address(RVA = "0x2DD560", Offset = "0x2DC760", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027D4")]
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027F6")]
	private void set_panel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x1B9DEA0", Offset = "0x1B9D0A0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E1")]
	internal void set_rootRenderTree(RenderTree value) { }

	[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027FF")]
	private void set_tempMeshAllocator(TempMeshAllocatorImpl value) { }

	[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60027FD")]
	private void set_vectorImageManager(VectorImageManager value) { }

	[Address(RVA = "0x1B9C390", Offset = "0x1B9B590", Length = "0x160")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "InitRenderChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027E9")]
	public void UIEOnChildAdded(VisualElement ve) { }

	[Address(RVA = "0x1B9C500", Offset = "0x1B9B700", Length = "0xFF")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnElementRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027EC")]
	public void UIEOnChildRemoving(VisualElement ve) { }

	[Address(RVA = "0x1B9C600", Offset = "0x1B9B800", Length = "0x1AB")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnElementRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60027EB")]
	public void UIEOnChildrenReordered(VisualElement ve) { }

	[Address(RVA = "0x1B9C7B0", Offset = "0x1B9B9B0", Length = "0x30")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EF")]
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	[Address(RVA = "0x1B9C7F0", Offset = "0x1B9B9F0", Length = "0x23")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027F1")]
	public void UIEOnColorChanged(VisualElement ve) { }

	[Address(RVA = "0x1B9C820", Offset = "0x1B9BA20", Length = "0x9A")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_disableRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60027F4")]
	public void UIEOnDisableRenderingChanged(VisualElement ve) { }

	[Address(RVA = "0x1B9C8C0", Offset = "0x1B9BAC0", Length = "0x34")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027F0")]
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false) { }

	[Address(RVA = "0x1B9C900", Offset = "0x1B9BB00", Length = "0x1BD")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnElementRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "MarkRenderHintsClean", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027ED")]
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	[Address(RVA = "0x1B9CAC0", Offset = "0x1B9BCC0", Length = "0x22")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027F2")]
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	[Address(RVA = "0x1B9CAF0", Offset = "0x1B9BCF0", Length = "0x33")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTreeManager), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027F3")]
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

}

