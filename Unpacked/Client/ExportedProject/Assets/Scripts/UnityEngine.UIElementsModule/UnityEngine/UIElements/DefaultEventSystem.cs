namespace UnityEngine.UIElements;

[Token(Token = "0x2000252")]
internal class DefaultEventSystem
{
	[CompilerGenerated]
	[Token(Token = "0x200025D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000948")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C76280", Offset = "0x1C75480", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001085")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001086")]
		public <>c() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001087")]
		internal bool <.cctor>b__62_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200025E")]
	private sealed class <>c__35
	{
		[Token(Token = "0x4000949")]
		public static readonly <>c__35<TArg> <>9; //Field offset: 0x0
		[Token(Token = "0x400094A")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"evtFactory", "delta", "arg"})]
		public static Func<Vector3, ValueTuple`3<Func`4<Vector3, Vector3, TArg, EventBase>, Vector3, TArg>, EventBase> <>9__35_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001088")]
		private static <>c__35`1() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001089")]
		public <>c__35`1() { }

		[Address(RVA = "0x7FC4B0", Offset = "0x7FB6B0", Length = "0x19B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600108A")]
		internal EventBase <SendPositionBasedEvent>b__35_0(Vector3 p, ValueTuple<Func`4<Vector3, Vector3, TArg, EventBase>, Vector3, TArg> t) { }

	}

	[Token(Token = "0x2000254")]
	public struct FocusBasedEventSequenceContext : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000918")]
		private DefaultEventSystem es; //Field offset: 0x0

		[Address(RVA = "0x1C66520", Offset = "0x1C65720", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600101F")]
		public FocusBasedEventSequenceContext(DefaultEventSystem es) { }

		[Address(RVA = "0x1C664D0", Offset = "0x1C656D0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001020")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000255")]
	private class InputForUIProcessor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000256")]
		private sealed class <>c
		{
			[Token(Token = "0x400091D")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400091E")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_0; //Field offset: 0x8
			[Token(Token = "0x400091F")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_1; //Field offset: 0x10
			[Token(Token = "0x4000920")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_2; //Field offset: 0x18
			[Token(Token = "0x4000921")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_3; //Field offset: 0x20
			[Token(Token = "0x4000922")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"move", "deviceType", "mod"})]
			public static Func<ValueTuple`3<Vector2, NavigationDeviceType, EventModifiers>, EventBase> <>9__10_2; //Field offset: 0x28
			[Token(Token = "0x4000923")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "deviceType", "mod"})]
			public static Func<ValueTuple`3<Direction, NavigationDeviceType, EventModifiers>, EventBase> <>9__10_3; //Field offset: 0x30
			[Token(Token = "0x4000924")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"deviceType", "mod"})]
			public static Func<ValueTuple`2<NavigationDeviceType, EventModifiers>, EventBase> <>9__10_0; //Field offset: 0x38
			[Token(Token = "0x4000925")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"deviceType", "mod"})]
			public static Func<ValueTuple`2<NavigationDeviceType, EventModifiers>, EventBase> <>9__10_1; //Field offset: 0x40
			[Token(Token = "0x4000926")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "keyCode"})]
			public static Func<ValueTuple`2<EventModifiers, KeyCode>, EventBase> <>9__11_0; //Field offset: 0x48
			[Token(Token = "0x4000927")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "keyCode"})]
			public static Func<ValueTuple`2<EventModifiers, KeyCode>, EventBase> <>9__11_1; //Field offset: 0x50
			[Token(Token = "0x4000928")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "character"})]
			public static Func<ValueTuple`2<EventModifiers, Char>, EventBase> <>9__12_0; //Field offset: 0x58

			[Address(RVA = "0x1C76360", Offset = "0x1C75560", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600102D")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600102E")]
			public <>c() { }

			[Address(RVA = "0x1C750A0", Offset = "0x1C742A0", Length = "0x43")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(KeyCode), typeof(EventModifiers)}, ReturnType = "T")]
			[Token(Token = "0x6001037")]
			internal EventBase <ProcessKeyEvent>b__11_0(ValueTuple<EventModifiers, KeyCode> t) { }

			[Address(RVA = "0x1C750F0", Offset = "0x1C742F0", Length = "0x43")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(KeyCode), typeof(EventModifiers)}, ReturnType = "T")]
			[Token(Token = "0x6001038")]
			internal EventBase <ProcessKeyEvent>b__11_1(ValueTuple<EventModifiers, KeyCode> t) { }

			[Address(RVA = "0x1C75380", Offset = "0x1C74580", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			[Token(Token = "0x6001035")]
			internal EventBase <ProcessNavigationEvent>b__10_0(ValueTuple<NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x1C753C0", Offset = "0x1C745C0", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			[Token(Token = "0x6001036")]
			internal EventBase <ProcessNavigationEvent>b__10_1(ValueTuple<NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x1C75400", Offset = "0x1C74600", Length = "0x51")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			[Token(Token = "0x6001033")]
			internal EventBase <ProcessNavigationEvent>b__10_2(ValueTuple<Vector2, NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x1C75460", Offset = "0x1C74660", Length = "0x50")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			[Token(Token = "0x6001034")]
			internal EventBase <ProcessNavigationEvent>b__10_3(ValueTuple<Direction, NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x1C755A0", Offset = "0x1C747A0", Length = "0x11B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
			[Token(Token = "0x600102F")]
			internal EventBase <ProcessPointerEvent>b__9_0(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x1C756C0", Offset = "0x1C748C0", Length = "0x11B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
			[Token(Token = "0x6001030")]
			internal EventBase <ProcessPointerEvent>b__9_1(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x1C757E0", Offset = "0x1C749E0", Length = "0x11B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
			[Token(Token = "0x6001031")]
			internal EventBase <ProcessPointerEvent>b__9_2(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x1C75900", Offset = "0x1C74B00", Length = "0x11B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(Vector3), typeof(int), typeof(float)}, ReturnType = "T")]
			[Token(Token = "0x6001032")]
			internal EventBase <ProcessPointerEvent>b__9_3(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x1C75AC0", Offset = "0x1C74CC0", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(KeyCode), typeof(EventModifiers)}, ReturnType = "T")]
			[Token(Token = "0x6001039")]
			internal EventBase <ProcessTextInputEvent>b__12_0(ValueTuple<EventModifiers, Char> t) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000257")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000929")]
			public IMECompositionEvent compositionEvent; //Field offset: 0x10

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600103A")]
			public <>c__DisplayClass14_0() { }

			[Address(RVA = "0x1C761C0", Offset = "0x1C753C0", Length = "0x4D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(IMEEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IMEEvent))]
			[Token(Token = "0x600103B")]
			internal EventBase <ProcessIMECompositionEvent>b__0(int _) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000919")]
		private readonly DefaultEventSystem m_EventSystem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400091A")]
		private DiscreteTime m_LastPointerTimestamp; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400091B")]
		private DiscreteTime m_NextPointerTimestamp; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400091C")]
		private readonly Queue<Event> m_EventList; //Field offset: 0x28

		[Address(RVA = "0x1C6C9C0", Offset = "0x1C6BBC0", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001021")]
		public InputForUIProcessor(DefaultEventSystem eventSystem) { }

		[Address(RVA = "0x1C6C8E0", Offset = "0x1C6BAE0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(EventModifiers)}, ReturnType = typeof(WheelEvent))]
		[CompilerGenerated]
		[Token(Token = "0x600102C")]
		private EventBase <ProcessPointerEvent>b__9_4(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

		[Address(RVA = "0x1C69FF0", Offset = "0x1C691F0", Length = "0xAE")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "<ProcessPointerEvent>b__9_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, ReturnType = typeof(EventBase))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isShiftPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isCtrlPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isAltPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isMetaPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isCapsLockEnabled", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isNumericPressed", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.InputForUI.EventModifiers", Member = "get_isFunctionKeyPressed", ReturnType = typeof(bool))]
		[Token(Token = "0x6001025")]
		private EventModifiers GetModifiers(EventModifiers eventModifiers) { }

		[Address(RVA = "0x1C6A0A0", Offset = "0x1C692A0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<UnityEngine.InputForUI.Event>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001023")]
		public bool OnEvent(in Event ev) { }

		[Address(RVA = "0x1C6A170", Offset = "0x1C69370", Length = "0x89")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600102A")]
		private void ProcessCommandEvent(CommandEvent commandEvent) { }

		[Address(RVA = "0x1C6A200", Offset = "0x1C69400", Length = "0x145")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Int32, UnityEngine.UIElements.EventBase>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600102B")]
		private void ProcessIMECompositionEvent(IMECompositionEvent compositionEvent) { }

		[Address(RVA = "0x1C6A350", Offset = "0x1C69550", Length = "0x650")]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asTextInputEvent", ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asNavigationEvent", ReturnType = "UnityEngine.InputForUI.NavigationEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.CommandEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asCommandEvent", ReturnType = "UnityEngine.InputForUI.CommandEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessIMECompositionEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.IMECompositionEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asIMECompositionEvent", ReturnType = "UnityEngine.InputForUI.IMECompositionEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asPointerEvent", ReturnType = "UnityEngine.InputForUI.PointerEvent")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_asKeyEvent", ReturnType = "UnityEngine.InputForUI.KeyEvent")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "FocusBasedEventSequence", ReturnType = typeof(FocusBasedEventSequenceContext))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<UnityEngine.InputForUI.Event>), Member = "Dequeue", ReturnType = "UnityEngine.InputForUI.Event")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001024")]
		public void ProcessInputForUIEvents() { }

		[Address(RVA = "0x1C6A9C0", Offset = "0x1C69BC0", Length = "0x30C")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001028")]
		private void ProcessKeyEvent(KeyEvent keyEvent) { }

		[Address(RVA = "0x1C6ACD0", Offset = "0x1C69ED0", Length = "0x685")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Vector2, System.Int32Enum, System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Int32Enum", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Func`2<System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`3<System.Int32Enum, System.Int32Enum, System.Int32Enum>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001027")]
		private void ProcessNavigationEvent(NavigationEvent navigationEvent) { }

		[Address(RVA = "0x1C6B360", Offset = "0x1C6A560", Length = "0x12FF")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.PointerEvent", Member = "get_worldRay", ReturnType = typeof(Ray))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`3<UnityEngine.Vector3, System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent", typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(System.Func`3<UnityEngine.Vector3, System.ValueTuple`3<UnityEngine.InputForUI.PointerEvent, System.Int32, System.Single>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.InputForUI.PointerEvent", Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001026")]
		private void ProcessPointerEvent(PointerEvent pointerEvent) { }

		[Address(RVA = "0x1C6C660", Offset = "0x1C6B860", Length = "0x1D3")]
		[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(InputForUIProcessor), Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventModifiers"}, ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(System.ValueTuple`2<System.Int32Enum, System.Char>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001029")]
		private void ProcessTextInputEvent(TextInputEvent textInputEvent) { }

		[Address(RVA = "0x1C6C840", Offset = "0x1C6BA40", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001022")]
		public void Reset() { }

	}

	[Token(Token = "0x2000258")]
	public class LegacyInputProcessor
	{
		[CompilerGenerated]
		[Token(Token = "0x200025C")]
		private sealed class <>c
		{
			[Token(Token = "0x400093B")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400093C")]
			public static Func<Event, EventBase> <>9__28_0; //Field offset: 0x8
			[Token(Token = "0x400093D")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "scrollDelta"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Vector2>, EventBase> <>9__28_1; //Field offset: 0x10
			[Token(Token = "0x400093E")]
			public static Func<Vector3, Vector3, Event, EventBase> <>9__28_2; //Field offset: 0x18
			[Token(Token = "0x400093F")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Nullable`1<Int32>>, EventBase> <>9__29_0; //Field offset: 0x20
			[Token(Token = "0x4000940")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`4<Int32, Int32, EventModifiers, Nullable`1<Int32>>, EventBase> <>9__29_1; //Field offset: 0x28
			[Token(Token = "0x4000941")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`4<Int32, Int32, EventModifiers, Nullable`1<Int32>>, EventBase> <>9__29_2; //Field offset: 0x30
			[Token(Token = "0x4000942")]
			public static Func<LegacyInputProcessor, EventBase> <>9__30_0; //Field offset: 0x38
			[Token(Token = "0x4000943")]
			public static Func<LegacyInputProcessor, EventBase> <>9__30_1; //Field offset: 0x40
			[Token(Token = "0x4000944")]
			public static Func<LegacyInputProcessor, EventBase> <>9__30_2; //Field offset: 0x48
			[Token(Token = "0x4000945")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"touch", "pointerId", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`3<Touch, Int32, Nullable`1<Int32>>, EventBase> <>9__31_0; //Field offset: 0x50
			[Token(Token = "0x4000946")]
			public static Func<Vector3, Vector3, PenData, EventBase> <>9__32_0; //Field offset: 0x58
			[Token(Token = "0x4000947")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "modifiers", "input"})]
			public static Func<ValueTuple`3<Direction, EventModifiers, IInput>, EventBase> <>9__39_0; //Field offset: 0x60

			[Address(RVA = "0x1C763D0", Offset = "0x1C755D0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001077")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001078")]
			public <>c() { }

			[Address(RVA = "0x1C75140", Offset = "0x1C74340", Length = "0xBA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
			[Token(Token = "0x600107C")]
			internal EventBase <ProcessMouseEvents>b__29_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<EventModifiers, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x1C75200", Offset = "0x1C74400", Length = "0xBC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventHelper), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
			[Token(Token = "0x600107D")]
			internal EventBase <ProcessMouseEvents>b__29_1(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x1C752C0", Offset = "0x1C744C0", Length = "0xBF")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventHelper), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType), typeof(Vector3), typeof(Vector2), typeof(int), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = typeof(EventBase))]
			[Token(Token = "0x600107E")]
			internal EventBase <ProcessMouseEvents>b__29_2(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x1C754B0", Offset = "0x1C746B0", Length = "0xE6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
			[Token(Token = "0x6001083")]
			internal EventBase <ProcessPenEvents>b__32_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

			[Address(RVA = "0x1C75A20", Offset = "0x1C74C20", Length = "0x97")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6001084")]
			internal EventBase <ProcessTabEvent>b__39_0(ValueTuple<Direction, EventModifiers, IInput> t) { }

			[Address(RVA = "0x1C75B10", Offset = "0x1C74D10", Length = "0x1B4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
			[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001082")]
			internal EventBase <ProcessTouchEvents>b__31_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Touch, Int32, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x1C75CD0", Offset = "0x1C74ED0", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
			[Token(Token = "0x6001079")]
			internal EventBase <SendIMGUIEvents>b__28_0(Event e) { }

			[Address(RVA = "0x1C75D20", Offset = "0x1C74F20", Length = "0xA2")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(EventModifiers)}, ReturnType = typeof(WheelEvent))]
			[Token(Token = "0x600107A")]
			internal EventBase <SendIMGUIEvents>b__28_1(Vector3 panelPosition, Vector3 _, ValueTuple<EventModifiers, Vector2> t) { }

			[Address(RVA = "0x1C75DD0", Offset = "0x1C74FD0", Length = "0xA8")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Event), Member = "set_mousePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Event), Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600107B")]
			internal EventBase <SendIMGUIEvents>b__28_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

			[Address(RVA = "0x1C75E80", Offset = "0x1C75080", Length = "0x8A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x600107F")]
			internal EventBase <SendInputEvents>b__30_0(LegacyInputProcessor self) { }

			[Address(RVA = "0x1C75F10", Offset = "0x1C75110", Length = "0xA0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6001080")]
			internal EventBase <SendInputEvents>b__30_1(LegacyInputProcessor self) { }

			[Address(RVA = "0x1C75FC0", Offset = "0x1C751C0", Length = "0xA0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6001081")]
			internal EventBase <SendInputEvents>b__30_2(LegacyInputProcessor self) { }

		}

		[Token(Token = "0x2000259")]
		public interface IInput
		{

			[Token(Token = "0x170002FD")]
			public bool anyKey
			{
				[Token(Token = "0x6001056")]
				 get { } //Length: 0
			}

			[Token(Token = "0x170002FF")]
			public float doubleClickTime
			{
				[Token(Token = "0x6001058")]
				 get { } //Length: 0
			}

			[Token(Token = "0x170002FC")]
			public int mouseButtonCount
			{
				[Token(Token = "0x6001055")]
				 get { } //Length: 0
			}

			[Token(Token = "0x170002FB")]
			public Vector3 mousePosition
			{
				[Token(Token = "0x6001054")]
				 get { } //Length: 0
			}

			[Token(Token = "0x170002FA")]
			public bool mousePresent
			{
				[Token(Token = "0x6001051")]
				 get { } //Length: 0
			}

			[Token(Token = "0x170002F9")]
			public int touchCount
			{
				[Token(Token = "0x600104F")]
				 get { } //Length: 0
			}

			[Token(Token = "0x170002FE")]
			public float unscaledTime
			{
				[Token(Token = "0x6001057")]
				 get { } //Length: 0
			}

			[Token(Token = "0x600104D")]
			public void ClearLastPenContactEvent() { }

			[Token(Token = "0x6001056")]
			public bool get_anyKey() { }

			[Token(Token = "0x6001058")]
			public float get_doubleClickTime() { }

			[Token(Token = "0x6001055")]
			public int get_mouseButtonCount() { }

			[Token(Token = "0x6001054")]
			public Vector3 get_mousePosition() { }

			[Token(Token = "0x6001051")]
			public bool get_mousePresent() { }

			[Token(Token = "0x600104F")]
			public int get_touchCount() { }

			[Token(Token = "0x6001057")]
			public float get_unscaledTime() { }

			[Token(Token = "0x600104C")]
			public float GetAxisRaw(string axis) { }

			[Token(Token = "0x600104B")]
			public bool GetButtonDown(string button) { }

			[Token(Token = "0x600104E")]
			public PenData GetLastPenContactEvent() { }

			[Token(Token = "0x6001052")]
			public bool GetMouseButtonDown(int button) { }

			[Token(Token = "0x6001053")]
			public bool GetMouseButtonUp(int button) { }

			[Token(Token = "0x6001050")]
			public Touch GetTouch(int index) { }

		}

		[Token(Token = "0x200025A")]
		private class Input : IInput
		{

			[Token(Token = "0x17000304")]
			public override bool anyKey
			{
				[Address(RVA = "0x488DC0", Offset = "0x487FC0", Length = "0x7")]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(Input), Member = "get_anyKey", ReturnType = typeof(bool))]
				[DeduplicatedMethod]
				[Token(Token = "0x6001064")]
				 get { } //Length: 7
			}

			[Token(Token = "0x17000306")]
			public override float doubleClickTime
			{
				[Address(RVA = "0x1C6CAD0", Offset = "0x1C6BCD0", Length = "0x1F")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
				[Token(Token = "0x6001066")]
				 get { } //Length: 31
			}

			[Token(Token = "0x17000303")]
			public override int mouseButtonCount
			{
				[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001063")]
				 get { } //Length: 6
			}

			[Token(Token = "0x17000302")]
			public override Vector3 mousePosition
			{
				[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
				[DeduplicatedMethod]
				[Token(Token = "0x6001062")]
				 get { } //Length: 44
			}

			[Token(Token = "0x17000301")]
			public override bool mousePresent
			{
				[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
				[DeduplicatedMethod]
				[Token(Token = "0x600105F")]
				 get { } //Length: 7
			}

			[Token(Token = "0x17000300")]
			public override int touchCount
			{
				[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
				[DeduplicatedMethod]
				[Token(Token = "0x600105D")]
				 get { } //Length: 7
			}

			[Token(Token = "0x17000305")]
			public override float unscaledTime
			{
				[Address(RVA = "0x1C6CAF0", Offset = "0x1C6BCF0", Length = "0x7")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
				[Token(Token = "0x6001065")]
				 get { } //Length: 7
			}

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001067")]
			public Input() { }

			[Address(RVA = "0x1C6CAB0", Offset = "0x1C6BCB0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "ClearLastPenContactEvent", ReturnType = typeof(void))]
			[Token(Token = "0x600105B")]
			public override void ClearLastPenContactEvent() { }

			[Address(RVA = "0x488DC0", Offset = "0x487FC0", Length = "0x7")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Input), Member = "get_anyKey", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x6001064")]
			public override bool get_anyKey() { }

			[Address(RVA = "0x1C6CAD0", Offset = "0x1C6BCD0", Length = "0x1F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
			[Token(Token = "0x6001066")]
			public override float get_doubleClickTime() { }

			[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001063")]
			public override int get_mouseButtonCount() { }

			[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
			[DeduplicatedMethod]
			[Token(Token = "0x6001062")]
			public override Vector3 get_mousePosition() { }

			[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x600105F")]
			public override bool get_mousePresent() { }

			[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
			[DeduplicatedMethod]
			[Token(Token = "0x600105D")]
			public override int get_touchCount() { }

			[Address(RVA = "0x1C6CAF0", Offset = "0x1C6BCF0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
			[Token(Token = "0x6001065")]
			public override float get_unscaledTime() { }

			[Address(RVA = "0x1C6CAC0", Offset = "0x1C6BCC0", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
			[Token(Token = "0x600105A")]
			public override float GetAxisRaw(string axis) { }

			[Address(RVA = "0x19D7060", Offset = "0x19D6260", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x6001059")]
			public override bool GetButtonDown(string button) { }

			[Address(RVA = "0x19D7080", Offset = "0x19D6280", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
			[DeduplicatedMethod]
			[Token(Token = "0x600105C")]
			public override PenData GetLastPenContactEvent() { }

			[Address(RVA = "0x561D50", Offset = "0x560F50", Length = "0x9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x6001060")]
			public override bool GetMouseButtonDown(int button) { }

			[Address(RVA = "0x561D60", Offset = "0x560F60", Length = "0x9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x6001061")]
			public override bool GetMouseButtonUp(int button) { }

			[Address(RVA = "0x5C4AE0", Offset = "0x5C3CE0", Length = "0x46")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
			[DeduplicatedMethod]
			[Token(Token = "0x600105E")]
			public override Touch GetTouch(int index) { }

		}

		[Token(Token = "0x200025B")]
		private class NoInput : IInput
		{

			[Token(Token = "0x1700030B")]
			public override bool anyKey
			{
				[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
				[CallerCount(Count = 137)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001073")]
				 get { } //Length: 3
			}

			[Token(Token = "0x1700030D")]
			public override float doubleClickTime
			{
				[Address(RVA = "0x1C70FD0", Offset = "0x1C701D0", Length = "0x9")]
				[CallerCount(Count = 0)]
				[Token(Token = "0x6001075")]
				 get { } //Length: 9
			}

			[Token(Token = "0x1700030A")]
			public override int mouseButtonCount
			{
				[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
				[CallerCount(Count = 51)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001072")]
				 get { } //Length: 3
			}

			[Token(Token = "0x17000309")]
			public override Vector3 mousePosition
			{
				[Address(RVA = "0x40F330", Offset = "0x40E530", Length = "0xC")]
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001071")]
				 get { } //Length: 12
			}

			[Token(Token = "0x17000308")]
			public override bool mousePresent
			{
				[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
				[CallerCount(Count = 137)]
				[DeduplicatedMethod]
				[Token(Token = "0x600106E")]
				 get { } //Length: 3
			}

			[Token(Token = "0x17000307")]
			public override int touchCount
			{
				[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
				[CallerCount(Count = 51)]
				[DeduplicatedMethod]
				[Token(Token = "0x600106A")]
				 get { } //Length: 3
			}

			[Token(Token = "0x1700030C")]
			public override float unscaledTime
			{
				[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001074")]
				 get { } //Length: 4
			}

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001076")]
			public NoInput() { }

			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DeduplicatedMethod]
			[Token(Token = "0x600106C")]
			public override void ClearLastPenContactEvent() { }

			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001073")]
			public override bool get_anyKey() { }

			[Address(RVA = "0x1C70FD0", Offset = "0x1C701D0", Length = "0x9")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6001075")]
			public override float get_doubleClickTime() { }

			[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
			[CallerCount(Count = 51)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001072")]
			public override int get_mouseButtonCount() { }

			[Address(RVA = "0x40F330", Offset = "0x40E530", Length = "0xC")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001071")]
			public override Vector3 get_mousePosition() { }

			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600106E")]
			public override bool get_mousePresent() { }

			[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
			[CallerCount(Count = 51)]
			[DeduplicatedMethod]
			[Token(Token = "0x600106A")]
			public override int get_touchCount() { }

			[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001074")]
			public override float get_unscaledTime() { }

			[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001069")]
			public override float GetAxisRaw(string axis) { }

			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001068")]
			public override bool GetButtonDown(string button) { }

			[Address(RVA = "0x18FB020", Offset = "0x18FA220", Length = "0x14")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600106D")]
			public override PenData GetLastPenContactEvent() { }

			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600106F")]
			public override bool GetMouseButtonDown(int button) { }

			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001070")]
			public override bool GetMouseButtonUp(int button) { }

			[Address(RVA = "0x1C70FB0", Offset = "0x1C701B0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x600106B")]
			public override Touch GetTouch(int index) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400092A")]
		private bool m_SendingTouchEvents; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x400092B")]
		private bool m_SendingPenEvent; //Field offset: 0x11
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400092C")]
		private EventModifiers m_CurrentModifiers; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400092D")]
		private int m_LastMousePressButton; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400092E")]
		private float m_NextMousePressTime; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400092F")]
		private int m_LastMouseClickCount; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000930")]
		private Vector2 m_LastMousePosition; //Field offset: 0x24
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000931")]
		private bool m_MouseProcessedAtLeastOnce; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000932")]
		private Dictionary<Int32, Int32> m_TouchFingerIdToFingerIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000933")]
		private int m_TouchNextFingerIndex; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000934")]
		private IInput m_Input; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000935")]
		private readonly Event m_Event; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000936")]
		private readonly DefaultEventSystem m_EventSystem; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000937")]
		private int m_ConsecutiveMoveCount; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000938")]
		private Vector2 m_LastMoveVector; //Field offset: 0x5C
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000939")]
		private float m_PrevActionTime; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400093A")]
		private bool m_IsMoveFromKeyboard; //Field offset: 0x68

		[Token(Token = "0x170002F8")]
		public IInput input
		{
			[Address(RVA = "0x1C6F960", Offset = "0x1C6EB60", Length = "0x3F")]
			[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x600103D")]
			 get { } //Length: 63
		}

		[Token(Token = "0x170002F7")]
		private EventModifiers m_CurrentPointerModifiers
		{
			[Address(RVA = "0x1C6F9A0", Offset = "0x1C6EBA0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x600103C")]
			private get { } //Length: 7
		}

		[Address(RVA = "0x1C6F840", Offset = "0x1C6EA40", Length = "0x11C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600103E")]
		public LegacyInputProcessor(DefaultEventSystem eventSystem) { }

		[Address(RVA = "0x1C6F960", Offset = "0x1C6EB60", Length = "0x3F")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600103D")]
		public IInput get_input() { }

		[Address(RVA = "0x1C6F9A0", Offset = "0x1C6EBA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600103C")]
		private EventModifiers get_m_CurrentPointerModifiers() { }

		[Address(RVA = "0x1C6CB00", Offset = "0x1C6BD00", Length = "0xE3")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendInputEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessPenEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "get_input", ReturnType = typeof(IInput))]
		[CalledBy(Type = typeof(<>c), Member = "<SendInputEvents>b__30_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
		[CalledBy(Type = typeof(<>c), Member = "<SendInputEvents>b__30_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180188EA0")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600103F")]
		public IInput GetDefaultInput() { }

		[Address(RVA = "0x1C6CBF0", Offset = "0x1C6BDF0", Length = "0x1FD")]
		[CalledBy(Type = typeof(<>c), Member = "<SendInputEvents>b__30_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180188EA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001046")]
		private Vector2 GetRawMoveVector() { }

		[Address(RVA = "0x1C6CDF0", Offset = "0x1C6BFF0", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
		[Token(Token = "0x600104A")]
		private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers, int targetDisplay) { }

		[Address(RVA = "0x1C6CED0", Offset = "0x1C6C0D0", Length = "0x10C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(EventModifiers), typeof(int)}, ReturnType = "T")]
		[Token(Token = "0x6001049")]
		private static EventBase MakeTouchEvent(Touch touch, int pointerId, EventModifiers modifiers, int targetDisplay) { }

		[Address(RVA = "0x1C6CFE0", Offset = "0x1C6C1E0", Length = "0x163")]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessPenEvents", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "SendInputEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C63090")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001040")]
		public void ProcessLegacyInputEvents() { }

		[Address(RVA = "0x1C6D150", Offset = "0x1C6C350", Length = "0xB0A")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Int32Enum", typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "get_input", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Func`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`4<System.Int32, System.Int32, System.Int32Enum, System.Nullable`1<System.Int32>>), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001042")]
		private void ProcessMouseEvents() { }

		[Address(RVA = "0x1C6DC60", Offset = "0x1C6CE60", Length = "0x3B6")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.PenData, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PenData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.PenData, UnityEngine.UIElements.EventBase>), typeof(PenData), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001045")]
		private bool ProcessPenEvents() { }

		[Address(RVA = "0x1C6E020", Offset = "0x1C6D220", Length = "0x1D0")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(ValueTuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001048")]
		private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

		[Address(RVA = "0x1C6E200", Offset = "0x1C6D400", Length = "0x724")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Touch), Member = "get_rawPosition", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.Touch, System.Int32, System.Nullable`1<System.Int32>>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`3<UnityEngine.Touch, System.Int32, System.Nullable`1<System.Int32>>, UnityEngine.UIElements.EventBase>), typeof(System.ValueTuple`3<UnityEngine.Touch, System.Int32, System.Nullable`1<System.Int32>>), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Touch, System.Int32, System.Nullable`1<System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(int), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.ValueTuple`3<UnityEngine.Touch, System.Int32, System.Nullable`1<System.Int32>>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "ScreenBottomLeftToPanelDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001044")]
		private bool ProcessTouchEvents() { }

		[Address(RVA = "0x1C6E930", Offset = "0x1C6DB30", Length = "0x891")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "get_delta", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Func`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "get_input", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Object, UnityEngine.UIElements.EventBase>), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Func`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Event), Member = "get_pointerType", ReturnType = typeof(PointerType))]
		[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
		[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
		[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayToLocalScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, UnityEngine.UIElements.EventBase>), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001041")]
		private void SendIMGUIEvents() { }

		[Address(RVA = "0x1C6F1D0", Offset = "0x1C6E3D0", Length = "0x38E")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, UnityEngine.UIElements.EventBase>), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6001043")]
		private void SendInputEvents() { }

		[Address(RVA = "0x1C6F560", Offset = "0x1C6E760", Length = "0x2DE")]
		[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendInputEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(LegacyInputProcessor), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NavigationMoveEvent), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Direction))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001047")]
		private bool ShouldSendMoveFromInput() { }

	}

	[Token(Token = "0x2000253")]
	internal enum UpdateMode
	{
		Always = 0,
		IgnoreIfAppNotFocused = 1,
	}

	[Token(Token = "0x4000901")]
	internal static Func<Boolean> IsEditorRemoteConnected; //Field offset: 0x0
	[Token(Token = "0x4000910")]
	private static readonly Vector3 s_InvalidPanelCoordinates; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000902")]
	private RuntimePanel m_FocusedPanel; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000903")]
	private RuntimePanel m_PreviousFocusedPanel; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000904")]
	private Focusable m_PreviousFocusedElement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000905")]
	private int m_UpdateFrameCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000906")]
	private LegacyInputProcessor m_LegacyInputProcessor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000907")]
	private InputForUIProcessor m_InputForUIProcessor; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000908")]
	private bool m_IsInputReady; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000909")]
	private bool m_UseInputForUI; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x400090A")]
	private bool m_IsInputForUIActive; //Field offset: 0x42
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400090B")]
	private IScreenRaycaster m_Raycaster; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400090C")]
	private readonly PhysicsDocumentPicker m_WorldSpacePicker; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400090D")]
	private readonly ScreenOverlayPanelPicker m_ScreenOverlayPicker; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400090E")]
	public float worldSpaceMaxDistance; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400090F")]
	public int worldSpaceLayers; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000911")]
	internal bool verbose; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000912")]
	internal bool logToGameScreen; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000913")]
	private Label m_LogLabel; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000914")]
	private List<String> m_LogLines; //Field offset: 0x78

	[Token(Token = "0x170002F2")]
	public RuntimePanel focusedPanel
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001005")]
		 get { } //Length: 5
		[Address(RVA = "0x1C65400", Offset = "0x1C64600", Length = "0x51")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001006")]
		 set { } //Length: 81
	}

	[Token(Token = "0x170002F4")]
	private InputForUIProcessor inputForUIProcessor
	{
		[Address(RVA = "0x1C65FA0", Offset = "0x1C651A0", Length = "0x12C")]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "RemoveInputProcessor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "InitInputProcessor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001009")]
		private get { } //Length: 300
	}

	[Token(Token = "0x170002F1")]
	private bool isAppFocused
	{
		[Address(RVA = "0x1C660D0", Offset = "0x1C652D0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
		[Token(Token = "0x6001003")]
		private get { } //Length: 64
	}

	[Token(Token = "0x170002F5")]
	internal bool isInputReady
	{
		[Address(RVA = "0x1C66340", Offset = "0x1C65540", Length = "0xE3")]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdateEventSystem", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisableRenderingAndInputCallbacks", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultEventSystem), Member = "InitInputProcessor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600100A")]
		internal set { } //Length: 227
	}

	[Token(Token = "0x170002F3")]
	internal LegacyInputProcessor legacyInputProcessor
	{
		[Address(RVA = "0x1C66110", Offset = "0x1C65310", Length = "0x166")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001008")]
		internal get { } //Length: 358
	}

	[Token(Token = "0x170002F6")]
	public IScreenRaycaster raycaster
	{
		[Address(RVA = "0x1C66280", Offset = "0x1C65480", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(MainCameraScreenRaycaster), Member = "ResolveCamera", ReturnType = typeof(void))]
		[Token(Token = "0x6001013")]
		 get { } //Length: 177
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001014")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1C65DA0", Offset = "0x1C64FA0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600101E")]
	private static DefaultEventSystem() { }

	[Address(RVA = "0x1C65E90", Offset = "0x1C65090", Length = "0x106")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600101D")]
	public DefaultEventSystem() { }

	[Address(RVA = "0x1C63AB0", Offset = "0x1C62CB0", Length = "0xAC0")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MainCameraScreenRaycaster), Member = "ResolveCamera", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "ScreenToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector3&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ScreenOverlayPanelPicker), Member = "TryPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(int), typeof(Vector2), typeof(Vector2), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedScreenOverlayPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetScreenPointerState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ScreenPointerState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001015")]
	internal void FindTargetAtPosition(Vector2 mousePosition, Vector2 delta, int pointerId, Nullable<Int32> targetDisplay, out VisualElement target, out RuntimePanel targetPanel, out Vector3 targetPanelPosition, out VisualElement elementUnderPointer, out Camera camera) { }

	[Address(RVA = "0x1C64580", Offset = "0x1C63780", Length = "0x541")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetTrackedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(TrackedPointerState))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001016")]
	internal void FindTargetAtRay(Ray worldRay, float maxDistance, int pointerId, out VisualElement target, out RuntimePanel targetPanel, out Vector3 targetPanelPosition, out VisualElement elementUnderPointer) { }

	[Address(RVA = "0x1C64AD0", Offset = "0x1C63CD0", Length = "0x80")]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600100B")]
	internal FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001005")]
	public RuntimePanel get_focusedPanel() { }

	[Address(RVA = "0x1C65FA0", Offset = "0x1C651A0", Length = "0x12C")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "RemoveInputProcessor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001009")]
	private InputForUIProcessor get_inputForUIProcessor() { }

	[Address(RVA = "0x1C660D0", Offset = "0x1C652D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	[Token(Token = "0x6001003")]
	private bool get_isAppFocused() { }

	[Address(RVA = "0x1C66110", Offset = "0x1C65310", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001008")]
	internal LegacyInputProcessor get_legacyInputProcessor() { }

	[Address(RVA = "0x1C66280", Offset = "0x1C65480", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MainCameraScreenRaycaster), Member = "ResolveCamera", ReturnType = typeof(void))]
	[Token(Token = "0x6001013")]
	public IScreenRaycaster get_raycaster() { }

	[Address(RVA = "0x1C64B60", Offset = "0x1C63D60", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001017")]
	private Vector3 GetPanelPosition(VisualElement pickedElement, UIDocument document, Ray worldRay) { }

	[Address(RVA = "0x1C64CE0", Offset = "0x1C63EE0", Length = "0x1CA")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600100D")]
	private void InitInputProcessor() { }

	[Address(RVA = "0x1C65360", Offset = "0x1C64560", Length = "0x9D")]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.CommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessIMECompositionEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.IMECompositionEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600101A")]
	private void Log(object o) { }

	[Address(RVA = "0x1C64EB0", Offset = "0x1C640B0", Length = "0x3EC")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "FindFirstObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600101C")]
	private void LogToGameScreen(string s) { }

	[Address(RVA = "0x1C652A0", Offset = "0x1C644A0", Length = "0xB4")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "GetDefaultInput", ReturnType = typeof(IInput))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600101B")]
	private void LogWarning(object o) { }

	[Address(RVA = "0x1C65400", Offset = "0x1C64600", Length = "0x51")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600100E")]
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	[Address(RVA = "0x1C65460", Offset = "0x1C64660", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600100C")]
	private void RemoveInputProcessor() { }

	[Address(RVA = "0x697DC0", Offset = "0x696FC0", Length = "0x495")]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessNavigationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.KeyEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.TextInputEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "get_focusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600100F")]
	internal void SendFocusBasedEvent(Func<TArg, EventBase> evtFactory, TArg arg) { }

	[Address(RVA = "0x69AAC0", Offset = "0x699CC0", Length = "0x29D")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ValueTuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001010")]
	internal void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<Int32> targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[Address(RVA = "0x69AD60", Offset = "0x699F60", Length = "0x5D7")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_processedByFocusController", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001011")]
	internal void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<Int32> targetDisplay, Func<Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[Address(RVA = "0x69D6A0", Offset = "0x69C8A0", Length = "0x5D4")]
	[CalledBy(Type = typeof(InputForUIProcessor), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_processedByFocusController", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001012")]
	internal void SendRayBasedEvent(Ray worldRay, float maxDistance, int pointerId, Func<Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[Address(RVA = "0x1C65400", Offset = "0x1C64600", Length = "0x51")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001006")]
	public void set_focusedPanel(RuntimePanel value) { }

	[Address(RVA = "0x1C66340", Offset = "0x1C65540", Length = "0xE3")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdateEventSystem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisableRenderingAndInputCallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600100A")]
	internal void set_isInputReady(bool value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001014")]
	public void set_raycaster(IScreenRaycaster value) { }

	[Address(RVA = "0x1C65520", Offset = "0x1C64720", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001004")]
	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	[Address(RVA = "0x1C65B60", Offset = "0x1C64D60", Length = "0x230")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdateEventSystem", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LegacyInputProcessor), Member = "ProcessLegacyInputEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "get_inputForUIProcessor", ReturnType = typeof(InputForUIProcessor))]
	[Calls(Type = typeof(InputForUIProcessor), Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001007")]
	public void Update(UpdateMode updateMode = 0) { }

	[Address(RVA = "0x1C65540", Offset = "0x1C64740", Length = "0xDD")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001018")]
	private void UpdateFocusedPanel(RuntimePanel runtimePanel) { }

	[Address(RVA = "0x1C65620", Offset = "0x1C64820", Length = "0x538")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPointerState), Member = "get_worldRay", ReturnType = typeof(Ray))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetTrackedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(TrackedPointerState))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetScreenPointerState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ScreenPointerState))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetWorldSpacePlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001019")]
	private void UpdateWorldSpacePointers() { }

}

