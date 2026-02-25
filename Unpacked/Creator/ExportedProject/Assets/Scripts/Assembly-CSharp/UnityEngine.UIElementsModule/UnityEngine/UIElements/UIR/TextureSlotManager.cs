namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005AA")]
internal class TextureSlotManager
{
	[Token(Token = "0x4001470")]
	internal static readonly int k_SlotCount; //Field offset: 0x0
	[Token(Token = "0x4001471")]
	internal static readonly int k_SlotSize; //Field offset: 0x4
	[Token(Token = "0x4001472")]
	internal static Int32[] slotIds; //Field offset: 0x8
	[Token(Token = "0x4001473")]
	internal static readonly int textureTableId; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001474")]
	private TextureId[] m_Textures; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001475")]
	private Int32[] m_Tickets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001476")]
	private int m_CurrentTicket; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001477")]
	private int m_FirstUsedTicket; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001478")]
	private Vector4[] m_GpuTextures; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001479")]
	private int <FreeSlots>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400147A")]
	internal TextureRegistry textureRegistry; //Field offset: 0x38

	[Token(Token = "0x17000A26")]
	public private int FreeSlots
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002873")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002874")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1BA1B00", Offset = "0x1BA0D00", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600286D")]
	private static TextureSlotManager() { }

	[Address(RVA = "0x1BA1C80", Offset = "0x1BA0E80", Length = "0x2CA")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600286E")]
	public TextureSlotManager() { }

	[Address(RVA = "0x1BA1240", Offset = "0x1BA0440", Length = "0x307")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyDrawCommandState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(int), typeof(Material), typeof(bool), typeof(EvaluationState&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextureRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandList), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture), typeof(int), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002876")]
	public void Bind(TextureId id, float sdfScale, float sharpness, bool isPremultiplied, int slot, MaterialPropertyBlock mat, CommandList commandList = null) { }

	[Address(RVA = "0x1BA1550", Offset = "0x1BA0750", Length = "0xC9")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyDrawCommandState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(int), typeof(Material), typeof(bool), typeof(EvaluationState&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002875")]
	public int FindOldestSlot() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002873")]
	public int get_FreeSlots() { }

	[Address(RVA = "0x1BA1620", Offset = "0x1BA0820", Length = "0xD7")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureId), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002871")]
	public int IndexOf(TextureId id) { }

	[Address(RVA = "0x1BA1700", Offset = "0x1BA0900", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002872")]
	public void MarkUsed(int slotIndex) { }

	[Address(RVA = "0x1BA1760", Offset = "0x1BA0960", Length = "0x15A")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "GetOrCreateCommandList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(VisualElement), typeof(Material), typeof(Texture), typeof(Texture)}, ReturnType = typeof(CommandList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286F")]
	public void Reset() { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002874")]
	private void set_FreeSlots(int value) { }

	[Address(RVA = "0x1BA18C0", Offset = "0x1BA0AC0", Length = "0x1C0")]
	[CalledBy(Type = typeof(TextureSlotManager), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureId), Member = "ConvertToGpu", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002877")]
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness, bool isPremultiplied) { }

	[Address(RVA = "0x1BA1A90", Offset = "0x1BA0C90", Length = "0x61")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002870")]
	public void StartNewBatch() { }

}

