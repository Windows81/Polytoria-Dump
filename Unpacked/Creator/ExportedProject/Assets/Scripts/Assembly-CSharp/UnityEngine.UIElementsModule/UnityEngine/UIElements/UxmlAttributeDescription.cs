namespace UnityEngine.UIElements;

[Token(Token = "0x20004BC")]
public abstract class UxmlAttributeDescription
{
	[Token(Token = "0x20004BD")]
	internal enum Use
	{
		None = 0,
		Optional = 1,
		Prohibited = 2,
		Required = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FEA")]
	private string <name>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FEB")]
	private String[] m_ObsoleteNames; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FEC")]
	private string <type>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FED")]
	private string <typeNamespace>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FEE")]
	private Use <use>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FEF")]
	private UxmlTypeRestriction <restriction>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700096B")]
	public string name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023BC")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023BD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700096C")]
	public IEnumerable<String> obsoleteNames
	{
		[Address(RVA = "0x1B50610", Offset = "0x1B4F810", Length = "0x78")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60023BE")]
		 set { } //Length: 120
	}

	[Token(Token = "0x17000970")]
	public UxmlTypeRestriction restriction
	{
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023C2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700096D")]
	protected private string type
	{
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023BF")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700096E")]
	protected string typeNamespace
	{
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023C0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700096F")]
	public Use use
	{
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60023C1")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1B505E0", Offset = "0x1B4F7E0", Length = "0x2F")]
	[CalledBy(Type = typeof(UxmlAssetAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTypeAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023BB")]
	protected UxmlAttributeDescription() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023BC")]
	public string get_name() { }

	[Address(RVA = "0x7C99B0", Offset = "0x7C8BB0", Length = "0x116")]
	[CalledBy(Type = typeof(UxmlTypeAttributeDescription`1), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(UxmlStringAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UxmlIntAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UxmlUnsignedIntAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(UxmlUnsignedLongAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(UxmlLongAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(UxmlBoolAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C9")]
	protected T GetValueFromBag(IUxmlAttributes bag, CreationContext cc, Func<String, T, T> converterFunc, T defaultValue) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023BD")]
	public void set_name(string value) { }

	[Address(RVA = "0x1B50610", Offset = "0x1B4F810", Length = "0x78")]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60023BE")]
	public void set_obsoleteNames(IEnumerable<String> value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C2")]
	public void set_restriction(UxmlTypeRestriction value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023BF")]
	protected private void set_type(string value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C0")]
	protected void set_typeNamespace(string value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C1")]
	public void set_use(Use value) { }

	[Address(RVA = "0x1B4FBB0", Offset = "0x1B4EDB0", Length = "0x33C")]
	[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryGetAttributeOverrideValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&), typeof(VisualTreeAsset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AttributeOverride), Member = "NamesPathMatchesElementNamesPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.String>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60023C3")]
	internal bool TryFindValueInAttributeOverrides(string elementName, CreationContext cc, List<AttributeOverride> attributeOverrides, out string value) { }

	[Address(RVA = "0x1B4FEF0", Offset = "0x1B4F0F0", Length = "0x2E8")]
	[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&), typeof(VisualTreeAsset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryFindValueInAttributeOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CreationContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset+AttributeOverride>), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60023C5")]
	internal bool TryGetAttributeOverrideValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset) { }

	[Address(RVA = "0x7CA2F0", Offset = "0x7C94F0", Length = "0xD4")]
	[CalledBy(Type = typeof(UxmlIntAttributeDescription), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlEnumAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C8")]
	protected bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, Func<String, T, T> converterFunc, T defaultValue, ref T value) { }

	[Address(RVA = "0x1B50510", Offset = "0x1B4F710", Length = "0x50")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T", "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&), typeof(VisualTreeAsset&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023C4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) { }

	[Address(RVA = "0x1B501E0", Offset = "0x1B4F3E0", Length = "0x32E")]
	[CalledBy(Type = typeof(UxmlAssetAttributeDescription`1), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UxmlAssetAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlImageAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetAttributeOverrideValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&), typeof(VisualTreeAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(UxmlAsset), Member = "RemoveAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023C7")]
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset) { }

	[Address(RVA = "0x1B50560", Offset = "0x1B4F760", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60023C6")]
	internal bool ValidateName() { }

}

