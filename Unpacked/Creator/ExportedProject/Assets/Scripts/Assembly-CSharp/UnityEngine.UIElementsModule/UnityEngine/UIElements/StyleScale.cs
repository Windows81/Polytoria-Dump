namespace UnityEngine.UIElements;

[Token(Token = "0x2000403")]
public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D65")]
	private Scale m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D66")]
	private StyleKeyword m_Keyword; //Field offset: 0x10

	[Token(Token = "0x1700087F")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ECB")]
		 get { } //Length: 6
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ECC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700087E")]
	public override Scale value
	{
		[Address(RVA = "0x1B19640", Offset = "0x1B18840", Length = "0x146")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001EC9")]
		 get { } //Length: 326
		[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ECA")]
		 set { } //Length: 14
	}

	[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ECD")]
	public StyleScale(Scale v) { }

	[Address(RVA = "0x1B16660", Offset = "0x1B15860", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ECE")]
	public StyleScale(StyleKeyword keyword) { }

	[Address(RVA = "0x88C310", Offset = "0x88B510", Length = "0xB")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ECF")]
	internal StyleScale(Scale v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B19420", Offset = "0x1B18620", Length = "0x65")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ED3")]
	public override bool Equals(StyleScale other) { }

	[Address(RVA = "0x1B19490", Offset = "0x1B18690", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ED4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ECB")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B19640", Offset = "0x1B18840", Length = "0x146")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001EC9")]
	public override Scale get_value() { }

	[Address(RVA = "0x1B19570", Offset = "0x1B18770", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001ED5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B19790", Offset = "0x1B18990", Length = "0x65")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001ED0")]
	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	[Address(RVA = "0x1B16710", Offset = "0x1B15910", Length = "0xD")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ED1")]
	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B16720", Offset = "0x1B15920", Length = "0x17")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ED2")]
	public static StyleScale op_Implicit(Scale v) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ECC")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1405CF0", Offset = "0x1404EF0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ECA")]
	public override void set_value(Scale value) { }

	[Address(RVA = "0x1B195D0", Offset = "0x1B187D0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001ED6")]
	public virtual string ToString() { }

}

