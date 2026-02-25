namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000079")]
public abstract class BasePopupField : BaseField<TValueType>
{
	[CompilerGenerated]
	[Token(Token = "0x200007B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000292")]
		public static readonly <>c<TValueType, TValueChoice> <>9; //Field offset: 0x0
		[Token(Token = "0x4000293")]
		public static EventCallback<MouseDownEvent> <>9__28_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000477")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000478")]
		public <>c() { }

		[Address(RVA = "0x7FBE20", Offset = "0x7FB020", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000479")]
		internal void <.ctor>b__28_0(MouseDownEvent e) { }

	}

	[Token(Token = "0x200007A")]
	private class PopupTextElement : TextElement
	{

		[Address(RVA = "0xE88A00", Offset = "0xE87C00", Length = "0x49")]
		[CalledBy(Type = typeof(BasePopupField`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000476")]
		public PopupTextElement() { }

		[Address(RVA = "0xE888F0", Offset = "0xE87AF0", Length = "0xBD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextElement), Member = "MeasureTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000475")]
		protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	}

	[Token(Token = "0x4000282")]
	internal static readonly BindingId choicesProperty; //Field offset: 0x0
	[Token(Token = "0x4000283")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x400028D")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400028E")]
	public static readonly string textUssClassName; //Field offset: 0x0
	[Token(Token = "0x400028F")]
	public static readonly string arrowUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000290")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000291")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000284")]
	internal List<TValueChoice> m_Choices; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000285")]
	private TextElement m_TextElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000286")]
	private VisualElement m_ArrowElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000287")]
	private IVisualElementScheduledItem m_ScheduledShowMenuItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000288")]
	internal Func<TValueChoice, String> m_FormatSelectedValueCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000289")]
	internal Func<TValueChoice, String> m_FormatListItemCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028A")]
	internal Func<IGenericMenu> createMenuCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028B")]
	internal IGenericMenu m_GenericMenu; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028C")]
	internal bool m_AutoCloseMenu; //Field offset: 0x0

	[CreateProperty]
	[Token(Token = "0x170000A3")]
	public override List<TValueChoice> choices
	{
		[Address(RVA = "0x94A3D0", Offset = "0x9495D0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000467")]
		 get { } //Length: 10
		[Address(RVA = "0x94A4A0", Offset = "0x9496A0", Length = "0x106")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000468")]
		 set { } //Length: 262
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000A4")]
	public string text
	{
		[Address(RVA = "0x94A420", Offset = "0x949620", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046A")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000A2")]
	protected TextElement textElement
	{
		[Address(RVA = "0x94A3E0", Offset = "0x9495E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000463")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x948D40", Offset = "0x947F40", Length = "0x789")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000474")]
	private static BasePopupField`2() { }

	[Address(RVA = "0x949D00", Offset = "0x948F00", Length = "0x6C5")]
	[CalledBy(Type = typeof(PopupField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PopupTextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046B")]
	internal BasePopupField`2(string label) { }

	[Token(Token = "0x6000466")]
	internal abstract void AddMenuItems(IGenericMenu menu) { }

	[Address(RVA = "0x947870", Offset = "0x946A70", Length = "0x83")]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600046F")]
	private bool ContainsPointer(int pointerId) { }

	[Address(RVA = "0x94A3D0", Offset = "0x9495D0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000467")]
	public override List<TValueChoice> get_choices() { }

	[Address(RVA = "0x94A420", Offset = "0x949620", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046A")]
	public string get_text() { }

	[Address(RVA = "0x94A3E0", Offset = "0x9495E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000463")]
	protected TextElement get_textElement() { }

	[Token(Token = "0x6000465")]
	internal abstract string GetListItemToDisplay(TValueType item) { }

	[Token(Token = "0x6000464")]
	internal abstract string GetValueToDisplay() { }

	[Address(RVA = "0x947940", Offset = "0x946B40", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasePopupField`2), Member = "ShowMenu", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000471")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x947980", Offset = "0x946B80", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasePopupField`2), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600046C")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x9479C0", Offset = "0x946BC0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BasePopupField`2), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600046E")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x947B80", Offset = "0x946D80", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600046D")]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x604920", Offset = "0x603B20", Length = "0x12E")]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(BasePopupField`2), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000470")]
	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	[Address(RVA = "0x94A4A0", Offset = "0x9496A0", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000468")]
	public override void set_choices(List<TValueChoice> value) { }

	[Address(RVA = "0x947DB0", Offset = "0x946FB0", Length = "0xA0")]
	[CalledBy(Type = typeof(PopupField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000469")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x9480E0", Offset = "0x9472E0", Length = "0x18F")]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000472")]
	internal void ShowMenu() { }

	[Address(RVA = "0x948270", Offset = "0x947470", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000473")]
	protected virtual void UpdateMixedValueContent() { }

}

