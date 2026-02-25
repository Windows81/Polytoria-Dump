namespace UnityEngine.UIElements;

[HelpURL("UIE-USS")]
[Token(Token = "0x2000460")]
public class StyleSheet : ScriptableObject
{
	[Token(Token = "0x2000461")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct ImportStruct
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E79")]
		public StyleSheet styleSheet; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000E7A")]
		public String[] mediaQueries; //Field offset: 0x8

	}

	[Token(Token = "0x2000462")]
	public enum OrderedSelectorType
	{
		None = -1,
		Name = 0,
		Type = 1,
		Class = 2,
		Length = 3,
	}

	[Token(Token = "0x4000E78")]
	private static string kCustomPropertyMarker; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000E66")]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x4000E67")]
	private bool m_ImportedWithWarnings; //Field offset: 0x19
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000E68")]
	private StyleRule[] m_Rules; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000E69")]
	private StyleComplexSelector[] m_ComplexSelectors; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000E6A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Single[] floats; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000E6B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Dimension[] dimensions; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000E6C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Color[] colors; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000E6D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal String[] strings; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000E6E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Object[] assets; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000E6F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ImportStruct[] imports; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000E70")]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000E71")]
	private int m_ContentHash; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000E72")]
	internal ScalableImage[] scalableImages; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E73")]
	internal Dictionary<String, StyleComplexSelector>[] tables; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000E74")]
	internal int nonEmptyTablesMask; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E75")]
	internal StyleComplexSelector firstRootSelector; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000E76")]
	internal StyleComplexSelector firstWildCardSelector; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000E77")]
	private bool m_IsDefaultStyleSheet; //Field offset: 0x98

	[Token(Token = "0x170008C8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleComplexSelector[] complexSelectors
	{
		[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600209D")]
		internal get { } //Length: 7
		[Address(RVA = "0x1B2CF80", Offset = "0x1B2C180", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
		[Token(Token = "0x600209E")]
		internal set { } //Length: 37
	}

	[Token(Token = "0x170008CA")]
	public int contentHash
	{
		[Address(RVA = "0x1B2CF50", Offset = "0x1B2C150", Length = "0x6")]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60020A0")]
		 get { } //Length: 6
		[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60020A1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008C9")]
	internal List<StyleSheet> flattenedRecursiveImports
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600209F")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170008C5")]
	public internal bool importedWithErrors
	{
		[Address(RVA = "0x1A76600", Offset = "0x1A75800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002097")]
		 get { } //Length: 7
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002098")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170008C6")]
	public internal bool importedWithWarnings
	{
		[Address(RVA = "0x1B2CF60", Offset = "0x1B2C160", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002099")]
		 get { } //Length: 7
		[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600209A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170008CB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool isDefaultStyleSheet
	{
		[Address(RVA = "0x1B2CF70", Offset = "0x1B2C170", Length = "0xA")]
		[CalledBy(Type = typeof(SelectorMatchRecord), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60020A2")]
		internal get { } //Length: 10
		[Address(RVA = "0x1B2CFB0", Offset = "0x1B2C1B0", Length = "0x10F")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThemeStyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60020A3")]
		internal set { } //Length: 271
	}

	[Token(Token = "0x170008C7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule[] rules
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x600209B")]
		internal get { } //Length: 7
		[Address(RVA = "0x1B2D0C0", Offset = "0x1B2C2C0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
		[Token(Token = "0x600209C")]
		internal set { } //Length: 37
	}

	[Address(RVA = "0x1B2CB50", Offset = "0x1B2BD50", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60020EC")]
	private static StyleSheet() { }

	[Address(RVA = "0x1B2CBC0", Offset = "0x1B2BDC0", Length = "0x387")]
	[CalledBy(Type = typeof(ThemeStyleSheet), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60020EB")]
	public StyleSheet() { }

	[Address(RVA = "0x1B298F0", Offset = "0x1B28AF0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020AB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(StyleValueKeyword keyword) { }

	[Address(RVA = "0x1B29740", Offset = "0x1B28940", Length = "0x1AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CollectionExtensions), Member = "GetValueOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyDictionary`2<TKey, TValue>", "TKey", "TValue"}, ReturnType = "TValue")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60020B3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(Enum value) { }

	[Address(RVA = "0x1B296F0", Offset = "0x1B288F0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x60020B2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(object value) { }

	[Address(RVA = "0x1B29A00", Offset = "0x1B28C00", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x60020B1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(string value) { }

	[Address(RVA = "0x1B298F0", Offset = "0x1B28AF0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020AC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(StyleValueFunction function) { }

	[Address(RVA = "0x1B29A50", Offset = "0x1B28C50", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage[]&), typeof(ScalableImage)}, ReturnType = typeof(int))]
	[Token(Token = "0x60020B0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(ScalableImage value) { }

	[Address(RVA = "0x1B29950", Offset = "0x1B28B50", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]&), typeof(float)}, ReturnType = typeof(int))]
	[Token(Token = "0x60020AD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(float value) { }

	[Address(RVA = "0x1B29AB0", Offset = "0x1B28CB0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]&), typeof(Dimension)}, ReturnType = typeof(int))]
	[Token(Token = "0x60020AE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(Dimension value) { }

	[Address(RVA = "0x1B299A0", Offset = "0x1B28BA0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "T"}, ReturnType = typeof(int))]
	[Token(Token = "0x60020AF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int AddValue(Color value) { }

	[Address(RVA = "0x7651D0", Offset = "0x7643D0", Length = "0x7D")]
	[CalledBy(Type = typeof(StyleSheet), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "Unity.Collections.CollectionExtensions", Member = "AddToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "SetTemporaryContentHash", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60020AA")]
	private int AddValueToArray(ref T[] array, T value) { }

	[Address(RVA = "0x765550", Offset = "0x764750", Length = "0x1FF")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A5")]
	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	[Address(RVA = "0x1B29B00", Offset = "0x1B28D00", Length = "0xCC")]
	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020D7")]
	private static bool CustomStartsWith(string originalString, string pattern) { }

	[Address(RVA = "0x1B29D00", Offset = "0x1B28F00", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020A7")]
	internal void FlattenImportedStyleSheetsRecursive() { }

	[Address(RVA = "0x1B29BD0", Offset = "0x1B28DD0", Length = "0x124")]
	[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020A8")]
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600209D")]
	internal StyleComplexSelector[] get_complexSelectors() { }

	[Address(RVA = "0x1B2CF50", Offset = "0x1B2C150", Length = "0x6")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60020A0")]
	public int get_contentHash() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600209F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	[Address(RVA = "0x1A76600", Offset = "0x1A75800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002097")]
	public bool get_importedWithErrors() { }

	[Address(RVA = "0x1B2CF60", Offset = "0x1B2C160", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002099")]
	public bool get_importedWithWarnings() { }

	[Address(RVA = "0x1B2CF70", Offset = "0x1B2C170", Length = "0xA")]
	[CalledBy(Type = typeof(SelectorMatchRecord), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60020A2")]
	internal bool get_isDefaultStyleSheet() { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x600209B")]
	internal StyleRule[] get_rules() { }

	[Address(RVA = "0x1B29D80", Offset = "0x1B28F80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[Token(Token = "0x60020A6")]
	internal override void OnEnable() { }

	[Address(RVA = "0x1B29D90", Offset = "0x1B28F90", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = "IsAngle", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "ToAngle", ReturnType = typeof(Angle))]
	[Calls(Type = typeof(Angle), Member = "None", ReturnType = typeof(Angle))]
	[Token(Token = "0x60020D3")]
	internal Angle ReadAngle(StyleValueHandle handle) { }

	[Address(RVA = "0x1B29DF0", Offset = "0x1B28FF0", Length = "0x58")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020C6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object ReadAssetReference(StyleValueHandle handle) { }

	[Address(RVA = "0x1B29E50", Offset = "0x1B29050", Length = "0x116")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetColor), Member = "TryGetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020BA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Color ReadColor(StyleValueHandle handle) { }

	[Address(RVA = "0x1B29F70", Offset = "0x1B29170", Length = "0xB0")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchTime", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchPercentage", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchLength", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(BackgroundPositionKeyword)}, ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue)}, ReturnType = typeof(Angle))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOriginEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TransformOrigin))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TimeValue))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(TimeValue))]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Angle))]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchAngle", ReturnType = typeof(bool))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Token(Token = "0x60020B8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	[Address(RVA = "0x7662A0", Offset = "0x7654A0", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetUtility), Member = "ConvertDashToHungarian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020C0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TEnum ReadEnum(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A020", Offset = "0x1B29220", Length = "0x58")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadEnum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = "TEnum")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListEasingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020BE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadEnum(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A080", Offset = "0x1B29280", Length = "0x9A")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(float)}, ReturnType = typeof(Cursor))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.StyleVariableResolver+Result")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Scale))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Rotate))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchLength", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchPercentage", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchFilterFunction", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchAngle", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Token(Token = "0x60020B6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal float ReadFloat(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A4A0", Offset = "0x1B296A0", Length = "0x9")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A120", Offset = "0x1B29320", Length = "0x11C")]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60020CC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadFunctionName(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A4A0", Offset = "0x1B296A0", Length = "0x9")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020B4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A4B0", Offset = "0x1B296B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = "IsLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "ToLength", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "Auto", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "None", ReturnType = typeof(Length))]
	[Token(Token = "0x60020D1")]
	internal Length ReadLength(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A520", Offset = "0x1B29720", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020C7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A580", Offset = "0x1B29780", Length = "0x58")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020C4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadResourcePath(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A5E0", Offset = "0x1B297E0", Length = "0x7D")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(ScalableImage))]
	[Token(Token = "0x60020CD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A660", Offset = "0x1B29860", Length = "0x58")]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020BC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadString(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A6C0", Offset = "0x1B298C0", Length = "0x8E")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListStylePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60020CF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StylePropertyName ReadStylePropertyName(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A750", Offset = "0x1B29950", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = "IsTimeValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "ToTime", ReturnType = typeof(TimeValue))]
	[Token(Token = "0x60020D5")]
	internal TimeValue ReadTimeValue(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2A790", Offset = "0x1B29990", Length = "0x58")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.StyleVariableResolver+Result")]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020C2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadVariable(StyleValueHandle handle) { }

	[Address(RVA = "0x1B2CF80", Offset = "0x1B2C180", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[Token(Token = "0x600209E")]
	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A1")]
	public void set_contentHash(int value) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002098")]
	internal void set_importedWithErrors(bool value) { }

	[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600209A")]
	internal void set_importedWithWarnings(bool value) { }

	[Address(RVA = "0x1B2CFB0", Offset = "0x1B2C1B0", Length = "0x10F")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThemeStyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60020A3")]
	internal void set_isDefaultStyleSheet(bool value) { }

	[Address(RVA = "0x1B2D0C0", Offset = "0x1B2C2C0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[Token(Token = "0x600209C")]
	internal void set_rules(StyleRule[] value) { }

	[Address(RVA = "0x1B2A7F0", Offset = "0x1B299F0", Length = "0x41")]
	[CalledBy(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020EA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetTemporaryContentHash() { }

	[Address(RVA = "0x1B2A840", Offset = "0x1B29A40", Length = "0x810")]
	[CalledBy(Type = typeof(StyleSheet), Member = "set_rules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "set_complexSelectors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThemeStyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleComplexSelector), Member = "CalculateHashes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(StyleComplexSelector), Member = "CachePseudoStateMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "CustomStartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020A9")]
	private void SetupReferences() { }

	[Address(RVA = "0x7664C0", Offset = "0x7656C0", Length = "0x7D")]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Color&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A4")]
	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }

	[Address(RVA = "0x1B2B070", Offset = "0x1B2A270", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "IsAngle", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "ToAngle", ReturnType = typeof(Angle))]
	[Calls(Type = typeof(Angle), Member = "None", ReturnType = typeof(Angle))]
	[Token(Token = "0x60020D4")]
	internal bool TryReadAngle(StyleValueHandle handle, out Angle value) { }

	[Address(RVA = "0x1B2B100", Offset = "0x1B2A300", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020C9")]
	internal bool TryReadAssetReference(StyleValueHandle handle, out object value) { }

	[Address(RVA = "0x1B2B170", Offset = "0x1B2A370", Length = "0x126")]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color>), typeof(Color&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TextShadow))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(StyleValueType), typeof(StyleValueHandle), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetColor), Member = "TryGetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020BB")]
	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	[Address(RVA = "0x1B2B2A0", Offset = "0x1B2A4A0", Length = "0xEC")]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ReadSingleLineHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Angle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(TimeValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextAutoSize))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TextShadow))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TextAutoSize))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	[Token(Token = "0x60020B9")]
	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	[Address(RVA = "0x766880", Offset = "0x765A80", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetUtility), Member = "ConvertDashToHungarian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020C1")]
	internal bool TryReadEnum(StyleValueHandle handle, out TEnum value) { }

	[Address(RVA = "0x1B2B390", Offset = "0x1B2A590", Length = "0x6A")]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadEnum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), "TEnum&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020BF")]
	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x1B2B400", Offset = "0x1B2A600", Length = "0xCA")]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Single>), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020B7")]
	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	[Address(RVA = "0x1B2B4D0", Offset = "0x1B2A6D0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020CB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadFunction(StyleValueHandle handle, out StyleValueFunction value) { }

	[Address(RVA = "0x1B2B4F0", Offset = "0x1B2A6F0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020B5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadKeyword(StyleValueHandle handle, out StyleValueKeyword value) { }

	[Address(RVA = "0x1B2B510", Offset = "0x1B2A710", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "IsLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "ToLength", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "Auto", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "None", ReturnType = typeof(Length))]
	[Token(Token = "0x60020D2")]
	internal bool TryReadLength(StyleValueHandle handle, out Length value) { }

	[Address(RVA = "0x1B2B5B0", Offset = "0x1B2A7B0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020C8")]
	internal bool TryReadMissingAssetReferenceUrl(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x1B2B620", Offset = "0x1B2A820", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020C5")]
	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x1B2B690", Offset = "0x1B2A890", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(ScalableImage&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020CE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadScalableImage(StyleValueHandle handle, out ScalableImage value) { }

	[Address(RVA = "0x1B2B700", Offset = "0x1B2A900", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020BD")]
	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x1B2B770", Offset = "0x1B2A970", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60020D0")]
	internal bool TryReadStylePropertyName(StyleValueHandle handle, out StylePropertyName value) { }

	[Address(RVA = "0x1B2B830", Offset = "0x1B2AA30", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "IsTimeValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = "ToTime", ReturnType = typeof(TimeValue))]
	[Token(Token = "0x60020D6")]
	internal bool TryReadTimeValue(StyleValueHandle handle, out TimeValue value) { }

	[Address(RVA = "0x1B2B890", Offset = "0x1B2AA90", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60020C3")]
	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x1B2B900", Offset = "0x1B2AB00", Length = "0x30C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Angle), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]&), typeof(Dimension)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60020E8")]
	internal void WriteAngle(ref StyleValueHandle handle, Angle value) { }

	[Address(RVA = "0x1B2BC10", Offset = "0x1B2AE10", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteAssetReference(ref StyleValueHandle handle, object value) { }

	[Address(RVA = "0x1B2BD20", Offset = "0x1B2AF20", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020DB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteColor(ref StyleValueHandle handle, Color color) { }

	[Address(RVA = "0x1B2BE00", Offset = "0x1B2B000", Length = "0x44")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteCommaSeparator(ref StyleValueHandle handle) { }

	[Address(RVA = "0x1B2BE50", Offset = "0x1B2B050", Length = "0xC9")]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(TimeValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]&), typeof(Dimension)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020DA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteDimension(ref StyleValueHandle handle, Dimension dimension) { }

	[Address(RVA = "0x766970", Offset = "0x765B70", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetUtility), Member = "GetEnumExportString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "WriteEnumAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60020DD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteEnum(ref StyleValueHandle handle, TEnum value) { }

	[Address(RVA = "0x1B2BF20", Offset = "0x1B2B120", Length = "0xD9")]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteEnum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), "TEnum"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020DE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteEnumAsString(ref StyleValueHandle handle, string valueStr) { }

	[Address(RVA = "0x1B2C000", Offset = "0x1B2B200", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]&), typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020D9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteFloat(ref StyleValueHandle handle, float value) { }

	[Address(RVA = "0x1B2C0D0", Offset = "0x1B2B2D0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteFunction(ref StyleValueHandle handle, StyleValueFunction function) { }

	[Address(RVA = "0x1B2C120", Offset = "0x1B2B320", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020D8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteKeyword(ref StyleValueHandle handle, StyleValueKeyword value) { }

	[Address(RVA = "0x1B2C170", Offset = "0x1B2B370", Length = "0x323")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]&), typeof(Dimension)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60020E7")]
	internal void WriteLength(ref StyleValueHandle handle, Length value) { }

	[Address(RVA = "0x1B2C4A0", Offset = "0x1B2B6A0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteMissingAssetReferenceUrl(ref StyleValueHandle handle, string assetReference) { }

	[Address(RVA = "0x1B2C580", Offset = "0x1B2B780", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteResourcePath(ref StyleValueHandle handle, string resourcePath) { }

	[Address(RVA = "0x1B2C660", Offset = "0x1B2B860", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage[]&), typeof(ScalableImage)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteScalableImage(ref StyleValueHandle handle, ScalableImage scalableImage) { }

	[Address(RVA = "0x1B2C750", Offset = "0x1B2B950", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020DC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteString(ref StyleValueHandle handle, string value) { }

	[Address(RVA = "0x1B2C830", Offset = "0x1B2BA30", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteStylePropertyName(ref StyleValueHandle handle, StylePropertyName propertyName) { }

	[Address(RVA = "0x1B2C910", Offset = "0x1B2BB10", Length = "0x156")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "WriteDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Dimension)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60020E9")]
	internal void WriteTimeValue(ref StyleValueHandle handle, TimeValue value) { }

	[Address(RVA = "0x1B2CA70", Offset = "0x1B2BC70", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleSheet), Member = "AddValueToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020DF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteVariable(ref StyleValueHandle handle, string variableName) { }

}

