namespace UnityEngine.UIElements;

[Token(Token = "0x20003F5")]
public struct StyleBackgroundRepeat : IStyleValue<BackgroundRepeat>, IEquatable<StyleBackgroundRepeat>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D48")]
	private BackgroundRepeat m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D49")]
	private StyleKeyword m_Keyword; //Field offset: 0x8

	[Token(Token = "0x17000866")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E15")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E16")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000865")]
	public override BackgroundRepeat value
	{
		[Address(RVA = "0x1B15A60", Offset = "0x1B14C60", Length = "0xD")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E13")]
		 get { } //Length: 13
		[Address(RVA = "0x1B15AC0", Offset = "0x1B14CC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001E14")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x1B15A30", Offset = "0x1B14C30", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E17")]
	public StyleBackgroundRepeat(BackgroundRepeat v) { }

	[Address(RVA = "0x1B15A50", Offset = "0x1B14C50", Length = "0xB")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E18")]
	public StyleBackgroundRepeat(StyleKeyword keyword) { }

	[Address(RVA = "0x1B15A40", Offset = "0x1B14C40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E19")]
	internal StyleBackgroundRepeat(BackgroundRepeat v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B15880", Offset = "0x1B14A80", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E1C")]
	public override bool Equals(StyleBackgroundRepeat other) { }

	[Address(RVA = "0x1B158E0", Offset = "0x1B14AE0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001E1D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E15")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B15A60", Offset = "0x1B14C60", Length = "0xD")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E13")]
	public override BackgroundRepeat get_value() { }

	[Address(RVA = "0x1B159A0", Offset = "0x1B14BA0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E1E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B15A70", Offset = "0x1B14C70", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E1A")]
	public static bool op_Equality(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs) { }

	[Address(RVA = "0x1B15AA0", Offset = "0x1B14CA0", Length = "0x20")]
	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E1B")]
	public static StyleBackgroundRepeat op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E16")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B15AC0", Offset = "0x1B14CC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E14")]
	public override void set_value(BackgroundRepeat value) { }

	[Address(RVA = "0x1B159C0", Offset = "0x1B14BC0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E1F")]
	public virtual string ToString() { }

}

