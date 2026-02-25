namespace UnityEngine;

[Token(Token = "0x2000024")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class GUILayoutEntry
{
	[Token(Token = "0x40000DD")]
	internal static Rect kDummyRect; //Field offset: 0x0
	[Token(Token = "0x40000DE")]
	protected static int indent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D4")]
	public float minWidth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D5")]
	public float maxWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D6")]
	public float minHeight; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000D7")]
	public float maxHeight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D8")]
	public Rect rect; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D9")]
	public int stretchWidth; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000DA")]
	public int stretchHeight; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DB")]
	public bool consideredForMargin; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000DC")]
	private GUIStyle m_Style; //Field offset: 0x40

	[Token(Token = "0x1700007F")]
	public override int marginBottom
	{
		[Address(RVA = "0x19BB950", Offset = "0x19BAB50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000243")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000080")]
	public int marginHorizontal
	{
		[Address(RVA = "0x19BB980", Offset = "0x19BAB80", Length = "0x46")]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000244")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700007C")]
	public override int marginLeft
	{
		[Address(RVA = "0x19BB9D0", Offset = "0x19BABD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000240")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700007D")]
	public override int marginRight
	{
		[Address(RVA = "0x19BBA00", Offset = "0x19BAC00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000241")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700007E")]
	public override int marginTop
	{
		[Address(RVA = "0x19BBA30", Offset = "0x19BAC30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000242")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000081")]
	public int marginVertical
	{
		[Address(RVA = "0x19BBA60", Offset = "0x19BAC60", Length = "0x46")]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000245")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700007B")]
	public GUIStyle style
	{
		[Address(RVA = "0x19AA890", Offset = "0x19A9A90", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		 get { } //Length: 7
		[Address(RVA = "0x19BBAB0", Offset = "0x19BACB0", Length = "0x41")]
		[CalledBy(Type = "UnityEngine.GUILayout+LayoutedWindow", Member = "DoWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[]), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600023F")]
		 set { } //Length: 65
	}

	[Address(RVA = "0x19BB6C0", Offset = "0x19BA8C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600024F")]
	private static GUILayoutEntry() { }

	[Address(RVA = "0x19BB840", Offset = "0x19BAA40", Length = "0x10C")]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000247")]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	[Address(RVA = "0x19BB720", Offset = "0x19BA920", Length = "0x111")]
	[CalledBy(Type = typeof(GUIWordWrapSizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUIContent), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000246")]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	[Address(RVA = "0x19BACE0", Offset = "0x19B9EE0", Length = "0x380")]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600024D")]
	public override void ApplyOptions(GUILayoutOption[] options) { }

	[Address(RVA = "0x19BB080", Offset = "0x19BA280", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_stretchWidth", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fixedHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIStyle), Member = "get_stretchHeight", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600024C")]
	protected override void ApplyStyleSettings(GUIStyle style) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	public override void CalcHeight() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000248")]
	public override void CalcWidth() { }

	[Address(RVA = "0x19BB950", Offset = "0x19BAB50", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000243")]
	public override int get_marginBottom() { }

	[Address(RVA = "0x19BB980", Offset = "0x19BAB80", Length = "0x46")]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000244")]
	public int get_marginHorizontal() { }

	[Address(RVA = "0x19BB9D0", Offset = "0x19BABD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000240")]
	public override int get_marginLeft() { }

	[Address(RVA = "0x19BBA00", Offset = "0x19BAC00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000241")]
	public override int get_marginRight() { }

	[Address(RVA = "0x19BBA30", Offset = "0x19BAC30", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000242")]
	public override int get_marginTop() { }

	[Address(RVA = "0x19BBA60", Offset = "0x19BAC60", Length = "0x46")]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000245")]
	public int get_marginVertical() { }

	[Address(RVA = "0x19AA890", Offset = "0x19A9A90", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023E")]
	public GUIStyle get_style() { }

	[Address(RVA = "0x19BBAB0", Offset = "0x19BACB0", Length = "0x41")]
	[CalledBy(Type = "UnityEngine.GUILayout+LayoutedWindow", Member = "DoWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[]), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Type)}, ReturnType = typeof(GUILayoutGroup))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023F")]
	public void set_style(GUIStyle value) { }

	[Address(RVA = "0x19BB130", Offset = "0x19BA330", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600024A")]
	public override void SetHorizontal(float x, float width) { }

	[Address(RVA = "0x19BB140", Offset = "0x19BA340", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600024B")]
	public override void SetVertical(float y, float height) { }

	[Address(RVA = "0x19BB150", Offset = "0x19BA350", Length = "0x56E")]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x600024E")]
	public virtual string ToString() { }

}

