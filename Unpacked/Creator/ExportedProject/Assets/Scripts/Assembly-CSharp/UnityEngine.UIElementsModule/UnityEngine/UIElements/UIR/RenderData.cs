namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200058B")]
internal class RenderData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001370")]
	public VisualElement owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001371")]
	public RenderTree renderTree; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001372")]
	public RenderData parent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001373")]
	public RenderData prevSibling; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001374")]
	public RenderData nextSibling; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001375")]
	public RenderData firstChild; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001376")]
	public RenderData lastChild; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001377")]
	public RenderData groupTransformAncestor; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001378")]
	public RenderData boneTransformAncestor; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001379")]
	public RenderData prevDirty; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400137A")]
	public RenderData nextDirty; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400137B")]
	public RenderDataFlags flags; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400137C")]
	public int depthInRenderTree; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400137D")]
	public RenderDataDirtyTypes dirtiedValues; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400137E")]
	public uint dirtyID; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400137F")]
	public RenderChainCommand firstHeadCommand; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001380")]
	public RenderChainCommand lastHeadCommand; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001381")]
	public RenderChainCommand firstTailCommand; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001382")]
	public RenderChainCommand lastTailCommand; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001383")]
	public bool localFlipsWinding; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x4001384")]
	public bool worldFlipsWinding; //Field offset: 0x99
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x4001385")]
	public bool worldTransformScaleZero; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4001386")]
	public ClipMethod clipMethod; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001387")]
	public int childrenStencilRef; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4001388")]
	public int childrenMaskDepth; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001389")]
	public MeshHandle headMesh; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400138A")]
	public MeshHandle tailMesh; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400138B")]
	public Matrix4x4 verticesSpace; //Field offset: 0xB8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400138C")]
	public BMPAlloc transformID; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400138D")]
	public BMPAlloc clipRectID; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400138E")]
	public BMPAlloc opacityID; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400138F")]
	public BMPAlloc textCoreSettingsID; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001390")]
	public BMPAlloc colorID; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001391")]
	public BMPAlloc backgroundColorID; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001392")]
	public BMPAlloc borderLeftColorID; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001393")]
	public BMPAlloc borderTopColorID; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001394")]
	public BMPAlloc borderRightColorID; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001395")]
	public BMPAlloc borderBottomColorID; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001396")]
	public BMPAlloc tintColorID; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4001397")]
	public float compositeOpacity; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4001398")]
	public float backgroundAlpha; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4001399")]
	public BasicNode<TextureEntry> textures; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400139A")]
	public bool pendingRepaint; //Field offset: 0x160
	[FieldOffset(Offset = "0x161")]
	[Token(Token = "0x400139B")]
	public bool pendingHierarchicalRepaint; //Field offset: 0x161
	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x400139C")]
	private Rect m_ClippingRect; //Field offset: 0x164
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x400139D")]
	private Rect m_ClippingRectMinusGroup; //Field offset: 0x174
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x400139E")]
	private bool m_ClippingRectIsInfinite; //Field offset: 0x184

	[Token(Token = "0x170009F7")]
	public Rect clippingRect
	{
		[Address(RVA = "0x1B91860", Offset = "0x1B90A60", Length = "0x42")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[Token(Token = "0x6002773")]
		 get { } //Length: 66
		[Address(RVA = "0x1B91940", Offset = "0x1B90B40", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002774")]
		 set { } //Length: 11
	}

	[Token(Token = "0x170009F9")]
	internal bool clippingRectIsInfinite
	{
		[Address(RVA = "0x1B917D0", Offset = "0x1B909D0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[Token(Token = "0x6002777")]
		internal get { } //Length: 52
		[Address(RVA = "0x1B91920", Offset = "0x1B90B20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002778")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170009F8")]
	public Rect clippingRectMinusGroup
	{
		[Address(RVA = "0x1B91810", Offset = "0x1B90A10", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
		[Token(Token = "0x6002775")]
		 get { } //Length: 66
		[Address(RVA = "0x1B91930", Offset = "0x1B90B30", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002776")]
		 set { } //Length: 11
	}

	[Token(Token = "0x170009F2")]
	public bool hasExtraData
	{
		[Address(RVA = "0x1B918B0", Offset = "0x1B90AB0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600276E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170009F3")]
	public bool hasExtraMeshes
	{
		[Address(RVA = "0x1B918C0", Offset = "0x1B90AC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600276F")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170009F6")]
	public bool isClippingRectDirty
	{
		[Address(RVA = "0x1B918D0", Offset = "0x1B90AD0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002772")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170009F0")]
	public bool isGroupTransform
	{
		[Address(RVA = "0x1B918E0", Offset = "0x1B90AE0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600276C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170009F1")]
	public bool isIgnoringDynamicColorHint
	{
		[Address(RVA = "0x1B918F0", Offset = "0x1B90AF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600276D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170009F5")]
	public bool isNestedRenderTreeRoot
	{
		[Address(RVA = "0x1B91900", Offset = "0x1B90B00", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002771")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170009F4")]
	public bool isSubTreeQuad
	{
		[Address(RVA = "0x1B91910", Offset = "0x1B90B10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002770")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600277C")]
	public RenderData() { }

	[Address(RVA = "0x1B90770", Offset = "0x1B8F970", Length = "0x59")]
	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Token(Token = "0x6002768")]
	public static bool AllocatesID(BMPAlloc alloc) { }

	[Address(RVA = "0x1B91860", Offset = "0x1B90A60", Length = "0x42")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[Token(Token = "0x6002773")]
	public Rect get_clippingRect() { }

	[Address(RVA = "0x1B917D0", Offset = "0x1B909D0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[Token(Token = "0x6002777")]
	internal bool get_clippingRectIsInfinite() { }

	[Address(RVA = "0x1B91810", Offset = "0x1B90A10", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[Token(Token = "0x6002775")]
	public Rect get_clippingRectMinusGroup() { }

	[Address(RVA = "0x1B918B0", Offset = "0x1B90AB0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600276E")]
	public bool get_hasExtraData() { }

	[Address(RVA = "0x1B918C0", Offset = "0x1B90AC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600276F")]
	public bool get_hasExtraMeshes() { }

	[Address(RVA = "0x1B918D0", Offset = "0x1B90AD0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002772")]
	public bool get_isClippingRectDirty() { }

	[Address(RVA = "0x1B918E0", Offset = "0x1B90AE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600276C")]
	public bool get_isGroupTransform() { }

	[Address(RVA = "0x1B918F0", Offset = "0x1B90AF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600276D")]
	public bool get_isIgnoringDynamicColorHint() { }

	[Address(RVA = "0x1B91900", Offset = "0x1B90B00", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002771")]
	public bool get_isNestedRenderTreeRoot() { }

	[Address(RVA = "0x1B91910", Offset = "0x1B90B10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002770")]
	public bool get_isSubTreeQuad() { }

	[Address(RVA = "0x1B907D0", Offset = "0x1B8F9D0", Length = "0x220")]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityOverflowClipBox", ReturnType = typeof(OverflowClipBox))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600277B")]
	private static void GetLocalClippingRect(VisualElement owner, out Rect localRect) { }

	[Address(RVA = "0x1B90A00", Offset = "0x1B8FC00", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Token(Token = "0x6002769")]
	public static bool InheritsID(BMPAlloc alloc) { }

	[Address(RVA = "0x1B90A60", Offset = "0x1B8FC60", Length = "0x37C")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "GetPooledRenderData", ReturnType = typeof(RenderData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600276A")]
	public void Init() { }

	[Address(RVA = "0x1B90DE0", Offset = "0x1B8FFE0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600277A")]
	private static Rect IntersectClipRects(Rect rect, Rect parentRect) { }

	[Address(RVA = "0x1B90E70", Offset = "0x1B90070", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600276B")]
	public void Reset() { }

	[Address(RVA = "0x1B91940", Offset = "0x1B90B40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002774")]
	public void set_clippingRect(Rect value) { }

	[Address(RVA = "0x1B91920", Offset = "0x1B90B20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002778")]
	internal void set_clippingRectIsInfinite(bool value) { }

	[Address(RVA = "0x1B91930", Offset = "0x1B90B30", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002776")]
	public void set_clippingRectMinusGroup(Rect value) { }

	[Address(RVA = "0x1B90FC0", Offset = "0x1B901C0", Length = "0x80F")]
	[CalledBy(Type = typeof(VisualElement), Member = "EnsureWorldTransformAndClipUpToDate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderData), Member = "get_clippingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RenderData), Member = "get_clippingRectMinusGroup", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RenderData), Member = "get_clippingRectIsInfinite", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(RenderData), Member = "GetLocalClippingRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderData), Member = "get_clippingRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RenderData), Member = "UpdateClippingRect", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AEF1F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002779")]
	internal void UpdateClippingRect() { }

}

