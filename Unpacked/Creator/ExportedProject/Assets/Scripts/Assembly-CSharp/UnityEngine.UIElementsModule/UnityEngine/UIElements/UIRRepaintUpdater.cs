namespace UnityEngine.UIElements;

[Token(Token = "0x20002D2")]
internal class UIRRepaintUpdater : BaseVisualTreeUpdater, IPanelRenderer
{
	[Token(Token = "0x4000B6F")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x4000B70")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B6D")]
	private BaseVisualElementPanel attachedPanel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B6E")]
	internal RenderTreeManager renderTreeManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B71")]
	private bool m_ForceGammaRendering; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B72")]
	private uint m_VertexBudget; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B73")]
	private bool <drawStats>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000B74")]
	private bool <breakBatches>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000B75")]
	private bool <disposed>k__BackingField; //Field offset: 0x42

	[Token(Token = "0x170003CC")]
	public bool breakBatches
	{
		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003CD")]
	protected private bool disposed
	{
		[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B2")]
		 get { } //Length: 5
		[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B3")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003CB")]
	public bool drawStats
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600139F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C9")]
	public override bool forceGammaRendering
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600139B")]
		 get { } //Length: 5
		[Address(RVA = "0x1C92F50", Offset = "0x1C92150", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600139C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170003C8")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x1C92F00", Offset = "0x1C92100", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600139A")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170003CA")]
	public override uint vertexBudget
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600139D")]
		 get { } //Length: 4
		[Address(RVA = "0x1C92F60", Offset = "0x1C92160", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600139E")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x1C92D70", Offset = "0x1C91F70", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utility), Member = "add_GraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013A5")]
	private static UIRRepaintUpdater() { }

	[Address(RVA = "0x1C92E80", Offset = "0x1C92080", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseVisualTreeUpdater), Member = "add_panelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001399")]
	public UIRRepaintUpdater() { }

	[Address(RVA = "0x1C91C50", Offset = "0x1C90E50", Length = "0x433")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A8")]
	private void AttachToPanel() { }

	[Address(RVA = "0x1C92090", Offset = "0x1C91290", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013A4")]
	protected override RenderTreeManager CreateRenderChain() { }

	[Address(RVA = "0x1C92100", Offset = "0x1C91300", Length = "0x68")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AC")]
	private void DestroyRenderChain() { }

	[Address(RVA = "0x1C92170", Offset = "0x1C91370", Length = "0x410")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A9")]
	private void DetachFromPanel() { }

	[Address(RVA = "0x1C92590", Offset = "0x1C91790", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[Token(Token = "0x60013B4")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013A0")]
	public bool get_breakBatches() { }

	[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B2")]
	protected bool get_disposed() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600139F")]
	public bool get_drawStats() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600139B")]
	public override bool get_forceGammaRendering() { }

	[Address(RVA = "0x1C92F00", Offset = "0x1C92100", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600139A")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600139D")]
	public override uint get_vertexBudget() { }

	[Address(RVA = "0x1C925C0", Offset = "0x1C917C0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013AA")]
	private void InitRenderChain() { }

	[Address(RVA = "0x1C92680", Offset = "0x1C91880", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRenderDevice), Member = "PrepareForGfxDeviceRecreate", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "GetPanelsIterator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(UIRenderDevice), Member = "WrapUpGfxDeviceRecreate", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "FlushAllPendingDeviceDisposes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013A6")]
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	[Address(RVA = "0x1C92100", Offset = "0x1C91300", Length = "0x68")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AE")]
	private void OnPanelAtlasChanged() { }

	[Address(RVA = "0x1C92840", Offset = "0x1C91A40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
	[Token(Token = "0x60013A7")]
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	[Address(RVA = "0x1C92100", Offset = "0x1C91300", Length = "0x68")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AF")]
	private void OnPanelDrawsInCamerasChanged() { }

	[Address(RVA = "0x1C92860", Offset = "0x1C91A60", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013B0")]
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x1C92100", Offset = "0x1C91300", Length = "0x68")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AD")]
	private void OnPanelIsFlatChanged() { }

	[Address(RVA = "0x1C928D0", Offset = "0x1C91AD0", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A1")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1C92B00", Offset = "0x1C91D00", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RenderRootTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A3")]
	public override void Render() { }

	[Address(RVA = "0x1C92100", Offset = "0x1C91300", Length = "0x68")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTreeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AB")]
	public override void Reset() { }

	[Address(RVA = "0x1C92B90", Offset = "0x1C91D90", Length = "0xBC")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelIsFlatChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelAtlasChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelDrawsInCamerasChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013B1")]
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B3")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x1C92F50", Offset = "0x1C92150", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600139C")]
	public override void set_forceGammaRendering(bool value) { }

	[Address(RVA = "0x1C92F60", Offset = "0x1C92160", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600139E")]
	public override void set_vertexBudget(uint value) { }

	[Address(RVA = "0x1C92C50", Offset = "0x1C91E50", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTreeManager), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A2")]
	public virtual void Update() { }

}

