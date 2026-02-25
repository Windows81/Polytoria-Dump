namespace UnityEngine.UIElements;

[Token(Token = "0x200045D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleSelectorPart
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000E56")]
	private string m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000E57")]
	private StyleSelectorType m_Type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E58")]
	internal object tempData; //Field offset: 0x10

	[Token(Token = "0x170008C4")]
	public internal StyleSelectorType type
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002091")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002092")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170008C3")]
	public string value
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002090")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1B28600", Offset = "0x1B27800", Length = "0x51")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "Class", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddClasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002094")]
	public static StyleSelectorPart CreateClass(string className) { }

	[Address(RVA = "0x1B28660", Offset = "0x1B27860", Length = "0x51")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002095")]
	public static StyleSelectorPart CreateId(string Id) { }

	[Address(RVA = "0x1B286C0", Offset = "0x1B278C0", Length = "0x4E")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "SingleBaseType", ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "AddType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T2"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002096")]
	public static StyleSelectorPart CreatePredicate(object predicate) { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002091")]
	public StyleSelectorType get_type() { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002090")]
	public string get_value() { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002092")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_type(StyleSelectorType value) { }

	[Address(RVA = "0x1B28710", Offset = "0x1B27910", Length = "0x70")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSelector+<>c", Member = "<ToString>b__11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSelectorPart)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002093")]
	public virtual string ToString() { }

}

