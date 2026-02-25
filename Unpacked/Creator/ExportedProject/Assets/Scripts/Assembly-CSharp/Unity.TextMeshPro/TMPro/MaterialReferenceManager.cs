namespace TMPro;

[Token(Token = "0x2000012")]
public class MaterialReferenceManager
{
	[Token(Token = "0x4000023")]
	private static MaterialReferenceManager s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000024")]
	private Dictionary<Int32, Material> m_FontMaterialReferenceLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000025")]
	private Dictionary<Int32, TMP_FontAsset> m_FontAssetReferenceLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000026")]
	private Dictionary<Int32, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000027")]
	private Dictionary<Int32, TMP_ColorGradient> m_ColorGradientReferenceLookup; //Field offset: 0x28

	[Token(Token = "0x17000011")]
	public static MaterialReferenceManager instance
	{
		[Address(RVA = "0x18741D0", Offset = "0x18733D0", Length = "0x1C3")]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000037")]
		 get { } //Length: 451
	}

	[Address(RVA = "0x1874080", Offset = "0x1873280", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	public MaterialReferenceManager() { }

	[Address(RVA = "0x1873490", Offset = "0x1872690", Length = "0x95")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000040")]
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	[Address(RVA = "0x1873400", Offset = "0x1872600", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000041")]
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	[Address(RVA = "0x1873620", Offset = "0x1872820", Length = "0xF1")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Asset), Member = "get_materialHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000038")]
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x1873530", Offset = "0x1872730", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Asset), Member = "get_materialHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000039")]
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x1873790", Offset = "0x1872990", Length = "0x6D")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003E")]
	public static void AddFontMaterial(int hashCode, Material material) { }

	[Address(RVA = "0x1873720", Offset = "0x1872920", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003F")]
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	[Address(RVA = "0x18739C0", Offset = "0x1872BC0", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003A")]
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1873AC0", Offset = "0x1872CC0", Length = "0xD9")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003C")]
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1873800", Offset = "0x1872A00", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003B")]
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x18738F0", Offset = "0x1872AF0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003D")]
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1873C10", Offset = "0x1872E10", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000043")]
	public bool Contains(TMP_SpriteAsset sprite) { }

	[Address(RVA = "0x1873BA0", Offset = "0x1872DA0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Asset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000042")]
	public bool Contains(TMP_FontAsset font) { }

	[Address(RVA = "0x18741D0", Offset = "0x18733D0", Length = "0x1C3")]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	public static MaterialReferenceManager get_instance() { }

	[Address(RVA = "0x1873D00", Offset = "0x1872F00", Length = "0x7E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000048")]
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	[Address(RVA = "0x1873C80", Offset = "0x1872E80", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000049")]
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	[Address(RVA = "0x1873E00", Offset = "0x1873000", Length = "0x7E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000044")]
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x1873D80", Offset = "0x1872F80", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000045")]
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x1873F00", Offset = "0x1873100", Length = "0x7E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004A")]
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	[Address(RVA = "0x1873E80", Offset = "0x1873080", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004B")]
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	[Address(RVA = "0x1874000", Offset = "0x1873200", Length = "0x7E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000046")]
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1873F80", Offset = "0x1873180", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000047")]
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

}

