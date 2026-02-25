namespace UnityEngine.UIElements;

[Token(Token = "0x20003FF")]
public struct StyleInt : IStyleValue<Int32>, IEquatable<StyleInt>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D5D")]
	private int m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D5E")]
	private StyleKeyword m_Keyword; //Field offset: 0x4

	[Token(Token = "0x17000877")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E95")]
		 get { } //Length: 6
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E96")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000876")]
	public override int value
	{
		[Address(RVA = "0xF69A80", Offset = "0xF68C80", Length = "0xC")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E93")]
		 get { } //Length: 12
		[Address(RVA = "0xF6A340", Offset = "0xF69540", Length = "0xA")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E94")]
		 set { } //Length: 10
	}

	[Address(RVA = "0x1B16C00", Offset = "0x1B15E00", Length = "0xA")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E97")]
	public StyleInt(StyleKeyword keyword) { }

	[Address(RVA = "0xF69840", Offset = "0xF68A40", Length = "0x7")]
	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E98")]
	internal StyleInt(int v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B17490", Offset = "0x1B16690", Length = "0x22")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E9B")]
	public override bool Equals(StyleInt other) { }

	[Address(RVA = "0x1B173F0", Offset = "0x1B165F0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E9C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E95")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xF69A80", Offset = "0xF68C80", Length = "0xC")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E93")]
	public override int get_value() { }

	[Address(RVA = "0x1B174C0", Offset = "0x1B166C0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E9D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B17530", Offset = "0x1B16730", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E99")]
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	[Address(RVA = "0x1B16C50", Offset = "0x1B15E50", Length = "0x12")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E9A")]
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E96")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xF6A340", Offset = "0xF69540", Length = "0xA")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E94")]
	public override void set_value(int value) { }

	[Address(RVA = "0x1B174D0", Offset = "0x1B166D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E9E")]
	public virtual string ToString() { }

}

