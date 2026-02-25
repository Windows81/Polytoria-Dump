namespace UnityEngine.UIElements;

[Token(Token = "0x200012E")]
public class RadioButton : BaseBoolField, IGroupBoxOption
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200012F")]
	internal class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
	{

		[Address(RVA = "0x1C2C690", Offset = "0x1C2B890", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000951")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000130")]
	internal class UxmlTraits : BaseFieldTraits<Boolean, UxmlBoolAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40005D7")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0xA0

		[Address(RVA = "0x1C2F4C0", Offset = "0x1C2E6C0", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000953")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2D920", Offset = "0x1C2CB20", Length = "0x141")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseBoolField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000952")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005D0")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40005D1")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40005D2")]
	public static readonly string inputUssClassName; //Field offset: 0x10
	[Token(Token = "0x40005D3")]
	public static readonly string checkmarkBackgroundUssClassName; //Field offset: 0x18
	[Token(Token = "0x40005D4")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x20
	[Token(Token = "0x40005D5")]
	public static readonly string textUssClassName; //Field offset: 0x28
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x40005D6")]
	private VisualElement m_CheckmarkBackground; //Field offset: 0x388

	[Token(Token = "0x1700018F")]
	public virtual bool value
	{
		[Address(RVA = "0x1C1C3A0", Offset = "0x1C1B5A0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000944")]
		 get { } //Length: 57
		[Address(RVA = "0x1C1C3E0", Offset = "0x1C1B5E0", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseField`1), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RadioButton), Member = "UpdateCheckmark", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GroupBoxUtility), Member = "OnOptionSelected", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000945")]
		 set { } //Length: 181
	}

	[Address(RVA = "0x1C1BE80", Offset = "0x1C1B080", Length = "0x21A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000950")]
	private static RadioButton() { }

	[Address(RVA = "0x1C1C0A0", Offset = "0x1C1B2A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadioButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000946")]
	public RadioButton() { }

	[Address(RVA = "0x1C1C0B0", Offset = "0x1C1B2B0", Length = "0x2E5")]
	[CalledBy(Type = typeof(RadioButton), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RadioButton), Member = "UpdateCheckmark", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseBoolField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000947")]
	public RadioButton(string label) { }

	[Address(RVA = "0x1C1C3A0", Offset = "0x1C1B5A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000944")]
	public virtual bool get_value() { }

	[Address(RVA = "0x1C1BB60", Offset = "0x1C1AD60", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseBoolField), Member = "InitLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600094A")]
	protected virtual void InitLabel() { }

	[Address(RVA = "0x1C1BBE0", Offset = "0x1C1ADE0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GroupBoxUtility), Member = "RegisterGroupBoxOption", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000948")]
	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x1C1BC40", Offset = "0x1C1AE40", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GroupBoxUtility), Member = "UnregisterGroupBoxOption", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000949")]
	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1C1C3E0", Offset = "0x1C1B5E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RadioButton), Member = "UpdateCheckmark", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GroupBoxUtility), Member = "OnOptionSelected", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000945")]
	public virtual void set_value(bool value) { }

	[Address(RVA = "0x1C1BCA0", Offset = "0x1C1AEA0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseBoolField), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RadioButton), Member = "UpdateCheckmark", ReturnType = typeof(void))]
	[Token(Token = "0x600094D")]
	public virtual void SetValueWithoutNotify(bool newValue) { }

	[Address(RVA = "0x1C1BCC0", Offset = "0x1C1AEC0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600094B")]
	protected virtual void ToggleValue() { }

	[Address(RVA = "0x1C1BD10", Offset = "0x1C1AF10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600094C")]
	private override void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	[Address(RVA = "0x1C1BD30", Offset = "0x1C1AF30", Length = "0xA1")]
	[CalledBy(Type = typeof(RadioButton), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButton), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600094E")]
	private void UpdateCheckmark() { }

	[Address(RVA = "0x1C1BDE0", Offset = "0x1C1AFE0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseBoolField), Member = "UpdateMixedValueContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600094F")]
	protected virtual void UpdateMixedValueContent() { }

}

