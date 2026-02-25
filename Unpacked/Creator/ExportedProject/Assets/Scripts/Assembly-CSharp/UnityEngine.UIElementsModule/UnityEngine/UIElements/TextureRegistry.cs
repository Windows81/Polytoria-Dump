namespace UnityEngine.UIElements;

[Token(Token = "0x20002D5")]
internal class TextureRegistry
{
	[Token(Token = "0x20002D6")]
	private struct TextureInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7E")]
		public Texture texture; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B7F")]
		public bool dynamic; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000B80")]
		public int refCount; //Field offset: 0xC

	}

	[Token(Token = "0x4000B7C")]
	internal const int maxTextures = 2048; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000B7D")]
	private static readonly TextureRegistry <instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B79")]
	private List<TextureInfo> m_Textures; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B7A")]
	private Dictionary<Texture, TextureId> m_TextureToId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B7B")]
	private Stack<TextureId> m_FreeIds; //Field offset: 0x20

	[Token(Token = "0x170003CF")]
	public static TextureRegistry instance
	{
		[Address(RVA = "0x1C8F100", Offset = "0x1C8E300", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60013C0")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x1C8EE90", Offset = "0x1C8E090", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.TextureId>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013C8")]
	private static TextureRegistry() { }

	[Address(RVA = "0x1C8EFF0", Offset = "0x1C8E1F0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.TextureId>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013C7")]
	public TextureRegistry() { }

	[Address(RVA = "0x1C8E2B0", Offset = "0x1C8D4B0", Length = "0x193")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureRegistry), Member = "AllocAndAcquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(bool)}, ReturnType = typeof(TextureId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C5")]
	public TextureId Acquire(Texture tex) { }

	[Address(RVA = "0x1C8E460", Offset = "0x1C8D660", Length = "0x37F")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureRegistry), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(TextureId))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.TextureId>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C4")]
	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	[Address(RVA = "0x1C8E450", Offset = "0x1C8D650", Length = "0xF")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "AssignTextureIds_DepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60013C2")]
	public TextureId AllocAndAcquireDynamic() { }

	[Address(RVA = "0x1C8F100", Offset = "0x1C8E300", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60013C0")]
	public static TextureRegistry get_instance() { }

	[Address(RVA = "0x1C8E7E0", Offset = "0x1C8D9E0", Length = "0x19F")]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C1")]
	public Texture GetTexture(TextureId id) { }

	[Address(RVA = "0x1C8E980", Offset = "0x1C8DB80", Length = "0x28C")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "CleanupOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.TextureId>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C6")]
	public void Release(TextureId id) { }

	[Address(RVA = "0x1C8EC10", Offset = "0x1C8DE10", Length = "0x273")]
	[CalledBy(Type = typeof(AtlasBase), Member = "SetDynamicTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "OnUpdateDynamicTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C3")]
	public void UpdateDynamic(TextureId id, Texture texture) { }

}

