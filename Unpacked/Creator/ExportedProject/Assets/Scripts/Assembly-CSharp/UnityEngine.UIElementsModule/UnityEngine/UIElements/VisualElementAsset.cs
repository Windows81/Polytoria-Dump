namespace UnityEngine.UIElements;

[Token(Token = "0x20004EF")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400102F")]
	private string m_Name; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4001030")]
	private int m_RuleIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4001031")]
	private string m_Text; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4001032")]
	private PickingMode m_PickingMode; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4001033")]
	private String[] m_Classes; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4001034")]
	private List<String> m_StylesheetPaths; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4001035")]
	private List<StyleSheet> m_Stylesheets; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeReference]
	[Token(Token = "0x4001036")]
	internal UxmlSerializedData m_SerializedData; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4001037")]
	private bool m_SkipClone; //Field offset: 0x88

	[Token(Token = "0x17000983")]
	public String[] classes
	{
		[Address(RVA = "0x19AA810", Offset = "0x19A9A10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600245A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000985")]
	public bool hasStylesheetPaths
	{
		[Address(RVA = "0x1B54D90", Offset = "0x1B53F90", Length = "0x9")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600245C")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000987")]
	public bool hasStylesheets
	{
		[Address(RVA = "0x1B54DA0", Offset = "0x1B53FA0", Length = "0x9")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600245E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000982")]
	public int ruleIndex
	{
		[Address(RVA = "0xFE9840", Offset = "0xFE8A40", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002459")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000988")]
	public UxmlSerializedData serializedData
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600245F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000989")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool skipClone
	{
		[Address(RVA = "0x1B54DB0", Offset = "0x1B53FB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002460")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000984")]
	public List<String> stylesheetPaths
	{
		[Address(RVA = "0x1B54DC0", Offset = "0x1B53FC0", Length = "0x7B")]
		[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600245B")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000986")]
	public List<StyleSheet> stylesheets
	{
		[Address(RVA = "0x1B54E40", Offset = "0x1B54040", Length = "0x7B")]
		[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600245D")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x19AA810", Offset = "0x19A9A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600245A")]
	public String[] get_classes() { }

	[Address(RVA = "0x1B54D90", Offset = "0x1B53F90", Length = "0x9")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600245C")]
	public bool get_hasStylesheetPaths() { }

	[Address(RVA = "0x1B54DA0", Offset = "0x1B53FA0", Length = "0x9")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600245E")]
	public bool get_hasStylesheets() { }

	[Address(RVA = "0xFE9840", Offset = "0xFE8A40", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002459")]
	public int get_ruleIndex() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600245F")]
	public UxmlSerializedData get_serializedData() { }

	[Address(RVA = "0x1B54DB0", Offset = "0x1B53FB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002460")]
	internal bool get_skipClone() { }

	[Address(RVA = "0x1B54DC0", Offset = "0x1B53FC0", Length = "0x7B")]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600245B")]
	public List<String> get_stylesheetPaths() { }

	[Address(RVA = "0x1B54E40", Offset = "0x1B54040", Length = "0x7B")]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600245D")]
	public List<StyleSheet> get_stylesheets() { }

	[Address(RVA = "0x1B54380", Offset = "0x1B53580", Length = "0x11C")]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Token(Token = "0x6002463")]
	private static bool IdsPathMatchesAttributeOverrideIdsPath(List<Int32> idsPath, List<Int32> attributeOverrideIdsPath, int templateId) { }

	[Address(RVA = "0x1B544A0", Offset = "0x1B536A0", Length = "0x6D7")]
	[CalledBy(Type = typeof(TemplateAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleSheets", ReturnType = typeof(VisualElementStyleSheetSet))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementAsset), Member = "get_stylesheets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet>))]
	[Calls(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElementAsset), Member = "get_stylesheetPaths", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreationContext), Member = "get_hasOverrides", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(VisualElementAsset), Member = "IdsPathMatchesAttributeOverrideIdsPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002464")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override VisualElement Instantiate(CreationContext cc) { }

	[Address(RVA = "0x1B54B80", Offset = "0x1B53D80", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002462")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002461")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x1B54D10", Offset = "0x1B53F10", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002465")]
	public virtual string ToString() { }

}

