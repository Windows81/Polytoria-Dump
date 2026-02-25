namespace UnityEngine.UIElements;

[Token(Token = "0x20002FC")]
internal class InlineStyleAccess : StyleValueCollection, IStyle
{
	[Token(Token = "0x20002FD")]
	public struct InlineRule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C28")]
		public StyleSheet sheet; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C29")]
		public StyleRule rule; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C2A")]
		public StylePropertyId[] propertyIds; //Field offset: 0x10

	}

	[Token(Token = "0x4000C14")]
	private static StylePropertyReader s_StylePropertyReader; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C15")]
	private List<StyleValueManaged> m_ValuesManaged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C16")]
	private VisualElement <ve>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C17")]
	private bool m_HasInlineCursor; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C18")]
	private StyleCursor m_InlineCursor; //Field offset: 0x30
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C19")]
	private bool m_HasInlineTextShadow; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000C1A")]
	private StyleTextShadow m_InlineTextShadow; //Field offset: 0x54
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000C1B")]
	private bool m_HasInlineTextAutoSize; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C1C")]
	private StyleTextAutoSize m_InlineTextAutoSize; //Field offset: 0x78
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C1D")]
	private bool m_HasInlineTransformOrigin; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000C1E")]
	private StyleTransformOrigin m_InlineTransformOrigin; //Field offset: 0x94
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000C1F")]
	private bool m_HasInlineTranslate; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C20")]
	private StyleTranslate m_InlineTranslateOperation; //Field offset: 0xB0
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4000C21")]
	private bool m_HasInlineRotate; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C22")]
	private StyleRotate m_InlineRotateOperation; //Field offset: 0xD0
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000C23")]
	private bool m_HasInlineScale; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000C24")]
	private StyleScale m_InlineScale; //Field offset: 0xF0
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000C25")]
	private bool m_HasInlineBackgroundSize; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000C26")]
	public StyleBackgroundSize m_InlineBackgroundSize; //Field offset: 0x108
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C27")]
	private InlineRule m_InlineRule; //Field offset: 0x120

	[Token(Token = "0x17000453")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignContent
	{
		[Address(RVA = "0x1AE1710", Offset = "0x1AE0910", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001545")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE3120", Offset = "0x1AE2320", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
		[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001546")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000454")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignItems
	{
		[Address(RVA = "0x1AE1790", Offset = "0x1AE0990", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001547")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE31D0", Offset = "0x1AE23D0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
		[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001548")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000455")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignSelf
	{
		[Address(RVA = "0x1AE1810", Offset = "0x1AE0A10", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001549")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE3280", Offset = "0x1AE2480", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
		[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600154A")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000456")]
	private override StyleColor UnityEngine.UIElements.IStyle.backgroundColor
	{
		[Address(RVA = "0x1AE1890", Offset = "0x1AE0A90", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x600154B")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE3330", Offset = "0x1AE2530", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600154C")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000457")]
	private override StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
	{
		[Address(RVA = "0x1AE18D0", Offset = "0x1AE0AD0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
		[Token(Token = "0x600154D")]
		private get { } //Length: 77
		[Address(RVA = "0x1AE3390", Offset = "0x1AE2590", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600154E")]
		private set { } //Length: 97
	}

	[Token(Token = "0x17000458")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
	{
		[Address(RVA = "0x1AE1920", Offset = "0x1AE0B20", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
		[Token(Token = "0x600154F")]
		private get { } //Length: 49
		[Address(RVA = "0x1AE3400", Offset = "0x1AE2600", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001550")]
		private set { } //Length: 77
	}

	[Token(Token = "0x17000459")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
	{
		[Address(RVA = "0x1AE1960", Offset = "0x1AE0B60", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
		[Token(Token = "0x6001551")]
		private get { } //Length: 49
		[Address(RVA = "0x1AE3450", Offset = "0x1AE2650", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001552")]
		private set { } //Length: 77
	}

	[Token(Token = "0x1700045A")]
	private override StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
	{
		[Address(RVA = "0x1AE19A0", Offset = "0x1AE0BA0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundRepeat))]
		[Token(Token = "0x6001553")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE34A0", Offset = "0x1AE26A0", Length = "0x169")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001554")]
		private set { } //Length: 361
	}

	[Token(Token = "0x170004A4")]
	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
	{
		[Address(RVA = "0x1AE19E0", Offset = "0x1AE0BE0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015EC")]
		private get { } //Length: 104
		[Address(RVA = "0x1AE3610", Offset = "0x1AE2810", Length = "0x16C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
		[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60015ED")]
		private set { } //Length: 364
	}

	[Token(Token = "0x1700045B")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
	{
		[Address(RVA = "0x1AE1A50", Offset = "0x1AE0C50", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x6001555")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE3780", Offset = "0x1AE2980", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001556")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700045C")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
	{
		[Address(RVA = "0x1AE1A90", Offset = "0x1AE0C90", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001557")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE37E0", Offset = "0x1AE29E0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001558")]
		private set { } //Length: 86
	}

	[Token(Token = "0x1700045D")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
	{
		[Address(RVA = "0x1AE1AD0", Offset = "0x1AE0CD0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001559")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE3840", Offset = "0x1AE2A40", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600155A")]
		private set { } //Length: 86
	}

	[Token(Token = "0x1700045E")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
	{
		[Address(RVA = "0x1AE1B10", Offset = "0x1AE0D10", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x600155B")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE38A0", Offset = "0x1AE2AA0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600155C")]
		private set { } //Length: 131
	}

	[Token(Token = "0x1700045F")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
	{
		[Address(RVA = "0x1AE1B20", Offset = "0x1AE0D20", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x600155D")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE3930", Offset = "0x1AE2B30", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600155E")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000460")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
	{
		[Address(RVA = "0x1AE1B60", Offset = "0x1AE0D60", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x600155F")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE3990", Offset = "0x1AE2B90", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001560")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000461")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderRightColor
	{
		[Address(RVA = "0x1AE1B70", Offset = "0x1AE0D70", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x6001561")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE3A20", Offset = "0x1AE2C20", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001562")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000462")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
	{
		[Address(RVA = "0x1AE1BB0", Offset = "0x1AE0DB0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x6001563")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE3A80", Offset = "0x1AE2C80", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001564")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000463")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderTopColor
	{
		[Address(RVA = "0x1AE1BC0", Offset = "0x1AE0DC0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x6001565")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE3B10", Offset = "0x1AE2D10", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001566")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000464")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
	{
		[Address(RVA = "0x1AE1C00", Offset = "0x1AE0E00", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001567")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE3B70", Offset = "0x1AE2D70", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001568")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000465")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
	{
		[Address(RVA = "0x1AE1C40", Offset = "0x1AE0E40", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001569")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE3BD0", Offset = "0x1AE2DD0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600156A")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000466")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
	{
		[Address(RVA = "0x1AE1C80", Offset = "0x1AE0E80", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x600156B")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE3C30", Offset = "0x1AE2E30", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600156C")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000467")]
	private override StyleLength UnityEngine.UIElements.IStyle.bottom
	{
		[Address(RVA = "0x1AE1C90", Offset = "0x1AE0E90", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600156D")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE3CC0", Offset = "0x1AE2EC0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600156E")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000468")]
	private override StyleColor UnityEngine.UIElements.IStyle.color
	{
		[Address(RVA = "0x1AE1CD0", Offset = "0x1AE0ED0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x600156F")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE3D70", Offset = "0x1AE2F70", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001570")]
		private set { } //Length: 84
	}

	[Token(Token = "0x170004A1")]
	private override StyleCursor UnityEngine.UIElements.IStyle.cursor
	{
		[Address(RVA = "0x1AE1D10", Offset = "0x1AE0F10", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StyleCursor), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleCursor))]
		[Token(Token = "0x60015E6")]
		private get { } //Length: 132
		[Address(RVA = "0x1AE3DD0", Offset = "0x1AE2FD0", Length = "0x1D7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
		[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleCursor), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Token(Token = "0x60015E7")]
		private set { } //Length: 471
	}

	[Token(Token = "0x17000469")]
	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display
	{
		[Address(RVA = "0x1AE1DA0", Offset = "0x1AE0FA0", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001571")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE3FB0", Offset = "0x1AE31B0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001572")]
		private set { } //Length: 167
	}

	[Token(Token = "0x1700046A")]
	private override StyleLength UnityEngine.UIElements.IStyle.flexBasis
	{
		[Address(RVA = "0x1AE1E20", Offset = "0x1AE1020", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001573")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4060", Offset = "0x1AE3260", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001574")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700046B")]
	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection
	{
		[Address(RVA = "0x1AE1E60", Offset = "0x1AE1060", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001575")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE4110", Offset = "0x1AE3310", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001576")]
		private set { } //Length: 167
	}

	[Token(Token = "0x1700046C")]
	private override StyleFloat UnityEngine.UIElements.IStyle.flexGrow
	{
		[Address(RVA = "0x1AE1EE0", Offset = "0x1AE10E0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x6001577")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE41C0", Offset = "0x1AE33C0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001578")]
		private set { } //Length: 131
	}

	[Token(Token = "0x1700046D")]
	private override StyleFloat UnityEngine.UIElements.IStyle.flexShrink
	{
		[Address(RVA = "0x1AE1EF0", Offset = "0x1AE10F0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x6001579")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE4250", Offset = "0x1AE3450", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600157A")]
		private set { } //Length: 131
	}

	[Token(Token = "0x1700046E")]
	private override StyleEnum<Wrap> UnityEngine.UIElements.IStyle.flexWrap
	{
		[Address(RVA = "0x1AE1F00", Offset = "0x1AE1100", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600157B")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE42E0", Offset = "0x1AE34E0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600157C")]
		private set { } //Length: 167
	}

	[Token(Token = "0x1700046F")]
	private override StyleLength UnityEngine.UIElements.IStyle.fontSize
	{
		[Address(RVA = "0x1AE1F80", Offset = "0x1AE1180", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600157D")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4390", Offset = "0x1AE3590", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600157E")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000470")]
	private override StyleLength UnityEngine.UIElements.IStyle.height
	{
		[Address(RVA = "0x1AE1FC0", Offset = "0x1AE11C0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600157F")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE43F0", Offset = "0x1AE35F0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001580")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000471")]
	private override StyleEnum<Justify> UnityEngine.UIElements.IStyle.justifyContent
	{
		[Address(RVA = "0x1AE2000", Offset = "0x1AE1200", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001581")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE44A0", Offset = "0x1AE36A0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
		[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001582")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000472")]
	private override StyleLength UnityEngine.UIElements.IStyle.left
	{
		[Address(RVA = "0x1AE2080", Offset = "0x1AE1280", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001583")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4550", Offset = "0x1AE3750", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001584")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000473")]
	private override StyleLength UnityEngine.UIElements.IStyle.letterSpacing
	{
		[Address(RVA = "0x1AE20C0", Offset = "0x1AE12C0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001585")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4600", Offset = "0x1AE3800", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001586")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000474")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginBottom
	{
		[Address(RVA = "0x1AE2100", Offset = "0x1AE1300", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001587")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4660", Offset = "0x1AE3860", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001588")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000475")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginLeft
	{
		[Address(RVA = "0x1AE2140", Offset = "0x1AE1340", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001589")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4710", Offset = "0x1AE3910", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600158A")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000476")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginRight
	{
		[Address(RVA = "0x1AE2180", Offset = "0x1AE1380", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600158B")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE47C0", Offset = "0x1AE39C0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600158C")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000477")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginTop
	{
		[Address(RVA = "0x1AE21C0", Offset = "0x1AE13C0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600158D")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4870", Offset = "0x1AE3A70", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600158E")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000478")]
	private override StyleLength UnityEngine.UIElements.IStyle.maxHeight
	{
		[Address(RVA = "0x1AE2200", Offset = "0x1AE1400", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600158F")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4920", Offset = "0x1AE3B20", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001590")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000479")]
	private override StyleLength UnityEngine.UIElements.IStyle.maxWidth
	{
		[Address(RVA = "0x1AE2240", Offset = "0x1AE1440", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001591")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE49D0", Offset = "0x1AE3BD0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001592")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700047A")]
	private override StyleLength UnityEngine.UIElements.IStyle.minHeight
	{
		[Address(RVA = "0x1AE2280", Offset = "0x1AE1480", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001593")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4A80", Offset = "0x1AE3C80", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001594")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700047B")]
	private override StyleLength UnityEngine.UIElements.IStyle.minWidth
	{
		[Address(RVA = "0x1AE22C0", Offset = "0x1AE14C0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x6001595")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4B30", Offset = "0x1AE3D30", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001596")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700047C")]
	private override StyleFloat UnityEngine.UIElements.IStyle.opacity
	{
		[Address(RVA = "0x1AE2300", Offset = "0x1AE1500", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x6001597")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE4BE0", Offset = "0x1AE3DE0", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001598")]
		private set { } //Length: 67
	}

	[Token(Token = "0x1700047D")]
	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow
	{
		[Address(RVA = "0x1AE2310", Offset = "0x1AE1510", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001599")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE4C30", Offset = "0x1AE3E30", Length = "0x112")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600159A")]
		private set { } //Length: 274
	}

	[Token(Token = "0x1700047E")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingBottom
	{
		[Address(RVA = "0x1AE2390", Offset = "0x1AE1590", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600159B")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4D50", Offset = "0x1AE3F50", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600159C")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700047F")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingLeft
	{
		[Address(RVA = "0x1AE23D0", Offset = "0x1AE15D0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600159D")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4E00", Offset = "0x1AE4000", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600159E")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000480")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingRight
	{
		[Address(RVA = "0x1AE2410", Offset = "0x1AE1610", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x600159F")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4EB0", Offset = "0x1AE40B0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015A0")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000481")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingTop
	{
		[Address(RVA = "0x1AE2450", Offset = "0x1AE1650", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x60015A1")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE4F60", Offset = "0x1AE4160", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015A2")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000482")]
	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.position
	{
		[Address(RVA = "0x1AE2490", Offset = "0x1AE1690", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015A3")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE5010", Offset = "0x1AE4210", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015A4")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000483")]
	private override StyleLength UnityEngine.UIElements.IStyle.right
	{
		[Address(RVA = "0x1AE2510", Offset = "0x1AE1710", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x60015A5")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE50C0", Offset = "0x1AE42C0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015A6")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A7")]
	private override StyleRotate UnityEngine.UIElements.IStyle.rotate
	{
		[Address(RVA = "0x1AE2550", Offset = "0x1AE1750", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015F5")]
		private get { } //Length: 122
		[Address(RVA = "0x1AE5170", Offset = "0x1AE4370", Length = "0x1A7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60015F6")]
		private set { } //Length: 423
	}

	[Token(Token = "0x170004A8")]
	private override StyleScale UnityEngine.UIElements.IStyle.scale
	{
		[Address(RVA = "0x1AE25D0", Offset = "0x1AE17D0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015F7")]
		private get { } //Length: 95
		[Address(RVA = "0x1AE5320", Offset = "0x1AE4520", Length = "0x164")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
		[Calls(Type = typeof(Scale), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60015F8")]
		private set { } //Length: 356
	}

	[Token(Token = "0x17000484")]
	private override StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.textOverflow
	{
		[Address(RVA = "0x1AE2630", Offset = "0x1AE1830", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015A7")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE5490", Offset = "0x1AE4690", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015A8")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004A2")]
	private override StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
	{
		[Address(RVA = "0x1AE26B0", Offset = "0x1AE18B0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTextShadow), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleTextShadow))]
		[Token(Token = "0x60015E8")]
		private get { } //Length: 90
		[Address(RVA = "0x1AE5500", Offset = "0x1AE4700", Length = "0x1C1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
		[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleTextShadow), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Token(Token = "0x60015E9")]
		private set { } //Length: 449
	}

	[Token(Token = "0x17000485")]
	private override StyleLength UnityEngine.UIElements.IStyle.top
	{
		[Address(RVA = "0x1AE2710", Offset = "0x1AE1910", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x60015A9")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE56D0", Offset = "0x1AE48D0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015AA")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A5")]
	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
	{
		[Address(RVA = "0x1AE2750", Offset = "0x1AE1950", Length = "0x68")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015F1")]
		private get { } //Length: 104
		[Address(RVA = "0x1AE5780", Offset = "0x1AE4980", Length = "0x16C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
		[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60015F2")]
		private set { } //Length: 364
	}

	[Token(Token = "0x17000486")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.transitionDelay
	{
		[Address(RVA = "0x1AE27C0", Offset = "0x1AE19C0", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		[Token(Token = "0x60015AB")]
		private get { } //Length: 98
		[Address(RVA = "0x1AE58F0", Offset = "0x1AE4AF0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015AC")]
		private set { } //Length: 119
	}

	[Token(Token = "0x17000487")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.transitionDuration
	{
		[Address(RVA = "0x1AE2830", Offset = "0x1AE1A30", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		[Token(Token = "0x60015AD")]
		private get { } //Length: 98
		[Address(RVA = "0x1AE5970", Offset = "0x1AE4B70", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015AE")]
		private set { } //Length: 119
	}

	[Token(Token = "0x17000488")]
	private override StyleList<StylePropertyName> UnityEngine.UIElements.IStyle.transitionProperty
	{
		[Address(RVA = "0x1AE28A0", Offset = "0x1AE1AA0", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		[Token(Token = "0x60015AF")]
		private get { } //Length: 98
		[Address(RVA = "0x1AE59F0", Offset = "0x1AE4BF0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015B0")]
		private set { } //Length: 119
	}

	[Token(Token = "0x17000489")]
	private override StyleList<EasingFunction> UnityEngine.UIElements.IStyle.transitionTimingFunction
	{
		[Address(RVA = "0x1AE2910", Offset = "0x1AE1B10", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		[Token(Token = "0x60015B1")]
		private get { } //Length: 98
		[Address(RVA = "0x1AE5A70", Offset = "0x1AE4C70", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015B2")]
		private set { } //Length: 119
	}

	[Token(Token = "0x170004A6")]
	private override StyleTranslate UnityEngine.UIElements.IStyle.translate
	{
		[Address(RVA = "0x1AE2980", Offset = "0x1AE1B80", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015F3")]
		private get { } //Length: 122
		[Address(RVA = "0x1AE5AF0", Offset = "0x1AE4CF0", Length = "0x1A7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
		[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60015F4")]
		private set { } //Length: 423
	}

	[Token(Token = "0x1700048A")]
	private override StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
	{
		[Address(RVA = "0x1AE2A00", Offset = "0x1AE1C00", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x60015B3")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE5CA0", Offset = "0x1AE4EA0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015B4")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700048B")]
	private override StyleEnum<EditorTextRenderingMode> UnityEngine.UIElements.IStyle.unityEditorTextRenderingMode
	{
		[Address(RVA = "0x1AE2A40", Offset = "0x1AE1C40", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015B5")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE5D00", Offset = "0x1AE4F00", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015B6")]
		private set { } //Length: 109
	}

	[Token(Token = "0x1700048C")]
	private override StyleFont UnityEngine.UIElements.IStyle.unityFont
	{
		[Address(RVA = "0x1AE2B90", Offset = "0x1AE1D90", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFont))]
		[Token(Token = "0x60015B7")]
		private get { } //Length: 49
		[Address(RVA = "0x1AE5E40", Offset = "0x1AE5040", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015B8")]
		private set { } //Length: 77
	}

	[Token(Token = "0x1700048D")]
	private override StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
	{
		[Address(RVA = "0x1AE2AC0", Offset = "0x1AE1CC0", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFontDefinition))]
		[Token(Token = "0x60015B9")]
		private get { } //Length: 65
		[Address(RVA = "0x1AE5D70", Offset = "0x1AE4F70", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015BA")]
		private set { } //Length: 88
	}

	[Token(Token = "0x1700048E")]
	private override StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
	{
		[Address(RVA = "0x1AE2B10", Offset = "0x1AE1D10", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015BB")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE5DD0", Offset = "0x1AE4FD0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015BC")]
		private set { } //Length: 109
	}

	[Token(Token = "0x1700048F")]
	private override StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.unityOverflowClipBox
	{
		[Address(RVA = "0x1AE2BD0", Offset = "0x1AE1DD0", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015BD")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE5E90", Offset = "0x1AE5090", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015BE")]
		private set { } //Length: 109
	}

	[Token(Token = "0x17000490")]
	private override StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
	{
		[Address(RVA = "0x1AE2C50", Offset = "0x1AE1E50", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x60015BF")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE5F00", Offset = "0x1AE5100", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015C0")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000491")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
	{
		[Address(RVA = "0x1AE2C90", Offset = "0x1AE1E90", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[Token(Token = "0x60015C1")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE5F60", Offset = "0x1AE5160", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015C2")]
		private set { } //Length: 67
	}

	[Token(Token = "0x17000492")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
	{
		[Address(RVA = "0x1AE2CA0", Offset = "0x1AE1EA0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[Token(Token = "0x60015C3")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE5FB0", Offset = "0x1AE51B0", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015C4")]
		private set { } //Length: 67
	}

	[Token(Token = "0x17000493")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
	{
		[Address(RVA = "0x1AE2CB0", Offset = "0x1AE1EB0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[Token(Token = "0x60015C5")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE6000", Offset = "0x1AE5200", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015C6")]
		private set { } //Length: 67
	}

	[Token(Token = "0x17000494")]
	private override StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
	{
		[Address(RVA = "0x1AE2CC0", Offset = "0x1AE1EC0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x60015C7")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE6050", Offset = "0x1AE5250", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015C8")]
		private set { } //Length: 67
	}

	[Token(Token = "0x17000495")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
	{
		[Address(RVA = "0x1AE2CD0", Offset = "0x1AE1ED0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[Token(Token = "0x60015C9")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE60A0", Offset = "0x1AE52A0", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015CA")]
		private set { } //Length: 67
	}

	[Token(Token = "0x17000496")]
	private override StyleEnum<SliceType> UnityEngine.UIElements.IStyle.unitySliceType
	{
		[Address(RVA = "0x1AE2CE0", Offset = "0x1AE1EE0", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015CB")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE60F0", Offset = "0x1AE52F0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015CC")]
		private set { } //Length: 109
	}

	[Token(Token = "0x17000497")]
	private override StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.unityTextAlign
	{
		[Address(RVA = "0x1AE2D60", Offset = "0x1AE1F60", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015CD")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE6160", Offset = "0x1AE5360", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015CE")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004A3")]
	private override StyleTextAutoSize UnityEngine.UIElements.IStyle.unityTextAutoSize
	{
		[Address(RVA = "0x1AE2DE0", Offset = "0x1AE1FE0", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTextAutoSize), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleTextAutoSize))]
		[Token(Token = "0x60015EA")]
		private get { } //Length: 98
		[Address(RVA = "0x1AE61D0", Offset = "0x1AE53D0", Length = "0x1E7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTextAutoSize), Member = "get_value", ReturnType = typeof(TextAutoSize))]
		[Calls(Type = typeof(TextAutoSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleTextAutoSize), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Token(Token = "0x60015EB")]
		private set { } //Length: 487
	}

	[Token(Token = "0x17000498")]
	private override StyleEnum<TextGeneratorType> UnityEngine.UIElements.IStyle.unityTextGenerator
	{
		[Address(RVA = "0x1AE2E50", Offset = "0x1AE2050", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015CF")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE63C0", Offset = "0x1AE55C0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015D0")]
		private set { } //Length: 109
	}

	[Token(Token = "0x17000499")]
	private override StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
	{
		[Address(RVA = "0x1AE2ED0", Offset = "0x1AE20D0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		[Token(Token = "0x60015D1")]
		private get { } //Length: 60
		[Address(RVA = "0x1AE6430", Offset = "0x1AE5630", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015D2")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700049A")]
	private override StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
	{
		[Address(RVA = "0x1AE2F10", Offset = "0x1AE2110", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		[Token(Token = "0x60015D3")]
		private get { } //Length: 15
		[Address(RVA = "0x1AE6490", Offset = "0x1AE5690", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015D4")]
		private set { } //Length: 67
	}

	[Token(Token = "0x1700049B")]
	private override StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.unityTextOverflowPosition
	{
		[Address(RVA = "0x1AE2F20", Offset = "0x1AE2120", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015D5")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE64E0", Offset = "0x1AE56E0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015D6")]
		private set { } //Length: 109
	}

	[Token(Token = "0x1700049C")]
	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility
	{
		[Address(RVA = "0x1AE2FA0", Offset = "0x1AE21A0", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015D7")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE6550", Offset = "0x1AE5750", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015D8")]
		private set { } //Length: 109
	}

	[Token(Token = "0x1700049D")]
	private override StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.whiteSpace
	{
		[Address(RVA = "0x1AE3020", Offset = "0x1AE2220", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60015D9")]
		private get { } //Length: 126
		[Address(RVA = "0x1AE65C0", Offset = "0x1AE57C0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015DA")]
		private set { } //Length: 109
	}

	[Token(Token = "0x1700049E")]
	private override StyleLength UnityEngine.UIElements.IStyle.width
	{
		[Address(RVA = "0x1AE30A0", Offset = "0x1AE22A0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x60015DB")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE6630", Offset = "0x1AE5830", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015DC")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049F")]
	private override StyleLength UnityEngine.UIElements.IStyle.wordSpacing
	{
		[Address(RVA = "0x1AE30E0", Offset = "0x1AE22E0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		[Token(Token = "0x60015DD")]
		private get { } //Length: 59
		[Address(RVA = "0x1AE66E0", Offset = "0x1AE58E0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60015DE")]
		private set { } //Length: 86
	}

	[Token(Token = "0x170004A0")]
	private VisualElement ve
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60015DF")]
		private get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60015E0")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1AE6740", Offset = "0x1AE5940", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StylePropertyReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001620")]
	private static InlineStyleAccess() { }

	[Address(RVA = "0x1AE67C0", Offset = "0x1AE59C0", Length = "0x31")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleValueCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60015E1")]
	public InlineStyleAccess(VisualElement ve) { }

	[Address(RVA = "0x1ADC950", Offset = "0x1ADBB50", Length = "0x222")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsAnimatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001617")]
	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	[Address(RVA = "0x1ADCB80", Offset = "0x1ADBD80", Length = "0xC6E")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B8E0")]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "get_value", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D030")]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyReader), Member = "SetInlineContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleProperty[]), typeof(StylePropertyId[]), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60015E5")]
	public void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1ADD7F0", Offset = "0x1ADC9F0", Length = "0x231")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleBackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001613")]
	private void ApplyStyleBackgroundSize(StyleBackgroundSize backgroundSize) { }

	[Address(RVA = "0x1ADDA30", Offset = "0x1ADCC30", Length = "0x1F1")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001605")]
	private void ApplyStyleCursor(StyleCursor cursor) { }

	[Address(RVA = "0x1ADDC30", Offset = "0x1ADCE30", Length = "0x2B5")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001611")]
	private void ApplyStyleRotate(StyleRotate rotate) { }

	[Address(RVA = "0x1ADDEF0", Offset = "0x1ADD0F0", Length = "0x224")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600160F")]
	private void ApplyStyleScale(StyleScale scale) { }

	[Address(RVA = "0x1ADE120", Offset = "0x1ADD320", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "get_value", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001609")]
	private void ApplyStyleTextAutoSize(StyleTextAutoSize textAutoSize) { }

	[Address(RVA = "0x1ADE190", Offset = "0x1ADD390", Length = "0x240")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001607")]
	private void ApplyStyleTextShadow(StyleTextShadow textShadow) { }

	[Address(RVA = "0x1ADE3E0", Offset = "0x1ADD5E0", Length = "0x231")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600160B")]
	private void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin) { }

	[Address(RVA = "0x1ADE620", Offset = "0x1ADD820", Length = "0x245")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600160D")]
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	[Address(RVA = "0x1ADEB90", Offset = "0x1ADDD90", Length = "0xD2")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001615")]
	private void ApplyStyleValue(StyleValueManaged value) { }

	[Address(RVA = "0x1ADE870", Offset = "0x1ADDA70", Length = "0x315")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundRepeat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsAnimatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001614")]
	private void ApplyStyleValue(StyleValue value) { }

	[Address(RVA = "0x1ADEC70", Offset = "0x1ADDE70", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60015E2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60015DF")]
	private VisualElement get_ve() { }

	[Address(RVA = "0x6E6EA0", Offset = "0x6E60A0", Length = "0x10C")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionDelay", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionDuration", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionProperty", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionTimingFunction", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "TryGetStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValueManaged&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleList`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(StyleList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60015EE")]
	private StyleList<T> GetStyleList(StylePropertyId id) { }

	[Address(RVA = "0x1ADED30", Offset = "0x1ADDF30", Length = "0x2DE")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60015E4")]
	public bool IsValueSet(StylePropertyId id) { }

	[Address(RVA = "0x1ADF010", Offset = "0x1ADE210", Length = "0xF3")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleCache), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001616")]
	private bool RemoveInlineStyle(StylePropertyId id) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60015E0")]
	private void set_ve(VisualElement value) { }

	[Address(RVA = "0x1ADF110", Offset = "0x1ADE310", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001612")]
	private bool SetInlineBackgroundSize(StyleBackgroundSize inlineValue) { }

	[Address(RVA = "0x1ADF270", Offset = "0x1ADE470", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleCursor), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6001604")]
	private bool SetInlineCursor(StyleCursor inlineValue) { }

	[Address(RVA = "0x1ADF430", Offset = "0x1ADE630", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001610")]
	private bool SetInlineRotate(StyleRotate inlineValue) { }

	[Address(RVA = "0x1ADF600", Offset = "0x1ADE800", Length = "0xC3")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetCache), Member = "GetPropertyIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule)}, ReturnType = typeof(StylePropertyId[]))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015E3")]
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	[Address(RVA = "0x1ADF6D0", Offset = "0x1ADE8D0", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(Scale), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600160E")]
	private bool SetInlineScale(StyleScale inlineValue) { }

	[Address(RVA = "0x1ADF840", Offset = "0x1ADEA40", Length = "0x1C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "get_value", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(TextAutoSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6001608")]
	private bool SetInlineTextAutoSize(StyleTextAutoSize inlineValue) { }

	[Address(RVA = "0x1ADFA10", Offset = "0x1ADEC10", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextShadow), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6001606")]
	private bool SetInlineTextShadow(StyleTextShadow inlineValue) { }

	[Address(RVA = "0x1ADFBC0", Offset = "0x1ADEDC0", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600160A")]
	private bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue) { }

	[Address(RVA = "0x1ADFD20", Offset = "0x1ADEF20", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600160C")]
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	[Address(RVA = "0x1AE0100", Offset = "0x1ADF300", Length = "0x17F")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundPositionX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundPositionY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleBackgroundPosition), Member = "get_value", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015F9")]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundPosition inlineValue) { }

	[Address(RVA = "0x1AE0710", Offset = "0x1ADF910", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015FA")]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundRepeat inlineValue) { }

	[Address(RVA = "0x1AE0280", Offset = "0x1ADF480", Length = "0x15D")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015FB")]
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	[Address(RVA = "0x1AE0DC0", Offset = "0x1ADFFC0", Length = "0x140")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextOutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015FC")]
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	[Address(RVA = "0x1AE0A40", Offset = "0x1ADFC40", Length = "0x14E")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015FD")]
	private bool SetStyleValue(StylePropertyId id, StyleInt inlineValue) { }

	[Address(RVA = "0x1AE0B90", Offset = "0x1ADFD90", Length = "0x227")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFont)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001602")]
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	[Address(RVA = "0x6E78B0", Offset = "0x6E6AB0", Length = "0x19A")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityFontStyleAndWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.FontStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_whiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.WhiteSpace>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_visibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Visibility>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextOverflowPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.TextOverflowPosition>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.TextGeneratorType>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.TextAnchor>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.SliceType>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityOverflowClipBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.OverflowClipBox>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityEditorTextRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.EditorTextRenderingMode>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.TextOverflow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60015FF")]
	private bool SetStyleValue(StylePropertyId id, StyleEnum<T> inlineValue) { }

	[Address(RVA = "0x1AE0F00", Offset = "0x1AE0100", Length = "0x554")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001600")]
	private bool SetStyleValue(StylePropertyId id, StyleBackground inlineValue) { }

	[Address(RVA = "0x1AE03E0", Offset = "0x1ADF5E0", Length = "0x328")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleFontDefinition), Member = "get_value", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001601")]
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	[Address(RVA = "0x6E70D0", Offset = "0x6E62D0", Length = "0x2CB")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transitionTimingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingFunction)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleList`1), Member = "get_value", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "TryGetStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValueManaged&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001603")]
	private bool SetStyleValue(StylePropertyId id, StyleList<T> inlineValue) { }

	[Address(RVA = "0x1AE0880", Offset = "0x1ADFA80", Length = "0x1BE")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextOutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleColor), Member = "get_value", ReturnType = typeof(Color))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015FE")]
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	[Address(RVA = "0x1ADFEF0", Offset = "0x1ADF0F0", Length = "0x202")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015EF")]
	private void SetStyleValueManaged(StyleValueManaged value) { }

	[Address(RVA = "0x1AE1460", Offset = "0x1AE0660", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161F")]
	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	[Address(RVA = "0x1AE1490", Offset = "0x1AE0690", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001618")]
	public bool TryGetInlineCursor(ref StyleCursor value) { }

	[Address(RVA = "0x1AE14D0", Offset = "0x1AE06D0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161D")]
	public bool TryGetInlineRotate(ref StyleRotate value) { }

	[Address(RVA = "0x1AE1500", Offset = "0x1AE0700", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161E")]
	public bool TryGetInlineScale(ref StyleScale value) { }

	[Address(RVA = "0x1AE1530", Offset = "0x1AE0730", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161A")]
	public bool TryGetInlineTextAutoSize(ref StyleTextAutoSize value) { }

	[Address(RVA = "0x1AE1550", Offset = "0x1AE0750", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001619")]
	public bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	[Address(RVA = "0x1AE1570", Offset = "0x1AE0770", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161B")]
	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	[Address(RVA = "0x1AE15A0", Offset = "0x1AE07A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161C")]
	public bool TryGetInlineTranslate(ref StyleTranslate value) { }

	[Address(RVA = "0x1AE15D0", Offset = "0x1AE07D0", Length = "0x130")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015F0")]
	private bool TryGetStyleValueManaged(StylePropertyId id, ref StyleValueManaged value) { }

	[Address(RVA = "0x1AE1710", Offset = "0x1AE0910", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001545")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignContent() { }

	[Address(RVA = "0x1AE1790", Offset = "0x1AE0990", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001547")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignItems() { }

	[Address(RVA = "0x1AE1810", Offset = "0x1AE0A10", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001549")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignSelf() { }

	[Address(RVA = "0x1AE1890", Offset = "0x1AE0A90", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x600154B")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_backgroundColor() { }

	[Address(RVA = "0x1AE18D0", Offset = "0x1AE0AD0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
	[Token(Token = "0x600154D")]
	private override StyleBackground UnityEngine.UIElements.IStyle.get_backgroundImage() { }

	[Address(RVA = "0x1AE1920", Offset = "0x1AE0B20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
	[Token(Token = "0x600154F")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.get_backgroundPositionX() { }

	[Address(RVA = "0x1AE1960", Offset = "0x1AE0B60", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
	[Token(Token = "0x6001551")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.get_backgroundPositionY() { }

	[Address(RVA = "0x1AE19A0", Offset = "0x1AE0BA0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundRepeat))]
	[Token(Token = "0x6001553")]
	private override StyleBackgroundRepeat UnityEngine.UIElements.IStyle.get_backgroundRepeat() { }

	[Address(RVA = "0x1AE19E0", Offset = "0x1AE0BE0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015EC")]
	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	[Address(RVA = "0x1AE1A50", Offset = "0x1AE0C50", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x6001555")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderBottomColor() { }

	[Address(RVA = "0x1AE1A90", Offset = "0x1AE0C90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001557")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderBottomLeftRadius() { }

	[Address(RVA = "0x1AE1AD0", Offset = "0x1AE0CD0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001559")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderBottomRightRadius() { }

	[Address(RVA = "0x1AE1B10", Offset = "0x1AE0D10", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x600155B")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderBottomWidth() { }

	[Address(RVA = "0x1AE1B20", Offset = "0x1AE0D20", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x600155D")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderLeftColor() { }

	[Address(RVA = "0x1AE1B60", Offset = "0x1AE0D60", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x600155F")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderLeftWidth() { }

	[Address(RVA = "0x1AE1B70", Offset = "0x1AE0D70", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x6001561")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderRightColor() { }

	[Address(RVA = "0x1AE1BB0", Offset = "0x1AE0DB0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x6001563")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderRightWidth() { }

	[Address(RVA = "0x1AE1BC0", Offset = "0x1AE0DC0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x6001565")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderTopColor() { }

	[Address(RVA = "0x1AE1C00", Offset = "0x1AE0E00", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001567")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderTopLeftRadius() { }

	[Address(RVA = "0x1AE1C40", Offset = "0x1AE0E40", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001569")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderTopRightRadius() { }

	[Address(RVA = "0x1AE1C80", Offset = "0x1AE0E80", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x600156B")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderTopWidth() { }

	[Address(RVA = "0x1AE1C90", Offset = "0x1AE0E90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600156D")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_bottom() { }

	[Address(RVA = "0x1AE1CD0", Offset = "0x1AE0ED0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x600156F")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_color() { }

	[Address(RVA = "0x1AE1D10", Offset = "0x1AE0F10", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleCursor), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleCursor))]
	[Token(Token = "0x60015E6")]
	private override StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	[Address(RVA = "0x1AE1DA0", Offset = "0x1AE0FA0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001571")]
	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	[Address(RVA = "0x1AE1E20", Offset = "0x1AE1020", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001573")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_flexBasis() { }

	[Address(RVA = "0x1AE1E60", Offset = "0x1AE1060", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001575")]
	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.get_flexDirection() { }

	[Address(RVA = "0x1AE1EE0", Offset = "0x1AE10E0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x6001577")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_flexGrow() { }

	[Address(RVA = "0x1AE1EF0", Offset = "0x1AE10F0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x6001579")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_flexShrink() { }

	[Address(RVA = "0x1AE1F00", Offset = "0x1AE1100", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600157B")]
	private override StyleEnum<Wrap> UnityEngine.UIElements.IStyle.get_flexWrap() { }

	[Address(RVA = "0x1AE1F80", Offset = "0x1AE1180", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600157D")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_fontSize() { }

	[Address(RVA = "0x1AE1FC0", Offset = "0x1AE11C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600157F")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_height() { }

	[Address(RVA = "0x1AE2000", Offset = "0x1AE1200", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001581")]
	private override StyleEnum<Justify> UnityEngine.UIElements.IStyle.get_justifyContent() { }

	[Address(RVA = "0x1AE2080", Offset = "0x1AE1280", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001583")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_left() { }

	[Address(RVA = "0x1AE20C0", Offset = "0x1AE12C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001585")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_letterSpacing() { }

	[Address(RVA = "0x1AE2100", Offset = "0x1AE1300", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001587")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginBottom() { }

	[Address(RVA = "0x1AE2140", Offset = "0x1AE1340", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001589")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginLeft() { }

	[Address(RVA = "0x1AE2180", Offset = "0x1AE1380", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600158B")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginRight() { }

	[Address(RVA = "0x1AE21C0", Offset = "0x1AE13C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600158D")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginTop() { }

	[Address(RVA = "0x1AE2200", Offset = "0x1AE1400", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600158F")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_maxHeight() { }

	[Address(RVA = "0x1AE2240", Offset = "0x1AE1440", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001591")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_maxWidth() { }

	[Address(RVA = "0x1AE2280", Offset = "0x1AE1480", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001593")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_minHeight() { }

	[Address(RVA = "0x1AE22C0", Offset = "0x1AE14C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x6001595")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_minWidth() { }

	[Address(RVA = "0x1AE2300", Offset = "0x1AE1500", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x6001597")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_opacity() { }

	[Address(RVA = "0x1AE2310", Offset = "0x1AE1510", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001599")]
	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.get_overflow() { }

	[Address(RVA = "0x1AE2390", Offset = "0x1AE1590", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600159B")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingBottom() { }

	[Address(RVA = "0x1AE23D0", Offset = "0x1AE15D0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600159D")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingLeft() { }

	[Address(RVA = "0x1AE2410", Offset = "0x1AE1610", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x600159F")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingRight() { }

	[Address(RVA = "0x1AE2450", Offset = "0x1AE1650", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x60015A1")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	[Address(RVA = "0x1AE2490", Offset = "0x1AE1690", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015A3")]
	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.get_position() { }

	[Address(RVA = "0x1AE2510", Offset = "0x1AE1710", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x60015A5")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_right() { }

	[Address(RVA = "0x1AE2550", Offset = "0x1AE1750", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015F5")]
	private override StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	[Address(RVA = "0x1AE25D0", Offset = "0x1AE17D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015F7")]
	private override StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	[Address(RVA = "0x1AE2630", Offset = "0x1AE1830", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015A7")]
	private override StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.get_textOverflow() { }

	[Address(RVA = "0x1AE26B0", Offset = "0x1AE18B0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextShadow), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleTextShadow))]
	[Token(Token = "0x60015E8")]
	private override StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	[Address(RVA = "0x1AE2710", Offset = "0x1AE1910", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x60015A9")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_top() { }

	[Address(RVA = "0x1AE2750", Offset = "0x1AE1950", Length = "0x68")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015F1")]
	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	[Address(RVA = "0x1AE27C0", Offset = "0x1AE19C0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[Token(Token = "0x60015AB")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.get_transitionDelay() { }

	[Address(RVA = "0x1AE2830", Offset = "0x1AE1A30", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[Token(Token = "0x60015AD")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.get_transitionDuration() { }

	[Address(RVA = "0x1AE28A0", Offset = "0x1AE1AA0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[Token(Token = "0x60015AF")]
	private override StyleList<StylePropertyName> UnityEngine.UIElements.IStyle.get_transitionProperty() { }

	[Address(RVA = "0x1AE2910", Offset = "0x1AE1B10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[Token(Token = "0x60015B1")]
	private override StyleList<EasingFunction> UnityEngine.UIElements.IStyle.get_transitionTimingFunction() { }

	[Address(RVA = "0x1AE2980", Offset = "0x1AE1B80", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015F3")]
	private override StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	[Address(RVA = "0x1AE2A00", Offset = "0x1AE1C00", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x60015B3")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_unityBackgroundImageTintColor() { }

	[Address(RVA = "0x1AE2A40", Offset = "0x1AE1C40", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015B5")]
	private override StyleEnum<EditorTextRenderingMode> UnityEngine.UIElements.IStyle.get_unityEditorTextRenderingMode() { }

	[Address(RVA = "0x1AE2B90", Offset = "0x1AE1D90", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFont))]
	[Token(Token = "0x60015B7")]
	private override StyleFont UnityEngine.UIElements.IStyle.get_unityFont() { }

	[Address(RVA = "0x1AE2AC0", Offset = "0x1AE1CC0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFontDefinition))]
	[Token(Token = "0x60015B9")]
	private override StyleFontDefinition UnityEngine.UIElements.IStyle.get_unityFontDefinition() { }

	[Address(RVA = "0x1AE2B10", Offset = "0x1AE1D10", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015BB")]
	private override StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.get_unityFontStyleAndWeight() { }

	[Address(RVA = "0x1AE2BD0", Offset = "0x1AE1DD0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015BD")]
	private override StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.get_unityOverflowClipBox() { }

	[Address(RVA = "0x1AE2C50", Offset = "0x1AE1E50", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x60015BF")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_unityParagraphSpacing() { }

	[Address(RVA = "0x1AE2C90", Offset = "0x1AE1E90", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[Token(Token = "0x60015C1")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceBottom() { }

	[Address(RVA = "0x1AE2CA0", Offset = "0x1AE1EA0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[Token(Token = "0x60015C3")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceLeft() { }

	[Address(RVA = "0x1AE2CB0", Offset = "0x1AE1EB0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[Token(Token = "0x60015C5")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceRight() { }

	[Address(RVA = "0x1AE2CC0", Offset = "0x1AE1EC0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x60015C7")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_unitySliceScale() { }

	[Address(RVA = "0x1AE2CD0", Offset = "0x1AE1ED0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[Token(Token = "0x60015C9")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceTop() { }

	[Address(RVA = "0x1AE2CE0", Offset = "0x1AE1EE0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015CB")]
	private override StyleEnum<SliceType> UnityEngine.UIElements.IStyle.get_unitySliceType() { }

	[Address(RVA = "0x1AE2D60", Offset = "0x1AE1F60", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015CD")]
	private override StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.get_unityTextAlign() { }

	[Address(RVA = "0x1AE2DE0", Offset = "0x1AE1FE0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleTextAutoSize))]
	[Token(Token = "0x60015EA")]
	private override StyleTextAutoSize UnityEngine.UIElements.IStyle.get_unityTextAutoSize() { }

	[Address(RVA = "0x1AE2E50", Offset = "0x1AE2050", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015CF")]
	private override StyleEnum<TextGeneratorType> UnityEngine.UIElements.IStyle.get_unityTextGenerator() { }

	[Address(RVA = "0x1AE2ED0", Offset = "0x1AE20D0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	[Token(Token = "0x60015D1")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_unityTextOutlineColor() { }

	[Address(RVA = "0x1AE2F10", Offset = "0x1AE2110", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	[Token(Token = "0x60015D3")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_unityTextOutlineWidth() { }

	[Address(RVA = "0x1AE2F20", Offset = "0x1AE2120", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015D5")]
	private override StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.get_unityTextOverflowPosition() { }

	[Address(RVA = "0x1AE2FA0", Offset = "0x1AE21A0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015D7")]
	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.get_visibility() { }

	[Address(RVA = "0x1AE3020", Offset = "0x1AE2220", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60015D9")]
	private override StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.get_whiteSpace() { }

	[Address(RVA = "0x1AE30A0", Offset = "0x1AE22A0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x60015DB")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	[Address(RVA = "0x1AE30E0", Offset = "0x1AE22E0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	[Token(Token = "0x60015DD")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_wordSpacing() { }

	[Address(RVA = "0x1AE3120", Offset = "0x1AE2320", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001546")]
	private override void UnityEngine.UIElements.IStyle.set_alignContent(StyleEnum<Align> value) { }

	[Address(RVA = "0x1AE31D0", Offset = "0x1AE23D0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001548")]
	private override void UnityEngine.UIElements.IStyle.set_alignItems(StyleEnum<Align> value) { }

	[Address(RVA = "0x1AE3280", Offset = "0x1AE2480", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600154A")]
	private override void UnityEngine.UIElements.IStyle.set_alignSelf(StyleEnum<Align> value) { }

	[Address(RVA = "0x1AE3330", Offset = "0x1AE2530", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600154C")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	[Address(RVA = "0x1AE3390", Offset = "0x1AE2590", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600154E")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundImage(StyleBackground value) { }

	[Address(RVA = "0x1AE3400", Offset = "0x1AE2600", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001550")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundPositionX(StyleBackgroundPosition value) { }

	[Address(RVA = "0x1AE3450", Offset = "0x1AE2650", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001552")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundPositionY(StyleBackgroundPosition value) { }

	[Address(RVA = "0x1AE34A0", Offset = "0x1AE26A0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001554")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundRepeat(StyleBackgroundRepeat value) { }

	[Address(RVA = "0x1AE3610", Offset = "0x1AE2810", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60015ED")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundSize(StyleBackgroundSize value) { }

	[Address(RVA = "0x1AE3780", Offset = "0x1AE2980", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001556")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	[Address(RVA = "0x1AE37E0", Offset = "0x1AE29E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001558")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	[Address(RVA = "0x1AE3840", Offset = "0x1AE2A40", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600155A")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	[Address(RVA = "0x1AE38A0", Offset = "0x1AE2AA0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600155C")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	[Address(RVA = "0x1AE3930", Offset = "0x1AE2B30", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600155E")]
	private override void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	[Address(RVA = "0x1AE3990", Offset = "0x1AE2B90", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001560")]
	private override void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	[Address(RVA = "0x1AE3A20", Offset = "0x1AE2C20", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001562")]
	private override void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	[Address(RVA = "0x1AE3A80", Offset = "0x1AE2C80", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001564")]
	private override void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	[Address(RVA = "0x1AE3B10", Offset = "0x1AE2D10", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001566")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	[Address(RVA = "0x1AE3B70", Offset = "0x1AE2D70", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001568")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	[Address(RVA = "0x1AE3BD0", Offset = "0x1AE2DD0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600156A")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	[Address(RVA = "0x1AE3C30", Offset = "0x1AE2E30", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600156C")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	[Address(RVA = "0x1AE3CC0", Offset = "0x1AE2EC0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600156E")]
	private override void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	[Address(RVA = "0x1AE3D70", Offset = "0x1AE2F70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001570")]
	private override void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	[Address(RVA = "0x1AE3DD0", Offset = "0x1AE2FD0", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleCursor), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60015E7")]
	private override void UnityEngine.UIElements.IStyle.set_cursor(StyleCursor value) { }

	[Address(RVA = "0x1AE3FB0", Offset = "0x1AE31B0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001572")]
	private override void UnityEngine.UIElements.IStyle.set_display(StyleEnum<DisplayStyle> value) { }

	[Address(RVA = "0x1AE4060", Offset = "0x1AE3260", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001574")]
	private override void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	[Address(RVA = "0x1AE4110", Offset = "0x1AE3310", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001576")]
	private override void UnityEngine.UIElements.IStyle.set_flexDirection(StyleEnum<FlexDirection> value) { }

	[Address(RVA = "0x1AE41C0", Offset = "0x1AE33C0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001578")]
	private override void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	[Address(RVA = "0x1AE4250", Offset = "0x1AE3450", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600157A")]
	private override void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	[Address(RVA = "0x1AE42E0", Offset = "0x1AE34E0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600157C")]
	private override void UnityEngine.UIElements.IStyle.set_flexWrap(StyleEnum<Wrap> value) { }

	[Address(RVA = "0x1AE4390", Offset = "0x1AE3590", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600157E")]
	private override void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	[Address(RVA = "0x1AE43F0", Offset = "0x1AE35F0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001580")]
	private override void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	[Address(RVA = "0x1AE44A0", Offset = "0x1AE36A0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001582")]
	private override void UnityEngine.UIElements.IStyle.set_justifyContent(StyleEnum<Justify> value) { }

	[Address(RVA = "0x1AE4550", Offset = "0x1AE3750", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001584")]
	private override void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	[Address(RVA = "0x1AE4600", Offset = "0x1AE3800", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001586")]
	private override void UnityEngine.UIElements.IStyle.set_letterSpacing(StyleLength value) { }

	[Address(RVA = "0x1AE4660", Offset = "0x1AE3860", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001588")]
	private override void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	[Address(RVA = "0x1AE4710", Offset = "0x1AE3910", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600158A")]
	private override void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	[Address(RVA = "0x1AE47C0", Offset = "0x1AE39C0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600158C")]
	private override void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	[Address(RVA = "0x1AE4870", Offset = "0x1AE3A70", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600158E")]
	private override void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	[Address(RVA = "0x1AE4920", Offset = "0x1AE3B20", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001590")]
	private override void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	[Address(RVA = "0x1AE49D0", Offset = "0x1AE3BD0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001592")]
	private override void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	[Address(RVA = "0x1AE4A80", Offset = "0x1AE3C80", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001594")]
	private override void UnityEngine.UIElements.IStyle.set_minHeight(StyleLength value) { }

	[Address(RVA = "0x1AE4B30", Offset = "0x1AE3D30", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001596")]
	private override void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	[Address(RVA = "0x1AE4BE0", Offset = "0x1AE3DE0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001598")]
	private override void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	[Address(RVA = "0x1AE4C30", Offset = "0x1AE3E30", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600159A")]
	private override void UnityEngine.UIElements.IStyle.set_overflow(StyleEnum<Overflow> value) { }

	[Address(RVA = "0x1AE4D50", Offset = "0x1AE3F50", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600159C")]
	private override void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	[Address(RVA = "0x1AE4E00", Offset = "0x1AE4000", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600159E")]
	private override void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	[Address(RVA = "0x1AE4EB0", Offset = "0x1AE40B0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015A0")]
	private override void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	[Address(RVA = "0x1AE4F60", Offset = "0x1AE4160", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015A2")]
	private override void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	[Address(RVA = "0x1AE5010", Offset = "0x1AE4210", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015A4")]
	private override void UnityEngine.UIElements.IStyle.set_position(StyleEnum<Position> value) { }

	[Address(RVA = "0x1AE50C0", Offset = "0x1AE42C0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015A6")]
	private override void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	[Address(RVA = "0x1AE5170", Offset = "0x1AE4370", Length = "0x1A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60015F6")]
	private override void UnityEngine.UIElements.IStyle.set_rotate(StyleRotate value) { }

	[Address(RVA = "0x1AE5320", Offset = "0x1AE4520", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(Scale), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60015F8")]
	private override void UnityEngine.UIElements.IStyle.set_scale(StyleScale value) { }

	[Address(RVA = "0x1AE5490", Offset = "0x1AE4690", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015A8")]
	private override void UnityEngine.UIElements.IStyle.set_textOverflow(StyleEnum<TextOverflow> value) { }

	[Address(RVA = "0x1AE5500", Offset = "0x1AE4700", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextShadow), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60015E9")]
	private override void UnityEngine.UIElements.IStyle.set_textShadow(StyleTextShadow value) { }

	[Address(RVA = "0x1AE56D0", Offset = "0x1AE48D0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015AA")]
	private override void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	[Address(RVA = "0x1AE5780", Offset = "0x1AE4980", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60015F2")]
	private override void UnityEngine.UIElements.IStyle.set_transformOrigin(StyleTransformOrigin value) { }

	[Address(RVA = "0x1AE58F0", Offset = "0x1AE4AF0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015AC")]
	private override void UnityEngine.UIElements.IStyle.set_transitionDelay(StyleList<TimeValue> value) { }

	[Address(RVA = "0x1AE5970", Offset = "0x1AE4B70", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015AE")]
	private override void UnityEngine.UIElements.IStyle.set_transitionDuration(StyleList<TimeValue> value) { }

	[Address(RVA = "0x1AE59F0", Offset = "0x1AE4BF0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015B0")]
	private override void UnityEngine.UIElements.IStyle.set_transitionProperty(StyleList<StylePropertyName> value) { }

	[Address(RVA = "0x1AE5A70", Offset = "0x1AE4C70", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015B2")]
	private override void UnityEngine.UIElements.IStyle.set_transitionTimingFunction(StyleList<EasingFunction> value) { }

	[Address(RVA = "0x1AE5AF0", Offset = "0x1AE4CF0", Length = "0x1A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60015F4")]
	private override void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	[Address(RVA = "0x1AE5CA0", Offset = "0x1AE4EA0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015B4")]
	private override void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	[Address(RVA = "0x1AE5D00", Offset = "0x1AE4F00", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015B6")]
	private override void UnityEngine.UIElements.IStyle.set_unityEditorTextRenderingMode(StyleEnum<EditorTextRenderingMode> value) { }

	[Address(RVA = "0x1AE5E40", Offset = "0x1AE5040", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015B8")]
	private override void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	[Address(RVA = "0x1AE5D70", Offset = "0x1AE4F70", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015BA")]
	private override void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	[Address(RVA = "0x1AE5DD0", Offset = "0x1AE4FD0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015BC")]
	private override void UnityEngine.UIElements.IStyle.set_unityFontStyleAndWeight(StyleEnum<FontStyle> value) { }

	[Address(RVA = "0x1AE5E90", Offset = "0x1AE5090", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015BE")]
	private override void UnityEngine.UIElements.IStyle.set_unityOverflowClipBox(StyleEnum<OverflowClipBox> value) { }

	[Address(RVA = "0x1AE5F00", Offset = "0x1AE5100", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015C0")]
	private override void UnityEngine.UIElements.IStyle.set_unityParagraphSpacing(StyleLength value) { }

	[Address(RVA = "0x1AE5F60", Offset = "0x1AE5160", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015C2")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceBottom(StyleInt value) { }

	[Address(RVA = "0x1AE5FB0", Offset = "0x1AE51B0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015C4")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceLeft(StyleInt value) { }

	[Address(RVA = "0x1AE6000", Offset = "0x1AE5200", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015C6")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceRight(StyleInt value) { }

	[Address(RVA = "0x1AE6050", Offset = "0x1AE5250", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015C8")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceScale(StyleFloat value) { }

	[Address(RVA = "0x1AE60A0", Offset = "0x1AE52A0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015CA")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceTop(StyleInt value) { }

	[Address(RVA = "0x1AE60F0", Offset = "0x1AE52F0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015CC")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceType(StyleEnum<SliceType> value) { }

	[Address(RVA = "0x1AE6160", Offset = "0x1AE5360", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015CE")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextAlign(StyleEnum<TextAnchor> value) { }

	[Address(RVA = "0x1AE61D0", Offset = "0x1AE53D0", Length = "0x1E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "get_value", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(TextAutoSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextAutoSize), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60015EB")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextAutoSize(StyleTextAutoSize value) { }

	[Address(RVA = "0x1AE63C0", Offset = "0x1AE55C0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015D0")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextGenerator(StyleEnum<TextGeneratorType> value) { }

	[Address(RVA = "0x1AE6430", Offset = "0x1AE5630", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015D2")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOutlineColor(StyleColor value) { }

	[Address(RVA = "0x1AE6490", Offset = "0x1AE5690", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015D4")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOutlineWidth(StyleFloat value) { }

	[Address(RVA = "0x1AE64E0", Offset = "0x1AE56E0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015D6")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOverflowPosition(StyleEnum<TextOverflowPosition> value) { }

	[Address(RVA = "0x1AE6550", Offset = "0x1AE5750", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015D8")]
	private override void UnityEngine.UIElements.IStyle.set_visibility(StyleEnum<Visibility> value) { }

	[Address(RVA = "0x1AE65C0", Offset = "0x1AE57C0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015DA")]
	private override void UnityEngine.UIElements.IStyle.set_whiteSpace(StyleEnum<WhiteSpace> value) { }

	[Address(RVA = "0x1AE6630", Offset = "0x1AE5830", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015DC")]
	private override void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	[Address(RVA = "0x1AE66E0", Offset = "0x1AE58E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015DE")]
	private override void UnityEngine.UIElements.IStyle.set_wordSpacing(StyleLength value) { }

}

