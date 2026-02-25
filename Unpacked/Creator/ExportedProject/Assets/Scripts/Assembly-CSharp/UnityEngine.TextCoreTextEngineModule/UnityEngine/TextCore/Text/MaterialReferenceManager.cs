namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000025")]
internal class MaterialReferenceManager
{
	[Token(Token = "0x40000BF")]
	private static MaterialReferenceManager s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C0")]
	private Dictionary<Int32, Material> m_FontMaterialReferenceLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C1")]
	private Dictionary<Int32, FontAsset> m_FontAssetReferenceLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C2")]
	private Dictionary<Int32, SpriteAsset> m_SpriteAssetReferenceLookup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C3")]
	private Dictionary<Int32, TextColorGradient> m_ColorGradientReferenceLookup; //Field offset: 0x28

	[Token(Token = "0x1700000B")]
	public static MaterialReferenceManager instance
	{
		[Address(RVA = "0x1A35340", Offset = "0x1A34540", Length = "0x1C3")]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000054")]
		 get { } //Length: 451
	}

	[Address(RVA = "0x1A351F0", Offset = "0x1A343F0", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000065")]
	public MaterialReferenceManager() { }

	[Address(RVA = "0x1A348F0", Offset = "0x1A33AF0", Length = "0x95")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005B")]
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	[Address(RVA = "0x1A34860", Offset = "0x1A33A60", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005C")]
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	[Address(RVA = "0x1A34A70", Offset = "0x1A33C70", Length = "0xEE")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextAsset), Member = "get_materialHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000055")]
	public static void AddFontAsset(FontAsset fontAsset) { }

	[Address(RVA = "0x1A34990", Offset = "0x1A33B90", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextAsset), Member = "get_materialHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000056")]
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	[Address(RVA = "0x1A34BD0", Offset = "0x1A33DD0", Length = "0x6D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000059")]
	public static void AddFontMaterial(int hashCode, Material material) { }

	[Address(RVA = "0x1A34B60", Offset = "0x1A33D60", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005A")]
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	[Address(RVA = "0x1A34D10", Offset = "0x1A33F10", Length = "0xD6")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000057")]
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1A34C40", Offset = "0x1A33E40", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000058")]
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1A35340", Offset = "0x1A34540", Length = "0x1C3")]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	public static MaterialReferenceManager get_instance() { }

	[Address(RVA = "0x1A34E70", Offset = "0x1A34070", Length = "0x7E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000061")]
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	[Address(RVA = "0x1A34DF0", Offset = "0x1A33FF0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000062")]
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	[Address(RVA = "0x1A34F70", Offset = "0x1A34170", Length = "0x7E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005D")]
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	[Address(RVA = "0x1A34EF0", Offset = "0x1A340F0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005E")]
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	[Address(RVA = "0x1A35070", Offset = "0x1A34270", Length = "0x7E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000063")]
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	[Address(RVA = "0x1A34FF0", Offset = "0x1A341F0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000064")]
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	[Address(RVA = "0x1A35170", Offset = "0x1A34370", Length = "0x7E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "get_instance", ReturnType = typeof(MaterialReferenceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005F")]
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	[Address(RVA = "0x1A350F0", Offset = "0x1A342F0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000060")]
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

}

