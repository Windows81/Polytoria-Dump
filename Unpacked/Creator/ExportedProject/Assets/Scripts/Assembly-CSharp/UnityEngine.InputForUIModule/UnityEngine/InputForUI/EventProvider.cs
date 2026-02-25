namespace UnityEngine.InputForUI;

[Token(Token = "0x200001D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class EventProvider
{
	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private sealed class <>c
	{
		[Token(Token = "0x40000B2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000B3")]
		public static Comparison<Registration> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x19D8EB0", Offset = "0x19D80B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000078")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000079")]
		public <>c() { }

		[Address(RVA = "0x19D8E70", Offset = "0x19D8070", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x600007A")]
		internal int <Subscribe>b__7_0(Registration a, Registration b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B4")]
		public EventConsumer handler; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x19D8E90", Offset = "0x19D8090", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600007C")]
		internal bool <Unsubscribe>b__0(Registration x) { }

	}

	[Token(Token = "0x200001E")]
	private struct Registration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		public EventConsumer handler; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AF")]
		public int priority; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000B0")]
		public Nullable<Int32> playerId; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B1")]
		public HashSet<Type> _types; //Field offset: 0x18

	}

	[Token(Token = "0x40000A7")]
	private static IEventProviderImpl s_impl; //Field offset: 0x0
	[Token(Token = "0x40000A8")]
	private static EventSanitizer s_sanitizer; //Field offset: 0x8
	[Token(Token = "0x40000A9")]
	private static IEventProviderImpl s_implMockBackup; //Field offset: 0x10
	[Token(Token = "0x40000AA")]
	private static bool s_focusChangedRegistered; //Field offset: 0x18
	[Token(Token = "0x40000AB")]
	private static bool m_IsEnabled; //Field offset: 0x19
	[Token(Token = "0x40000AC")]
	private static bool m_IsInitialized; //Field offset: 0x1A
	[Token(Token = "0x40000AD")]
	private static List<Registration> _registrations; //Field offset: 0x20

	[Address(RVA = "0x19D1360", Offset = "0x19D0560", Length = "0x128")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InputManagerProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000077")]
	private static EventProvider() { }

	[Address(RVA = "0x19D04E0", Offset = "0x19CF6E0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[Token(Token = "0x6000072")]
	private static void Bootstrap() { }

	[Address(RVA = "0x19D0550", Offset = "0x19CF750", Length = "0x281")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckIfIMEChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "NextPreviousNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSanitizer), Member = "Inspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000071")]
	internal static void Dispatch(in Event ev) { }

	[Address(RVA = "0x19D07E0", Offset = "0x19CF9E0", Length = "0x193")]
	[CalledBy(Type = typeof(EventProvider), Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventConsumer), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(Type[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventProvider), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventProvider), Member = "Bootstrap", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Application), Member = "add_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000073")]
	private static void Initialize() { }

	[Address(RVA = "0x19D0980", Offset = "0x19CFB80", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSanitizer), Member = "BeforeProviderUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(EventSanitizer), Member = "AfterProviderUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000076")]
	internal static void NotifyUpdate() { }

	[Address(RVA = "0x19D0AE0", Offset = "0x19CFCE0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000075")]
	private static void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x19D0BD0", Offset = "0x19CFDD0", Length = "0x1E2")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "RemoveInputProcessor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Application), Member = "remove_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public static void SetEnabled(bool enable) { }

	[Address(RVA = "0x19D0DC0", Offset = "0x19CFFC0", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Application), Member = "remove_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	private static void Shutdown() { }

	[Address(RVA = "0x19D0F30", Offset = "0x19D0130", Length = "0x31F")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006E")]
	public static void Subscribe(EventConsumer handler, int priority = 0, Nullable<Int32> playerId = null, Type[] type) { }

	[Address(RVA = "0x19D1250", Offset = "0x19D0450", Length = "0x109")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "RemoveInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600006F")]
	public static void Unsubscribe(EventConsumer handler) { }

}

