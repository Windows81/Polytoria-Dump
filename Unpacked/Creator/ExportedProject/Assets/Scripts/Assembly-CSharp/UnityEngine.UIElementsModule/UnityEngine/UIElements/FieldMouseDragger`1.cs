namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000244")]
public class FieldMouseDragger : BaseFieldMouseDragger
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CC")]
	private readonly IValueField<T> m_DrivenField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CD")]
	private VisualElement m_DragElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CE")]
	private Rect m_DragHotZone; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CF")]
	private bool <dragging>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D0")]
	private T <startValue>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170002CF")]
	public bool dragging
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8D")]
		 get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002D0")]
	public T startValue
	{
		[Address(RVA = "0xC3AF10", Offset = "0xC3A110", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F8F")]
		 get { } //Length: 6
		[Address(RVA = "0xC3AF90", Offset = "0xC3A190", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F90")]
		 set { } //Length: 6
	}

	[Address(RVA = "0xC3ADD0", Offset = "0xC39FD0", Length = "0x55")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDraggerType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8C")]
	public FieldMouseDragger`1(IValueField<T> drivenField) { }

	[Address(RVA = "0xC34490", Offset = "0xC33690", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F92")]
	private bool CanStartDrag(int button, Vector2 localPosition) { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8D")]
	public bool get_dragging() { }

	[Address(RVA = "0xC3AF10", Offset = "0xC3A110", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8F")]
	public T get_startValue() { }

	[Address(RVA = "0xC34E80", Offset = "0xC34080", Length = "0x219")]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_uiElementsBridge", ReturnType = typeof(UIElementsBridge))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F94")]
	private void ProcessDownEvent(EventBase evt) { }

	[Address(RVA = "0xC35C30", Offset = "0xC34E30", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F96")]
	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }

	[Address(RVA = "0xC35FA0", Offset = "0xC351A0", Length = "0x1FD")]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_uiElementsBridge", ReturnType = typeof(UIElementsBridge))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F98")]
	private void ProcessUpEvent(EventBase evt, int pointerId) { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8E")]
	public void set_dragging(bool value) { }

	[Address(RVA = "0xC3AF90", Offset = "0xC3A190", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F90")]
	public void set_startValue(T value) { }

	[Address(RVA = "0xC37910", Offset = "0xC36B10", Length = "0x2B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F91")]
	public virtual void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	[Address(RVA = "0xC38C70", Offset = "0xC37E70", Length = "0x226")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_uiElementsBridge", ReturnType = typeof(UIElementsBridge))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F99")]
	private void UpdateValueOnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0xC39470", Offset = "0xC38670", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MouseCaptureController), Member = "CaptureMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldMouseDragger`1), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F93")]
	private void UpdateValueOnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0xC39F50", Offset = "0xC39150", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "get_shiftKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "get_altKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F95")]
	private void UpdateValueOnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0xC3AC20", Offset = "0xC39E20", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldMouseDragger`1), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F97")]
	private void UpdateValueOnPointerUp(PointerUpEvent evt) { }

}

