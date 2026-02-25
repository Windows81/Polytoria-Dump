namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000564")]
internal class EntryProcessor
{
	[Token(Token = "0x2000565")]
	private struct MaskMesh
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001269")]
		public NativeSlice<Vertex> vertices; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400126A")]
		public NativeSlice<UInt16> indices; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400126B")]
		public int indexOffset; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001243")]
	private EntryPreProcessor m_PreProcessor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001244")]
	private RenderTreeManager m_RenderTreeManager; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001245")]
	private RenderData m_CurrentRenderData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001246")]
	private int m_MaskDepth; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001247")]
	private int m_MaskDepthPopped; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001248")]
	private int m_MaskDepthPushed; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001249")]
	private int m_StencilRef; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400124A")]
	private int m_StencilRefPopped; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400124B")]
	private int m_StencilRefPushed; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400124C")]
	private BMPAlloc m_ClipRectId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400124D")]
	private BMPAlloc m_ClipRectIdPopped; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400124E")]
	private BMPAlloc m_ClipRectIdPushed; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400124F")]
	private bool m_IsDrawingMask; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001250")]
	private Stack<MaskMesh> m_MaskMeshes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001251")]
	private bool m_VertexDataComputed; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001252")]
	private Matrix4x4 m_Transform; //Field offset: 0x6C
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4001253")]
	private Color32 m_TransformData; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001254")]
	private Color32 m_OpacityData; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4001255")]
	private Color32 m_TextCoreSettingsPage; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001256")]
	private MeshHandle m_Mesh; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001257")]
	private NativeSlice<Vertex> m_Verts; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001258")]
	private NativeSlice<UInt16> m_Indices; //Field offset: 0xD0
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001259")]
	private ushort m_IndexOffset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400125A")]
	private int m_AllocVertexCount; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400125B")]
	private int m_AllocIndex; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x400125C")]
	private int m_VertsFilled; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400125D")]
	private int m_IndicesFilled; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x400125E")]
	private VertexFlags m_RenderType; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400125F")]
	private bool m_RemapUVs; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4001260")]
	private Rect m_AtlasRect; //Field offset: 0xFC
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4001261")]
	private int m_GradientSettingIndexOffset; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001262")]
	private bool m_IsTail; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001263")]
	private RenderChainCommand m_FirstCommand; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001264")]
	private RenderChainCommand m_LastCommand; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001265")]
	private RenderChainCommand <firstHeadCommand>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001266")]
	private RenderChainCommand <lastHeadCommand>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001267")]
	private RenderChainCommand <firstTailCommand>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001268")]
	private RenderChainCommand <lastTailCommand>k__BackingField; //Field offset: 0x140

