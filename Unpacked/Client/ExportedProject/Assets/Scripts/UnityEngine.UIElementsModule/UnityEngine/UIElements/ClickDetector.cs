namespace UnityEngine.UIElements;

[Token(Token = "0x200004F")]
internal class ClickDetector
{
	[Token(Token = "0x2000050")]
	private class ButtonClickStatus
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000183")]
		public VisualElement m_Target; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000184")]
		public Vector3 m_PointerDownPosition; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000185")]
		public long m_LastPointerDownTime; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000186")]
		public int m_ClickCount; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000268")]
		public ButtonClickStatus() { }

		[Address(RVA = "0x1AC41F0", Offset = "0x1AC33F0", Length = "0x6A")]
		[CalledBy(Type = typeof(ClickDetector), Member = "StartClickTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClickDetector), Member = "CancelClickTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClickDetector), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000267")]
		public void Reset() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000182")]
	private static int <s_DoubleClickTime>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000181")]
	private List<ButtonClickStatus> m_ClickStatus; //Field offset: 0x10

	[Token(Token = "0x1700004F")]
	internal static int s_DoubleClickTime
	{
		[Address(RVA = "0x1AC4C90", Offset = "0x1AC3E90", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600025D")]
		internal get { } //Length: 77
		[Address(RVA = "0x1AC4CE0", Offset = "0x1AC3EE0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600025E")]
		internal set { } //Length: 82
	}

	[Address(RVA = "0x1AC49D0", Offset = "0x1AC3BD0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000266")]
	private static ClickDetector() { }

	[Address(RVA = "0x1AC4A10", Offset = "0x1AC3C10", Length = "0x278")]
	[CalledBy(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	[CalledBy(Type = typeof(EventDispatcher), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600025F")]
	public ClickDetector() { }

	[Address(RVA = "0x1AC4260", Offset = "0x1AC3460", Length = "0x96")]
	[CalledBy(Type = typeof(ClickDetector), Member = "ProcessEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ButtonClickStatus), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000262")]
	private void CancelClickTracking(EventBase evt) { }

	[Address(RVA = "0x1AC4300", Offset = "0x1AC3500", Length = "0x151")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ButtonClickStatus), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000265")]
	internal void Cleanup(List<VisualElement> elements) { }

	[Address(RVA = "0x1AC4460", Offset = "0x1AC3660", Length = "0x1AE")]
	[CalledBy(Type = typeof(ClickDetector), Member = "SendClickEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000264")]
	private static bool ContainsPointer(VisualElement element, IPointerEvent pe) { }

	[Address(RVA = "0x1AC4C90", Offset = "0x1AC3E90", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600025D")]
	internal static int get_s_DoubleClickTime() { }

	[Address(RVA = "0x685DE0", Offset = "0x684FE0", Length = "0x27F")]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerMoveEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClickDetector), Member = "StartClickTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClickDetector), Member = "SendClickEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClickDetector), Member = "CancelClickTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000263")]
	public void ProcessEvent(PointerEventBase<TEvent> evt) { }

	[Address(RVA = "0x1AC4610", Offset = "0x1AC3810", Length = "0x219")]
	[CalledBy(Type = typeof(ClickDetector), Member = "ProcessEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ClickDetector), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "FindCommonAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ClickEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(int)}, ReturnType = typeof(ClickEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000261")]
	private void SendClickEvent(EventBase evt) { }

	[Address(RVA = "0x1AC4CE0", Offset = "0x1AC3EE0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600025E")]
	internal static void set_s_DoubleClickTime(int value) { }

	[Address(RVA = "0x1AC4830", Offset = "0x1AC3A30", Length = "0x198")]
	[CalledBy(Type = typeof(ClickDetector), Member = "ProcessEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ButtonClickStatus), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000260")]
	private void StartClickTracking(EventBase evt) { }

}

