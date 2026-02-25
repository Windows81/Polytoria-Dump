namespace UnityEngine.UIElements;

[Token(Token = "0x20003F4")]
public struct StyleBackgroundPosition : IStyleValue<BackgroundPosition>, IEquatable<StyleBackgroundPosition>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D46")]
	private BackgroundPosition m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D47")]
	private StyleKeyword m_Keyword; //Field offset: 0xC

	[Token(Token = "0x17000864")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
		[CallerCount(Count = 119)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E08")]
		 get { } //Length: 6
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E09")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000863")]
	public override BackgroundPosition value
	{
		[Address(RVA = "0x1B157C0", Offset = "0x1B149C0", Length = "0x3A")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6001E06")]
		 get { } //Length: 58
		[Address(RVA = "0x1B157A0", Offset = "0x1B149A0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E07")]
		 set { } //Length: 22
	}

	[Address(RVA = "0x1B157A0", Offset = "0x1B149A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E0A")]
	public StyleBackgroundPosition(BackgroundPosition v) { }

	[Address(RVA = "0x1B15780", Offset = "0x1B14980", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E0B")]
	public StyleBackgroundPosition(StyleKeyword keyword) { }

	[Address(RVA = "0x1B15760", Offset = "0x1B14960", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E0C")]
	internal StyleBackgroundPosition(BackgroundPosition v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B15680", Offset = "0x1B14880", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E0F")]
	public override bool Equals(StyleBackgroundPosition other) { }

	[Address(RVA = "0x1B155B0", Offset = "0x1B147B0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001E10")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
	[CallerCount(Count = 119)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E08")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B157C0", Offset = "0x1B149C0", Length = "0x3A")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001E06")]
	public override BackgroundPosition get_value() { }

	[Address(RVA = "0x1B156E0", Offset = "0x1B148E0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundPosition), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E11")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B15800", Offset = "0x1B14A00", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E0D")]
	public static bool op_Equality(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs) { }

	[Address(RVA = "0x1B15850", Offset = "0x1B14A50", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E0E")]
	public static StyleBackgroundPosition op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E09")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B157A0", Offset = "0x1B149A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E07")]
	public override void set_value(BackgroundPosition value) { }

	[Address(RVA = "0x1B15700", Offset = "0x1B14900", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E12")]
	public virtual string ToString() { }

}

