namespace UnityEngine.EventSystems;

[Token(Token = "0x20000BA")]
public static class ExecuteEvents
{
	[Token(Token = "0x20000BB")]
	internal sealed class EventFunction : MulticastDelegate
	{

		[Address(RVA = "0x335350", Offset = "0x334550", Length = "0x125")]
		[CallerCount(Count = 116)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006FB")]
		public EventFunction`1(object object, IntPtr method) { }

		[Address(RVA = "0x335300", Offset = "0x334500", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006FD")]
		public override IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006FE")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006FC")]
		public override void Invoke(T1 handler, BaseEventData eventData) { }

	}

	[Token(Token = "0x4000323")]
	private static readonly EventFunction<IPointerMoveHandler> s_PointerMoveHandler; //Field offset: 0x0
	[Token(Token = "0x4000324")]
	private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler; //Field offset: 0x8
	[Token(Token = "0x4000325")]
	private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler; //Field offset: 0x10
	[Token(Token = "0x4000326")]
	private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler; //Field offset: 0x18
	[Token(Token = "0x4000327")]
	private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler; //Field offset: 0x20
	[Token(Token = "0x4000328")]
	private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler; //Field offset: 0x28
	[Token(Token = "0x4000329")]
	private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; //Field offset: 0x30
	[Token(Token = "0x400032A")]
	private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler; //Field offset: 0x38
	[Token(Token = "0x400032B")]
	private static readonly EventFunction<IDragHandler> s_DragHandler; //Field offset: 0x40
	[Token(Token = "0x400032C")]
	private static readonly EventFunction<IEndDragHandler> s_EndDragHandler; //Field offset: 0x48
	[Token(Token = "0x400032D")]
	private static readonly EventFunction<IDropHandler> s_DropHandler; //Field offset: 0x50
	[Token(Token = "0x400032E")]
	private static readonly EventFunction<IScrollHandler> s_ScrollHandler; //Field offset: 0x58
	[Token(Token = "0x400032F")]
	private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; //Field offset: 0x60
	[Token(Token = "0x4000330")]
	private static readonly EventFunction<ISelectHandler> s_SelectHandler; //Field offset: 0x68
	[Token(Token = "0x4000331")]
	private static readonly EventFunction<IDeselectHandler> s_DeselectHandler; //Field offset: 0x70
	[Token(Token = "0x4000332")]
	private static readonly EventFunction<IMoveHandler> s_MoveHandler; //Field offset: 0x78
	[Token(Token = "0x4000333")]
	private static readonly EventFunction<ISubmitHandler> s_SubmitHandler; //Field offset: 0x80
	[Token(Token = "0x4000334")]
	private static readonly EventFunction<ICancelHandler> s_CancelHandler; //Field offset: 0x88
	[Token(Token = "0x4000335")]
	private static readonly List<Transform> s_InternalTransformList; //Field offset: 0x90

	[Token(Token = "0x170001D9")]
	public static EventFunction<IBeginDragHandler> beginDragHandler
	{
		[Address(RVA = "0x1CE4320", Offset = "0x1CE3520", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E8")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E3")]
	public static EventFunction<ICancelHandler> cancelHandler
	{
		[Address(RVA = "0x1CE4370", Offset = "0x1CE3570", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006F2")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170001E0")]
	public static EventFunction<IDeselectHandler> deselectHandler
	{
		[Address(RVA = "0x1CE43D0", Offset = "0x1CE35D0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006EF")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DA")]
	public static EventFunction<IDragHandler> dragHandler
	{
		[Address(RVA = "0x1CE4420", Offset = "0x1CE3620", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DC")]
	public static EventFunction<IDropHandler> dropHandler
	{
		[Address(RVA = "0x1CE4470", Offset = "0x1CE3670", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DB")]
	public static EventFunction<IEndDragHandler> endDragHandler
	{
		[Address(RVA = "0x1CE44C0", Offset = "0x1CE36C0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D8")]
	public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
	{
		[Address(RVA = "0x1CE4510", Offset = "0x1CE3710", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E7")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E1")]
	public static EventFunction<IMoveHandler> moveHandler
	{
		[Address(RVA = "0x1CE4560", Offset = "0x1CE3760", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006F0")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D7")]
	public static EventFunction<IPointerClickHandler> pointerClickHandler
	{
		[Address(RVA = "0x1CE45B0", Offset = "0x1CE37B0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E6")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D5")]
	public static EventFunction<IPointerDownHandler> pointerDownHandler
	{
		[Address(RVA = "0x1CE4600", Offset = "0x1CE3800", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D3")]
	public static EventFunction<IPointerEnterHandler> pointerEnterHandler
	{
		[Address(RVA = "0x1CE4650", Offset = "0x1CE3850", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E2")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D4")]
	public static EventFunction<IPointerExitHandler> pointerExitHandler
	{
		[Address(RVA = "0x1CE46A0", Offset = "0x1CE38A0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E3")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D2")]
	public static EventFunction<IPointerMoveHandler> pointerMoveHandler
	{
		[Address(RVA = "0x1CE46F0", Offset = "0x1CE38F0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170001D6")]
	public static EventFunction<IPointerUpHandler> pointerUpHandler
	{
		[Address(RVA = "0x1CE4740", Offset = "0x1CE3940", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DD")]
	public static EventFunction<IScrollHandler> scrollHandler
	{
		[Address(RVA = "0x1CE4790", Offset = "0x1CE3990", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DF")]
	public static EventFunction<ISelectHandler> selectHandler
	{
		[Address(RVA = "0x1CE47E0", Offset = "0x1CE39E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E2")]
	public static EventFunction<ISubmitHandler> submitHandler
	{
		[Address(RVA = "0x1CE4830", Offset = "0x1CE3A30", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006F1")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170001DE")]
	public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
	{
		[Address(RVA = "0x1CE4890", Offset = "0x1CE3A90", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x1CE3B40", Offset = "0x1CE2D40", Length = "0x7DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[Token(Token = "0x60006FA")]
	private static ExecuteEvents() { }

	[Address(RVA = "0x6AD830", Offset = "0x6ACA30", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.EventSystems.IEventSystemHandler>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F8")]
	public static bool CanHandleEvent(GameObject go) { }

	[Address(RVA = "0x6AE020", Offset = "0x6AD220", Length = "0x37C")]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "UpdateModule", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "SendSubmitEventToSelectedObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "SendMoveEventToSelectedObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "SendUpdateEventToSelectedObject", ReturnType = typeof(bool))]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.EventSystems.IEventSystemHandler>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F4")]
	public static bool Execute(GameObject target, BaseEventData eventData, EventFunction<T> functor) { }

	[Address(RVA = "0x1CE3120", Offset = "0x1CE2320", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006E0")]
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3540", Offset = "0x1CE2740", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DF")]
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3640", Offset = "0x1CE2840", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006DE")]
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3730", Offset = "0x1CE2930", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DC")]
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3970", Offset = "0x1CE2B70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DB")]
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE2FE0", Offset = "0x1CE21E0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DA")]
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE35A0", Offset = "0x1CE27A0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D9")]
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE2F80", Offset = "0x1CE2180", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DD")]
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3790", Offset = "0x1CE2990", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D7")]
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3360", Offset = "0x1CE2560", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D6")]
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3830", Offset = "0x1CE2A30", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D5")]
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3400", Offset = "0x1CE2600", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D4")]
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3180", Offset = "0x1CE2380", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006CF")]
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE38D0", Offset = "0x1CE2AD0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D3")]
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3220", Offset = "0x1CE2420", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D2")]
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE32C0", Offset = "0x1CE24C0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D1")]
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE34A0", Offset = "0x1CE26A0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D0")]
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x1CE3080", Offset = "0x1CE2280", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D8")]
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x6ADA90", Offset = "0x6ACC90", Length = "0x161")]
	[CalledBy(Type = "Battlehub.UIControls.ItemContainer", Member = "UnityEngine.EventSystems.IEndDragHandler.OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemContainer", Member = "UnityEngine.EventSystems.IEndDragHandler.OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemContainer", Member = "UnityEngine.EventSystems.IDragHandler.OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemContainer", Member = "UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.ItemContainer", Member = "UnityEngine.EventSystems.IDragHandler.OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.ItemContainer", Member = "UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.Transform>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F5")]
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) { }

	[Address(RVA = "0x1CE4320", Offset = "0x1CE3520", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E8")]
	public static EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	[Address(RVA = "0x1CE4370", Offset = "0x1CE3570", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006F2")]
	public static EventFunction<ICancelHandler> get_cancelHandler() { }

	[Address(RVA = "0x1CE43D0", Offset = "0x1CE35D0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006EF")]
	public static EventFunction<IDeselectHandler> get_deselectHandler() { }

	[Address(RVA = "0x1CE4420", Offset = "0x1CE3620", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E9")]
	public static EventFunction<IDragHandler> get_dragHandler() { }

	[Address(RVA = "0x1CE4470", Offset = "0x1CE3670", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006EB")]
	public static EventFunction<IDropHandler> get_dropHandler() { }

	[Address(RVA = "0x1CE44C0", Offset = "0x1CE36C0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006EA")]
	public static EventFunction<IEndDragHandler> get_endDragHandler() { }

	[Address(RVA = "0x1CE4510", Offset = "0x1CE3710", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E7")]
	public static EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	[Address(RVA = "0x1CE4560", Offset = "0x1CE3760", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006F0")]
	public static EventFunction<IMoveHandler> get_moveHandler() { }

	[Address(RVA = "0x1CE45B0", Offset = "0x1CE37B0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E6")]
	public static EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	[Address(RVA = "0x1CE4600", Offset = "0x1CE3800", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E4")]
	public static EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	[Address(RVA = "0x1CE4650", Offset = "0x1CE3850", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E2")]
	public static EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	[Address(RVA = "0x1CE46A0", Offset = "0x1CE38A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E3")]
	public static EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	[Address(RVA = "0x1CE46F0", Offset = "0x1CE38F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E1")]
	public static EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	[Address(RVA = "0x1CE4740", Offset = "0x1CE3940", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006E5")]
	public static EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	[Address(RVA = "0x1CE4790", Offset = "0x1CE3990", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006EC")]
	public static EventFunction<IScrollHandler> get_scrollHandler() { }

	[Address(RVA = "0x1CE47E0", Offset = "0x1CE39E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006EE")]
	public static EventFunction<ISelectHandler> get_selectHandler() { }

	[Address(RVA = "0x1CE4830", Offset = "0x1CE3A30", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006F1")]
	public static EventFunction<ISubmitHandler> get_submitHandler() { }

	[Address(RVA = "0x1CE4890", Offset = "0x1CE3A90", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60006ED")]
	public static EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	[Address(RVA = "0x1CE39D0", Offset = "0x1CE2BD0", Length = "0x16D")]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F3")]
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	[Address(RVA = "0x6AE4D0", Offset = "0x6AD6D0", Length = "0x1DC")]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.EventSystems.IEventSystemHandler>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F9")]
	public static GameObject GetEventHandler(GameObject root) { }

	[Address(RVA = "0x6AE910", Offset = "0x6ADB10", Length = "0x344")]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "CanHandleEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002AFC0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F7")]
	private static void GetEventList(GameObject go, IList<IEventSystemHandler> results) { }

	[Address(RVA = "0x6AEC60", Offset = "0x6ADE60", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F6")]
	private static bool ShouldSendToComponent(Component component) { }

	[Address(RVA = "0x6AED70", Offset = "0x6ADF70", Length = "0x10D")]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScrollHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMoveHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDropHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEndDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInitializePotentialDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerClickHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBeginDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerDownHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerExitHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEnterHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerMoveHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerUpHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CE")]
	public static T ValidateEventData(BaseEventData data) { }

}