	[Token(Token = "0x170009DB")]
	public private RenderChainCommand firstHeadCommand
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AA")]
		 get { } //Length: 8
		[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AB")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170009DD")]
	public private RenderChainCommand firstTailCommand
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AE")]
		 get { } //Length: 8
		[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AF")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170009DC")]
	public private RenderChainCommand lastHeadCommand
	{
		[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AC")]
		 get { } //Length: 8
		[Address(RVA = "0x189D980", Offset = "0x189CB80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AD")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170009DE")]
	public private RenderChainCommand lastTailCommand
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026B0")]
		 get { } //Length: 8
		[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60026B1")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x1B81130", Offset = "0x1B80330", Length = "0x1DF")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60026BE")]
	public EntryProcessor() { }

	[Address(RVA = "0x1B7A600", Offset = "0x1B79800", Length = "0x2449")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(MeshGenerator), Member = "StampRectangleWithSubRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams), typeof(Rect), typeof(Rect), typeof(Rect), typeof(NativePagedList`1<BackgroundRepeatInstance>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AlignmentUtils), Member = "CeilToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3AA0")]
	[Calls(Type = typeof(BackgroundSize), Member = "get_x", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026BA")]
	private void AppendCommand(RenderChainCommand next) { }

	[Address(RVA = "0x1B7EDB0", Offset = "0x1B7DFB0", Length = "0x122")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B3")]
	public void ClearReferences() { }

	[Address(RVA = "0x1B7EEE0", Offset = "0x1B7E0E0", Length = "0xEE")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "DrawReverseMask", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTreeManager), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B9")]
	private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture) { }

	[Address(RVA = "0x1B7EFD0", Offset = "0x1B7E1D0", Length = "0x4D8")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.UIR.EntryProcessor+MaskMesh>), Member = "TryPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskMesh&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "CreateMeshDrawCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(int), typeof(int), typeof(Material), typeof(TextureId)}, ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyMeshJobData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CopyMeshJobData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026B8")]
	private void DrawReverseMask() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AA")]
	public RenderChainCommand get_firstHeadCommand() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AE")]
	public RenderChainCommand get_firstTailCommand() { }

	[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AC")]
	public RenderChainCommand get_lastHeadCommand() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026B0")]
	public RenderChainCommand get_lastTailCommand() { }

	[Address(RVA = "0x1B7F4B0", Offset = "0x1B7E6B0", Length = "0x2E1")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryPreProcessor), Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "FreeExtraMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B2")]
	public void Init(Entry root, RenderTreeManager renderTreeManager, RenderData renderData) { }

	[Address(RVA = "0x1B7F7A0", Offset = "0x1B7E9A0", Length = "0x235")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessHead", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessTail", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "get_statsByRef", ReturnType = typeof(ChainBuilderStats&))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026BB")]
	private void ProcessFirstAlloc(List<AllocSize> allocList, ref MeshHandle mesh) { }

	[Address(RVA = "0x1B7F9E0", Offset = "0x1B7EBE0", Length = "0xCA")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B4")]
	public void ProcessHead() { }

	[Address(RVA = "0x1B7FAB0", Offset = "0x1B7ECB0", Length = "0x874")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "OpacityAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureId), Member = "ConvertToGpu", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "TextCoreSettingsToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ClipRectAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.UIR.EntryProcessor+MaskMesh>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskMesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "TransformAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(EntryProcessor), Member = "CreateMeshDrawCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(int), typeof(int), typeof(Material), typeof(TextureId)}, ReturnType = typeof(RenderChainCommand))]
	[CallsDeduplicatedMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026B7")]
	private void ProcessMeshEntry(Entry entry, TextureId textureId) { }

	[Address(RVA = "0x1B80330", Offset = "0x1B7F530", Length = "0x27C")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTreeManager), Member = "get_statsByRef", ReturnType = typeof(ChainBuilderStats&))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[Calls(Type = typeof(RenderTreeManager), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026BC")]
	private void ProcessNextAlloc() { }

	[Address(RVA = "0x1B805B0", Offset = "0x1B7F7B0", Length = "0x898")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessHead", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessTail", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VectorImageManager), Member = "AddUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(GradientRemap))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EntryProcessor), Member = "DrawReverseMask", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTreeManager), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C4B0")]
	[Calls(Type = typeof(TextureRegistry), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(TextureId))]
	[Calls(Type = typeof(RenderTreeManager), Member = "InsertTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Texture), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181A923B0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026B6")]
	private void ProcessRange(int first, int last) { }

	[Address(RVA = "0x1B80EA0", Offset = "0x1B800A0", Length = "0x16F")]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026B5")]
	public void ProcessTail() { }

	[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AB")]
	private void set_firstHeadCommand(RenderChainCommand value) { }

	[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AF")]
	private void set_firstTailCommand(RenderChainCommand value) { }

	[Address(RVA = "0x189D980", Offset = "0x189CB80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AD")]
	private void set_lastHeadCommand(RenderChainCommand value) { }

	[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60026B1")]
	private void set_lastTailCommand(RenderChainCommand value) { }

	[Address(RVA = "0x1B81010", Offset = "0x1B80210", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BD")]
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex>& verts, out NativeSlice<UInt16>& indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

}

