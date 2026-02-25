namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200054C")]
internal class UIRenderDevice : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000553")]
	private sealed class <>c
	{
		[Token(Token = "0x40011E3")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40011E4")]
		public static Func<MeshHandle> <>9__59_0; //Field offset: 0x8
		[Token(Token = "0x40011E5")]
		public static Action<MeshHandle> <>9__59_1; //Field offset: 0x10

		[Address(RVA = "0x1B8F2D0", Offset = "0x1B8E4D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002666")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002667")]
		public <>c() { }

		[Address(RVA = "0x1B8F280", Offset = "0x1B8E480", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MeshHandle), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002668")]
		internal MeshHandle <.ctor>b__59_0() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002669")]
		internal void <.ctor>b__59_1(MeshHandle mh) { }

	}

	[Token(Token = "0x200054E")]
	private struct AllocToFree
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011C7")]
		public Alloc alloc; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011C8")]
		public Page page; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011C9")]
		public bool vertices; //Field offset: 0x20

	}

	[Token(Token = "0x200054D")]
	public struct AllocToUpdate
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011C0")]
		public uint id; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40011C1")]
		public uint allocTime; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011C2")]
		public MeshHandle meshHandle; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011C3")]
		public Alloc permAllocVerts; //Field offset: 0x10
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40011C4")]
		public Alloc permAllocIndices; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40011C5")]
		public Page permPage; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40011C6")]
		public bool copyBackIndices; //Field offset: 0x48

	}

	[Token(Token = "0x200054F")]
	private struct DeviceToFree
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011CA")]
		public uint handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011CB")]
		public Page page; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011CC")]
		public List<CommandList>[] commandLists; //Field offset: 0x10

		[Address(RVA = "0x1B7D730", Offset = "0x1B7C930", Length = "0x232")]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CommandList), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002665")]
		public void Dispose() { }

	}

	[Token(Token = "0x2000550")]
	private struct DisableForceGammaMaterial
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011CD")]
		public Material material; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011CE")]
		public int count; //Field offset: 0x8

	}

	[Token(Token = "0x2000552")]
	public struct DrawStatistics
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011D8")]
		public int currentFrameIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40011D9")]
		public uint totalIndices; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011DA")]
		public uint commandCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40011DB")]
		public uint skippedCommandCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011DC")]
		public uint drawCommandCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40011DD")]
		public uint disableCommandCount; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011DE")]
		public uint materialSetCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40011DF")]
		public uint drawRangeCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011E0")]
		public uint drawRangeCallCount; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40011E1")]
		public uint immediateDraws; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40011E2")]
		public uint stencilRefChanges; //Field offset: 0x28

	}

	[Token(Token = "0x2000551")]
	private struct EvaluationState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011CF")]
		public CommandList activeCommandList; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011D0")]
		public MaterialPropertyBlock constantProps; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011D1")]
		public MaterialPropertyBlock batchProps; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011D2")]
		public Material defaultMat; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011D3")]
		public State curState; //Field offset: 0x20
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40011D4")]
		public Page curPage; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40011D5")]
		public bool mustApplyMaterial; //Field offset: 0x48
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x40011D6")]
		public bool mustApplyBatchProps; //Field offset: 0x49
		[FieldOffset(Offset = "0x4A")]
		[Token(Token = "0x40011D7")]
		public bool mustApplyStencil; //Field offset: 0x4A

	}

	[Token(Token = "0x4001198")]
	internal const uint k_MaxQueuedFrameCount = 4; //Field offset: 0x0
	[Token(Token = "0x4001199")]
	internal const int k_PruneEmptyPageFrameCount = 60; //Field offset: 0x0
	[Token(Token = "0x40011AC")]
	private static LinkedList<DeviceToFree> m_DeviceFreeQueue; //Field offset: 0x0
	[Token(Token = "0x40011AD")]
	private static int m_ActiveDeviceCount; //Field offset: 0x8
	[Token(Token = "0x40011AE")]
	private static bool m_SubscribedToNotifications; //Field offset: 0xC
	[Token(Token = "0x40011AF")]
	private static bool m_SynchronousFree; //Field offset: 0xD
	[Token(Token = "0x40011B0")]
	private static readonly int s_GradientSettingsTexID; //Field offset: 0x10
	[Token(Token = "0x40011B1")]
	private static readonly int s_ShaderInfoTexID; //Field offset: 0x14
	[Token(Token = "0x40011B2")]
	private static ProfilerMarker s_MarkerAllocate; //Field offset: 0x18
	[Token(Token = "0x40011B3")]
	private static ProfilerMarker s_MarkerFree; //Field offset: 0x20
	[Token(Token = "0x40011B4")]
	private static ProfilerMarker s_MarkerAdvanceFrame; //Field offset: 0x28
	[Token(Token = "0x40011B5")]
	private static ProfilerMarker s_MarkerFence; //Field offset: 0x30
	[Token(Token = "0x40011B6")]
	private static ProfilerMarker s_MarkerBeforeDraw; //Field offset: 0x38
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400119A")]
	private IntPtr m_DefaultStencilState; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400119B")]
	private IntPtr m_VertexDecl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400119C")]
	private Page m_FirstPage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400119D")]
	private uint m_NextPageVertexCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400119E")]
	private uint m_LargeMeshVertexCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400119F")]
	private float m_IndexToVertexCountRatio; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011A0")]
	private List<List`1<AllocToFree>> m_DeferredFrees; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40011A1")]
	private List<List`1<AllocToUpdate>> m_Updates; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40011A2")]
	private List<CommandList>[] m_CommandLists; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40011A3")]
	private UInt32[] m_Fences; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40011A4")]
	private MaterialPropertyBlock m_ConstantProps; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40011A5")]
	private MaterialPropertyBlock m_BatchProps; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40011A6")]
	private uint m_FrameIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40011A7")]
	private uint m_NextUpdateID; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40011A8")]
	private DrawStatistics m_DrawStats; //Field offset: 0x70
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40011A9")]
	private readonly LinkedPool<MeshHandle> m_MeshHandles; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40011AA")]
	private readonly DrawParams m_DrawParams; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40011AB")]
	private readonly TextureSlotManager m_TextureSlotManager; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40011B7")]
	private bool <breakBatches>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB9")]
	[Token(Token = "0x40011B8")]
	private readonly bool <isFlat>k__BackingField; //Field offset: 0xB9
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xBA")]
	[Token(Token = "0x40011B9")]
	private readonly bool <forceGammaRendering>k__BackingField; //Field offset: 0xBA
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40011BA")]
	internal int currentFrameCommandListCount; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40011BB")]
	private CommandList m_DefaultCommandList; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40011BC")]
	private Dictionary<Material, DisableForceGammaMaterial> m_DisableForceGammaMaterialTable; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40011BD")]
	private List<Material> m_MaterialToRemove; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40011BE")]
	private List<Material> m_Materialkeys; //Field offset: 0xD8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40011BF")]
	private bool <disposed>k__BackingField; //Field offset: 0xE0

	[Token(Token = "0x170009CA")]
	internal bool breakBatches
	{
		[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002639")]
		internal get { } //Length: 8
		[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600263A")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170009CD")]
	internal List<CommandList>[] commandLists
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600263D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170009CE")]
	internal List<CommandList> currentFrameCommandLists
	{
		[Address(RVA = "0x1B6FAE0", Offset = "0x1B6ECE0", Length = "0x3A")]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600263E")]
		internal get { } //Length: 58
	}

	[Token(Token = "0x170009CF")]
	protected private bool disposed
	{
		[Address(RVA = "0x17F8A80", Offset = "0x17F7C80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002642")]
		 get { } //Length: 8
		[Address(RVA = "0x1B6FB30", Offset = "0x1B6ED30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002643")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170009CB")]
	internal bool forceGammaRendering
	{
		[Address(RVA = "0x1B6FB20", Offset = "0x1B6ED20", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600263B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170009CC")]
	internal uint frameIndex
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600263C")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170009C9")]
	internal static uint maxVerticesPerPage
	{
		[Address(RVA = "0x13D70D0", Offset = "0x13D62D0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002638")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1B6EC30", Offset = "0x1B6DE30", Length = "0x452")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600263F")]
	private static UIRenderDevice() { }

	[Address(RVA = "0x1B6F090", Offset = "0x1B6E290", Length = "0xA44")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRenderDevice), Member = "InitVertexDeclaration", ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_writeMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_passOperationFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_failOperationFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_zFailOperationFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_compareFunctionBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_failOperationBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_zFailOperationBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StencilState), Member = "set_passOperationBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IntPtr), typeof(IntPtr), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawParams), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002640")]
	public UIRenderDevice(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0, bool isFlat = true, bool forceGammaRendering = false) { }

	[Address(RVA = "0x1B68FF0", Offset = "0x1B681F0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600264A")]
	internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	[Address(RVA = "0x1B69060", Offset = "0x1B68260", Length = "0xB7E")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Page), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Page), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18000AC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DataSet`1), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600265B")]
	public void AdvanceFrame() { }

	[Address(RVA = "0x1B69CB0", Offset = "0x1B68EB0", Length = "0x793")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Page), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet`1), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Page), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600264C")]
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, bool shortLived) { }

	[Address(RVA = "0x1B69BE0", Offset = "0x1B68DE0", Length = "0xCB")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "UpdateOrAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle&), typeof(int), typeof(int), typeof(UIRenderDevice), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002646")]
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	[Address(RVA = "0x1B6A450", Offset = "0x1B69650", Length = "0x402")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shaders), Member = "get_runtimeMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIRenderDevice), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(UIRenderDevice), Member = "GetOrCreateCommandList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(VisualElement), typeof(Material), typeof(Texture), typeof(Texture)}, ReturnType = typeof(CommandList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4470")]
	[Calls(Type = typeof(TextureSlotManager), Member = "StartNewBatch", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002652")]
	private void ApplyBatchState(ref EvaluationState st, Texture gradientSettings, Texture shaderInfo) { }

	[Address(RVA = "0x1B6A860", Offset = "0x1B69A60", Length = "0x1DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureSlotManager), Member = "FindOldestSlot", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002651")]
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref EvaluationState st) { }

	[Address(RVA = "0x1B6AA40", Offset = "0x1B69C40", Length = "0x2AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeviceToFree)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree>))]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceToFree), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002645")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1B6ACF0", Offset = "0x1B69EF0", Length = "0x61")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002644")]
	public override void Dispose() { }

	[Address(RVA = "0x1B6AD60", Offset = "0x1B69F60", Length = "0x2E9")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "KickRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBufferRange*), typeof(Int32&), typeof(Int32&), typeof(int), typeof(Page), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4470")]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002659")]
	private void DrawRanges(GPUBuffer<UInt16> ib, GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges, CommandList commandList) { }

	[Address(RVA = "0x1B6B050", Offset = "0x1B6A250", Length = "0xB91")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRenderDevice), Member = "InitializeConstantProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "KickRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBufferRange*), typeof(Int32&), typeof(Int32&), typeof(int), typeof(Page), typeof(CommandList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "GetOrCreateCommandList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(VisualElement), typeof(Material), typeof(Texture), typeof(Texture)}, ReturnType = typeof(CommandList))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C4B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C500")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureSlotManager), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawParams), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandList), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateFenceValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002654")]
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, Nullable<Rect> scissor, float pixelsPerPoint, bool isSerializing, ref Exception immediateException) { }

	[Address(RVA = "0x1B6BBF0", Offset = "0x1B6ADF0", Length = "0x82")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002660")]
	internal static void FlushAllPendingDeviceDisposes() { }

	[Address(RVA = "0x1B6BC80", Offset = "0x1B6AE80", Length = "0x64D")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "FreeExtraMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "UpdateOrAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle&), typeof(int), typeof(int), typeof(UIRenderDevice), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AllocToUpdate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18000AC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600264E")]
	public void Free(MeshHandle mesh) { }

	[Address(RVA = "0x1B6C2D0", Offset = "0x1B6B4D0", Length = "0x2C")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "DrawStats", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002661")]
	internal DrawStatistics GatherDrawStatistics() { }

	[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002639")]
	internal bool get_breakBatches() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600263D")]
	internal List<CommandList>[] get_commandLists() { }

	[Address(RVA = "0x1B6FAE0", Offset = "0x1B6ECE0", Length = "0x3A")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600263E")]
	internal List<CommandList> get_currentFrameCommandLists() { }

	[Address(RVA = "0x17F8A80", Offset = "0x17F7C80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002642")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1B6FB20", Offset = "0x1B6ED20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600263B")]
	internal bool get_forceGammaRendering() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600263C")]
	internal uint get_frameIndex() { }

	[Address(RVA = "0x13D70D0", Offset = "0x13D62D0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002638")]
	internal static uint get_maxVerticesPerPage() { }

	[Address(RVA = "0x1B6C300", Offset = "0x1B6B500", Length = "0x292")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IntPtr), typeof(IntPtr), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CommandList), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "InitializeConstantProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002656")]
	private CommandList GetOrCreateCommandList(ref EvaluationState st, VisualElement owner, Material material, Texture gradientSettings, Texture shaderInfo) { }

	[Address(RVA = "0x1B6C5A0", Offset = "0x1B6B7A0", Length = "0x20C")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shaders), Member = "get_runtimeWorldMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.UIR.UIRenderDevice+DisableForceGammaMaterial>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DisableForceGammaMaterial)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.UIR.UIRenderDevice+DisableForceGammaMaterial>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DisableForceGammaMaterial)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002653")]
	private Material GetOrCreateMaterial(Material material) { }

	[Address(RVA = "0x1B6CB60", Offset = "0x1B6BD60", Length = "0x11D")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "GetOrCreateCommandList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(VisualElement), typeof(Material), typeof(Texture), typeof(Texture)}, ReturnType = typeof(CommandList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002655")]
	private void InitializeConstantProperties(MaterialPropertyBlock constantProps, Texture gradientSettings, Texture shaderInfo) { }

	[Address(RVA = "0x1B6C7B0", Offset = "0x1B6B9B0", Length = "0x3AA")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002641")]
	private void InitVertexDeclaration() { }

	[Address(RVA = "0x1B6CC80", Offset = "0x1B6BE80", Length = "0x2BD")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(UIRenderDevice), Member = "DrawRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<System.UInt16>), typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.DrawBufferRange>), typeof(CommandList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002658")]
	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage, CommandList commandList) { }

	[Address(RVA = "0x1B6CF40", Offset = "0x1B6C140", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[Token(Token = "0x6002663")]
	private static void OnEngineUpdateGlobal() { }

	[Address(RVA = "0x1B6CF80", Offset = "0x1B6C180", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[Token(Token = "0x6002664")]
	private static void OnFlushPendingResources() { }

	[Address(RVA = "0x1B6CFE0", Offset = "0x1B6C1E0", Length = "0xAF")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "SendUpdates", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateFenceValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600264F")]
	public void OnFrameRenderingBegin() { }

	[Address(RVA = "0x1B6D090", Offset = "0x1B6C290", Length = "0x53")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600265E")]
	internal static void PrepareForGfxDeviceRecreate() { }

	[Address(RVA = "0x1B6D0F0", Offset = "0x1B6C2F0", Length = "0x320")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "FlushAllPendingDeviceDisposes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnEngineUpdateGlobal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnFlushPendingResources", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(DeviceToFree), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveFirst", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002662")]
	public static void ProcessDeviceFreeQueue() { }

	[Address(RVA = "0x1B6D420", Offset = "0x1B6C620", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Page), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Page), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600265C")]
	private void PruneUnusedPages() { }

	[Address(RVA = "0x7C64D0", Offset = "0x7C56D0", Length = "0x78")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "KickRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBufferRange*), typeof(Int32&), typeof(Int32&), typeof(int), typeof(Page), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NativeSliceUnsafeUtility), Member = "ConvertExistingDataToNativeSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002650")]
	internal static NativeSlice<T> PtrToSlice(Void* p, int count) { }

	[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600263A")]
	internal void set_breakBatches(bool value) { }

	[Address(RVA = "0x1B6FB30", Offset = "0x1B6ED30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002643")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x1B6D550", Offset = "0x1B6C750", Length = "0x5FB")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_shader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.UIR.UIRenderDevice+DisableForceGammaMaterial>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DisableForceGammaMaterial)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600265D")]
	public void SynchronizeMaterials() { }

	[Address(RVA = "0x1B6DB50", Offset = "0x1B6CD50", Length = "0x145")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600264B")]
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	[Address(RVA = "0x1B6E840", Offset = "0x1B6DA40", Length = "0x2D4")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "UpdateOrAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle&), typeof(int), typeof(int), typeof(UIRenderDevice), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AllocToUpdate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002648")]
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	[Address(RVA = "0x1B6E600", Offset = "0x1B6D800", Length = "0x230")]
	[CalledBy(Type = typeof(RenderEvents), Member = "PrepareNudgeVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIRenderDevice), typeof(MeshHandle), typeof(IntPtr&), typeof(IntPtr&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002647")]
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex>& vertexData) { }

	[Address(RVA = "0x1B6DCA0", Offset = "0x1B6CEA0", Length = "0x733")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(NativeSlice`1<Vertex>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet`1), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18000AC40")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AllocToUpdate))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600264D")]
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	[Address(RVA = "0x1B6E3E0", Offset = "0x1B6D5E0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AllocToUpdate))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002649")]
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	[Address(RVA = "0x1B6E530", Offset = "0x1B6D730", Length = "0xCF")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnFrameRenderingBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002657")]
	private void UpdateFenceValue() { }

	[Address(RVA = "0x1B6EB20", Offset = "0x1B6DD20", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600265A")]
	private void WaitOnCpuFence(uint fence) { }

	[Address(RVA = "0x1B6EBD0", Offset = "0x1B6DDD0", Length = "0x53")]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600265F")]
	internal static void WrapUpGfxDeviceRecreate() { }

}

