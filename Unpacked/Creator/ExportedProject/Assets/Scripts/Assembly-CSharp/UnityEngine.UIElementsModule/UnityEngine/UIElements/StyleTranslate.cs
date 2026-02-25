namespace UnityEngine.UIElements;

[Token(Token = "0x2000406")]
public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D6B")]
	private Translate m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D6C")]
	private StyleKeyword m_Keyword; //Field offset: 0x18

	[Token(Token = "0x17000885")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EF3")]
		 get { } //Length: 6
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EF4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000884")]
	public override Translate value
	{
		[Address(RVA = "0x1B1A2D0", Offset = "0x1B194D0", Length = "0xAB")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001EF1")]
		 get { } //Length: 171
		[Address(RVA = "0x1B191C0", Offset = "0x1B183C0", Length = "0x18")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EF2")]
		 set { } //Length: 24
	}

	[Address(RVA = "0x1B191C0", Offset = "0x1B183C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF5")]
	public StyleTranslate(Translate v) { }

	[Address(RVA = "0x1B19190", Offset = "0x1B18390", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF6")]
	public StyleTranslate(StyleKeyword keyword) { }

	[Address(RVA = "0x1B191E0", Offset = "0x1B183E0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF7")]
	internal StyleTranslate(Translate v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B1A0A0", Offset = "0x1B192A0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001EFC")]
	public override bool Equals(StyleTranslate other) { }

	[Address(RVA = "0x1B1A130", Offset = "0x1B19330", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001EFD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF3")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B1A2D0", Offset = "0x1B194D0", Length = "0xAB")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001EF1")]
	public override Translate get_value() { }

	[Address(RVA = "0x1B1A230", Offset = "0x1B19430", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001EFE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B1A380", Offset = "0x1B19580", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001EF8")]
	public static bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	[Address(RVA = "0x1B193F0", Offset = "0x1B185F0", Length = "0x27")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF9")]
	public static StyleTranslate op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B193C0", Offset = "0x1B185C0", Length = "0x21")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EFA")]
	public static StyleTranslate op_Implicit(Translate v) { }

	[Address(RVA = "0x1B1A410", Offset = "0x1B19610", Length = "0x114")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "SetSliderValueFromClick", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "RemoveMultilineComponents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnNextClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnPreviousClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "ScrollHorizontally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Token(Token = "0x6001EFB")]
	public static StyleTranslate op_Implicit(Vector3 v) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF4")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B191C0", Offset = "0x1B183C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EF2")]
	public override void set_value(Translate value) { }

	[Address(RVA = "0x1B1A250", Offset = "0x1B19450", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001EFF")]
	public virtual string ToString() { }

}

