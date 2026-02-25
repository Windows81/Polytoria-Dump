namespace UnityEngine.UIElements;

[Token(Token = "0x20003F6")]
public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D4A")]
	private BackgroundSize m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D4B")]
	private StyleKeyword m_Keyword; //Field offset: 0x14

	[Token(Token = "0x17000868")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E22")]
		 get { } //Length: 6
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E23")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000867")]
	public override BackgroundSize value
	{
		[Address(RVA = "0x1B15D50", Offset = "0x1B14F50", Length = "0x25")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleBackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x6001E20")]
		 get { } //Length: 37
		[Address(RVA = "0x1B15E50", Offset = "0x1B15050", Length = "0x14")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E21")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x1B15D40", Offset = "0x1B14F40", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E24")]
	public StyleBackgroundSize(StyleKeyword keyword) { }

	[Address(RVA = "0x1B15D20", Offset = "0x1B14F20", Length = "0x11")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E25")]
	internal StyleBackgroundSize(BackgroundSize v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B15BF0", Offset = "0x1B14DF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E28")]
	public override bool Equals(StyleBackgroundSize other) { }

	[Address(RVA = "0x1B15AD0", Offset = "0x1B14CD0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001E29")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E22")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B15D50", Offset = "0x1B14F50", Length = "0x25")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleBackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x6001E20")]
	public override BackgroundSize get_value() { }

	[Address(RVA = "0x1B15C90", Offset = "0x1B14E90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E2A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B15D80", Offset = "0x1B14F80", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E26")]
	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	[Address(RVA = "0x1B15E20", Offset = "0x1B15020", Length = "0x27")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E27")]
	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E23")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B15E50", Offset = "0x1B15050", Length = "0x14")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E21")]
	public override void set_value(BackgroundSize value) { }

	[Address(RVA = "0x1B15CB0", Offset = "0x1B14EB0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E2B")]
	public virtual string ToString() { }

}

