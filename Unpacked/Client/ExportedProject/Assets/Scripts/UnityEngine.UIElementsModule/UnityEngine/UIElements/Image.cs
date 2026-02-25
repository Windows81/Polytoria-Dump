namespace UnityEngine.UIElements;

[Token(Token = "0x20000DD")]
public class Image : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000DE")]
	internal class UxmlFactory : UxmlFactory<Image, UxmlTraits>
	{

		[Address(RVA = "0x1C157F0", Offset = "0x1C149F0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60006D4")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000DF")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x1C16CD0", Offset = "0x1C15ED0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60006D5")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x400042F")]
	internal static readonly BindingId imageProperty; //Field offset: 0x0
	[Token(Token = "0x4000430")]
	internal static readonly BindingId spriteProperty; //Field offset: 0x98
	[Token(Token = "0x4000431")]
	internal static readonly BindingId vectorImageProperty; //Field offset: 0x130
	[Token(Token = "0x4000432")]
	internal static readonly BindingId sourceRectProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000433")]
	internal static readonly BindingId uvProperty; //Field offset: 0x260
	[Token(Token = "0x4000434")]
	internal static readonly BindingId scaleModeProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000435")]
	internal static readonly BindingId tintColorProperty; //Field offset: 0x390
	[Token(Token = "0x400043F")]
	public static readonly string ussClassName; //Field offset: 0x428
	[Token(Token = "0x4000440")]
	private static CustomStyleProperty<Texture2D> s_ImageProperty; //Field offset: 0x430
	[Token(Token = "0x4000441")]
	private static CustomStyleProperty<Sprite> s_SpriteProperty; //Field offset: 0x438
	[Token(Token = "0x4000442")]
	private static CustomStyleProperty<VectorImage> s_VectorImageProperty; //Field offset: 0x440
	[Token(Token = "0x4000443")]
	private static CustomStyleProperty<String> s_ScaleModeProperty; //Field offset: 0x448
	[Token(Token = "0x4000444")]
	private static CustomStyleProperty<Color> s_TintColorProperty; //Field offset: 0x450
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000436")]
	private ScaleMode m_ScaleMode; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000437")]
	private Texture m_Image; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000438")]
	private Sprite m_Sprite; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000439")]
	private VectorImage m_VectorImage; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400043A")]
	private Rect m_UV; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x400043B")]
	private Color m_TintColor; //Field offset: 0x300
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x400043C")]
	internal bool m_ImageIsInline; //Field offset: 0x310
	[FieldOffset(Offset = "0x311")]
	[Token(Token = "0x400043D")]
	private bool m_ScaleModeIsInline; //Field offset: 0x311
	[FieldOffset(Offset = "0x312")]
	[Token(Token = "0x400043E")]
	private bool m_TintColorIsInline; //Field offset: 0x312

	[CreateProperty]
	[Token(Token = "0x170000F7")]
	public Texture image
	{
		[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 8
		[Address(RVA = "0x1C08010", Offset = "0x1C07210", Length = "0x198")]
		[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 408
	}

	[CreateProperty]
	[Token(Token = "0x170000FC")]
	public ScaleMode scaleMode
	{
		[Address(RVA = "0x1C07FD0", Offset = "0x1C071D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 7
		[Address(RVA = "0x1C081B0", Offset = "0x1C073B0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "SetScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(void))]
		[Token(Token = "0x60006C3")]
		 set { } //Length: 33
	}

	[CreateProperty]
	[Token(Token = "0x170000FA")]
	public Rect sourceRect
	{
		[Address(RVA = "0x1C07FE0", Offset = "0x1C071E0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "GetSourceRect", ReturnType = typeof(Rect))]
		[Token(Token = "0x60006BE")]
		 get { } //Length: 37
		[Address(RVA = "0x1C081E0", Offset = "0x1C073E0", Length = "0x178")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "GetSourceRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "CalculateUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006BF")]
		 set { } //Length: 376
	}

	[CreateProperty]
	[Token(Token = "0x170000F8")]
	public Sprite sprite
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BA")]
		 get { } //Length: 8
		[Address(RVA = "0x1C08360", Offset = "0x1C07560", Length = "0x1B1")]
		[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
		[Token(Token = "0x60006BB")]
		 set { } //Length: 433
	}

	[CreateProperty]
	[Token(Token = "0x170000FD")]
	public Color tintColor
	{
		[Address(RVA = "0x1551C60", Offset = "0x1550E60", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C4")]
		 get { } //Length: 14
		[Address(RVA = "0x1C08520", Offset = "0x1C07720", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "SetTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Token(Token = "0x60006C5")]
		 set { } //Length: 152
	}

	[CreateProperty]
	[Token(Token = "0x170000FB")]
	public Rect uv
	{
		[Address(RVA = "0x1551C40", Offset = "0x1550E40", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C0")]
		 get { } //Length: 14
		[Address(RVA = "0x1C085C0", Offset = "0x1C077C0", Length = "0xC3")]
		[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006C1")]
		 set { } //Length: 195
	}

	[CreateProperty]
	[Token(Token = "0x170000F9")]
	public VectorImage vectorImage
	{
		[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 8
		[Address(RVA = "0x1C08690", Offset = "0x1C07890", Length = "0x1B1")]
		[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
		[Token(Token = "0x60006BD")]
		 set { } //Length: 433
	}

	[Address(RVA = "0x1C075E0", Offset = "0x1C067E0", Length = "0x81D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomStyleProperty`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D3")]
	private static Image() { }

	[Address(RVA = "0x1C07E00", Offset = "0x1C07000", Length = "0x1C3")]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumnIcon), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "CreateDefaultHeaderContent", ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006C6")]
	public Image() { }

	[Address(RVA = "0x1C05840", Offset = "0x1C04A40", Length = "0x1D4")]
	[CalledBy(Type = typeof(Image), Member = "set_sourceRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D1")]
	private void CalculateUV(Rect srcRect) { }

	[Address(RVA = "0x1C05A20", Offset = "0x1C04C20", Length = "0x456")]
	[CalledBy(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
	[Token(Token = "0x60006CE")]
	private void ClearProperty() { }

	[Address(RVA = "0x1C05E80", Offset = "0x1C05080", Length = "0x3BD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsUtility), Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Sprite)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Image), Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Image), Member = "GetSourceRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006C9")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B8")]
	public Texture get_image() { }

	[Address(RVA = "0x1C07FD0", Offset = "0x1C071D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006C2")]
	public ScaleMode get_scaleMode() { }

	[Address(RVA = "0x1C07FE0", Offset = "0x1C071E0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "GetSourceRect", ReturnType = typeof(Rect))]
	[Token(Token = "0x60006BE")]
	public Rect get_sourceRect() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BA")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x1551C60", Offset = "0x1550E60", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C4")]
	public Color get_tintColor() { }

	[Address(RVA = "0x1551C40", Offset = "0x1550E40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C0")]
	public Rect get_uv() { }

	[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BC")]
	public VectorImage get_vectorImage() { }

	[Address(RVA = "0x1C06240", Offset = "0x1C05440", Length = "0x1FD")]
	[CalledBy(Type = typeof(Image), Member = "get_sourceRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(Image), Member = "set_sourceRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D2")]
	private Rect GetSourceRect() { }

	[Address(RVA = "0x1C06440", Offset = "0x1C05640", Length = "0xE4")]
	[CalledBy(Type = typeof(Image), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Image), Member = "CalculateUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GetSourceRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006C7")]
	private Vector2 GetTextureDisplaySize(Texture texture) { }

	[Address(RVA = "0x1C06530", Offset = "0x1C05730", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsUtility), Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Sprite)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006C8")]
	private Vector2 GetTextureDisplaySize(Sprite sprite) { }

	[Address(RVA = "0x1C06680", Offset = "0x1C05880", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[Calls(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CB")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[Address(RVA = "0x1C066C0", Offset = "0x1C058C0", Length = "0x5D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GUIUtility), Member = "AlignRectToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectangleParams), Member = "MakeVectorTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(VectorImage), typeof(ScaleMode), typeof(Color)}, ReturnType = typeof(RectangleParams))]
	[Calls(Type = typeof(RectangleParams), Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), typeof(ScaleMode), typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = typeof(RectangleParams))]
	[Calls(Type = typeof(RectangleParams), Member = "MakeTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Texture), typeof(ScaleMode), typeof(Color)}, ReturnType = typeof(RectangleParams))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006CA")]
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1C06CA0", Offset = "0x1C05EA0", Length = "0x7A5")]
	[CalledBy(Type = typeof(Image), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(IProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Image), Member = "ClearProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E1F60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
	[Calls(Type = typeof(StylePropertyUtil), Member = "TryGetEnumIntValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "SetScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "SetTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60006CC")]
	private void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	[Address(RVA = "0x1C08010", Offset = "0x1C07210", Length = "0x198")]
	[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
	[Token(Token = "0x60006B9")]
	public void set_image(Texture value) { }

	[Address(RVA = "0x1C081B0", Offset = "0x1C073B0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "SetScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C3")]
	public void set_scaleMode(ScaleMode value) { }

	[Address(RVA = "0x1C081E0", Offset = "0x1C073E0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "GetSourceRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "CalculateUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006BF")]
	public void set_sourceRect(Rect value) { }

	[Address(RVA = "0x1C08360", Offset = "0x1C07560", Length = "0x1B1")]
	[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
	[Token(Token = "0x60006BB")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x1C08520", Offset = "0x1C07720", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "SetTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C5")]
	public void set_tintColor(Color value) { }

	[Address(RVA = "0x1C085C0", Offset = "0x1C077C0", Length = "0xC3")]
	[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006C1")]
	public void set_uv(Rect value) { }

	[Address(RVA = "0x1C08690", Offset = "0x1C07890", Length = "0x1B1")]
	[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DefaultBindHeaderContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9C80")]
	[Token(Token = "0x60006BD")]
	public void set_vectorImage(VectorImage value) { }

	[Address(RVA = "0x6E4C30", Offset = "0x6E3E30", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[Calls(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CD")]
	private void SetProperty(T0 src, ref T0 dst, ref T1 alt0, ref T2 alt1, BindingId binding) { }

	[Address(RVA = "0x1C07450", Offset = "0x1C06650", Length = "0x8C")]
	[CalledBy(Type = typeof(Image), Member = "set_scaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006CF")]
	private void SetScaleMode(ScaleMode mode) { }

	[Address(RVA = "0x1C074E0", Offset = "0x1C066E0", Length = "0xFA")]
	[CalledBy(Type = typeof(Image), Member = "set_tintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D0")]
	private void SetTintColor(Color color) { }

}

