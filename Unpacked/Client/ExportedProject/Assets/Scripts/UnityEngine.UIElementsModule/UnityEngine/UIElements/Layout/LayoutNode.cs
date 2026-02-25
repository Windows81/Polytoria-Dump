namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x20005C1")]
internal struct LayoutNode : IEquatable<LayoutNode>
{
	[Token(Token = "0x40014E3")]
	private const int k_DefaultChildCapacity = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014E4")]
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014E5")]
	private readonly LayoutHandle m_Handle; //Field offset: 0x28

	[Token(Token = "0x17000A52")]
	public LayoutAlign AlignContent
	{
		[Address(RVA = "0x1BAE190", Offset = "0x1BAD390", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600290C")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A50")]
	public LayoutAlign AlignItems
	{
		[Address(RVA = "0x1BAE1E0", Offset = "0x1BAD3E0", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600290A")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A51")]
	public LayoutAlign AlignSelf
	{
		[Address(RVA = "0x1BAE230", Offset = "0x1BAD430", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600290B")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A6E")]
	public float BorderBottomWidth
	{
		[Address(RVA = "0x1BAE280", Offset = "0x1BAD480", Length = "0x58")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002928")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000A6B")]
	public float BorderLeftWidth
	{
		[Address(RVA = "0x1BAE2E0", Offset = "0x1BAD4E0", Length = "0x58")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002925")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000A6D")]
	public float BorderRightWidth
	{
		[Address(RVA = "0x1BAE340", Offset = "0x1BAD540", Length = "0x58")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002927")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000A6C")]
	public float BorderTopWidth
	{
		[Address(RVA = "0x1BAE3A0", Offset = "0x1BAD5A0", Length = "0x58")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002926")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000A62")]
	public LayoutValue Bottom
	{
		[Address(RVA = "0x1BAE400", Offset = "0x1BAD600", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x600291C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A4B")]
	private LayoutList<LayoutHandle> Children
	{
		[Address(RVA = "0x1BADAE0", Offset = "0x1BACCE0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x6002902")]
		private get { } //Length: 43
	}

	[Token(Token = "0x17000A49")]
	public float ComputedFlexBasis
	{
		[Address(RVA = "0x1BADB10", Offset = "0x1BACD10", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexBasis", ReturnType = typeof(StyleFloat))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028FE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A77")]
	public LayoutConfig Config
	{
		[Address(RVA = "0x1BADB30", Offset = "0x1BACD30", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x6002943")]
		 get { } //Length: 100
		[Address(RVA = "0x1BAE410", Offset = "0x1BAD610", Length = "0x23")]
		[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x6002944")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000A4C")]
	public int Count
	{
		[Address(RVA = "0x1BADBA0", Offset = "0x1BACDA0", Length = "0x9D")]
		[CalledBy(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
		[Token(Token = "0x6002903")]
		 get { } //Length: 157
	}

	[Token(Token = "0x17000A4F")]
	public LayoutDisplay Display
	{
		[Address(RVA = "0x1BAE440", Offset = "0x1BAD640", Length = "0x47")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x6002909")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A57")]
	public LayoutValue FlexBasis
	{
		[Address(RVA = "0x1BAE490", Offset = "0x1BAD690", Length = "0x38")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002911")]
		 set { } //Length: 56
	}

	[Token(Token = "0x17000A4D")]
	public LayoutFlexDirection FlexDirection
	{
		[Address(RVA = "0x1BAE4D0", Offset = "0x1BAD6D0", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x6002907")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A55")]
	public float FlexGrow
	{
		[Address(RVA = "0x1BAE520", Offset = "0x1BAD720", Length = "0x55")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600290F")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000A56")]
	public float FlexShrink
	{
		[Address(RVA = "0x1BAE580", Offset = "0x1BAD780", Length = "0x55")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x6002910")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000A71")]
	public LayoutHandle Handle
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002938")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A75")]
	public bool HasNewLayout
	{
		[Address(RVA = "0x1BADC40", Offset = "0x1BACE40", Length = "0x1D")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x600293D")]
		 get { } //Length: 29
		[Address(RVA = "0x1BAE5E0", Offset = "0x1BAD7E0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x600293E")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000A59")]
	public LayoutValue Height
	{
		[Address(RVA = "0x1BAE620", Offset = "0x1BAD820", Length = "0x5A")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002913")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000A74")]
	public bool IsDirty
	{
		[Address(RVA = "0x1BADC60", Offset = "0x1BACE60", Length = "0x1B")]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x600293B")]
		 get { } //Length: 27
		[Address(RVA = "0x1BAE680", Offset = "0x1BAD880", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x600293C")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000A70")]
	public bool IsUndefined
	{
		[Address(RVA = "0x1BADC80", Offset = "0x1BACE80", Length = "0x10")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002937")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000A4E")]
	public LayoutJustify JustifyContent
	{
		[Address(RVA = "0x1BAE6C0", Offset = "0x1BAD8C0", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x6002908")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A72")]
	public LayoutComputedData Layout
	{
		[Address(RVA = "0x1BADFF0", Offset = "0x1BAD1F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x6002939")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000A48")]
	public float LayoutBorderBottom
	{
		[Address(RVA = "0x1BADC90", Offset = "0x1BACE90", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028FD")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A45")]
	public float LayoutBorderLeft
	{
		[Address(RVA = "0x1BADCB0", Offset = "0x1BACEB0", Length = "0x4C")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028FA")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000A47")]
	public float LayoutBorderRight
	{
		[Address(RVA = "0x1BADD00", Offset = "0x1BACF00", Length = "0x4C")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028FC")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000A46")]
	public float LayoutBorderTop
	{
		[Address(RVA = "0x1BADD50", Offset = "0x1BACF50", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028FB")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A3A")]
	public float LayoutBottom
	{
		[Address(RVA = "0x1BADD70", Offset = "0x1BACF70", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_bottom", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028EF")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A3C")]
	public float LayoutHeight
	{
		[Address(RVA = "0x1BADD90", Offset = "0x1BACF90", Length = "0x1A")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_height", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A40")]
	public float LayoutMarginBottom
	{
		[Address(RVA = "0x1BADDB0", Offset = "0x1BACFB0", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginBottom", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F5")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A3D")]
	public float LayoutMarginLeft
	{
		[Address(RVA = "0x1BADDD0", Offset = "0x1BACFD0", Length = "0x4C")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginLeft", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F2")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000A3F")]
	public float LayoutMarginRight
	{
		[Address(RVA = "0x1BADE20", Offset = "0x1BAD020", Length = "0x4C")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginRight", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F4")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000A3E")]
	public float LayoutMarginTop
	{
		[Address(RVA = "0x1BADE70", Offset = "0x1BAD070", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginTop", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F3")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A44")]
	public float LayoutPaddingBottom
	{
		[Address(RVA = "0x1BADE90", Offset = "0x1BAD090", Length = "0x1A")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingBottom", ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F9")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A41")]
	public float LayoutPaddingLeft
	{
		[Address(RVA = "0x1BADEB0", Offset = "0x1BAD0B0", Length = "0x4C")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingLeft", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F6")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000A43")]
	public float LayoutPaddingRight
	{
		[Address(RVA = "0x1BADF00", Offset = "0x1BAD100", Length = "0x4C")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingRight", ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F8")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000A42")]
	public float LayoutPaddingTop
	{
		[Address(RVA = "0x1BADF50", Offset = "0x1BAD150", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingTop", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F7")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A39")]
	public float LayoutRight
	{
		[Address(RVA = "0x1BADF70", Offset = "0x1BAD170", Length = "0x1A")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_right", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028EE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A3B")]
	public float LayoutWidth
	{
		[Address(RVA = "0x1BADF90", Offset = "0x1BAD190", Length = "0x1A")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_width", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028F0")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A37")]
	public float LayoutX
	{
		[Address(RVA = "0x1BADFB0", Offset = "0x1BAD1B0", Length = "0x19")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_left", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028EC")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000A38")]
	public float LayoutY
	{
		[Address(RVA = "0x1BADFD0", Offset = "0x1BAD1D0", Length = "0x1A")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_top", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
		[Token(Token = "0x60028ED")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A5F")]
	public LayoutValue Left
	{
		[Address(RVA = "0x1BAE710", Offset = "0x1BAD910", Length = "0xD")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002919")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000A66")]
	public LayoutValue MarginBottom
	{
		[Address(RVA = "0x1BAE720", Offset = "0x1BAD920", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002920")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A63")]
	public LayoutValue MarginLeft
	{
		[Address(RVA = "0x1BAE730", Offset = "0x1BAD930", Length = "0xD")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x600291D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000A65")]
	public LayoutValue MarginRight
	{
		[Address(RVA = "0x1BAE740", Offset = "0x1BAD940", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x600291F")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A64")]
	public LayoutValue MarginTop
	{
		[Address(RVA = "0x1BAE750", Offset = "0x1BAD950", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x600291E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A5B")]
	public LayoutValue MaxHeight
	{
		[Address(RVA = "0x1BAE760", Offset = "0x1BAD960", Length = "0x5A")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002915")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000A5A")]
	public LayoutValue MaxWidth
	{
		[Address(RVA = "0x1BAE7C0", Offset = "0x1BAD9C0", Length = "0x5A")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002914")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000A5D")]
	public LayoutValue MinHeight
	{
		[Address(RVA = "0x1BAE820", Offset = "0x1BADA20", Length = "0x5A")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002917")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000A5C")]
	public LayoutValue MinWidth
	{
		[Address(RVA = "0x1BAE880", Offset = "0x1BADA80", Length = "0x5A")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002916")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000A5E")]
	public LayoutOverflow Overflow
	{
		[Address(RVA = "0x1BAE8E0", Offset = "0x1BADAE0", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x6002918")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A6A")]
	public LayoutValue PaddingBottom
	{
		[Address(RVA = "0x1BAE930", Offset = "0x1BADB30", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002924")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A67")]
	public LayoutValue PaddingLeft
	{
		[Address(RVA = "0x1BAE940", Offset = "0x1BADB40", Length = "0xD")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002921")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000A69")]
	public LayoutValue PaddingRight
	{
		[Address(RVA = "0x1BAE950", Offset = "0x1BADB50", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002923")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A68")]
	public LayoutValue PaddingTop
	{
		[Address(RVA = "0x1BAE960", Offset = "0x1BADB60", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002922")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A4A")]
	public LayoutNode Parent
	{
		[Address(RVA = "0x1BAE000", Offset = "0x1BAD200", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x6002900")]
		 get { } //Length: 100
		[Address(RVA = "0x1BAE970", Offset = "0x1BADB70", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x6002901")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000A53")]
	public LayoutPositionType PositionType
	{
		[Address(RVA = "0x1BAE9A0", Offset = "0x1BADBA0", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600290D")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000A61")]
	public LayoutValue Right
	{
		[Address(RVA = "0x1BAE9F0", Offset = "0x1BADBF0", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x600291B")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A73")]
	public LayoutStyleData Style
	{
		[Address(RVA = "0x1BAE070", Offset = "0x1BAD270", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Token(Token = "0x600293A")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000A60")]
	public LayoutValue Top
	{
		[Address(RVA = "0x1BAEA00", Offset = "0x1BADC00", Length = "0x10")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x600291A")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000A6F")]
	public static LayoutNode Undefined
	{
		[Address(RVA = "0x1BA8800", Offset = "0x1BA7A00", Length = "0x2C")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002935")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000A76")]
	public bool UsesMeasure
	{
		[Address(RVA = "0x1BAE080", Offset = "0x1BAD280", Length = "0x1D")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[Token(Token = "0x600293F")]
		 get { } //Length: 29
		[Address(RVA = "0x1BAEA10", Offset = "0x1BADC10", Length = "0x35")]
		[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002940")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000A58")]
	public LayoutValue Width
	{
		[Address(RVA = "0x1BAEA50", Offset = "0x1BADC50", Length = "0x5A")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002912")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000A54")]
	public LayoutWrap Wrap
	{
		[Address(RVA = "0x1BAEAB0", Offset = "0x1BADCB0", Length = "0x47")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600290E")]
		 set { } //Length: 71
	}

	[Address(RVA = "0x1BA86F0", Offset = "0x1BA78F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002936")]
	internal LayoutNode(LayoutDataAccess access, LayoutHandle handle) { }

	[Address(RVA = "0x1BAC2E0", Offset = "0x1BAB4E0", Length = "0x19E")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600294E")]
	public void CalculateLayout(float width = NaN, float height = NaN) { }

	[Address(RVA = "0x1BAC480", Offset = "0x1BAB680", Length = "0xAD")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002906")]
	public void Clear() { }

	[Address(RVA = "0x1BAC530", Offset = "0x1BAB730", Length = "0x800")]
	[CalledBy(Type = typeof(VisualElement), Member = "FinalizeLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Token(Token = "0x6002947")]
	public void CopyFromComputedStyle(ComputedStyle style) { }

	[Address(RVA = "0x1BACD30", Offset = "0x1BABF30", Length = "0x34")]
	[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002949")]
	public override bool Equals(LayoutNode other) { }

	[Address(RVA = "0x1BACD70", Offset = "0x1BABF70", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600294A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BADAE0", Offset = "0x1BACCE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002902")]
	private LayoutList<LayoutHandle> get_Children() { }

	[Address(RVA = "0x1BADB10", Offset = "0x1BACD10", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexBasis", ReturnType = typeof(StyleFloat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028FE")]
	public float get_ComputedFlexBasis() { }

	[Address(RVA = "0x1BADB30", Offset = "0x1BACD30", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002943")]
	public LayoutConfig get_Config() { }

	[Address(RVA = "0x1BADBA0", Offset = "0x1BACDA0", Length = "0x9D")]
	[CalledBy(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
	[Token(Token = "0x6002903")]
	public int get_Count() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002938")]
	public LayoutHandle get_Handle() { }

	[Address(RVA = "0x1BADC40", Offset = "0x1BACE40", Length = "0x1D")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x600293D")]
	public bool get_HasNewLayout() { }

	[Address(RVA = "0x1BADC60", Offset = "0x1BACE60", Length = "0x1B")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x600293B")]
	public bool get_IsDirty() { }

	[Address(RVA = "0x1BADC80", Offset = "0x1BACE80", Length = "0x10")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002937")]
	public bool get_IsUndefined() { }

	[Address(RVA = "0x1BADFF0", Offset = "0x1BAD1F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x6002939")]
	public LayoutComputedData get_Layout() { }

	[Address(RVA = "0x1BADC90", Offset = "0x1BACE90", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028FD")]
	public float get_LayoutBorderBottom() { }

	[Address(RVA = "0x1BADCB0", Offset = "0x1BACEB0", Length = "0x4C")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028FA")]
	public float get_LayoutBorderLeft() { }

	[Address(RVA = "0x1BADD00", Offset = "0x1BACF00", Length = "0x4C")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028FC")]
	public float get_LayoutBorderRight() { }

	[Address(RVA = "0x1BADD50", Offset = "0x1BACF50", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028FB")]
	public float get_LayoutBorderTop() { }

	[Address(RVA = "0x1BADD70", Offset = "0x1BACF70", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_bottom", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028EF")]
	public float get_LayoutBottom() { }

	[Address(RVA = "0x1BADD90", Offset = "0x1BACF90", Length = "0x1A")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_height", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F1")]
	public float get_LayoutHeight() { }

	[Address(RVA = "0x1BADDB0", Offset = "0x1BACFB0", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginBottom", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F5")]
	public float get_LayoutMarginBottom() { }

	[Address(RVA = "0x1BADDD0", Offset = "0x1BACFD0", Length = "0x4C")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginLeft", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F2")]
	public float get_LayoutMarginLeft() { }

	[Address(RVA = "0x1BADE20", Offset = "0x1BAD020", Length = "0x4C")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginRight", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F4")]
	public float get_LayoutMarginRight() { }

	[Address(RVA = "0x1BADE70", Offset = "0x1BAD070", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginTop", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F3")]
	public float get_LayoutMarginTop() { }

	[Address(RVA = "0x1BADE90", Offset = "0x1BAD090", Length = "0x1A")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingBottom", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F9")]
	public float get_LayoutPaddingBottom() { }

	[Address(RVA = "0x1BADEB0", Offset = "0x1BAD0B0", Length = "0x4C")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingLeft", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F6")]
	public float get_LayoutPaddingLeft() { }

	[Address(RVA = "0x1BADF00", Offset = "0x1BAD100", Length = "0x4C")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingRight", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F8")]
	public float get_LayoutPaddingRight() { }

	[Address(RVA = "0x1BADF50", Offset = "0x1BAD150", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingTop", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F7")]
	public float get_LayoutPaddingTop() { }

	[Address(RVA = "0x1BADF70", Offset = "0x1BAD170", Length = "0x1A")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_right", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028EE")]
	public float get_LayoutRight() { }

	[Address(RVA = "0x1BADF90", Offset = "0x1BAD190", Length = "0x1A")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_width", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028F0")]
	public float get_LayoutWidth() { }

	[Address(RVA = "0x1BADFB0", Offset = "0x1BAD1B0", Length = "0x19")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_left", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028EC")]
	public float get_LayoutX() { }

	[Address(RVA = "0x1BADFD0", Offset = "0x1BAD1D0", Length = "0x1A")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_top", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028ED")]
	public float get_LayoutY() { }

	[Address(RVA = "0x1BAE000", Offset = "0x1BAD200", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002900")]
	public LayoutNode get_Parent() { }

	[Address(RVA = "0x1BAE070", Offset = "0x1BAD270", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Token(Token = "0x600293A")]
	public LayoutStyleData get_Style() { }

	[Address(RVA = "0x1BA8800", Offset = "0x1BA7A00", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002935")]
	public static LayoutNode get_Undefined() { }

	[Address(RVA = "0x1BAE080", Offset = "0x1BAD280", Length = "0x1D")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x600293F")]
	public bool get_UsesMeasure() { }

	[Address(RVA = "0x1BACE10", Offset = "0x1BAC010", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600294B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BA3770", Offset = "0x1BA2970", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Token(Token = "0x60028FF")]
	private float GetLayoutValue(Single* buffer, LayoutEdge edge) { }

	[Address(RVA = "0x1BACE20", Offset = "0x1BAC020", Length = "0x6F")]
	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(IntPtr&), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002942")]
	public VisualElement GetOwner() { }

	[Address(RVA = "0x1BACE90", Offset = "0x1BAC090", Length = "0xF8")]
	[CalledBy(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002904")]
	public void Insert(int index, LayoutNode child) { }

	[Address(RVA = "0x1BACF90", Offset = "0x1BAC190", Length = "0xF0")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3390")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002945")]
	public void MarkDirty() { }

	[Address(RVA = "0x1BAD080", Offset = "0x1BAC280", Length = "0x19")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002946")]
	public void MarkLayoutSeen() { }

	[Address(RVA = "0x1BAE0A0", Offset = "0x1BAD2A0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600294C")]
	public static bool op_Equality(LayoutNode lhs, LayoutNode rhs) { }

	[Address(RVA = "0x1BAE100", Offset = "0x1BAD300", Length = "0x81")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600294D")]
	public static bool op_Inequality(LayoutNode lhs, LayoutNode rhs) { }

	[Address(RVA = "0x1BAD0A0", Offset = "0x1BAC2A0", Length = "0x18F")]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
	[Token(Token = "0x6002905")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1BAE190", Offset = "0x1BAD390", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600290C")]
	public void set_AlignContent(LayoutAlign value) { }

	[Address(RVA = "0x1BAE1E0", Offset = "0x1BAD3E0", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600290A")]
	public void set_AlignItems(LayoutAlign value) { }

	[Address(RVA = "0x1BAE230", Offset = "0x1BAD430", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600290B")]
	public void set_AlignSelf(LayoutAlign value) { }

	[Address(RVA = "0x1BAE280", Offset = "0x1BAD480", Length = "0x58")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002928")]
	public void set_BorderBottomWidth(float value) { }

	[Address(RVA = "0x1BAE2E0", Offset = "0x1BAD4E0", Length = "0x58")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002925")]
	public void set_BorderLeftWidth(float value) { }

	[Address(RVA = "0x1BAE340", Offset = "0x1BAD540", Length = "0x58")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002927")]
	public void set_BorderRightWidth(float value) { }

	[Address(RVA = "0x1BAE3A0", Offset = "0x1BAD5A0", Length = "0x58")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002926")]
	public void set_BorderTopWidth(float value) { }

	[Address(RVA = "0x1BAE400", Offset = "0x1BAD600", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600291C")]
	public void set_Bottom(LayoutValue value) { }

	[Address(RVA = "0x1BAE410", Offset = "0x1BAD610", Length = "0x23")]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002944")]
	public void set_Config(LayoutConfig value) { }

	[Address(RVA = "0x1BAE440", Offset = "0x1BAD640", Length = "0x47")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002909")]
	public void set_Display(LayoutDisplay value) { }

	[Address(RVA = "0x1BAE490", Offset = "0x1BAD690", Length = "0x38")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002911")]
	public void set_FlexBasis(LayoutValue value) { }

	[Address(RVA = "0x1BAE4D0", Offset = "0x1BAD6D0", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002907")]
	public void set_FlexDirection(LayoutFlexDirection value) { }

	[Address(RVA = "0x1BAE520", Offset = "0x1BAD720", Length = "0x55")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600290F")]
	public void set_FlexGrow(float value) { }

	[Address(RVA = "0x1BAE580", Offset = "0x1BAD780", Length = "0x55")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002910")]
	public void set_FlexShrink(float value) { }

	[Address(RVA = "0x1BAE5E0", Offset = "0x1BAD7E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x600293E")]
	public void set_HasNewLayout(bool value) { }

	[Address(RVA = "0x1BAE620", Offset = "0x1BAD820", Length = "0x5A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002913")]
	public void set_Height(LayoutValue value) { }

	[Address(RVA = "0x1BAE680", Offset = "0x1BAD880", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x600293C")]
	public void set_IsDirty(bool value) { }

	[Address(RVA = "0x1BAE6C0", Offset = "0x1BAD8C0", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002908")]
	public void set_JustifyContent(LayoutJustify value) { }

	[Address(RVA = "0x1BAE710", Offset = "0x1BAD910", Length = "0xD")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002919")]
	public void set_Left(LayoutValue value) { }

	[Address(RVA = "0x1BAE720", Offset = "0x1BAD920", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002920")]
	public void set_MarginBottom(LayoutValue value) { }

	[Address(RVA = "0x1BAE730", Offset = "0x1BAD930", Length = "0xD")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600291D")]
	public void set_MarginLeft(LayoutValue value) { }

	[Address(RVA = "0x1BAE740", Offset = "0x1BAD940", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600291F")]
	public void set_MarginRight(LayoutValue value) { }

	[Address(RVA = "0x1BAE750", Offset = "0x1BAD950", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600291E")]
	public void set_MarginTop(LayoutValue value) { }

	[Address(RVA = "0x1BAE760", Offset = "0x1BAD960", Length = "0x5A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002915")]
	public void set_MaxHeight(LayoutValue value) { }

	[Address(RVA = "0x1BAE7C0", Offset = "0x1BAD9C0", Length = "0x5A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002914")]
	public void set_MaxWidth(LayoutValue value) { }

	[Address(RVA = "0x1BAE820", Offset = "0x1BADA20", Length = "0x5A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002917")]
	public void set_MinHeight(LayoutValue value) { }

	[Address(RVA = "0x1BAE880", Offset = "0x1BADA80", Length = "0x5A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002916")]
	public void set_MinWidth(LayoutValue value) { }

	[Address(RVA = "0x1BAE8E0", Offset = "0x1BADAE0", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002918")]
	public void set_Overflow(LayoutOverflow value) { }

	[Address(RVA = "0x1BAE930", Offset = "0x1BADB30", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002924")]
	public void set_PaddingBottom(LayoutValue value) { }

	[Address(RVA = "0x1BAE940", Offset = "0x1BADB40", Length = "0xD")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002921")]
	public void set_PaddingLeft(LayoutValue value) { }

	[Address(RVA = "0x1BAE950", Offset = "0x1BADB50", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002923")]
	public void set_PaddingRight(LayoutValue value) { }

	[Address(RVA = "0x1BAE960", Offset = "0x1BADB60", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002922")]
	public void set_PaddingTop(LayoutValue value) { }

	[Address(RVA = "0x1BAE970", Offset = "0x1BADB70", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002901")]
	public void set_Parent(LayoutNode value) { }

	[Address(RVA = "0x1BAE9A0", Offset = "0x1BADBA0", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600290D")]
	public void set_PositionType(LayoutPositionType value) { }

	[Address(RVA = "0x1BAE9F0", Offset = "0x1BADBF0", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600291B")]
	public void set_Right(LayoutValue value) { }

	[Address(RVA = "0x1BAEA00", Offset = "0x1BADC00", Length = "0x10")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600291A")]
	public void set_Top(LayoutValue value) { }

	[Address(RVA = "0x1BAEA10", Offset = "0x1BADC10", Length = "0x35")]
	[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002940")]
	public void set_UsesMeasure(bool value) { }

	[Address(RVA = "0x1BAEA50", Offset = "0x1BADC50", Length = "0x5A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002912")]
	public void set_Width(LayoutValue value) { }

	[Address(RVA = "0x1BAEAB0", Offset = "0x1BADCB0", Length = "0x47")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600290E")]
	public void set_Wrap(LayoutWrap value) { }

	[Address(RVA = "0x1BAD230", Offset = "0x1BAC430", Length = "0xF")]
	[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA36F0")]
	[Token(Token = "0x6002941")]
	public void SetOwner(VisualElement func) { }

	[Address(RVA = "0x1BAD240", Offset = "0x1BAC440", Length = "0x1A5")]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABE20")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002930")]
	private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value) { }

	[Address(RVA = "0x1BAD3F0", Offset = "0x1BAC5F0", Length = "0x123")]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABE20")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002931")]
	private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value) { }

	[Address(RVA = "0x1BAD520", Offset = "0x1BAC720", Length = "0x123")]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA35F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABE20")]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600292F")]
	private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value) { }

	[Address(RVA = "0x1BAD830", Offset = "0x1BACA30", Length = "0x126")]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600292A")]
	private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x1BAD650", Offset = "0x1BAC850", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600292E")]
	private void SetStyleValueAuto(ref LayoutValue currentValue) { }

	[Address(RVA = "0x1BAD680", Offset = "0x1BAC880", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600292D")]
	private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x1BAD6F0", Offset = "0x1BAC8F0", Length = "0xA4")]
	[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600292C")]
	private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x1BAD7A0", Offset = "0x1BAC9A0", Length = "0x8D")]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValuePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600292B")]
	private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x1BAD960", Offset = "0x1BACB60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6002929")]
	private void SetValue(ref float currentValue, float newValue) { }

	[Address(RVA = "0x1BAD9B0", Offset = "0x1BACBB0", Length = "0x19")]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Token(Token = "0x6002948")]
	public void SoftReset() { }

	[Address(RVA = "0x1BAD650", Offset = "0x1BAC850", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002933")]
	private void StyleEdgeSetAuto(ref LayoutValue value) { }

	[Address(RVA = "0x1BAD9D0", Offset = "0x1BACBD0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002932")]
	private void StyleEdgeSetPercent(ref LayoutValue value, float newValue) { }

	[Address(RVA = "0x1BADA50", Offset = "0x1BACC50", Length = "0x8B")]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002934")]
	private void StyleEdgeSetPoint(ref LayoutValue value, float newValue) { }

}

