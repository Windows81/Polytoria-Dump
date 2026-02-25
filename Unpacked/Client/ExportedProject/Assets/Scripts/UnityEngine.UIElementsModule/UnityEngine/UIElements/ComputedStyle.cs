namespace UnityEngine.UIElements;

[Token(Token = "0x20002EA")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct ComputedStyle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BB7")]
	public StyleDataRef<InheritedData> inheritedData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BB8")]
	public StyleDataRef<LayoutData> layoutData; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BB9")]
	public StyleDataRef<RareData> rareData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BBA")]
	public StyleDataRef<TransformData> transformData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BBB")]
	public StyleDataRef<TransitionData> transitionData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BBC")]
	public StyleDataRef<VisualData> visualData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BBD")]
	public Dictionary<String, StylePropertyValue> customProperties; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BBE")]
	public long matchingRulesHash; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BBF")]
	public float dpiScaling; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BC0")]
	public ComputedTransitionProperty[] computedTransitions; //Field offset: 0x48

	[Token(Token = "0x170003EE")]
	public Align alignContent
	{
		[Address(RVA = "0x1CAAE30", Offset = "0x1CAA030", Length = "0x3D")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignContent", ReturnType = typeof(Align))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001458")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170003EF")]
	public Align alignItems
	{
		[Address(RVA = "0x1CAAE70", Offset = "0x1CAA070", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignItems", ReturnType = typeof(Align))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001459")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170003F0")]
	public Align alignSelf
	{
		[Address(RVA = "0x1CAAEB0", Offset = "0x1CAA0B0", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignSelf", ReturnType = typeof(Align))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600145A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170003F1")]
	public Color backgroundColor
	{
		[Address(RVA = "0x1CAAEF0", Offset = "0x1CAA0F0", Length = "0x50")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundColor", ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600145B")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170003F2")]
	public Background backgroundImage
	{
		[Address(RVA = "0x1CAAF40", Offset = "0x1CAA140", Length = "0x59")]
		[CalledBy(Type = typeof(UIRUtility), Member = "IsVectorImageBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundImage", ReturnType = typeof(Background))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "RequiresStencilMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementStencilMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600145C")]
		 get { } //Length: 89
	}

	[Token(Token = "0x170003F3")]
	public BackgroundPosition backgroundPositionX
	{
		[Address(RVA = "0x1CAAFA0", Offset = "0x1CAA1A0", Length = "0x59")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600145D")]
		 get { } //Length: 89
	}

	[Token(Token = "0x170003F4")]
	public BackgroundPosition backgroundPositionY
	{
		[Address(RVA = "0x1CAB000", Offset = "0x1CAA200", Length = "0x59")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600145E")]
		 get { } //Length: 89
	}

	[Token(Token = "0x170003F5")]
	public BackgroundRepeat backgroundRepeat
	{
		[Address(RVA = "0x1CAB060", Offset = "0x1CAA260", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600145F")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170003F6")]
	public BackgroundSize backgroundSize
	{
		[Address(RVA = "0x1CAB0A0", Offset = "0x1CAA2A0", Length = "0x57")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001460")]
		 get { } //Length: 87
	}

	[Token(Token = "0x170003F7")]
	public Color borderBottomColor
	{
		[Address(RVA = "0x1CAB100", Offset = "0x1CAA300", Length = "0x51")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001461")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170003F8")]
	public Length borderBottomLeftRadius
	{
		[Address(RVA = "0x1CAB160", Offset = "0x1CAA360", Length = "0x3F")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomLeftRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001462")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170003F9")]
	public Length borderBottomRightRadius
	{
		[Address(RVA = "0x1CAB1A0", Offset = "0x1CAA3A0", Length = "0x3F")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomRightRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001463")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170003FA")]
	public float borderBottomWidth
	{
		[Address(RVA = "0x1CAB1E0", Offset = "0x1CAA3E0", Length = "0x40")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001464")]
		 get { } //Length: 64
	}

	[Token(Token = "0x170003FB")]
	public Color borderLeftColor
	{
		[Address(RVA = "0x1CAB220", Offset = "0x1CAA420", Length = "0x54")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001465")]
		 get { } //Length: 84
	}

	[Token(Token = "0x170003FC")]
	public float borderLeftWidth
	{
		[Address(RVA = "0x1CAB280", Offset = "0x1CAA480", Length = "0x40")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001466")]
		 get { } //Length: 64
	}

	[Token(Token = "0x170003FD")]
	public Color borderRightColor
	{
		[Address(RVA = "0x1CAB2C0", Offset = "0x1CAA4C0", Length = "0x54")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001467")]
		 get { } //Length: 84
	}

	[Token(Token = "0x170003FE")]
	public float borderRightWidth
	{
		[Address(RVA = "0x1CAB320", Offset = "0x1CAA520", Length = "0x40")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001468")]
		 get { } //Length: 64
	}

	[Token(Token = "0x170003FF")]
	public Color borderTopColor
	{
		[Address(RVA = "0x1CAB360", Offset = "0x1CAA560", Length = "0x54")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001469")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000400")]
	public Length borderTopLeftRadius
	{
		[Address(RVA = "0x1CAB3C0", Offset = "0x1CAA5C0", Length = "0x42")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopLeftRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600146A")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000401")]
	public Length borderTopRightRadius
	{
		[Address(RVA = "0x1CAB410", Offset = "0x1CAA610", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopRightRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600146B")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000402")]
	public float borderTopWidth
	{
		[Address(RVA = "0x1CAB460", Offset = "0x1CAA660", Length = "0x40")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600146C")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000403")]
	public Length bottom
	{
		[Address(RVA = "0x1CAB4A0", Offset = "0x1CAA6A0", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600146D")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000404")]
	public Color color
	{
		[Address(RVA = "0x1CAB4E0", Offset = "0x1CAA6E0", Length = "0x4F")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_color", ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600146E")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000405")]
	public Cursor cursor
	{
		[Address(RVA = "0x1CAB530", Offset = "0x1CAA730", Length = "0x5A")]
		[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEventHandler), Member = "ATagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600146F")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170003EC")]
	public int customPropertiesCount
	{
		[Address(RVA = "0x1CAB590", Offset = "0x1CAA790", Length = "0x47")]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Token(Token = "0x6001449")]
		 get { } //Length: 71
	}

	[Token(Token = "0x17000406")]
	public DisplayStyle display
	{
		[Address(RVA = "0x1CAB5E0", Offset = "0x1CAA7E0", Length = "0x3E")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_display", ReturnType = typeof(DisplayStyle))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001470")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000407")]
	public Length flexBasis
	{
		[Address(RVA = "0x1CAB620", Offset = "0x1CAA820", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001471")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000408")]
	public FlexDirection flexDirection
	{
		[Address(RVA = "0x1CAB660", Offset = "0x1CAA860", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001472")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000409")]
	public float flexGrow
	{
		[Address(RVA = "0x1CAB6A0", Offset = "0x1CAA8A0", Length = "0x40")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexGrow", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001473")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700040A")]
	public float flexShrink
	{
		[Address(RVA = "0x1CAB6E0", Offset = "0x1CAA8E0", Length = "0x40")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexShrink", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001474")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700040B")]
	public Wrap flexWrap
	{
		[Address(RVA = "0x1CAB720", Offset = "0x1CAA920", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001475")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700040C")]
	public Length fontSize
	{
		[Address(RVA = "0x1CAB760", Offset = "0x1CAA960", Length = "0x3E")]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_fontSize", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001476")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170003ED")]
	public bool hasTransition
	{
		[Address(RVA = "0x1CAB7A0", Offset = "0x1CAA9A0", Length = "0x12")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600144A")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700040D")]
	public Length height
	{
		[Address(RVA = "0x1CAB7C0", Offset = "0x1CAA9C0", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001477")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700040E")]
	public Justify justifyContent
	{
		[Address(RVA = "0x1CAB800", Offset = "0x1CAAA00", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_justifyContent", ReturnType = typeof(Justify))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001478")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700040F")]
	public Length left
	{
		[Address(RVA = "0x1CAB840", Offset = "0x1CAAA40", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001479")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000410")]
	public Length letterSpacing
	{
		[Address(RVA = "0x1CAB880", Offset = "0x1CAAA80", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_letterSpacing", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600147A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000411")]
	public Length marginBottom
	{
		[Address(RVA = "0x1CAB8C0", Offset = "0x1CAAAC0", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600147B")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000412")]
	public Length marginLeft
	{
		[Address(RVA = "0x1CAB900", Offset = "0x1CAAB00", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600147C")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000413")]
	public Length marginRight
	{
		[Address(RVA = "0x1CAB940", Offset = "0x1CAAB40", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600147D")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000414")]
	public Length marginTop
	{
		[Address(RVA = "0x1CAB980", Offset = "0x1CAAB80", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600147E")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000415")]
	public Length maxHeight
	{
		[Address(RVA = "0x1CAB9C0", Offset = "0x1CAABC0", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxHeight", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600147F")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000416")]
	public Length maxWidth
	{
		[Address(RVA = "0x1CABA00", Offset = "0x1CAAC00", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxWidth", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001480")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000417")]
	public Length minHeight
	{
		[Address(RVA = "0x1CABA40", Offset = "0x1CAAC40", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minHeight", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001481")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000418")]
	public Length minWidth
	{
		[Address(RVA = "0x1CABA90", Offset = "0x1CAAC90", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minWidth", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001482")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000419")]
	public float opacity
	{
		[Address(RVA = "0x1CABAE0", Offset = "0x1CAACE0", Length = "0x43")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_opacity", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001483")]
		 get { } //Length: 67
	}

	[Token(Token = "0x1700041A")]
	public OverflowInternal overflow
	{
		[Address(RVA = "0x1CABB30", Offset = "0x1CAAD30", Length = "0x41")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001484")]
		 get { } //Length: 65
	}

	[Token(Token = "0x1700041B")]
	public Length paddingBottom
	{
		[Address(RVA = "0x1CABB80", Offset = "0x1CAAD80", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001485")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700041C")]
	public Length paddingLeft
	{
		[Address(RVA = "0x1CABBD0", Offset = "0x1CAADD0", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001486")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700041D")]
	public Length paddingRight
	{
		[Address(RVA = "0x1CABC20", Offset = "0x1CAAE20", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001487")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700041E")]
	public Length paddingTop
	{
		[Address(RVA = "0x1CABC70", Offset = "0x1CAAE70", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001488")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700041F")]
	public Position position
	{
		[Address(RVA = "0x1CABCC0", Offset = "0x1CAAEC0", Length = "0x41")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_position", ReturnType = typeof(Position))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001489")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000420")]
	public Length right
	{
		[Address(RVA = "0x1CABD10", Offset = "0x1CAAF10", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600148A")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000421")]
	public Rotate rotate
	{
		[Address(RVA = "0x1CABD60", Offset = "0x1CAAF60", Length = "0x5A")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DRotation", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveRotation", ReturnType = typeof(Quaternion))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600148B")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000422")]
	public Scale scale
	{
		[Address(RVA = "0x1CABDC0", Offset = "0x1CAAFC0", Length = "0x51")]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_scale", ReturnType = typeof(Scale))]
		[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveScale", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600148C")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000423")]
	public TextOverflow textOverflow
	{
		[Address(RVA = "0x1CABE20", Offset = "0x1CAB020", Length = "0x3E")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600148D")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000424")]
	public TextShadow textShadow
	{
		[Address(RVA = "0x1CABE60", Offset = "0x1CAB060", Length = "0x60")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600148E")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000425")]
	public Length top
	{
		[Address(RVA = "0x1CABEC0", Offset = "0x1CAB0C0", Length = "0x42")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600148F")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000426")]
	public TransformOrigin transformOrigin
	{
		[Address(RVA = "0x1CABF10", Offset = "0x1CAB110", Length = "0x57")]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001490")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000427")]
	public List<TimeValue> transitionDelay
	{
		[Address(RVA = "0x1CABF70", Offset = "0x1CAB170", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001491")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000428")]
	public List<TimeValue> transitionDuration
	{
		[Address(RVA = "0x1CABFB0", Offset = "0x1CAB1B0", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001492")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000429")]
	public List<StylePropertyName> transitionProperty
	{
		[Address(RVA = "0x1CABFF0", Offset = "0x1CAB1F0", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StylePropertyName>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001493")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700042A")]
	public List<EasingFunction> transitionTimingFunction
	{
		[Address(RVA = "0x1CAC030", Offset = "0x1CAB230", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001494")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700042B")]
	public Translate translate
	{
		[Address(RVA = "0x1CAC070", Offset = "0x1CAB270", Length = "0x5B")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTranslation", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001495")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700042C")]
	public Color unityBackgroundImageTintColor
	{
		[Address(RVA = "0x1CAC0D0", Offset = "0x1CAB2D0", Length = "0x51")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001496")]
		 get { } //Length: 81
	}

	[Token(Token = "0x1700042D")]
	public EditorTextRenderingMode unityEditorTextRenderingMode
	{
		[Address(RVA = "0x1CAC130", Offset = "0x1CAB330", Length = "0x3D")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001497")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700042E")]
	public Font unityFont
	{
		[Address(RVA = "0x1CAC200", Offset = "0x1CAB400", Length = "0x3E")]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFont", ReturnType = typeof(Font))]
		[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
		[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001498")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700042F")]
	public FontDefinition unityFontDefinition
	{
		[Address(RVA = "0x1CAC170", Offset = "0x1CAB370", Length = "0x50")]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
		[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x6001499")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000430")]
	public FontStyle unityFontStyleAndWeight
	{
		[Address(RVA = "0x1CAC1C0", Offset = "0x1CAB3C0", Length = "0x3D")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600149A")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000431")]
	public OverflowClipBox unityOverflowClipBox
	{
		[Address(RVA = "0x1CAC240", Offset = "0x1CAB440", Length = "0x3E")]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderData), Member = "GetLocalClippingRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600149B")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000432")]
	public Length unityParagraphSpacing
	{
		[Address(RVA = "0x1CAC280", Offset = "0x1CAB480", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityParagraphSpacing", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600149C")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000433")]
	public int unitySliceBottom
	{
		[Address(RVA = "0x1CAC2C0", Offset = "0x1CAB4C0", Length = "0x3E")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600149D")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000434")]
	public int unitySliceLeft
	{
		[Address(RVA = "0x1CAC300", Offset = "0x1CAB500", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600149E")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000435")]
	public int unitySliceRight
	{
		[Address(RVA = "0x1CAC340", Offset = "0x1CAB540", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceRight", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x600149F")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000436")]
	public float unitySliceScale
	{
		[Address(RVA = "0x1CAC380", Offset = "0x1CAB580", Length = "0x40")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceScale", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A0")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000437")]
	public int unitySliceTop
	{
		[Address(RVA = "0x1CAC3C0", Offset = "0x1CAB5C0", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceTop", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A1")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000438")]
	public SliceType unitySliceType
	{
		[Address(RVA = "0x1CAC400", Offset = "0x1CAB600", Length = "0x3E")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A2")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000439")]
	public TextAnchor unityTextAlign
	{
		[Address(RVA = "0x1CAC440", Offset = "0x1CAB640", Length = "0x3D")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A3")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700043A")]
	public TextAutoSize unityTextAutoSize
	{
		[Address(RVA = "0x1CAC480", Offset = "0x1CAB680", Length = "0x57")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A4")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700043B")]
	public TextGeneratorType unityTextGenerator
	{
		[Address(RVA = "0x1CAC4E0", Offset = "0x1CAB6E0", Length = "0x3D")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
		[CalledBy(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A5")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700043C")]
	public Color unityTextOutlineColor
	{
		[Address(RVA = "0x1CAC520", Offset = "0x1CAB720", Length = "0x50")]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A6")]
		 get { } //Length: 80
	}

	[Token(Token = "0x1700043D")]
	public float unityTextOutlineWidth
	{
		[Address(RVA = "0x1CAC570", Offset = "0x1CAB770", Length = "0x3F")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A7")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700043E")]
	public TextOverflowPosition unityTextOverflowPosition
	{
		[Address(RVA = "0x1CAC5B0", Offset = "0x1CAB7B0", Length = "0x3E")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A8")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700043F")]
	public Visibility visibility
	{
		[Address(RVA = "0x1CAC5F0", Offset = "0x1CAB7F0", Length = "0x40")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_visibility", ReturnType = typeof(Visibility))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014A9")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000440")]
	public WhiteSpace whiteSpace
	{
		[Address(RVA = "0x1CAC630", Offset = "0x1CAB830", Length = "0x40")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultilineContainerStyle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014AA")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000441")]
	public Length width
	{
		[Address(RVA = "0x1CAC670", Offset = "0x1CAB870", Length = "0x42")]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014AB")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000442")]
	public Length wordSpacing
	{
		[Address(RVA = "0x1CAC6C0", Offset = "0x1CAB8C0", Length = "0x41")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_wordSpacing", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Token(Token = "0x60014AC")]
		 get { } //Length: 65
	}

	[Address(RVA = "0x1C944F0", Offset = "0x1C936F0", Length = "0x111")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitialStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Acquire", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
	[Token(Token = "0x60014AF")]
	public ComputedStyle Acquire() { }

	[Address(RVA = "0x1C94610", Offset = "0x1C93810", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001450")]
	private void ApplyAllPropertyInitial() { }

	[Address(RVA = "0x1C94670", Offset = "0x1C93870", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.StyleSheets.StylePropertyValue>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600144F")]
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	[Address(RVA = "0x1C94780", Offset = "0x1C93980", Length = "0x810")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014B8")]
	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	[Address(RVA = "0x1C95FB0", Offset = "0x1C951B0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600144C")]
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C96070", Offset = "0x1C95270", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[Token(Token = "0x600144D")]
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C961B0", Offset = "0x1C953B0", Length = "0x1F98")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleKeyword), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(InitialStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[Calls(Type = typeof(InitialStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[Calls(Type = typeof(InitialStyle), Member = "get_textShadow", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(InitialStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(InitialStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextAutoSize", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityOverflowClipBox", ReturnType = typeof(OverflowClipBox))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(InitialStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(InitialStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(InitialStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transformOrigin", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(InitialStyle), Member = "get_opacity", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderRightColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60014D1")]
	public void ApplyInitialValue(StylePropertyId id) { }

	[Address(RVA = "0x1C96090", Offset = "0x1C95290", Length = "0x119")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014D0")]
	public void ApplyInitialValue(StylePropertyReader reader) { }

	[Address(RVA = "0x1C982B0", Offset = "0x1C974B0", Length = "0xA70")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadListEasingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadListStylePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadListTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Scale))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPositionY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPositionX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "MoveNextProperty", ReturnType = typeof(StylePropertyId))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014B2")]
	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C99D80", Offset = "0x1C98F80", Length = "0x364")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFloat", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFloat", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014BA")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	[Address(RVA = "0x1C9AC90", Offset = "0x1C99E90", Length = "0x6E4")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesInt", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesInt", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesEnum", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesEnum", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014BB")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	[Address(RVA = "0x1C9BAA0", Offset = "0x1C9ACA0", Length = "0x21B")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundPosition", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundPosition", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x60014BC")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	[Address(RVA = "0x1C9B8F0", Offset = "0x1C9AAF0", Length = "0x1AD")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackground", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackground", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(Background), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60014C0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	[Address(RVA = "0x1C9A110", Offset = "0x1C99310", Length = "0x141")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014BE")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	[Address(RVA = "0x1C9BFA0", Offset = "0x1C9B1A0", Length = "0xD4")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesColor", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesColor", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014BF")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	[Address(RVA = "0x1C9A260", Offset = "0x1C99460", Length = "0x654")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C9A9AB")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014B9")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	[Address(RVA = "0x1C9AAF0", Offset = "0x1C99CF0", Length = "0x199")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFont", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFont", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60014C1")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	[Address(RVA = "0x1C9B630", Offset = "0x1C9A830", Length = "0x167")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundRepeat", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundRepeat", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x60014BD")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	[Address(RVA = "0x1C99C30", Offset = "0x1C98E30", Length = "0x144")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014C6")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	[Address(RVA = "0x1C9BE50", Offset = "0x1C9B050", Length = "0x14A")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014C3")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	[Address(RVA = "0x1C9B7A0", Offset = "0x1C9A9A0", Length = "0x141")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014C5")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	[Address(RVA = "0x1C9BCC0", Offset = "0x1C9AEC0", Length = "0x18B")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFontDefinition", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFontDefinition", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(FontDefinition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition), typeof(FontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60014C2")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	[Address(RVA = "0x1C9B4F0", Offset = "0x1C9A6F0", Length = "0x13B")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014C7")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	[Address(RVA = "0x1C9B3A0", Offset = "0x1C9A5A0", Length = "0x145")]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014C4")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	[Address(RVA = "0x1C9C250", Offset = "0x1C9B450", Length = "0x54")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Token(Token = "0x60014CF")]
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	[Address(RVA = "0x1C9C2B0", Offset = "0x1C9B4B0", Length = "0x60")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60014B5")]
	public void ApplyStyleCursor(Cursor cursor) { }

	[Address(RVA = "0x1C9C310", Offset = "0x1C9B510", Length = "0x57")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Token(Token = "0x60014CD")]
	public void ApplyStyleRotate(Rotate rotateValue) { }

	[Address(RVA = "0x1C9C370", Offset = "0x1C9B570", Length = "0x4E")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Token(Token = "0x60014CE")]
	public void ApplyStyleScale(Scale scaleValue) { }

	[Address(RVA = "0x1C9C3C0", Offset = "0x1C9B5C0", Length = "0x54")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Token(Token = "0x60014B7")]
	public void ApplyStyleTextAutoSize(TextAutoSize st) { }

	[Address(RVA = "0x1C9C420", Offset = "0x1C9B620", Length = "0x5D")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Token(Token = "0x60014B6")]
	public void ApplyStyleTextShadow(TextShadow st) { }

	[Address(RVA = "0x1C9C480", Offset = "0x1C9B680", Length = "0x54")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Token(Token = "0x60014CB")]
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	[Address(RVA = "0x1C9C4E0", Offset = "0x1C9B6E0", Length = "0x58")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Token(Token = "0x60014CC")]
	public void ApplyStyleTranslate(Translate translateValue) { }

	[Address(RVA = "0x1C9CA90", Offset = "0x1C9BC90", Length = "0xD08")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(FontDefinition), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Background), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014B3")]
	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C9C540", Offset = "0x1C9B740", Length = "0x548")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Token(Token = "0x60014B4")]
	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C9D8D0", Offset = "0x1C9CAD0", Length = "0xB5")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014D2")]
	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C9D990", Offset = "0x1C9CB90", Length = "0x438")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014D3")]
	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C9DE10", Offset = "0x1C9D010", Length = "0x1BB8")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scale), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextShadow), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(Rotate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(FontDefinition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition), typeof(FontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Translate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Background), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAutoSize", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(TextAutoSize), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014D4")]
	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }

	[Address(RVA = "0x1C9F9D0", Offset = "0x1C9EBD0", Length = "0x118")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyAllPropertyInitial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60014B1")]
	public void CopyFrom(ref ComputedStyle other) { }

	[Address(RVA = "0x1C9FC80", Offset = "0x1C9EE80", Length = "0x1DD")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Acquire", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60014AD")]
	public static ComputedStyle Create(ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1C9FAF0", Offset = "0x1C9ECF0", Length = "0x186")]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Create", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60014AE")]
	public static ComputedStyle CreateInitial() { }

	[Address(RVA = "0x1C9FE60", Offset = "0x1C9F060", Length = "0x12E")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600144B")]
	public void FinalizeApply(ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x1CAAE30", Offset = "0x1CAA030", Length = "0x3D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignContent", ReturnType = typeof(Align))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001458")]
	public Align get_alignContent() { }

	[Address(RVA = "0x1CAAE70", Offset = "0x1CAA070", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignItems", ReturnType = typeof(Align))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001459")]
	public Align get_alignItems() { }

	[Address(RVA = "0x1CAAEB0", Offset = "0x1CAA0B0", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600145A")]
	public Align get_alignSelf() { }

	[Address(RVA = "0x1CAAEF0", Offset = "0x1CAA0F0", Length = "0x50")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600145B")]
	public Color get_backgroundColor() { }

	[Address(RVA = "0x1CAAF40", Offset = "0x1CAA140", Length = "0x59")]
	[CalledBy(Type = typeof(UIRUtility), Member = "IsVectorImageBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "RequiresStencilMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementStencilMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600145C")]
	public Background get_backgroundImage() { }

	[Address(RVA = "0x1CAAFA0", Offset = "0x1CAA1A0", Length = "0x59")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600145D")]
	public BackgroundPosition get_backgroundPositionX() { }

	[Address(RVA = "0x1CAB000", Offset = "0x1CAA200", Length = "0x59")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600145E")]
	public BackgroundPosition get_backgroundPositionY() { }

	[Address(RVA = "0x1CAB060", Offset = "0x1CAA260", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600145F")]
	public BackgroundRepeat get_backgroundRepeat() { }

	[Address(RVA = "0x1CAB0A0", Offset = "0x1CAA2A0", Length = "0x57")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001460")]
	public BackgroundSize get_backgroundSize() { }

	[Address(RVA = "0x1CAB100", Offset = "0x1CAA300", Length = "0x51")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001461")]
	public Color get_borderBottomColor() { }

	[Address(RVA = "0x1CAB160", Offset = "0x1CAA360", Length = "0x3F")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomLeftRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001462")]
	public Length get_borderBottomLeftRadius() { }

	[Address(RVA = "0x1CAB1A0", Offset = "0x1CAA3A0", Length = "0x3F")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomRightRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001463")]
	public Length get_borderBottomRightRadius() { }

	[Address(RVA = "0x1CAB1E0", Offset = "0x1CAA3E0", Length = "0x40")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001464")]
	public float get_borderBottomWidth() { }

	[Address(RVA = "0x1CAB220", Offset = "0x1CAA420", Length = "0x54")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001465")]
	public Color get_borderLeftColor() { }

	[Address(RVA = "0x1CAB280", Offset = "0x1CAA480", Length = "0x40")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001466")]
	public float get_borderLeftWidth() { }

	[Address(RVA = "0x1CAB2C0", Offset = "0x1CAA4C0", Length = "0x54")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001467")]
	public Color get_borderRightColor() { }

	[Address(RVA = "0x1CAB320", Offset = "0x1CAA520", Length = "0x40")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001468")]
	public float get_borderRightWidth() { }

	[Address(RVA = "0x1CAB360", Offset = "0x1CAA560", Length = "0x54")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001469")]
	public Color get_borderTopColor() { }

	[Address(RVA = "0x1CAB3C0", Offset = "0x1CAA5C0", Length = "0x42")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopLeftRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600146A")]
	public Length get_borderTopLeftRadius() { }

	[Address(RVA = "0x1CAB410", Offset = "0x1CAA610", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopRightRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600146B")]
	public Length get_borderTopRightRadius() { }

	[Address(RVA = "0x1CAB460", Offset = "0x1CAA660", Length = "0x40")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600146C")]
	public float get_borderTopWidth() { }

	[Address(RVA = "0x1CAB4A0", Offset = "0x1CAA6A0", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600146D")]
	public Length get_bottom() { }

	[Address(RVA = "0x1CAB4E0", Offset = "0x1CAA6E0", Length = "0x4F")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_color", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600146E")]
	public Color get_color() { }

	[Address(RVA = "0x1CAB530", Offset = "0x1CAA730", Length = "0x5A")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "ATagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600146F")]
	public Cursor get_cursor() { }

	[Address(RVA = "0x1CAB590", Offset = "0x1CAA790", Length = "0x47")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Token(Token = "0x6001449")]
	public int get_customPropertiesCount() { }

	[Address(RVA = "0x1CAB5E0", Offset = "0x1CAA7E0", Length = "0x3E")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001470")]
	public DisplayStyle get_display() { }

	[Address(RVA = "0x1CAB620", Offset = "0x1CAA820", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001471")]
	public Length get_flexBasis() { }

	[Address(RVA = "0x1CAB660", Offset = "0x1CAA860", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001472")]
	public FlexDirection get_flexDirection() { }

	[Address(RVA = "0x1CAB6A0", Offset = "0x1CAA8A0", Length = "0x40")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexGrow", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001473")]
	public float get_flexGrow() { }

	[Address(RVA = "0x1CAB6E0", Offset = "0x1CAA8E0", Length = "0x40")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexShrink", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001474")]
	public float get_flexShrink() { }

	[Address(RVA = "0x1CAB720", Offset = "0x1CAA920", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001475")]
	public Wrap get_flexWrap() { }

	[Address(RVA = "0x1CAB760", Offset = "0x1CAA960", Length = "0x3E")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_fontSize", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001476")]
	public Length get_fontSize() { }

	[Address(RVA = "0x1CAB7A0", Offset = "0x1CAA9A0", Length = "0x12")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600144A")]
	public bool get_hasTransition() { }

	[Address(RVA = "0x1CAB7C0", Offset = "0x1CAA9C0", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001477")]
	public Length get_height() { }

	[Address(RVA = "0x1CAB800", Offset = "0x1CAAA00", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001478")]
	public Justify get_justifyContent() { }

	[Address(RVA = "0x1CAB840", Offset = "0x1CAAA40", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001479")]
	public Length get_left() { }

	[Address(RVA = "0x1CAB880", Offset = "0x1CAAA80", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_letterSpacing", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600147A")]
	public Length get_letterSpacing() { }

	[Address(RVA = "0x1CAB8C0", Offset = "0x1CAAAC0", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600147B")]
	public Length get_marginBottom() { }

	[Address(RVA = "0x1CAB900", Offset = "0x1CAAB00", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600147C")]
	public Length get_marginLeft() { }

	[Address(RVA = "0x1CAB940", Offset = "0x1CAAB40", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600147D")]
	public Length get_marginRight() { }

	[Address(RVA = "0x1CAB980", Offset = "0x1CAAB80", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600147E")]
	public Length get_marginTop() { }

	[Address(RVA = "0x1CAB9C0", Offset = "0x1CAABC0", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600147F")]
	public Length get_maxHeight() { }

	[Address(RVA = "0x1CABA00", Offset = "0x1CAAC00", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001480")]
	public Length get_maxWidth() { }

	[Address(RVA = "0x1CABA40", Offset = "0x1CAAC40", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001481")]
	public Length get_minHeight() { }

	[Address(RVA = "0x1CABA90", Offset = "0x1CAAC90", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001482")]
	public Length get_minWidth() { }

	[Address(RVA = "0x1CABAE0", Offset = "0x1CAACE0", Length = "0x43")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_opacity", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001483")]
	public float get_opacity() { }

	[Address(RVA = "0x1CABB30", Offset = "0x1CAAD30", Length = "0x41")]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001484")]
	public OverflowInternal get_overflow() { }

	[Address(RVA = "0x1CABB80", Offset = "0x1CAAD80", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001485")]
	public Length get_paddingBottom() { }

	[Address(RVA = "0x1CABBD0", Offset = "0x1CAADD0", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001486")]
	public Length get_paddingLeft() { }

	[Address(RVA = "0x1CABC20", Offset = "0x1CAAE20", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001487")]
	public Length get_paddingRight() { }

	[Address(RVA = "0x1CABC70", Offset = "0x1CAAE70", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001488")]
	public Length get_paddingTop() { }

	[Address(RVA = "0x1CABCC0", Offset = "0x1CAAEC0", Length = "0x41")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_position", ReturnType = typeof(Position))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001489")]
	public Position get_position() { }

	[Address(RVA = "0x1CABD10", Offset = "0x1CAAF10", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600148A")]
	public Length get_right() { }

	[Address(RVA = "0x1CABD60", Offset = "0x1CAAF60", Length = "0x5A")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DRotation", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveRotation", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600148B")]
	public Rotate get_rotate() { }

	[Address(RVA = "0x1CABDC0", Offset = "0x1CAAFC0", Length = "0x51")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_scale", ReturnType = typeof(Scale))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveScale", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600148C")]
	public Scale get_scale() { }

	[Address(RVA = "0x1CABE20", Offset = "0x1CAB020", Length = "0x3E")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600148D")]
	public TextOverflow get_textOverflow() { }

	[Address(RVA = "0x1CABE60", Offset = "0x1CAB060", Length = "0x60")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600148E")]
	public TextShadow get_textShadow() { }

	[Address(RVA = "0x1CABEC0", Offset = "0x1CAB0C0", Length = "0x42")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600148F")]
	public Length get_top() { }

	[Address(RVA = "0x1CABF10", Offset = "0x1CAB110", Length = "0x57")]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001490")]
	public TransformOrigin get_transformOrigin() { }

	[Address(RVA = "0x1CABF70", Offset = "0x1CAB170", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001491")]
	public List<TimeValue> get_transitionDelay() { }

	[Address(RVA = "0x1CABFB0", Offset = "0x1CAB1B0", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001492")]
	public List<TimeValue> get_transitionDuration() { }

	[Address(RVA = "0x1CABFF0", Offset = "0x1CAB1F0", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StylePropertyName>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001493")]
	public List<StylePropertyName> get_transitionProperty() { }

	[Address(RVA = "0x1CAC030", Offset = "0x1CAB230", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001494")]
	public List<EasingFunction> get_transitionTimingFunction() { }

	[Address(RVA = "0x1CAC070", Offset = "0x1CAB270", Length = "0x5B")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTranslation", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001495")]
	public Translate get_translate() { }

	[Address(RVA = "0x1CAC0D0", Offset = "0x1CAB2D0", Length = "0x51")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001496")]
	public Color get_unityBackgroundImageTintColor() { }

	[Address(RVA = "0x1CAC130", Offset = "0x1CAB330", Length = "0x3D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001497")]
	public EditorTextRenderingMode get_unityEditorTextRenderingMode() { }

	[Address(RVA = "0x1CAC200", Offset = "0x1CAB400", Length = "0x3E")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFont", ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001498")]
	public Font get_unityFont() { }

	[Address(RVA = "0x1CAC170", Offset = "0x1CAB370", Length = "0x50")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x6001499")]
	public FontDefinition get_unityFontDefinition() { }

	[Address(RVA = "0x1CAC1C0", Offset = "0x1CAB3C0", Length = "0x3D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600149A")]
	public FontStyle get_unityFontStyleAndWeight() { }

	[Address(RVA = "0x1CAC240", Offset = "0x1CAB440", Length = "0x3E")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderData), Member = "GetLocalClippingRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600149B")]
	public OverflowClipBox get_unityOverflowClipBox() { }

	[Address(RVA = "0x1CAC280", Offset = "0x1CAB480", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityParagraphSpacing", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600149C")]
	public Length get_unityParagraphSpacing() { }

	[Address(RVA = "0x1CAC2C0", Offset = "0x1CAB4C0", Length = "0x3E")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600149D")]
	public int get_unitySliceBottom() { }

	[Address(RVA = "0x1CAC300", Offset = "0x1CAB500", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600149E")]
	public int get_unitySliceLeft() { }

	[Address(RVA = "0x1CAC340", Offset = "0x1CAB540", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x600149F")]
	public int get_unitySliceRight() { }

	[Address(RVA = "0x1CAC380", Offset = "0x1CAB580", Length = "0x40")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceScale", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A0")]
	public float get_unitySliceScale() { }

	[Address(RVA = "0x1CAC3C0", Offset = "0x1CAB5C0", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A1")]
	public int get_unitySliceTop() { }

	[Address(RVA = "0x1CAC400", Offset = "0x1CAB600", Length = "0x3E")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A2")]
	public SliceType get_unitySliceType() { }

	[Address(RVA = "0x1CAC440", Offset = "0x1CAB640", Length = "0x3D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A3")]
	public TextAnchor get_unityTextAlign() { }

	[Address(RVA = "0x1CAC480", Offset = "0x1CAB680", Length = "0x57")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A4")]
	public TextAutoSize get_unityTextAutoSize() { }

	[Address(RVA = "0x1CAC4E0", Offset = "0x1CAB6E0", Length = "0x3D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A5")]
	public TextGeneratorType get_unityTextGenerator() { }

	[Address(RVA = "0x1CAC520", Offset = "0x1CAB720", Length = "0x50")]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A6")]
	public Color get_unityTextOutlineColor() { }

	[Address(RVA = "0x1CAC570", Offset = "0x1CAB770", Length = "0x3F")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A7")]
	public float get_unityTextOutlineWidth() { }

	[Address(RVA = "0x1CAC5B0", Offset = "0x1CAB7B0", Length = "0x3E")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A8")]
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	[Address(RVA = "0x1CAC5F0", Offset = "0x1CAB7F0", Length = "0x40")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014A9")]
	public Visibility get_visibility() { }

	[Address(RVA = "0x1CAC630", Offset = "0x1CAB830", Length = "0x40")]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultilineContainerStyle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014AA")]
	public WhiteSpace get_whiteSpace() { }

	[Address(RVA = "0x1CAC670", Offset = "0x1CAB870", Length = "0x42")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014AB")]
	public Length get_width() { }

	[Address(RVA = "0x1CAC6C0", Offset = "0x1CAB8C0", Length = "0x41")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_wordSpacing", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Token(Token = "0x60014AC")]
	public Length get_wordSpacing() { }

	[Address(RVA = "0x1C9FF90", Offset = "0x1C9F190", Length = "0xC5")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Release", ReturnType = typeof(void))]
	[Token(Token = "0x60014B0")]
	public void Release() { }

	[Address(RVA = "0x1CA0060", Offset = "0x1C9F260", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600144E")]
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	[Address(RVA = "0x1CA0100", Offset = "0x1C9F300", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001451")]
	private void ResetComputedTransitions() { }

	[Address(RVA = "0x1CA7060", Offset = "0x1CA6260", Length = "0xCC")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014C8")]
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA0120", Offset = "0x1C9F320", Length = "0x30A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rotate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5E90")]
	[Calls(Type = typeof(Scale), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5B90")]
	[Calls(Type = typeof(Translate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5CA0")]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5A90")]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E59D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_hasRunningAnimations", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5DB0")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontDefinition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition), typeof(FontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5840")]
	[Calls(Type = typeof(TextShadow), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 103)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014C9")]
	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA3DA0", Offset = "0x1CA2FA0", Length = "0x318C")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(InitialStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5840")]
	[Calls(Type = typeof(InitialStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(InitialStyle), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(FontDefinition), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(InitialStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(InitialStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5900")]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityOverflowClipBox", ReturnType = typeof(OverflowClipBox))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(InitialStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(InitialStyle), Member = "get_opacity", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderRightColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E59D0")]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5A90")]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5CA0")]
	[Calls(Type = typeof(Background), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[CallsDeduplicatedMethods(Count = 70)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014CA")]
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA31D0", Offset = "0x1CA23D0", Length = "0x1DA")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001457")]
	public static bool StartAnimationInlineBackgroundSize(VisualElement element, ref ComputedStyle computedStyle, StyleBackgroundSize backgroundSize, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA33B0", Offset = "0x1CA25B0", Length = "0x22B")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001453")]
	public static bool StartAnimationInlineRotate(VisualElement element, ref ComputedStyle computedStyle, StyleRotate rotate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA35E0", Offset = "0x1CA27E0", Length = "0x1EF")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001455")]
	public static bool StartAnimationInlineScale(VisualElement element, ref ComputedStyle computedStyle, StyleScale scale, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA37D0", Offset = "0x1CA29D0", Length = "0x18B")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_textShadow", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E5FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001452")]
	public static bool StartAnimationInlineTextShadow(VisualElement element, ref ComputedStyle computedStyle, StyleTextShadow textShadow, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA3960", Offset = "0x1CA2B60", Length = "0x20F")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_transformOrigin", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001456")]
	public static bool StartAnimationInlineTransformOrigin(VisualElement element, ref ComputedStyle computedStyle, StyleTransformOrigin transformOrigin, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1CA3B70", Offset = "0x1CA2D70", Length = "0x22B")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InitialStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001454")]
	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

}

