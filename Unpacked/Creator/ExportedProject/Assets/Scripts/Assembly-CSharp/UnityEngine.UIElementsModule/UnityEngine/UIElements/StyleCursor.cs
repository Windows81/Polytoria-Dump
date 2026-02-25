namespace UnityEngine.UIElements;

[Token(Token = "0x20003F8")]
public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D4E")]
	private Cursor m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D4F")]
	private StyleKeyword m_Keyword; //Field offset: 0x18

	[Token(Token = "0x1700086C")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E3C")]
		 get { } //Length: 6
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E3D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700086B")]
	public override Cursor value
	{
		[Address(RVA = "0x1B16960", Offset = "0x1B15B60", Length = "0x42")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Token(Token = "0x6001E3A")]
		 get { } //Length: 66
		[Address(RVA = "0x1B16A80", Offset = "0x1B15C80", Length = "0x2D")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001E3B")]
		 set { } //Length: 45
	}

	[Address(RVA = "0x1B16910", Offset = "0x1B15B10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E3E")]
	public StyleCursor(StyleKeyword keyword) { }

	[Address(RVA = "0x1B16940", Offset = "0x1B15B40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E3F")]
	internal StyleCursor(Cursor v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16740", Offset = "0x1B15940", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E42")]
	public override bool Equals(StyleCursor other) { }

	[Address(RVA = "0x1B167B0", Offset = "0x1B159B0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001E43")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E3C")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B16960", Offset = "0x1B15B60", Length = "0x42")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Token(Token = "0x6001E3A")]
	public override Cursor get_value() { }

	[Address(RVA = "0x1B16880", Offset = "0x1B15A80", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E44")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B169B0", Offset = "0x1B15BB0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E40")]
	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	[Address(RVA = "0x1B16A20", Offset = "0x1B15C20", Length = "0x5D")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_cursor", ReturnType = typeof(StyleCursor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E41")]
	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E3D")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B16A80", Offset = "0x1B15C80", Length = "0x2D")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E3B")]
	public override void set_value(Cursor value) { }

	[Address(RVA = "0x1B168A0", Offset = "0x1B15AA0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E45")]
	public virtual string ToString() { }

}

