namespace UnityEngine.UIElements;

[Token(Token = "0x20003FE")]
public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D5B")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D5C")]
	private FontDefinition m_Value; //Field offset: 0x8

	[Token(Token = "0x17000875")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E84")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E85")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000874")]
	public override FontDefinition value
	{
		[Address(RVA = "0x1B16F50", Offset = "0x1B16150", Length = "0x1A")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(Font))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(FontAsset))]
		[CallerCount(Count = 8)]
		[Token(Token = "0x6001E82")]
		 get { } //Length: 26
		[Address(RVA = "0x1B17010", Offset = "0x1B16210", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001E83")]
		 set { } //Length: 39
	}

	[Address(RVA = "0x1B16ED0", Offset = "0x1B160D0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8A")]
	internal StyleFontDefinition(object obj, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16DB0", Offset = "0x1B15FB0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8D")]
	internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16E30", Offset = "0x1B16030", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E86")]
	public StyleFontDefinition(FontDefinition f) { }

	[Address(RVA = "0x1B16DF0", Offset = "0x1B15FF0", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset&)}, ReturnType = typeof(StyleFontDefinition))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontDefinition), Member = "FromSDFFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E87")]
	public StyleFontDefinition(FontAsset f) { }

	[Address(RVA = "0x1B16E90", Offset = "0x1B16090", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font&)}, ReturnType = typeof(StyleFontDefinition))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontDefinition), Member = "FromFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E88")]
	public StyleFontDefinition(Font f) { }

	[Address(RVA = "0x1B16DD0", Offset = "0x1B15FD0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E89")]
	public StyleFontDefinition(StyleKeyword keyword) { }

	[Address(RVA = "0x1B16E50", Offset = "0x1B16050", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "FromSDFFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8B")]
	internal StyleFontDefinition(FontAsset f, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16F10", Offset = "0x1B16110", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "FromFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8C")]
	internal StyleFontDefinition(Font f, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16D30", Offset = "0x1B15F30", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E90")]
	public override bool Equals(StyleFontDefinition other) { }

	[Address(RVA = "0x1B16C70", Offset = "0x1B15E70", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E91")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E84")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B16F50", Offset = "0x1B16150", Length = "0x1A")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(Font))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6001E82")]
	public override FontDefinition get_value() { }

	[Address(RVA = "0x1B16D80", Offset = "0x1B15F80", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E92")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B16F70", Offset = "0x1B16170", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8E")]
	public static StyleFontDefinition op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B16FC0", Offset = "0x1B161C0", Length = "0x4A")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8F")]
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E85")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B17010", Offset = "0x1B16210", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E83")]
	public override void set_value(FontDefinition value) { }

}

