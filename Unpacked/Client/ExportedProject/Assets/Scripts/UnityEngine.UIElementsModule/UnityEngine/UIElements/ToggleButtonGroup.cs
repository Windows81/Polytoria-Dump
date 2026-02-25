namespace UnityEngine.UIElements;

[Token(Token = "0x200015F")]
[UxmlElement(null, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Button)})]
public class ToggleButtonGroup : BaseField<ToggleButtonGroupState>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000160")]
	internal class UxmlFactory : UxmlFactory<ToggleButtonGroup, UxmlTraits>
	{

		[Address(RVA = "0x1C46CB0", Offset = "0x1C45EB0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000ABF")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000161")]
	internal class UxmlTraits : UxmlTraits<ToggleButtonGroupState>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000700")]
		private UxmlBoolAttributeDescription m_IsMultipleSelection; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000701")]
		private UxmlBoolAttributeDescription m_AllowEmptySelection; //Field offset: 0xA0

		[Address(RVA = "0x1C47910", Offset = "0x1C46B10", Length = "0xFF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.UIElements.ToggleButtonGroupState>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000AC1")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C47310", Offset = "0x1C46510", Length = "0x1A8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ToggleButtonGroup), Member = "set_isMultipleSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ToggleButtonGroup), Member = "set_allowEmptySelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000AC0")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40006EF")]
	private static readonly string k_MaxToggleButtonGroupMessage; //Field offset: 0x0
	[Token(Token = "0x40006F0")]
	internal static readonly BindingId isMultipleSelectionProperty; //Field offset: 0x8
	[Token(Token = "0x40006F1")]
	internal static readonly BindingId allowEmptySelectionProperty; //Field offset: 0xA0
	[Token(Token = "0x40006F2")]
	public static readonly string ussClassName; //Field offset: 0x138
	[Token(Token = "0x40006F3")]
	public static readonly string containerUssClassName; //Field offset: 0x140
	[Token(Token = "0x40006F4")]
	public static readonly string buttonGroupClassName; //Field offset: 0x148
	[Token(Token = "0x40006F5")]
	public static readonly string buttonClassName; //Field offset: 0x150
	[Token(Token = "0x40006F6")]
	public static readonly string buttonLeftClassName; //Field offset: 0x158
	[Token(Token = "0x40006F7")]
	public static readonly string buttonMidClassName; //Field offset: 0x160
	[Token(Token = "0x40006F8")]
	public static readonly string buttonRightClassName; //Field offset: 0x168
	[Token(Token = "0x40006F9")]
	public static readonly string buttonStandaloneClassName; //Field offset: 0x170
	[Token(Token = "0x40006FA")]
	public static readonly string emptyStateLabelClassName; //Field offset: 0x178
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40006FB")]
	private VisualElement m_ButtonGroupContainer; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40006FC")]
	private List<Button> m_Buttons; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x40006FD")]
	private VisualElement m_EmptyLabel; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x40006FE")]
	private bool m_IsMultipleSelection; //Field offset: 0x380
	[FieldOffset(Offset = "0x381")]
	[Token(Token = "0x40006FF")]
	private bool m_AllowEmptySelection; //Field offset: 0x381

	[CreateProperty]
	[Token(Token = "0x170001D4")]
	public bool allowEmptySelection
	{
		[Address(RVA = "0x1C3EF10", Offset = "0x1C3E110", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AB0")]
		 get { } //Length: 8
		[Address(RVA = "0x1C3EF30", Offset = "0x1C3E130", Length = "0x25F")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000AB1")]
		 set { } //Length: 607
	}

	[Token(Token = "0x170001D5")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x1C1B9E0", Offset = "0x1C1ABE0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB5")]
		 get { } //Length: 18
	}

	[CreateProperty]
	[Token(Token = "0x170001D3")]
	public bool isMultipleSelection
	{
		[Address(RVA = "0x1C3EF20", Offset = "0x1C3E120", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AAE")]
		 get { } //Length: 8
		[Address(RVA = "0x1C3F190", Offset = "0x1C3E390", Length = "0x1DD")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
		[Calls(Type = typeof(ToggleButtonGroupState), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000AAF")]
		 set { } //Length: 477
	}

	[Address(RVA = "0x1C3E5C0", Offset = "0x1C3D7C0", Length = "0x58C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000ABE")]
	private static ToggleButtonGroup() { }

	[Address(RVA = "0x1C3EBD0", Offset = "0x1C3DDD0", Length = "0x33E")]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "add_elementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "add_elementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.VisualElement, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.UIElements.ToggleButtonGroupState>), Member = "set_visualInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.UIElements.ToggleButtonGroupState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AB4")]
	public ToggleButtonGroup(string label, ToggleButtonGroupState toggleButtonGroupState) { }

	[Address(RVA = "0x1C3EB50", Offset = "0x1C3DD50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AB2")]
	public ToggleButtonGroup() { }

	[Address(RVA = "0x1C3EB90", Offset = "0x1C3DD90", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AB3")]
	public ToggleButtonGroup(string label) { }

	[Address(RVA = "0x1C3EF10", Offset = "0x1C3E110", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AB0")]
	public bool get_allowEmptySelection() { }

	[Address(RVA = "0x1C1B9E0", Offset = "0x1C1ABE0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB5")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x1C3EF20", Offset = "0x1C3E120", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AAE")]
	public bool get_isMultipleSelection() { }

	[Address(RVA = "0x1C3D180", Offset = "0x1C3C380", Length = "0x435")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleButtonGroup), Member = "UpdateButtonsStyling", ReturnType = typeof(void))]
	[Calls(Type = typeof(UQueryBuilder`1), Member = "ToList", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(UQueryExtensions), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "UnityEngine.UIElements.UQueryBuilder`1<T>")]
	[Calls(Type = typeof(Clickable), Member = "add_clickedWithEventInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.EventBase>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AB9")]
	private void OnButtonGroupContainerElementAdded(VisualElement ve, int index) { }

	[Address(RVA = "0x1C3D5C0", Offset = "0x1C3C7C0", Length = "0x415")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "remove_clickedWithEventInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.EventBase>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleButtonGroup), Member = "UpdateButtonsStyling", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E22E0")]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ABA")]
	private void OnButtonGroupContainerElementRemoved(VisualElement ve) { }

	[Address(RVA = "0x1C3D9E0", Offset = "0x1C3CBE0", Length = "0x306")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ABC")]
	private void OnOptionChange(EventBase evt) { }

	[Address(RVA = "0x1C3DCF0", Offset = "0x1C3CEF0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.UIElements.ToggleButtonGroupState>), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleButtonGroup), Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AB6")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1C3EF30", Offset = "0x1C3E130", Length = "0x25F")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AB1")]
	public void set_allowEmptySelection(bool value) { }

	[Address(RVA = "0x1C3F190", Offset = "0x1C3E390", Length = "0x1DD")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AAF")]
	public void set_isMultipleSelection(bool value) { }

	[Address(RVA = "0x1C3DD60", Offset = "0x1C3CF60", Length = "0x1CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ToggleButtonGroup), Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AB8")]
	public virtual void SetValueWithoutNotify(ToggleButtonGroupState newValue) { }

	[Address(RVA = "0x1C3E250", Offset = "0x1C3D450", Length = "0x1C5")]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ABD")]
	private void UpdateButtonsStyling() { }

	[Address(RVA = "0x1C3DF30", Offset = "0x1C3D130", Length = "0x312")]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
	[Calls(Type = "System.SpanHelpers", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.SpanHelpers", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.SpanHelpers", Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ABB")]
	private void UpdateButtonStates(ToggleButtonGroupState options) { }

	[Address(RVA = "0x1C3E420", Offset = "0x1C3D620", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AB7")]
	protected virtual void UpdateMixedValueContent() { }

}

