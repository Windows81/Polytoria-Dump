namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000546")]
internal class CommandList : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001181")]
	public VisualElement m_Owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001182")]
	private readonly IntPtr m_VertexDecl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001183")]
	private readonly IntPtr m_StencilState; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001184")]
	public MaterialPropertyBlock constantProps; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001185")]
	public MaterialPropertyBlock batchProps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001186")]
	public GCHandle handle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001187")]
	public Material m_Material; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001188")]
	private List<SerializedCommand> m_Commands; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001189")]
	private Vector4[] m_GpuTextureData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400118A")]
	private NativeList<DrawBufferRange> m_DrawRanges; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400118B")]
	private bool <disposed>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170009C8")]
	protected private bool disposed
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002613")]
		 get { } //Length: 5
		[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002614")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1B60670", Offset = "0x1B5F870", Length = "0x1E2")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "GetOrCreateCommandList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(VisualElement), typeof(Material), typeof(Texture), typeof(Texture)}, ReturnType = typeof(CommandList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600260D")]
	public CommandList(VisualElement owner, IntPtr vertexDecl, IntPtr stencilState, Material material) { }

	[Address(RVA = "0x1B5FC60", Offset = "0x1B5EE60", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4470")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002611")]
	public void ApplyBatchProps() { }

	[Address(RVA = "0x1B5FDC0", Offset = "0x1B5EFC0", Length = "0xAE")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002615")]
	public override void Dispose() { }

	[Address(RVA = "0x1B5FD30", Offset = "0x1B5EF30", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002616")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x1B5FE70", Offset = "0x1B5F070", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4470")]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002612")]
	public void DrawRanges(GPUBuffer<UInt16> ib, GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges) { }

	[Address(RVA = "0x1B60010", Offset = "0x1B5F210", Length = "0x3F6")]
	[CalledBy(Type = typeof(UIRenderer), Member = "OnRenderNodeExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIRenderer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "GetSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Utility), Member = "DrawRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr*), typeof(int), typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.SerializedCommand>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SerializedCommand))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600260F")]
	public void Execute() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002613")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1B60410", Offset = "0x1B5F610", Length = "0x146")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "GetOrCreateCommandList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(VisualElement), typeof(Material), typeof(Texture), typeof(Texture)}, ReturnType = typeof(CommandList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600260E")]
	public void Reset(VisualElement newOwner, Material material) { }

	[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002614")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x1B60560", Offset = "0x1B5F760", Length = "0x108")]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4470")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002610")]
	public void SetTexture(int name, Texture texture, int gpuDataOffset, Vector4 gpuData0, Vector4 gpuData1) { }

}

