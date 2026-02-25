namespace UnityEngine.UIElements;

[Token(Token = "0x20001EF")]
public class WheelEvent : MouseEventBase<WheelEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001F0")]
	private sealed class <>c
	{
		[Token(Token = "0x400084E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C62190", Offset = "0x1C61390", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DE7")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE8")]
		public <>c() { }

		[Address(RVA = "0x1C61200", Offset = "0x1C60400", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WheelEvent), Member = "LocalInit", ReturnType = typeof(void))]
		[Token(Token = "0x6000DE9")]
		internal WheelEvent <.cctor>b__1_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400084D")]
	private Vector3 <delta>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x17000279")]
	public private Vector3 delta
	{
		[Address(RVA = "0x1C63050", Offset = "0x1C62250", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000DDE")]
		 get { } //Length: 25
		[Address(RVA = "0x1C63070", Offset = "0x1C62270", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CompilerGenerated]
		[Token(Token = "0x6000DDF")]
		private set { } //Length: 105
	}

	[Address(RVA = "0x1C62F20", Offset = "0x1C62120", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DDD")]
	private static WheelEvent() { }

	[Address(RVA = "0x1C63000", Offset = "0x1C62200", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WheelEvent), Member = "LocalInit", ReturnType = typeof(void))]
	[Token(Token = "0x6000DE5")]
	public WheelEvent() { }

	[Address(RVA = "0x1C62BE0", Offset = "0x1C61DE0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000DE6")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1C63050", Offset = "0x1C62250", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000DDE")]
	public Vector3 get_delta() { }

	[Address(RVA = "0x1C62C80", Offset = "0x1C61E80", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[Calls(Type = typeof(Event), Member = "get_delta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DE0")]
	public static WheelEvent GetPooled(Event systemEvent) { }

	[Address(RVA = "0x1C62D80", Offset = "0x1C61F80", Length = "0xC0")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "<ProcessPointerEvent>b__9_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`2<UnityEngine.EventModifiers, UnityEngine.Vector2>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DE1")]
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x1C62D10", Offset = "0x1C61F10", Length = "0x65")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DE2")]
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	[Address(RVA = "0x1C62E50", Offset = "0x1C62050", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000DE3")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C62EA0", Offset = "0x1C620A0", Length = "0x78")]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_0", ReturnType = typeof(WheelEvent))]
	[CalledBy(Type = typeof(WheelEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000DE4")]
	private void LocalInit() { }

	[Address(RVA = "0x1C63070", Offset = "0x1C62270", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6000DDF")]
	private void set_delta(Vector3 value) { }

}

