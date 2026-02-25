namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerDown (3))]
[Token(Token = "0x200021E")]
public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200021F")]
	private sealed class <>c
	{
		[Token(Token = "0x40008B1")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61E10", Offset = "0x1C61010", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EF8")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF9")]
		public <>c() { }

		[Address(RVA = "0x1C60DF0", Offset = "0x1C5FFF0", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000EFA")]
		internal PointerDownEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C5B380", Offset = "0x1C5A580", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EF0")]
	private static PointerDownEvent() { }

	[Address(RVA = "0x1C5B460", Offset = "0x1C5A660", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000EF3")]
	public PointerDownEvent() { }

	[Address(RVA = "0x1C5B020", Offset = "0x1C5A220", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C484B0")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EF7")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1C5B0D0", Offset = "0x1C5A2D0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000EF4")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x1C5B170", Offset = "0x1C5A370", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000EF1")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C5B1E0", Offset = "0x1C5A3E0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000EF2")]
	private void LocalInit() { }

	[Address(RVA = "0x1C5B230", Offset = "0x1C5A430", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClickDetector), Member = "ProcessEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EF6")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x1C5B330", Offset = "0x1C5A530", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EF5")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

