namespace UnityEngine.UIElements;

[Token(Token = "0x2000152")]
[UxmlElement(null, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Tab)})]
public class TabView : VisualElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000156")]
	private sealed class <>c__DisplayClass81_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006DA")]
		public string key; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7F")]
		public <>c__DisplayClass81_0() { }

		[Address(RVA = "0x1C45370", Offset = "0x1C44570", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A80")]
		internal bool <FindTabByKey>b__0(Tab tab) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000153")]
	internal class UxmlFactory : UxmlFactory<TabView, UxmlTraits>
	{

		[Address(RVA = "0x1C46E30", Offset = "0x1C46030", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000A77")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000154")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40006D6")]
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x88

		[Address(RVA = "0x1C47A10", Offset = "0x1C46C10", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A79")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C471D0", Offset = "0x1C463D0", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TabView), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A78")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x2000155")]
	private class ViewState : ISerializationCallbackReceiver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006D7")]
		private bool m_HasPersistedData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40006D8")]
		private List<String> m_TabOrder; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40006D9")]
		private string m_ActiveTabKey; //Field offset: 0x20

		[Address(RVA = "0x1C47FD0", Offset = "0x1C471D0", Length = "0x68A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "ReleaseCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "GetCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
		[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C48900")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A7E")]
		public ViewState() { }

		[Address(RVA = "0x1C47C20", Offset = "0x1C46E20", Length = "0x196")]
		[CalledBy(Type = typeof(TabView), Member = "OnViewDataReady", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(TabView), Member = "FindTabByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Tab))]
		[Calls(Type = typeof(TabView), Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A7B")]
		internal void Apply(TabView tabView) { }

		[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7D")]
		public override void OnAfterDeserialize() { }

		[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7C")]
		public override void OnBeforeSerialize() { }

		[Address(RVA = "0x1C47DC0", Offset = "0x1C46FC0", Length = "0x203")]
		[CalledBy(Type = typeof(TabView), Member = "SaveViewState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000A7A")]
		internal void Save(TabView tabView) { }

	}

	[Token(Token = "0x40006BE")]
	internal static readonly BindingId reorderableProperty; //Field offset: 0x0
	[Token(Token = "0x40006BF")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x40006C0")]
	public static readonly string headerContainerClassName; //Field offset: 0xA0
	[Token(Token = "0x40006C1")]
	public static readonly string contentContainerUssClassName; //Field offset: 0xA8
	[Token(Token = "0x40006C2")]
	public static readonly string reorderableUssClassName; //Field offset: 0xB0
	[Token(Token = "0x40006C3")]
	public static readonly string verticalUssClassName; //Field offset: 0xB8
	[Token(Token = "0x40006C4")]
	public static readonly string viewportUssClassName; //Field offset: 0xC0
	[Token(Token = "0x40006C5")]
	public static readonly string nextButtonUssClassName; //Field offset: 0xC8
	[Token(Token = "0x40006C6")]
	public static readonly string previousButtonUssClassName; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40006C7")]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40006C8")]
	private VisualElement m_HeaderContainer; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40006C9")]
	private VisualElement m_ContentContainer; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40006CA")]
	private List<Tab> m_Tabs; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40006CB")]
	private List<VisualElement> m_TabHeaders; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40006CC")]
	private Tab m_ActiveTab; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x40006CD")]
	private ViewState m_ViewState; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x40006CE")]
	private bool m_ApplyingViewState; //Field offset: 0x308
	[FieldOffset(Offset = "0x309")]
	[Token(Token = "0x40006CF")]
	private bool m_Reordering; //Field offset: 0x309
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x40006D0")]
	private RepeatButton <nextButton>k__BackingField; //Field offset: 0x310
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x40006D1")]
	private RepeatButton <previousButton>k__BackingField; //Field offset: 0x318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x40006D2")]
	private Action<Tab, Tab> activeTabChanged; //Field offset: 0x320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x40006D3")]
	private Action<Int32, Int32> tabReordered; //Field offset: 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x40006D4")]
	private Action<Tab, Int32> tabClosed; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x40006D5")]
	private bool m_Reorderable; //Field offset: 0x338

	[Token(Token = "0x170001CB")]
	public Tab activeTab
	{
		[Address(RVA = "0x1BF7FF0", Offset = "0x1BF71F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A61")]
		 get { } //Length: 8
		[Address(RVA = "0x1C3C660", Offset = "0x1C3B860", Length = "0x1A5")]
		[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ViewState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = "OnElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = "OnTabSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Tab), Member = "SetInactive", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TabView), Member = "SaveViewState", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Tab), Member = "SetActive", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A62")]
		 set { } //Length: 421
	}

	[Token(Token = "0x170001C2")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A56")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001C3")]
	public VisualElement contentViewport
	{
		[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A57")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001C4")]
	internal VisualElement header
	{
		[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A58")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001CA")]
	internal bool needsButtons
	{
		[Address(RVA = "0x1C3C580", Offset = "0x1C3B780", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A60")]
		internal get { } //Length: 107
	}

	[Token(Token = "0x170001C7")]
	internal RepeatButton nextButton
	{
		[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5B")]
		internal get { } //Length: 8
		[Address(RVA = "0x1B36AE0", Offset = "0x1B35CE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5C")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170001C8")]
	internal RepeatButton previousButton
	{
		[Address(RVA = "0x1BF4780", Offset = "0x1BF3980", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5D")]
		internal get { } //Length: 8
		[Address(RVA = "0x1C3C810", Offset = "0x1C3BA10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000A5E")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170001CC")]
	public bool reorderable
	{
		[Address(RVA = "0xF53090", Offset = "0xF52290", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A63")]
		 get { } //Length: 8
		[Address(RVA = "0x1C3C830", Offset = "0x1C3BA30", Length = "0x1B7")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000A64")]
		 set { } //Length: 439
	}

	[Token(Token = "0x170001C9")]
	internal float scrollableWidth
	{
		[Address(RVA = "0x1C3C5F0", Offset = "0x1C3B7F0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A5F")]
		internal get { } //Length: 97
	}

	[Token(Token = "0x170001C6")]
	internal List<VisualElement> tabHeaders
	{
		[Address(RVA = "0x1B2F860", Offset = "0x1B2EA60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001C5")]
	internal List<Tab> tabs
	{
		[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A59")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x1C3B940", Offset = "0x1C3AB40", Length = "0x41A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000A74")]
	private static TabView() { }

	[Address(RVA = "0x1C3BD60", Offset = "0x1C3AF60", Length = "0x815")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "add_elementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.VisualElement, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RepeatButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "add_elementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6000A65")]
	public TabView() { }

	[Address(RVA = "0x1C3B4D0", Offset = "0x1C3A6D0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A75")]
	private bool <OnNextClicked>b__69_0(VisualElement tab) { }

	[Address(RVA = "0x1C3B620", Offset = "0x1C3A820", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A76")]
	private bool <OnPreviousClicked>b__70_0(VisualElement tab) { }

	[Address(RVA = "0x1C3A090", Offset = "0x1C39290", Length = "0xD9")]
	[CalledBy(Type = typeof(ViewState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A73")]
	internal Tab FindTabByKey(string key) { }

	[Address(RVA = "0x1BF7FF0", Offset = "0x1BF71F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A61")]
	public Tab get_activeTab() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A56")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A57")]
	public VisualElement get_contentViewport() { }

	[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A58")]
	internal VisualElement get_header() { }

	[Address(RVA = "0x1C3C580", Offset = "0x1C3B780", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A60")]
	internal bool get_needsButtons() { }

	[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5B")]
	internal RepeatButton get_nextButton() { }

	[Address(RVA = "0x1BF4780", Offset = "0x1BF3980", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5D")]
	internal RepeatButton get_previousButton() { }

	[Address(RVA = "0xF53090", Offset = "0xF52290", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A63")]
	public bool get_reorderable() { }

	[Address(RVA = "0x1C3C5F0", Offset = "0x1C3B7F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A5F")]
	internal float get_scrollableWidth() { }

	[Address(RVA = "0x1B2F860", Offset = "0x1B2EA60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5A")]
	internal List<VisualElement> get_tabHeaders() { }

	[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A59")]
	internal List<Tab> get_tabs() { }

	[Address(RVA = "0x1C3A170", Offset = "0x1C39370", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000A67")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1C3A280", Offset = "0x1C39480", Length = "0x1DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Tab), Member = "add_closed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Tab>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tab), Member = "add_selected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Tab>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TabView), Member = "UpdateIndexes", ReturnType = typeof(void))]
	[Calls(Type = typeof(TabView), Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A6E")]
	private void OnElementAdded(VisualElement ve, int index) { }

	[Address(RVA = "0x1C3A460", Offset = "0x1C39660", Length = "0x1D5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tab), Member = "SetInactive", ReturnType = typeof(void))]
	[Calls(Type = typeof(TabView), Member = "UpdateIndexes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TabView), Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A6F")]
	private void OnElementRemoved(VisualElement ve) { }

	[Address(RVA = "0x1C3A640", Offset = "0x1C39840", Length = "0x392")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D8B0")]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TabView), Member = "UpdateButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A68")]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C3A9E0", Offset = "0x1C39BE0", Length = "0x3E4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[Calls(Type = typeof(TabView), Member = "UpdateButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A69")]
	private void OnNextClicked() { }

	[Address(RVA = "0x1C3ADD0", Offset = "0x1C39FD0", Length = "0x359")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "FindLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[Calls(Type = typeof(TabView), Member = "UpdateButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A6A")]
	private void OnPreviousClicked() { }

	[Address(RVA = "0x1C3B130", Offset = "0x1C3A330", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A71")]
	private void OnTabClosed(Tab tab) { }

	[Address(RVA = "0x1C3B170", Offset = "0x1C3A370", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TabView), Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A70")]
	private void OnTabSelected(Tab tab) { }

	[Address(RVA = "0x1C3B180", Offset = "0x1C3A380", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "GetOrCreateViewData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ViewState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A66")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1C3B270", Offset = "0x1C3A470", Length = "0x216")]
	[CalledBy(Type = typeof(TabLayout), Member = "ReorderDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ViewState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TabView), Member = "UpdateIndexes", ReturnType = typeof(void))]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A72")]
	public void ReorderTab(int from, int to) { }

	[Address(RVA = "0x1C3B490", Offset = "0x1C3A690", Length = "0x3E")]
	[CalledBy(Type = typeof(TabView), Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Token(Token = "0x6000A6C")]
	private void SaveViewState() { }

	[Address(RVA = "0x1C3C660", Offset = "0x1C3B860", Length = "0x1A5")]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ViewState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TabView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnTabSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Tab), Member = "SetActive", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TabView), Member = "SaveViewState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Tab), Member = "SetInactive", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A62")]
	public void set_activeTab(Tab value) { }

	[Address(RVA = "0x1B36AE0", Offset = "0x1B35CE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5C")]
	private void set_nextButton(RepeatButton value) { }

	[Address(RVA = "0x1C3C810", Offset = "0x1C3BA10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000A5E")]
	private void set_previousButton(RepeatButton value) { }

	[Address(RVA = "0x1C3C830", Offset = "0x1C3BA30", Length = "0x1B7")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A64")]
	public void set_reorderable(bool value) { }

	[Address(RVA = "0x1C3B720", Offset = "0x1C3A920", Length = "0x170")]
	[CalledBy(Type = typeof(TabView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnNextClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnPreviousClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A6B")]
	internal void UpdateButtons(Vector3 contentTransform) { }

	[Address(RVA = "0x1C3B8A0", Offset = "0x1C3AAA0", Length = "0x91")]
	[CalledBy(Type = typeof(TabView), Member = "OnElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A6D")]
	private void UpdateIndexes() { }

}

