namespace UnityEngine.UIElements;

[Token(Token = "0x2000070")]
public abstract class BaseBoolField : BaseField<Boolean>
{
	[Token(Token = "0x4000214")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x4000215")]
	internal static readonly BindingId toggleOnLabelClickProperty; //Field offset: 0x98
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000216")]
	protected Label m_Label; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000217")]
	protected private readonly VisualElement m_CheckMark; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000218")]
	internal readonly Clickable m_Clickable; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000219")]
	private bool <toggleOnLabelClick>k__BackingField; //Field offset: 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x379")]
	[Token(Token = "0x400021A")]
	private bool <toggleOnTextClick>k__BackingField; //Field offset: 0x379
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x400021B")]
	private string m_OriginalText; //Field offset: 0x380

	[Token(Token = "0x1700008A")]
	internal bool acceptClicksIfDisabled
	{
		[Address(RVA = "0x1AB8980", Offset = "0x1AB7B80", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000402")]
		internal set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x1700008D")]
	public string text
	{
		[Address(RVA = "0x1AB8930", Offset = "0x1AB7B30", Length = "0x2F")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Foldout), Member = "get_text", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.RadioButtonGroup+<get_choices>d__17", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000409")]
		 get { } //Length: 47
		[Address(RVA = "0x1AB8A00", Offset = "0x1AB7C00", Length = "0x106")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseBoolField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseBoolField), Member = "UpdateMixedValueContent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600040A")]
		 set { } //Length: 262
	}

	[CreateProperty]
	[Token(Token = "0x1700008B")]
	public bool toggleOnLabelClick
	{
		[Address(RVA = "0x1AB8960", Offset = "0x1AB7B60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000403")]
		 get { } //Length: 8
		[Address(RVA = "0x1AB8B10", Offset = "0x1AB7D10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000404")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700008C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool toggleOnTextClick
	{
		[Address(RVA = "0x1AB8970", Offset = "0x1AB7B70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000405")]
		internal get { } //Length: 8
		[Address(RVA = "0x1AB8B20", Offset = "0x1AB7D20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000406")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x1AB83D0", Offset = "0x1AB75D0", Length = "0x1E2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000413")]
	private static BaseBoolField() { }

	[Address(RVA = "0x1AB85C0", Offset = "0x1AB77C0", Length = "0x361")]
	[CalledBy(Type = typeof(RadioButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000407")]
	public BaseBoolField(string label) { }

	[Address(RVA = "0x1AB8930", Offset = "0x1AB7B30", Length = "0x2F")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "get_text", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.RadioButtonGroup+<get_choices>d__17", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000409")]
	public string get_text() { }

	[Address(RVA = "0x1AB8960", Offset = "0x1AB7B60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000403")]
	public bool get_toggleOnLabelClick() { }

	[Address(RVA = "0x1AB8970", Offset = "0x1AB7B70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000405")]
	internal bool get_toggleOnTextClick() { }

	[Address(RVA = "0x1AB7920", Offset = "0x1AB6B20", Length = "0x154")]
	[CalledBy(Type = typeof(RadioButton), Member = "InitLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "InitLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040B")]
	protected override void InitLabel() { }

	[Address(RVA = "0x1AB7A80", Offset = "0x1AB6C80", Length = "0x2FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(BaseBoolField), Member = "ShouldIgnoreClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600040D")]
	private void OnClickEvent(EventBase evt) { }

	[Address(RVA = "0x1AB7D80", Offset = "0x1AB6F80", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000408")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x1AB7DC0", Offset = "0x1AB6FC0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000411")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x1AB8980", Offset = "0x1AB7B80", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000402")]
	internal void set_acceptClicksIfDisabled(bool value) { }

	[Address(RVA = "0x1AB8A00", Offset = "0x1AB7C00", Length = "0x106")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseBoolField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseBoolField), Member = "UpdateMixedValueContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600040A")]
	public void set_text(string value) { }

	[Address(RVA = "0x1AB8B10", Offset = "0x1AB7D10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000404")]
	public void set_toggleOnLabelClick(bool value) { }

	[Address(RVA = "0x1AB8B20", Offset = "0x1AB7D20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000406")]
	internal void set_toggleOnTextClick(bool value) { }

	[Address(RVA = "0x1AB7EB0", Offset = "0x1AB70B0", Length = "0xE6")]
	[CalledBy(Type = typeof(RadioButton), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600040C")]
	public virtual void SetValueWithoutNotify(bool newValue) { }

	[Address(RVA = "0x1AB7FA0", Offset = "0x1AB71A0", Length = "0x137")]
	[CalledBy(Type = typeof(BaseBoolField), Member = "OnClickEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600040E")]
	private bool ShouldIgnoreClick(Vector3 position) { }

	[Address(RVA = "0x1AB80E0", Offset = "0x1AB72E0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600040F")]
	protected override void ToggleValue() { }

	[Address(RVA = "0x1AB8120", Offset = "0x1AB7320", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000412")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x1AB8210", Offset = "0x1AB7410", Length = "0x1BB")]
	[CalledBy(Type = typeof(RadioButton), Member = "UpdateMixedValueContent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_mixedValueLabel", ReturnType = typeof(Label))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000410")]
	protected virtual void UpdateMixedValueContent() { }

}

