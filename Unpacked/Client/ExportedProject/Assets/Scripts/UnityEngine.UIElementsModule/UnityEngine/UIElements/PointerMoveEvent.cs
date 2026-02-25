namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerMove (2))]
[Token(Token = "0x2000220")]
public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000221")]
	private sealed class <>c
	{
		[Token(Token = "0x40008B3")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C619B0", Offset = "0x1C60BB0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F07")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F08")]
		public <>c() { }

		[Address(RVA = "0x1C60D50", Offset = "0x1C5FF50", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000F09")]
		internal PointerMoveEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40008B2")]
	private bool <isHandledByDraggable>k__BackingField; //Field offset: 0x100

	[Token(Token = "0x170002C5")]
	internal bool isHandledByDraggable
	{
		[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EFC")]
		internal get { } //Length: 8
		[Address(RVA = "0x1C5C5C0", Offset = "0x1C5B7C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000EFD")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002C6")]
	internal bool isPointerDown
	{
		[Address(RVA = "0x1C5C500", Offset = "0x1C5B700", Length = "0x5E")]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EFE")]
		internal get { } //Length: 94
	}

	[Token(Token = "0x170002C7")]
	internal bool isPointerUp
	{
		[Address(RVA = "0x1C5C560", Offset = "0x1C5B760", Length = "0x60")]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EFF")]
		internal get { } //Length: 96
	}

	[Address(RVA = "0x1C5C3B0", Offset = "0x1C5B5B0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EFB")]
	private static PointerMoveEvent() { }

	[Address(RVA = "0x1C5C490", Offset = "0x1C5B690", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F02")]
	public PointerMoveEvent() { }

	[Address(RVA = "0x1C5BFA0", Offset = "0x1C5B1A0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C484B0")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F06")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EFC")]
	internal bool get_isHandledByDraggable() { }

	[Address(RVA = "0x1C5C500", Offset = "0x1C5B700", Length = "0x5E")]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EFE")]
	internal bool get_isPointerDown() { }

	[Address(RVA = "0x1C5C560", Offset = "0x1C5B760", Length = "0x60")]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EFF")]
	internal bool get_isPointerUp() { }

	[Address(RVA = "0x1C5C050", Offset = "0x1C5B250", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000F03")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x1C5C210", Offset = "0x1C5B410", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000F00")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C5C280", Offset = "0x1C5B480", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000F01")]
	private void LocalInit() { }

	[Address(RVA = "0x1C5C2C0", Offset = "0x1C5B4C0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ClickDetector), Member = "ProcessEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F05")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x1C5C360", Offset = "0x1C5B560", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F04")]
	protected private virtual void PreDispatch(IPanel panel) { }

	[Address(RVA = "0x1C5C5C0", Offset = "0x1C5B7C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000EFD")]
	internal void set_isHandledByDraggable(bool value) { }

}

