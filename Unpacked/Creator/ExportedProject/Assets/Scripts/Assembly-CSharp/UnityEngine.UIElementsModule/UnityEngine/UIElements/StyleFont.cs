namespace UnityEngine.UIElements;

[Token(Token = "0x20003FD")]
public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D59")]
	private Font m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D5A")]
	private StyleKeyword m_Keyword; //Field offset: 0x8

	[Token(Token = "0x17000873")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E76")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E77")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000872")]
	public override Font value
	{
		[Address(RVA = "0x1B15A60", Offset = "0x1B14C60", Length = "0xD")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E74")]
		 get { } //Length: 13
		[Address(RVA = "0x1B173D0", Offset = "0x1B165D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001E75")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x1B172D0", Offset = "0x1B164D0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E78")]
	public StyleFont(Font v) { }

	[Address(RVA = "0x13AA4E0", Offset = "0x13A96E0", Length = "0x11")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E79")]
	public StyleFont(StyleKeyword keyword) { }

	[Address(RVA = "0x1B172C0", Offset = "0x1B164C0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E7A")]
	internal StyleFont(Font v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B17150", Offset = "0x1B16350", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E7E")]
	public override bool Equals(StyleFont other) { }

	[Address(RVA = "0x1B17040", Offset = "0x1B16240", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E7F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E76")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B15A60", Offset = "0x1B14C60", Length = "0xD")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E74")]
	public override Font get_value() { }

	[Address(RVA = "0x1B171D0", Offset = "0x1B163D0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E80")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B172E0", Offset = "0x1B164E0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E7B")]
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	[Address(RVA = "0x1B17350", Offset = "0x1B16550", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E7C")]
	public static StyleFont op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B17390", Offset = "0x1B16590", Length = "0x36")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E7D")]
	public static StyleFont op_Implicit(Font v) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E77")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B173D0", Offset = "0x1B165D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E75")]
	public override void set_value(Font value) { }

	[Address(RVA = "0x1B17260", Offset = "0x1B16460", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<System.Object>)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E81")]
	public virtual string ToString() { }

}

