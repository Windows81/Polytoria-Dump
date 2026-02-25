namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200058F")]
internal class RenderTree
{
	[Flags]
	[Token(Token = "0x2000590")]
	public enum AllowedClasses
	{
		Clipping = 1,
		Opacity = 2,
		Color = 4,
		TransformSize = 8,
		Visuals = 16,
		All = 31,
	}

	[Token(Token = "0x40013B6")]
	private static readonly ProfilerMarker k_MarkerClipProcessing; //Field offset: 0x0
	[Token(Token = "0x40013B7")]
	private static readonly ProfilerMarker k_MarkerOpacityProcessing; //Field offset: 0x8
	[Token(Token = "0x40013B8")]
	private static readonly ProfilerMarker k_MarkerColorsProcessing; //Field offset: 0x10
	[Token(Token = "0x40013B9")]
	private static readonly ProfilerMarker k_MarkerTransformProcessing; //Field offset: 0x18
	[Token(Token = "0x40013BA")]
	private static readonly ProfilerMarker k_MarkerVisualsProcessing; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013AD")]
	private RenderTreeManager m_RenderTreeManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013AE")]
	private DepthOrderedDirtyTracking m_DirtyTracker; //Field offset: 0x18
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013AF")]
	private RenderChainCommand m_FirstCommand; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013B0")]
	private RenderData m_RootRenderData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40013B1")]
	public TextureId quadTextureId; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40013B2")]
	public RectInt quadRect; //Field offset: 0x5C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013B3")]
	internal RenderTree parent; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013B4")]
	internal RenderTree firstChild; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013B5")]
	internal RenderTree nextSibling; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40013BB")]
	private AllowedClasses m_AllowedDirtyClasses; //Field offset: 0x88

	[Token(Token = "0x170009FC")]
	internal DepthOrderedDirtyTracking dirtyTracker
	{
		[Address(RVA = "0x1B9EE60", Offset = "0x1B9E060", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027A0")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170009FD")]
	internal RenderChainCommand firstCommand
	{
		[Address(RVA = "0x19AA880", Offset = "0x19A9A80", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027A1")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170009FE")]
	internal bool isRootRenderTree
	{
		[Address(RVA = "0x1B9EE70", Offset = "0x1B9E070", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A2")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x170009FA")]
	internal RenderTreeManager renderTreeManager
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600279E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170009FB")]
	internal RenderData rootRenderData
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x600279F")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1B9ECF0", Offset = "0x1B9DEF0", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x60027AF")]
	private static RenderTree() { }

	[Address(RVA = "0x1B9EE40", Offset = "0x1B9E040", Length = "0x11")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027AE")]
	public RenderTree() { }

	[Address(RVA = "0x1B9DF20", Offset = "0x1B9D120", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "ClearDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderDataDirtyTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027AD")]
	internal void ChildWillBeRemoved(RenderData renderData) { }

	[Address(RVA = "0x1B9DFC0", Offset = "0x1B9D1C0", Length = "0x57")]
	[CalledBy(Type = typeof(RenderTree), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTree), Member = "DepthFirstResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ReverseDepthFirstDisposeRenderTrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTree), Member = "DepthFirstResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A6")]
	private void DepthFirstResetTextures(RenderData renderData) { }

	[Address(RVA = "0x1B9E020", Offset = "0x1B9D220", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTreeManager), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTree), Member = "DepthFirstResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A5")]
	public void Dispose() { }

	[Address(RVA = "0x1B9EE60", Offset = "0x1B9E060", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027A0")]
	internal DepthOrderedDirtyTracking get_dirtyTracker() { }

	[Address(RVA = "0x19AA880", Offset = "0x19A9A80", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027A1")]
	internal RenderChainCommand get_firstCommand() { }

	[Address(RVA = "0x1B9EE70", Offset = "0x1B9E070", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A2")]
	internal bool get_isRootRenderTree() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600279E")]
	internal RenderTreeManager get_renderTreeManager() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x600279F")]
	internal RenderData get_rootRenderData() { }

	[Address(RVA = "0x1B9E090", Offset = "0x1B9D290", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "Reset", ReturnType = typeof(void))]
	[Token(Token = "0x60027A3")]
	public void Init(RenderTreeManager renderTreeManager, RenderData rootRenderData) { }

	[Address(RVA = "0x1B9E240", Offset = "0x1B9D440", Length = "0x2B")]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceHeadCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceTailCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "InjectCommandInBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderChainCommand), typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AB")]
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	[Address(RVA = "0x1B9E270", Offset = "0x1B9D470", Length = "0x34")]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceHeadCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceTailCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ResetCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveSingleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AC")]
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	[Address(RVA = "0x1B9E2B0", Offset = "0x1B9D4B0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027A8")]
	public void OnRenderDataOpacityIdChanged(RenderData renderData) { }

	[Address(RVA = "0x1B9E340", Offset = "0x1B9D540", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027A7")]
	public void OnRenderDataTransformOrSizeChanged(RenderData renderData, bool transformChanged, bool clipRectSizeChanged) { }

	[Address(RVA = "0x1B9E3F0", Offset = "0x1B9D5F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027A9")]
	public void OnRenderDataVisualsChanged(RenderData renderData, bool hierarchical) { }

	[Address(RVA = "0x1B9E490", Offset = "0x1B9D690", Length = "0x7E6")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DepthFirstProcessChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JobManager), Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobManager), Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "ClearDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderDataDirtyTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027AA")]
	public void ProcessChanges(ref ChainBuilderStats stats) { }

	[Address(RVA = "0x1B9EC80", Offset = "0x1B9DE80", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60027A4")]
	public void Reset() { }

}

