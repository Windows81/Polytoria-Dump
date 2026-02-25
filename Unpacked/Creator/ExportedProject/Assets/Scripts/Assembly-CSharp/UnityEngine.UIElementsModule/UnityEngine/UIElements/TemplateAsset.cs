namespace UnityEngine.UIElements;

[Token(Token = "0x20004B8")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TemplateAsset : VisualElementAsset
{
	[Token(Token = "0x20004B9")]
	internal struct AttributeOverride
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FE3")]
		public string m_ElementName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000FE4")]
		public String[] m_NamesPath; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FE5")]
		public string m_AttributeName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FE6")]
		public string m_Value; //Field offset: 0x18

		[Address(RVA = "0x1B3CBC0", Offset = "0x1B3BDC0", Length = "0x180")]
		[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryFindValueInAttributeOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CreationContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset+AttributeOverride>), typeof(String&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023B7")]
		public bool NamesPathMatchesElementNamesPath(IList<String> elementNamesPath) { }

	}

	[Token(Token = "0x20004BA")]
	internal struct UxmlSerializedDataOverride
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FE7")]
		public int m_ElementId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000FE8")]
		public List<Int32> m_ElementIdsPath; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeReference]
		[Token(Token = "0x4000FE9")]
		public UxmlSerializedData m_SerializedData; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000FDF")]
	private string m_TemplateAlias; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000FE0")]
	private List<AttributeOverride> m_AttributeOverrides; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000FE1")]
	private List<UxmlSerializedDataOverride> m_SerializedDataOverride; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000FE2")]
	private List<SlotUsageEntry> m_SlotUsages; //Field offset: 0xA8

	[Token(Token = "0x17000968")]
	public List<AttributeOverride> attributeOverrides
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023B3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000969")]
	public List<UxmlSerializedDataOverride> serializedDataOverrides
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023B4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700096A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> slotUsages
	{
		[Address(RVA = "0x19AA7E0", Offset = "0x19A99E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023B6")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 10
	}

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B3")]
	public List<AttributeOverride> get_attributeOverrides() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B4")]
	public List<UxmlSerializedDataOverride> get_serializedDataOverrides() { }

	[Address(RVA = "0x19AA7E0", Offset = "0x19A99E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> get_slotUsages() { }

	[Address(RVA = "0x1B3E1B0", Offset = "0x1B3D3B0", Length = "0x848")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializedDataOverrideRange), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset+UxmlSerializedDataOverride>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60023B5")]
	internal virtual VisualElement Instantiate(CreationContext cc) { }

}

