namespace UnityEngine.UIElements;

[Token(Token = "0x2000184")]
internal abstract class DragEventsProcessor
{
	[Token(Token = "0x2000185")]
	public enum DragState
	{
		None = 0,
		CanStartDrag = 1,
		Dragging = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400075C")]
	private bool m_IsRegistered; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400075D")]
	private DragState m_DragState; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400075E")]
	private Vector3 m_Start; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400075F")]
	private bool m_PendingPerformDrag; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000760")]
	protected readonly VisualElement m_Target; //Field offset: 0x28

	[Token(Token = "0x17000206")]
	protected IDragAndDrop dragAndDrop
	{
		[Address(RVA = "0x1C33740", Offset = "0x1C32940", Length = "0x27")]
		[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(DragAndDropUtility), Member = "GetDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(IDragAndDrop))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B85")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000207")]
	internal override bool isEditorContext
	{
		[Address(RVA = "0x1C33770", Offset = "0x1C32970", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B86")]
		internal get { } //Length: 199
	}

	[Token(Token = "0x17000204")]
	protected override bool supportsDragEvents
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B83")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000205")]
	private bool useDragEvents
	{
		[Address(RVA = "0x1C33840", Offset = "0x1C32A40", Length = "0x51")]
		[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B84")]
		private get { } //Length: 81
	}

	[Address(RVA = "0x1C33610", Offset = "0x1C32810", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "RegisterCallbacksFromTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000B87")]
	internal DragEventsProcessor(VisualElement target) { }

	[Address(RVA = "0x1C323E0", Offset = "0x1C315E0", Length = "0x105")]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCancelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerCapturedOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCaptureOutEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DragAndDropUtility), Member = "GetDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(IDragAndDrop))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B98")]
	private void CancelDragAndDrop(int releaseCapturePointerId = -1) { }

	[Token(Token = "0x6000B8C")]
	protected abstract bool CanStartDrag(Vector3 pointerPosition) { }

	[Token(Token = "0x6000B90")]
	protected abstract void ClearDragAndDropUI(bool dragCancelled) { }

	[Address(RVA = "0x1C33740", Offset = "0x1C32940", Length = "0x27")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DragAndDropUtility), Member = "GetDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(IDragAndDrop))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B85")]
	protected IDragAndDrop get_dragAndDrop() { }

	[Address(RVA = "0x1C33770", Offset = "0x1C32970", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B86")]
	internal override bool get_isEditorContext() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B83")]
	protected override bool get_supportsDragEvents() { }

	[Address(RVA = "0x1C33840", Offset = "0x1C32A40", Length = "0x51")]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B84")]
	private bool get_useDragEvents() { }

	[Address(RVA = "0x1C324F0", Offset = "0x1C316F0", Length = "0x123")]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "Pick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "GetFirstOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B9A")]
	private DragEventsProcessor GetDropTarget(Vector2 position) { }

	[Token(Token = "0x6000B8F")]
	protected private abstract void OnDrop(Vector3 pointerPosition) { }

	[Address(RVA = "0x1C32620", Offset = "0x1C31820", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "CancelDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B97")]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C326A0", Offset = "0x1C318A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "CancelDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B95")]
	private void OnPointerCancelEvent(PointerCancelEvent evt) { }

	[Address(RVA = "0x1C32700", Offset = "0x1C31900", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DragEventsProcessor), Member = "CancelDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B96")]
	private void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x1C32710", Offset = "0x1C31910", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B91")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x1C327D0", Offset = "0x1C319D0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B94")]
	private void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	[Address(RVA = "0x1C327F0", Offset = "0x1C319F0", Length = "0x331")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "get_useDragEvents", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DragAndDropUtility), Member = "GetDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(IDragAndDrop))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E2210")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "GetDropTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DragEventsProcessor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B99")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x1C32B30", Offset = "0x1C31D30", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B92")]
	private void OnPointerOutEvent(PointerOutEvent evt) { }

	[Address(RVA = "0x1C32BE0", Offset = "0x1C31DE0", Length = "0x1EB")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "GetDropTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DragEventsProcessor))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DragAndDropUtility), Member = "GetDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(IDragAndDrop))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B93")]
	internal void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x1C32DD0", Offset = "0x1C31FD0", Length = "0x395")]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "RegisterCallbacksFromTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000B89")]
	private void RegisterCallbacksFromTarget() { }

	[Address(RVA = "0x1C33170", Offset = "0x1C32370", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DragEventsProcessor), Member = "RegisterCallbacksFromTarget", ReturnType = typeof(void))]
	[Token(Token = "0x6000B88")]
	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	[Token(Token = "0x6000B8D")]
	protected private abstract StartDragArgs StartDrag(Vector3 pointerPosition) { }

	[Address(RVA = "0x1C33600", Offset = "0x1C32800", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DragEventsProcessor), Member = "UnregisterCallbacksFromTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B8A")]
	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1C33180", Offset = "0x1C32380", Length = "0x474")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "InitializeDragAndDropController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "UnregisterCallbacksFromTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetachFromPanelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Token(Token = "0x6000B8B")]
	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false) { }

	[Token(Token = "0x6000B8E")]
	protected private abstract void UpdateDrag(Vector3 pointerPosition) { }

}

