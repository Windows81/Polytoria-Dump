namespace UnityEngine.UIElements;

[Token(Token = "0x20003FC")]
public struct StyleFloat : IStyleValue<Single>, IEquatable<StyleFloat>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D57")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D58")]
	private StyleKeyword m_Keyword; //Field offset: 0x4

	[Token(Token = "0x17000871")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E68")]
		 get { } //Length: 6
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E69")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000870")]
	public override float value
	{
		[Address(RVA = "0x1B16C10", Offset = "0x1B15E10", Length = "0xF")]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_fixedPaneMinDimension", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_flexedPaneMinDimension", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
		[CallerCount(Count = 12)]
		[Token(Token = "0x6001E66")]
		 get { } //Length: 15
		[Address(RVA = "0x1B16BF0", Offset = "0x1B15DF0", Length = "0xC")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E67")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x1B16BF0", Offset = "0x1B15DF0", Length = "0xC")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E6A")]
	public StyleFloat(float v) { }

	[Address(RVA = "0x1B16C00", Offset = "0x1B15E00", Length = "0xA")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E6B")]
	public StyleFloat(StyleKeyword keyword) { }

	[Address(RVA = "0x9DF730", Offset = "0x9DE930", Length = "0x9")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E6C")]
	internal StyleFloat(float v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16B60", Offset = "0x1B15D60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E70")]
	public override bool Equals(StyleFloat other) { }

	[Address(RVA = "0x1B16AB0", Offset = "0x1B15CB0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E71")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E68")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B16C10", Offset = "0x1B15E10", Length = "0xF")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_fixedPaneMinDimension", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_flexedPaneMinDimension", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Token(Token = "0x6001E66")]
	public override float get_value() { }

	[Address(RVA = "0x1AD2AC0", Offset = "0x1AD1CC0", Length = "0x1F")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E72")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B16C20", Offset = "0x1B15E20", Length = "0x2B")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E6D")]
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	[Address(RVA = "0x1B16C50", Offset = "0x1B15E50", Length = "0x12")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E6E")]
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1AD2D70", Offset = "0x1AD1F70", Length = "0x14")]
	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E6F")]
	public static StyleFloat op_Implicit(float v) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E69")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B16BF0", Offset = "0x1B15DF0", Length = "0xC")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E67")]
	public override void set_value(float value) { }

	[Address(RVA = "0x1B16B90", Offset = "0x1B15D90", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<System.Single>)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E73")]
	public virtual string ToString() { }

}

