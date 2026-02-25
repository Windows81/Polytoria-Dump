namespace UnityEngine.UIElements;

[Token(Token = "0x2000271")]
internal class RuntimePanel : BaseRuntimePanel, IRuntimePanel, IPanel, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000272")]
	private sealed class <>c
	{
		[Token(Token = "0x40009AF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009B0")]
		public static EventCallback<FocusEvent, RuntimePanel> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x1C76210", Offset = "0x1C75410", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001127")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001128")]
		public <>c() { }

		[Address(RVA = "0x1C760C0", Offset = "0x1C752C0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
		[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001129")]
		internal void <.ctor>b__8_0(FocusEvent e, RuntimePanel p) { }

	}

	[Token(Token = "0x40009AC")]
	internal static readonly EventDispatcher s_EventDispatcher; //Field offset: 0x0
	[Token(Token = "0x40009AE")]
	private static readonly List<UIDocument> s_EmptyDocumentList; //Field offset: 0x8
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40009AD")]
	private readonly PanelSettings m_PanelSettings; //Field offset: 0x1F8

	[Token(Token = "0x17000344")]
	public override PanelSettings panelSettings
	{
		[Address(RVA = "0x1C74BF0", Offset = "0x1C73DF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001121")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1C746D0", Offset = "0x1C738D0", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001126")]
	private static RuntimePanel() { }

	[Address(RVA = "0x1C747C0", Offset = "0x1C739C0", Length = "0x427")]
	[CalledBy(Type = typeof(RuntimePanel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(RuntimePanel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseRuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Panel), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001123")]
	private RuntimePanel(ScriptableObject ownerObject) { }

	[Address(RVA = "0x1C74540", Offset = "0x1C73740", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001122")]
	public static RuntimePanel Create(ScriptableObject ownerObject) { }

	[Address(RVA = "0x1C74BF0", Offset = "0x1C73DF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001121")]
	public override PanelSettings get_panelSettings() { }

	[Address(RVA = "0x1C745A0", Offset = "0x1C737A0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
	[Calls(Type = typeof(Panel), Member = "Blur", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Panel), Member = "Focus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001125")]
	private void OnElementFocus(FocusEvent evt) { }

	[Address(RVA = "0x1C74640", Offset = "0x1C73840", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001124")]
	internal virtual void Update() { }

}

