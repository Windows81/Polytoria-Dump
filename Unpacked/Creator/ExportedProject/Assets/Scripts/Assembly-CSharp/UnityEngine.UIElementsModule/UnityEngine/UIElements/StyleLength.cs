namespace UnityEngine.UIElements;

[Token(Token = "0x2000400")]
public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D5F")]
	private Length m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D60")]
	private StyleKeyword m_Keyword; //Field offset: 0x8

	[Token(Token = "0x17000879")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EA1")]
		 get { } //Length: 6
		[Address(RVA = "0x1B17940", Offset = "0x1B16B40", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001EA2")]
		 set { } //Length: 73
	}

	[Token(Token = "0x17000878")]
	public override Length value
	{
		[Address(RVA = "0x1B17810", Offset = "0x1B16A10", Length = "0x19")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6001E9F")]
		 get { } //Length: 25
		[Address(RVA = "0x1B17990", Offset = "0x1B16B90", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001EA0")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x1B17750", Offset = "0x1B16950", Length = "0x58")]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = "CalculateOppositeProgressWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&)}, ReturnType = typeof(StyleLength))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(StyleLength))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001EA3")]
	public StyleLength(float v) { }

	[Address(RVA = "0x1B177E0", Offset = "0x1B169E0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001EA4")]
	public StyleLength(Length v) { }

	[Address(RVA = "0x1B15A50", Offset = "0x1B14C50", Length = "0xB")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EA5")]
	public StyleLength(StyleKeyword keyword) { }

	[Address(RVA = "0x1B177B0", Offset = "0x1B169B0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001EA6")]
	internal StyleLength(Length v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B17550", Offset = "0x1B16750", Length = "0x70")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EAB")]
	public override bool Equals(StyleLength other) { }

	[Address(RVA = "0x1B175C0", Offset = "0x1B167C0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EAC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EA1")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B17810", Offset = "0x1B16A10", Length = "0x19")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001E9F")]
	public override Length get_value() { }

	[Address(RVA = "0x1B176B0", Offset = "0x1B168B0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001EAD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B17830", Offset = "0x1B16A30", Length = "0x3E")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EA7")]
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	[Address(RVA = "0x1B15AA0", Offset = "0x1B14CA0", Length = "0x20")]
	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EA8")]
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B178B0", Offset = "0x1B16AB0", Length = "0x84")]
	[CallerCount(Count = 129)]
	[Token(Token = "0x6001EA9")]
	public static StyleLength op_Implicit(float v) { }

	[Address(RVA = "0x1B17870", Offset = "0x1B16A70", Length = "0x40")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x6001EAA")]
	public static StyleLength op_Implicit(Length v) { }

	[Address(RVA = "0x1B17940", Offset = "0x1B16B40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001EA2")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B17990", Offset = "0x1B16B90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001EA0")]
	public override void set_value(Length value) { }

	[Address(RVA = "0x1B176E0", Offset = "0x1B168E0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001EAE")]
	public virtual string ToString() { }

}

