namespace UnityEngine.UIElements;

[Token(Token = "0x2000404")]
public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D67")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D68")]
	private TextShadow m_Value; //Field offset: 0x4

	[Token(Token = "0x17000881")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ED9")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EDA")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000880")]
	public override TextShadow value
	{
		[Address(RVA = "0x1B19AE0", Offset = "0x1B18CE0", Length = "0x4B")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Token(Token = "0x6001ED7")]
		 get { } //Length: 75
		[Address(RVA = "0x1B19C20", Offset = "0x1B18E20", Length = "0x1E")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6001ED8")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x1B19A90", Offset = "0x1B18C90", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001EDB")]
	public StyleTextShadow(StyleKeyword keyword) { }

	[Address(RVA = "0x1B19AC0", Offset = "0x1B18CC0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001EDC")]
	internal StyleTextShadow(TextShadow v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B19930", Offset = "0x1B18B30", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EDF")]
	public override bool Equals(StyleTextShadow other) { }

	[Address(RVA = "0x1B19800", Offset = "0x1B18A00", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EE0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ED9")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B19AE0", Offset = "0x1B18CE0", Length = "0x4B")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Token(Token = "0x6001ED7")]
	public override TextShadow get_value() { }

	[Address(RVA = "0x1B199E0", Offset = "0x1B18BE0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextShadow), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001EE1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B19B30", Offset = "0x1B18D30", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EDD")]
	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	[Address(RVA = "0x1B19BE0", Offset = "0x1B18DE0", Length = "0x40")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_textShadow", ReturnType = typeof(StyleTextShadow))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001EDE")]
	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EDA")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B19C20", Offset = "0x1B18E20", Length = "0x1E")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001ED8")]
	public override void set_value(TextShadow value) { }

	[Address(RVA = "0x1B19A20", Offset = "0x1B18C20", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<UnityEngine.UIElements.TextShadow>)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001EE2")]
	public virtual string ToString() { }

}

