namespace UnityEngine.UIElements;

[Token(Token = "0x20000CB")]
public class Foldout : BindableElement, INotifyValueChanged<Boolean>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000CC")]
	internal class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
	{

		[Address(RVA = "0x1BE5680", Offset = "0x1BE4880", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000669")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000CD")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40003F3")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003F4")]
		private UxmlBoolAttributeDescription m_Value; //Field offset: 0x98

		[Address(RVA = "0x1BE8FE0", Offset = "0x1BE81E0", Length = "0x10A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600066B")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE5D60", Offset = "0x1BE4F60", Length = "0x31F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseBoolField), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Foldout), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600066A")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003E3")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x40003E4")]
	internal static readonly BindingId toggleOnLabelClickProperty; //Field offset: 0x98
	[Token(Token = "0x40003E5")]
	internal static readonly BindingId valueProperty; //Field offset: 0x130
	[Token(Token = "0x40003E9")]
	public static readonly string ussClassName; //Field offset: 0x1C8
	[Token(Token = "0x40003EA")]
	public static readonly string toggleUssClassName; //Field offset: 0x1D0
	[Token(Token = "0x40003EB")]
	public static readonly string contentUssClassName; //Field offset: 0x1D8
	[Token(Token = "0x40003EC")]
	public static readonly string inputUssClassName; //Field offset: 0x1E0
	[Token(Token = "0x40003ED")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x1E8
	[Token(Token = "0x40003EE")]
	public static readonly string textUssClassName; //Field offset: 0x1F0
	[Token(Token = "0x40003EF")]
	internal static readonly string toggleInspectorUssClassName; //Field offset: 0x1F8
	[Token(Token = "0x40003F0")]
	internal static readonly string ussFoldoutDepthClassName; //Field offset: 0x200
	[Token(Token = "0x40003F1")]
	internal static readonly int ussFoldoutMaxDepth; //Field offset: 0x208
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40003E6")]
	private readonly Toggle m_Toggle; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40003E7")]
	private VisualElement m_Container; //Field offset: 0x2E8
	[DontCreateProperty]
	[FieldOffset(Offset = "0x2F0")]
	[SerializeField]
	[Token(Token = "0x40003E8")]
	private bool m_Value; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40003F2")]
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x2F8

	[Token(Token = "0x170000EA")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000658")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000EB")]
	public virtual bool focusable
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000659")]
		 get { } //Length: 5
		[Address(RVA = "0x1BDE190", Offset = "0x1BDD390", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Focusable), Member = "set_focusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600065A")]
		 set { } //Length: 75
	}

	[CreateProperty]
	[Token(Token = "0x170000ED")]
	public string text
	{
		[Address(RVA = "0x1BDE120", Offset = "0x1BDD320", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseBoolField), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600065D")]
		 get { } //Length: 32
		[Address(RVA = "0x1BDE1E0", Offset = "0x1BDD3E0", Length = "0x1AA")]
		[CalledBy(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "set_headerTitle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseBoolField), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600065E")]
		 set { } //Length: 426
	}

	[Token(Token = "0x170000E9")]
	internal Toggle toggle
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000657")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170000EC")]
	public bool toggleOnLabelClick
	{
		[Address(RVA = "0x1BDE150", Offset = "0x1BDD350", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600065B")]
		 get { } //Length: 33
		[Address(RVA = "0x1BDE390", Offset = "0x1BDD590", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600065C")]
		 set { } //Length: 144
	}

	[CreateProperty]
	[Token(Token = "0x170000EE")]
	public override bool value
	{
		[Address(RVA = "0x1BDE180", Offset = "0x1BDD380", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600065F")]
		 get { } //Length: 8
		[Address(RVA = "0x1BDE430", Offset = "0x1BDD630", Length = "0x18C")]
		[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Foldout), Member = "<.ctor>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ChangeEvent`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = "UnityEngine.UIElements.ChangeEvent`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Foldout), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000660")]
		 set { } //Length: 396
	}

	[Address(RVA = "0x1BDD710", Offset = "0x1BDC910", Length = "0x5B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000667")]
	private static Foldout() { }

	[Address(RVA = "0x1BDDCD0", Offset = "0x1BDCED0", Length = "0x442")]
	[CalledBy(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Foldout), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000665")]
	public Foldout() { }

	[Address(RVA = "0x1BDD6B0", Offset = "0x1BDC8B0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Foldout), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000668")]
	private void <.ctor>b__39_0(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x1BDD090", Offset = "0x1BDC290", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Foldout), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000664")]
	private bool Apply(KeyboardNavigationOperation op) { }

	[Address(RVA = "0x1BDD1A0", Offset = "0x1BDC3A0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Foldout), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000663")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000658")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000659")]
	public virtual bool get_focusable() { }

	[Address(RVA = "0x1BDE120", Offset = "0x1BDD320", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseBoolField), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600065D")]
	public string get_text() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000657")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Toggle get_toggle() { }

	[Address(RVA = "0x1BDE150", Offset = "0x1BDD350", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600065B")]
	public bool get_toggleOnLabelClick() { }

	[Address(RVA = "0x1BDE180", Offset = "0x1BDD380", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600065F")]
	public override bool get_value() { }

	[Address(RVA = "0x1BDD2E0", Offset = "0x1BDC4E0", Length = "0x20A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementUtils), Member = "AssignInspectorStyleIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementUtils), Member = "GetFoldoutDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000666")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x1BDD4F0", Offset = "0x1BDC6F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000662")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1BDE190", Offset = "0x1BDD390", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Focusable), Member = "set_focusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065A")]
	public virtual void set_focusable(bool value) { }

	[Address(RVA = "0x1BDE1E0", Offset = "0x1BDD3E0", Length = "0x1AA")]
	[CalledBy(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_headerTitle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseBoolField), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600065E")]
	public void set_text(string value) { }

	[Address(RVA = "0x1BDE390", Offset = "0x1BDD590", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600065C")]
	public void set_toggleOnLabelClick(bool value) { }

	[Address(RVA = "0x1BDE430", Offset = "0x1BDD630", Length = "0x18C")]
	[CalledBy(Type = typeof(BaseListView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Foldout), Member = "<.ctor>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ChangeEvent`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = "UnityEngine.UIElements.ChangeEvent`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Foldout), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000660")]
	public override void set_value(bool value) { }

	[Address(RVA = "0x1BDD540", Offset = "0x1BDC740", Length = "0x167")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000661")]
	public override void SetValueWithoutNotify(bool newValue) { }

}

