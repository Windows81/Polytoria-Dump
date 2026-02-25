namespace UnityEngine.InputForUI;

[Token(Token = "0x2000005")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct Event : IEventProperties
{
	[Token(Token = "0x2000007")]
	private interface IMapFn
	{

		[Token(Token = "0x600001D")]
		public TOutputType Map(ref TEventType ev) { }

	}

	[Token(Token = "0x200000A")]
	private struct MapAsEventModifiers : IMapFn<EventModifiers>
	{

		[Address(RVA = "0x7CE120", Offset = "0x7CD320", Length = "0x2A")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000020")]
		public override EventModifiers Map(ref TEventType ev) { }

	}

	[Token(Token = "0x2000009")]
	private struct MapAsEventSource : IMapFn<EventSource>
	{

		[Address(RVA = "0x7CE2B0", Offset = "0x7CD4B0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		public override EventSource Map(ref TEventType ev) { }

	}

	[Token(Token = "0x2000008")]
	private struct MapAsObject : IMapFn<IEventProperties>
	{

		[Address(RVA = "0x7CE340", Offset = "0x7CD540", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		public override IEventProperties Map(ref TEventType ev) { }

	}

	[Token(Token = "0x2000006")]
	internal enum Type
	{
		Invalid = 0,
		KeyEvent = 1,
		PointerEvent = 2,
		TextInputEvent = 3,
		IMECompositionEvent = 4,
		CommandEvent = 5,
		NavigationEvent = 6,
	}

	[Token(Token = "0x4000023")]
	public static Type[] TypesWithState; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000024")]
	private Type _type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000025")]
	private object _managedEvent; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000026")]
	private KeyEvent _keyEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private PointerEvent _pointerEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	private TextInputEvent _textInputEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000029")]
	private CommandEvent _commandEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002A")]
	private NavigationEvent _navigationEvent; //Field offset: 0x10

	[Token(Token = "0x1700000D")]
	public CommandEvent asCommandEvent
	{
		[Address(RVA = "0x19D20D0", Offset = "0x19D12D0", Length = "0x78")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000017")]
		 get { } //Length: 120
	}

	[Token(Token = "0x1700000C")]
	public IMECompositionEvent asIMECompositionEvent
	{
		[Address(RVA = "0x19D2150", Offset = "0x19D1350", Length = "0xB3")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 179
	}

	[Token(Token = "0x17000009")]
	public KeyEvent asKeyEvent
	{
		[Address(RVA = "0x19D2210", Offset = "0x19D1410", Length = "0x9F")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Token(Token = "0x600000F")]
		 get { } //Length: 159
	}

	[Token(Token = "0x1700000E")]
	public NavigationEvent asNavigationEvent
	{
		[Address(RVA = "0x19D22B0", Offset = "0x19D14B0", Length = "0x87")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000019")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000006")]
	private IEventProperties asObject
	{
		[Address(RVA = "0x19D2340", Offset = "0x19D1540", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MapAsObject)}, ReturnType = typeof(object))]
		[Token(Token = "0x6000009")]
		private get { } //Length: 90
	}

	[Token(Token = "0x1700000A")]
	public PointerEvent asPointerEvent
	{
		[Address(RVA = "0x19D23A0", Offset = "0x19D15A0", Length = "0xC3")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000011")]
		 get { } //Length: 195
	}

	[Token(Token = "0x1700000B")]
	public TextInputEvent asTextInputEvent
	{
		[Address(RVA = "0x19D2470", Offset = "0x19D1670", Length = "0x78")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000013")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000008")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x19D24F0", Offset = "0x19D16F0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000007")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x19D2550", Offset = "0x19D1750", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000005")]
	public Type type
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000008")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x19D2040", Offset = "0x19D1240", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600001C")]
	private static Event() { }

	[Address(RVA = "0x19D1950", Offset = "0x19D0B50", Length = "0x79")]
	[CalledBy(Type = typeof(Event), Member = "get_asKeyEvent", ReturnType = typeof(KeyEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asPointerEvent", ReturnType = typeof(PointerEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asTextInputEvent", ReturnType = typeof(TextInputEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asIMECompositionEvent", ReturnType = typeof(IMECompositionEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asCommandEvent", ReturnType = typeof(CommandEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asNavigationEvent", ReturnType = typeof(NavigationEvent))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	private void Ensure(Type t) { }

	[Address(RVA = "0x19D1AF0", Offset = "0x19D0CF0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000018")]
	public static Event From(NavigationEvent navigationEvent) { }

	[Address(RVA = "0x19D1CD0", Offset = "0x19D0ED0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000016")]
	public static Event From(CommandEvent commandEvent) { }

	[Address(RVA = "0x19D19D0", Offset = "0x19D0BD0", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000014")]
	public static Event From(IMECompositionEvent imeCompositionEvent) { }

	[Address(RVA = "0x19D1BA0", Offset = "0x19D0DA0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000010")]
	public static Event From(PointerEvent pointerEvent) { }

	[Address(RVA = "0x19D1D70", Offset = "0x19D0F70", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000012")]
	public static Event From(TextInputEvent textInputEvent) { }

	[Address(RVA = "0x19D1C30", Offset = "0x19D0E30", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000E")]
	public static Event From(KeyEvent keyEvent) { }

	[Address(RVA = "0x19D20D0", Offset = "0x19D12D0", Length = "0x78")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000017")]
	public CommandEvent get_asCommandEvent() { }

	[Address(RVA = "0x19D2150", Offset = "0x19D1350", Length = "0xB3")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000015")]
	public IMECompositionEvent get_asIMECompositionEvent() { }

	[Address(RVA = "0x19D2210", Offset = "0x19D1410", Length = "0x9F")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x600000F")]
	public KeyEvent get_asKeyEvent() { }

	[Address(RVA = "0x19D22B0", Offset = "0x19D14B0", Length = "0x87")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000019")]
	public NavigationEvent get_asNavigationEvent() { }

	[Address(RVA = "0x19D2340", Offset = "0x19D1540", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MapAsObject)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000009")]
	private IEventProperties get_asObject() { }

	[Address(RVA = "0x19D23A0", Offset = "0x19D15A0", Length = "0xC3")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000011")]
	public PointerEvent get_asPointerEvent() { }

	[Address(RVA = "0x19D2470", Offset = "0x19D1670", Length = "0x78")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000013")]
	public TextInputEvent get_asTextInputEvent() { }

	[Address(RVA = "0x19D24F0", Offset = "0x19D16F0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
	[Token(Token = "0x600000B")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x19D2550", Offset = "0x19D1750", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
	[Token(Token = "0x600000A")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public Type get_type() { }

	[Address(RVA = "0x6AC920", Offset = "0x6ABB20", Length = "0x7D")]
	[CalledBy(Type = typeof(Event), Member = "get_eventModifiers", ReturnType = typeof(EventModifiers))]
	[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	private TOutputType Map() { }

	[Address(RVA = "0x6AC9A0", Offset = "0x6ABBA0", Length = "0x1D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MapAsEventModifiers), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyEvent)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyEvent&)}, ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(MapAsEventModifiers), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent&)}, ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(MapAsEventModifiers), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationEvent)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationEvent&)}, ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	private TOutputType Map(TMapType fn) { }

	[Address(RVA = "0x19D1E10", Offset = "0x19D1010", Length = "0x224")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
	[Calls(Type = typeof(EventModifiers), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MapAsObject)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600000D")]
	public virtual string ToString() { }

}

