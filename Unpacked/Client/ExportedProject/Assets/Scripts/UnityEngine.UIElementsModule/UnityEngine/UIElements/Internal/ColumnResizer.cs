namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000638")]
internal class ColumnResizer : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001722")]
	private Vector2 m_Start; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001723")]
	protected bool m_Active; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001724")]
	private bool m_Resizing; //Field offset: 0x31
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001725")]
	private MultiColumnCollectionHeader m_Header; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001726")]
	private Column m_Column; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001727")]
	private VisualElement m_PreviewElement; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001728")]
	private ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001729")]
	private bool <preview>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000B2D")]
	public ColumnLayout columnLayout
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BBF")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B2E")]
	public bool preview
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC1")]
		 get { } //Length: 5
		[Address(RVA = "0x12CDBA0", Offset = "0x12CCDA0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BC2")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1BEF970", Offset = "0x1BEEB70", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002BC3")]
	public ColumnResizer(Column column) { }

	[Address(RVA = "0x1BEEBF0", Offset = "0x1BEDDF0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColumnLayout), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnResizer), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[Token(Token = "0x6002BCA")]
	private void BeginDragResize(float pos) { }

	[Address(RVA = "0x1BEEC40", Offset = "0x1BEDE40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnResizer), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[Token(Token = "0x6002BCB")]
	private void DragResize(float pos) { }

	[Address(RVA = "0x1BEEC90", Offset = "0x1BEDE90", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ColumnLayout), Member = "EndDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002BCD")]
	private void EndDragResize(float pos, bool cancelled) { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BBF")]
	public ColumnLayout get_columnLayout() { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC1")]
	public bool get_preview() { }

	[Address(RVA = "0x1BEED00", Offset = "0x1BEDF00", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ColumnLayout), Member = "EndDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002BC6")]
	private void OnKeyDown(KeyDownEvent e) { }

	[Address(RVA = "0x1BEEDA0", Offset = "0x1BEDFA0", Length = "0x39A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(MouseCaptureController), Member = "CaptureMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnResizer), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopImmediatePropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "GetFirstAncestorOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BC7")]
	private void OnPointerDown(PointerDownEvent e) { }

	[Address(RVA = "0x1BEF140", Offset = "0x1BEE340", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnResizer), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BC8")]
	private void OnPointerMove(PointerMoveEvent e) { }

	[Address(RVA = "0x1BEF290", Offset = "0x1BEE490", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStopManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ColumnLayout), Member = "EndDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BC9")]
	private void OnPointerUp(PointerUpEvent e) { }

	[Address(RVA = "0x1BEF430", Offset = "0x1BEE630", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6002BC4")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC0")]
	public void set_columnLayout(ColumnLayout value) { }

	[Address(RVA = "0x12CDBA0", Offset = "0x12CCDA0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BC2")]
	public void set_preview(bool value) { }

	[Address(RVA = "0x1BEF630", Offset = "0x1BEE830", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6002BC5")]
	protected virtual void UnregisterCallbacksFromTarget() { }

	[Address(RVA = "0x1BEF830", Offset = "0x1BEEA30", Length = "0x133")]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BCC")]
	private void UpdatePreviewPosition() { }

}

