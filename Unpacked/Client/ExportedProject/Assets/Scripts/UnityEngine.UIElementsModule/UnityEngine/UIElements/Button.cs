namespace UnityEngine.UIElements;

[Token(Token = "0x2000099")]
public class Button : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200009A")]
	internal class UxmlFactory : UxmlFactory<Button, UxmlTraits>
	{

		[Address(RVA = "0x1BE5640", Offset = "0x1BE4840", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005A2")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200009B")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000367")]
		private readonly UxmlImageAttributeDescription m_IconImage; //Field offset: 0xD0

		[Address(RVA = "0x1BE9E80", Offset = "0x1BE9080", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlImageAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005A3")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE6080", Offset = "0x1BE5280", Length = "0x164")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlImageAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(Background))]
		[Calls(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005A4")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400035C")]
	internal static readonly BindingId iconImageProperty; //Field offset: 0x0
	[Token(Token = "0x400035D")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x400035E")]
	public static readonly string iconUssClassName; //Field offset: 0xA0
	[Token(Token = "0x400035F")]
	public static readonly string iconOnlyUssClassName; //Field offset: 0xA8
	[Token(Token = "0x4000360")]
	public static readonly string imageUSSClassName; //Field offset: 0xB0
	[Token(Token = "0x4000366")]
	private static readonly string NonEmptyString; //Field offset: 0xB8
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x4000361")]
	private Clickable m_Clickable; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x4000362")]
	private TextElement m_TextElement; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x4000363")]
	private Image m_ImageElement; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x4000364")]
	private Background m_IconImage; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x4000365")]
	private string m_Text; //Field offset: 0x410

	[Token(Token = "0x170000DE")]
	public Clickable clickable
	{
		[Address(RVA = "0x1BD97A0", Offset = "0x1BD89A0", Length = "0xA")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000594")]
		 get { } //Length: 10
		[Address(RVA = "0x1BD97F0", Offset = "0x1BD89F0", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000595")]
		 set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x170000DF")]
	public Background iconImage
	{
		[Address(RVA = "0x1BD97B0", Offset = "0x1BD89B0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000596")]
		 get { } //Length: 25
		[Address(RVA = "0x1BD9870", Offset = "0x1BD8A70", Length = "0x3C6")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Image), Member = "set_image", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Background), Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "set_vectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000597")]
		 set { } //Length: 966
	}

	[Token(Token = "0x170000E0")]
	public virtual string text
	{
		[Address(RVA = "0x1BD97D0", Offset = "0x1BD89D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000598")]
		 get { } //Length: 30
		[Address(RVA = "0x1BD9C40", Offset = "0x1BD8E40", Length = "0x182")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Background), Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(TextElement), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000599")]
		 set { } //Length: 386
	}

	[Address(RVA = "0x1BD8EE0", Offset = "0x1BD80E0", Length = "0x2D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005A1")]
	private static Button() { }

	[Address(RVA = "0x1BD93A0", Offset = "0x1BD85A0", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Clickable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600059A")]
	public Button() { }

	[Address(RVA = "0x1BD9590", Offset = "0x1BD8790", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Clickable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600059B")]
	public Button(Background iconImage, Action clickEvent = null) { }

	[Address(RVA = "0x1BD91C0", Offset = "0x1BD83C0", Length = "0x1D3")]
	[CalledBy(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Clickable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600059C")]
	public Button(Action clickEvent) { }

	[Address(RVA = "0x1BD8A30", Offset = "0x1BD7C30", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = "MeasureTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600059E")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x1BD97A0", Offset = "0x1BD89A0", Length = "0xA")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000594")]
	public Clickable get_clickable() { }

	[Address(RVA = "0x1BD97B0", Offset = "0x1BD89B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000596")]
	public Background get_iconImage() { }

	[Address(RVA = "0x1BD97D0", Offset = "0x1BD89D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000598")]
	public virtual string get_text() { }

	[Address(RVA = "0x1BD8B10", Offset = "0x1BD7D10", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "SimulateSingleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600059D")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x1BD8B50", Offset = "0x1BD7D50", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005A0")]
	private void ResetButtonHierarchy() { }

	[Address(RVA = "0x1BD97F0", Offset = "0x1BD89F0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000595")]
	public void set_clickable(Clickable value) { }

	[Address(RVA = "0x1BD9870", Offset = "0x1BD8A70", Length = "0x3C6")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Image), Member = "set_vectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Background), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "set_image", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000597")]
	public void set_iconImage(Background value) { }

	[Address(RVA = "0x1BD9C40", Offset = "0x1BD8E40", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Background), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextElement), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000599")]
	public virtual void set_text(string value) { }

	[Address(RVA = "0x1BD8C80", Offset = "0x1BD7E80", Length = "0x253")]
	[CalledBy(Type = typeof(Button), Member = "set_iconImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600059F")]
	private void UpdateButtonHierarchy() { }

}

