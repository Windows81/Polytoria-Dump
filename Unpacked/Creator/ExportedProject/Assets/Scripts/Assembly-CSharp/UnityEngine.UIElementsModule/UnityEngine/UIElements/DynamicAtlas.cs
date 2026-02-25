namespace UnityEngine.UIElements;

[Token(Token = "0x2000008")]
internal class DynamicAtlas : AtlasBase
{
	[Token(Token = "0x2000009")]
	public class TextureInfo : LinkedPoolItem<TextureInfo>
	{
		[Token(Token = "0x4000017")]
		public static readonly LinkedPool<TextureInfo> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000013")]
		public DynamicAtlasPage page; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000014")]
		public int counter; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000015")]
		public Alloc2D alloc; //Field offset: 0x28
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000016")]
		public RectInt rect; //Field offset: 0x58

		[Address(RVA = "0x1AB5FB0", Offset = "0x1AB51B0", Length = "0x11E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600002A")]
		private static TextureInfo() { }

		[Address(RVA = "0x1AB60D0", Offset = "0x1AB52D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000029")]
		public TextureInfo() { }

		[Address(RVA = "0x1AB5EF0", Offset = "0x1AB50F0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000027")]
		private static TextureInfo Create() { }

		[Address(RVA = "0x1AB5F60", Offset = "0x1AB5160", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000028")]
		private static void Reset(TextureInfo info) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000009")]
	private Dictionary<Texture, TextureInfo> m_Database; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000A")]
	private DynamicAtlasPage m_PointPage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000B")]
	private DynamicAtlasPage m_BilinearPage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	private ColorSpace m_ColorSpace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000D")]
	private List<IPanel> m_Panels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000E")]
	private int m_MinAtlasSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400000F")]
	private int m_MaxAtlasSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000010")]
	private int m_MaxSubTextureSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000011")]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000012")]
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x50

	[Token(Token = "0x17000005")]
	public DynamicAtlasFilters activeFilters
	{
		[Address(RVA = "0x1AB1260", Offset = "0x1AB0460", Length = "0x1D")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000022")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000007")]
	public DynamicAtlasCustomFilter customFilter
	{
		[Address(RVA = "0x1AB1280", Offset = "0x1AB0480", Length = "0x51")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000025")]
		 set { } //Length: 81
	}

	[Token(Token = "0x17000004")]
	public static DynamicAtlasFilters defaultFilters
	{
		[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000001")]
	internal bool isInitialized
	{
		[Address(RVA = "0x1AB1230", Offset = "0x1AB0430", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000014")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x17000003")]
	public int maxAtlasSize
	{
		[Address(RVA = "0x1AB12E0", Offset = "0x1AB04E0", Length = "0x1D")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000020")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000006")]
	public int maxSubTextureSize
	{
		[Address(RVA = "0x1AB1250", Offset = "0x1AB0450", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000023")]
		 get { } //Length: 6
		[Address(RVA = "0x1AB1300", Offset = "0x1AB0500", Length = "0x1D")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000024")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000002")]
	public int minAtlasSize
	{
		[Address(RVA = "0x1AB1320", Offset = "0x1AB0520", Length = "0x1D")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001F")]
		 set { } //Length: 29
	}

	[Address(RVA = "0x1AB10D0", Offset = "0x1AB02D0", Length = "0x15E")]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	public DynamicAtlas() { }

	[Address(RVA = "0x1AB0250", Offset = "0x1AAF450", Length = "0x8A")]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "OnRemovedFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000019")]
	private void DestroyPages() { }

	[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000021")]
	public static DynamicAtlasFilters get_defaultFilters() { }

	[Address(RVA = "0x1AB1230", Offset = "0x1AB0430", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000014")]
	internal bool get_isInitialized() { }

	[Address(RVA = "0x1AB1250", Offset = "0x1AB0450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000023")]
	public int get_maxSubTextureSize() { }

	[Address(RVA = "0x1AB02E0", Offset = "0x1AAF4E0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	private void InitPages() { }

	[Address(RVA = "0x1AB0430", Offset = "0x1AAF630", Length = "0x20")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600001D")]
	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	[Address(RVA = "0x1AB04C0", Offset = "0x1AAF6C0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600001E")]
	public override bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	[Address(RVA = "0x1AB0690", Offset = "0x1AAF890", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000015")]
	protected virtual void OnAssignedToPanel(IPanel panel) { }

	[Address(RVA = "0x1AB0760", Offset = "0x1AAF960", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlas), Member = "DestroyPages", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000016")]
	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	[Address(RVA = "0x1AB07F0", Offset = "0x1AAF9F0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "Commit", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureRegistry), Member = "UpdateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001C")]
	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	[Address(RVA = "0x1AB0870", Offset = "0x1AAFA70", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicAtlas), Member = "DestroyPages", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTreeManager), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000017")]
	public virtual void Reset() { }

	[Address(RVA = "0x1AB09F0", Offset = "0x1AAFBF0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001B")]
	public virtual void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	[Address(RVA = "0x1AB1260", Offset = "0x1AB0460", Length = "0x1D")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public void set_activeFilters(DynamicAtlasFilters value) { }

	[Address(RVA = "0x1AB1280", Offset = "0x1AB0480", Length = "0x51")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	[Address(RVA = "0x1AB12E0", Offset = "0x1AB04E0", Length = "0x1D")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public void set_maxAtlasSize(int value) { }

	[Address(RVA = "0x1AB1300", Offset = "0x1AB0500", Length = "0x1D")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	public void set_maxSubTextureSize(int value) { }

	[Address(RVA = "0x1AB1320", Offset = "0x1AB0520", Length = "0x1D")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	public void set_minAtlasSize(int value) { }

	[Address(RVA = "0x1AB0B40", Offset = "0x1AAFD40", Length = "0x582")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicAtlasPage), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Alloc2D&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600001A")]
	public virtual bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

