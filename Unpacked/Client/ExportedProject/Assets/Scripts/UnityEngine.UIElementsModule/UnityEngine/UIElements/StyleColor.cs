namespace UnityEngine.UIElements;

[Token(Token = "0x20003F7")]
public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D4C")]
	private Color m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D4D")]
	private StyleKeyword m_Keyword; //Field offset: 0x10

	[Token(Token = "0x1700086A")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E2E")]
		 get { } //Length: 6
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E2F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000869")]
	public override Color value
	{
		[Address(RVA = "0x1B16670", Offset = "0x1B15870", Length = "0x1A")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor&)}, ReturnType = typeof(Color32))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6001E2C")]
		 get { } //Length: 26
		[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E2D")]
		 set { } //Length: 14
	}

	[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E30")]
	public StyleColor(Color v) { }

	[Address(RVA = "0x1B16660", Offset = "0x1B15860", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E31")]
	public StyleColor(StyleKeyword keyword) { }

	[Address(RVA = "0x88C310", Offset = "0x88B510", Length = "0xB")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E32")]
	internal StyleColor(Color v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16450", Offset = "0x1B15650", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E36")]
	public override bool Equals(StyleColor other) { }

	[Address(RVA = "0x1B164D0", Offset = "0x1B156D0", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E37")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E2E")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B16670", Offset = "0x1B15870", Length = "0x1A")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor&)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001E2C")]
	public override Color get_value() { }

	[Address(RVA = "0x1B165D0", Offset = "0x1B157D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E38")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B16690", Offset = "0x1B15890", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E33")]
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	[Address(RVA = "0x1B16710", Offset = "0x1B15910", Length = "0xD")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E34")]
	public static StyleColor op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B16720", Offset = "0x1B15920", Length = "0x17")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E35")]
	public static StyleColor op_Implicit(Color v) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E2F")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E2D")]
	public override void set_value(Color value) { }

	[Address(RVA = "0x1B165F0", Offset = "0x1B157F0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E39")]
	public virtual string ToString() { }

}

