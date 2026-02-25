namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Default (0))]
[Token(Token = "0x20001BD")]
public abstract class EventBase : EventBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001BE")]
	private sealed class <>c
	{
		[Token(Token = "0x4000803")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC1")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC2")]
		public <>c() { }

		[Address(RVA = "0x7F9CD0", Offset = "0x7F8ED0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC3")]
		internal T <.cctor>b__15_0() { }

	}

	[Token(Token = "0x40007FF")]
	private static readonly long s_TypeId; //Field offset: 0x0
	[Token(Token = "0x4000800")]
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0
	[Token(Token = "0x4000802")]
	internal static readonly EventCategory EventCategory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000801")]
	private int m_RefCount; //Field offset: 0x0

	[Token(Token = "0x1700024B")]
	public virtual long eventTypeId
	{
		[Address(RVA = "0xC2E9E0", Offset = "0xC2DBE0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CBF")]
		 get { } //Length: 119
	}

	[Address(RVA = "0xC2E620", Offset = "0xC2D820", Length = "0x325")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "RegisterEventType", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetEventCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventCategory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC0")]
	private static EventBase`1() { }

	[Address(RVA = "0xC2E950", Offset = "0xC2DB50", Length = "0x88")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB7")]
	protected EventBase`1() { }

	[Address(RVA = "0xC2DF60", Offset = "0xC2D160", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBD")]
	internal virtual void Acquire() { }

	[Address(RVA = "0xC2DF70", Offset = "0xC2D170", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(EventBase), Member = "get_pooled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBE")]
	public virtual void Dispose() { }

	[Address(RVA = "0xC2E9E0", Offset = "0xC2DBE0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBF")]
	public virtual long get_eventTypeId() { }

	[Address(RVA = "0xC2E110", Offset = "0xC2D310", Length = "0x10D")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBA")]
	public static T GetPooled() { }

	[Address(RVA = "0xC2E220", Offset = "0xC2D420", Length = "0x194")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMouseEvent)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DropdownMenu), typeof(IEventHandler), typeof(ContextualMenuManager)}, ReturnType = typeof(ContextualMenuPopulateEvent))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBB")]
	internal static T GetPooled(EventBase e) { }

	[Address(RVA = "0xC2E3C0", Offset = "0xC2D5C0", Length = "0x7B")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransitionEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TooltipEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelChangedEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GeometryChangedEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMEEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChangeEvent`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCaptureEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEvent), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(EventBase), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB9")]
	protected virtual void Init() { }

	[Address(RVA = "0xC2E440", Offset = "0xC2D640", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "get_pooled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBC")]
	private static void ReleasePooled(T evt) { }

	[Address(RVA = "0xC2E560", Offset = "0xC2D760", Length = "0xB2")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB6")]
	internal static void SetCreateFunction(Func<T> createMethod) { }

	[Address(RVA = "0x3AFA50", Offset = "0x3AEC50", Length = "0x25F")]
	[CallerCount(Count = 176)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB8")]
	public static long TypeId() { }

}

