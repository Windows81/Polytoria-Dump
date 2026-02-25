namespace UnityEngine.UIElements;

[Token(Token = "0x2000471")]
public struct StyleTextAutoSize : IStyleValue<TextAutoSize>, IEquatable<StyleTextAutoSize>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EC3")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000EC4")]
	private TextAutoSize m_Value; //Field offset: 0x4

	[Token(Token = "0x170008D2")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002120")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002121")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170008D1")]
	public override TextAutoSize value
	{
		[Address(RVA = "0x1B2D350", Offset = "0x1B2C550", Length = "0x25")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Token(Token = "0x600211E")]
		 get { } //Length: 37
		[Address(RVA = "0x1B2D410", Offset = "0x1B2C610", Length = "0x14")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x600211F")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x1B2D340", Offset = "0x1B2C540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002122")]
	public StyleTextAutoSize(StyleKeyword keyword) { }

	[Address(RVA = "0x1B2D320", Offset = "0x1B2C520", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002123")]
	internal StyleTextAutoSize(TextAutoSize v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B2D0F0", Offset = "0x1B2C2F0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextAutoSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002126")]
	public override bool Equals(StyleTextAutoSize other) { }

	[Address(RVA = "0x1B2D170", Offset = "0x1B2C370", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TextAutoSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002127")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002120")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B2D350", Offset = "0x1B2C550", Length = "0x25")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x600211E")]
	public override TextAutoSize get_value() { }

	[Address(RVA = "0x1B2D270", Offset = "0x1B2C470", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextAutoSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002128")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B2D380", Offset = "0x1B2C580", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextAutoSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002124")]
	public static bool op_Equality(StyleTextAutoSize lhs, StyleTextAutoSize rhs) { }

	[Address(RVA = "0x1B2D3E0", Offset = "0x1B2C5E0", Length = "0x2F")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unityTextAutoSize", ReturnType = typeof(StyleTextAutoSize))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002125")]
	public static StyleTextAutoSize op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002121")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B2D410", Offset = "0x1B2C610", Length = "0x14")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600211F")]
	public override void set_value(TextAutoSize value) { }

	[Address(RVA = "0x1B2D2B0", Offset = "0x1B2C4B0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6002129")]
	public virtual string ToString() { }

}

