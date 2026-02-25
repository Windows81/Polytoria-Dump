namespace UnityEngine.UIElements;

[Token(Token = "0x20001C8")]
internal class EventCallbackRegistry
{
	[Token(Token = "0x20001C9")]
	public struct DynamicCallbackList
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000818")]
		private TrickleDown m_UseTrickleDown; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NotNull]
		[Token(Token = "0x4000819")]
		private EventCallbackList m_Callbacks; //Field offset: 0x8
		[CanBeNull]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400081A")]
		private EventCallbackList m_TemporaryCallbacks; //Field offset: 0x10
		[CanBeNull]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400081B")]
		private List<EventCallbackFunctorBase> m_UnregisteredCallbacksDuringInvoke; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400081C")]
		private int m_IsInvoking; //Field offset: 0x20

		[Address(RVA = "0x1C4AD40", Offset = "0x1C49F40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000CF5")]
		private void BeginInvoke() { }

		[Address(RVA = "0x1C4AD50", Offset = "0x1C49F50", Length = "0xE1")]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000CF0")]
		public static DynamicCallbackList Create(TrickleDown useTrickleDown) { }

		[Address(RVA = "0x1C4AE40", Offset = "0x1C4A040", Length = "0x23D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "ReleaseCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "GetCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000CF6")]
		private void EndInvoke() { }

		[Address(RVA = "0x1C4B080", Offset = "0x1C4A280", Length = "0xE")]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[IsReadOnly]
		[NotNull]
		[Token(Token = "0x6000CF2")]
		public EventCallbackList GetCallbackListForReading() { }

		[Address(RVA = "0x1C4B090", Offset = "0x1C4A290", Length = "0xF2")]
		[CalledBy(Type = typeof(DynamicCallbackList), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "GetCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[NotNull]
		[Token(Token = "0x6000CF1")]
		public EventCallbackList GetCallbackListForWriting() { }

		[Address(RVA = "0x1C4B190", Offset = "0x1C4A390", Length = "0x2B6")]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_TrickleDownCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C48270")]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CF4")]
		public void Invoke(EventBase evt, BaseVisualElementPanel panel, VisualElement target) { }

		[Address(RVA = "0x1C4B450", Offset = "0x1C4A650", Length = "0x261")]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000CF3")]
		public bool UnregisterCallback(long eventTypeId, Delegate callback) { }

	}

	[Token(Token = "0x4000815")]
	private static readonly EventCallbackListPool s_ListPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000816")]
	internal DynamicCallbackList m_TrickleDownCallbacks; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000817")]
	internal DynamicCallbackList m_BubbleUpCallbacks; //Field offset: 0x38

	[Address(RVA = "0x1C4D9D0", Offset = "0x1C4CBD0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CEF")]
	private static EventCallbackRegistry() { }

	[Address(RVA = "0x1C4DAB0", Offset = "0x1C4CCB0", Length = "0x81")]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CEE")]
	public EventCallbackRegistry() { }

	[Address(RVA = "0x1C4D880", Offset = "0x1C4CA80", Length = "0x68")]
	[CalledBy(Type = "UnityEngine.UIElements.TabView+ViewState", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "EndInvoke", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventCallbackListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CE7")]
	private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) { }

	[Address(RVA = "0x1C4D8F0", Offset = "0x1C4CAF0", Length = "0x18")]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000CE9")]
	private DynamicCallbackList GetDynamicCallbackList(TrickleDown useTrickleDown) { }

	[Address(RVA = "0x6AC730", Offset = "0x6AB930", Length = "0x143")]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventCallbackList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackFunctorBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForReading", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackList), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(EventCallbackFunctorBase))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackFunctor`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy)}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`1<TEventType>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEA")]
	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0x6AC5C0", Offset = "0x6AB7C0", Length = "0x161")]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(EventCallbackList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackFunctorBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForReading", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackList), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(EventCallbackFunctorBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackFunctor`2), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(InvokePolicy)}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`2<TEventType, TCallbackArgs>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEB")]
	public void RegisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0x1C4D910", Offset = "0x1C4CB10", Length = "0xB8")]
	[CalledBy(Type = "UnityEngine.UIElements.TabView+ViewState", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "EndInvoke", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CE8")]
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	[Address(RVA = "0x6AC880", Offset = "0x6ABA80", Length = "0x9A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicCallbackList), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEC")]
	public bool UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x6AC880", Offset = "0x6ABA80", Length = "0x9A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicCallbackList), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CED")]
	public bool UnregisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown = 0) { }

}

