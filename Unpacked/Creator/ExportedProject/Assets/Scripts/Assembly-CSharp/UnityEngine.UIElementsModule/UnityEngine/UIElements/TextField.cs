namespace UnityEngine.UIElements;

[Token(Token = "0x20000E9")]
public class TextField : TextInputBaseField<String>
{
	[Token(Token = "0x20000EC")]
	private class TextInput : TextInputBase<String>
	{

		[Token(Token = "0x17000111")]
		public bool multiline
		{
			[Address(RVA = "0x1C13BE0", Offset = "0x1C12DE0", Length = "0x60")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600072F")]
			 get { } //Length: 96
			[Address(RVA = "0x1C13CD0", Offset = "0x1C12ED0", Length = "0x23F")]
			[CalledBy(Type = typeof(TextField), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
			[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>), Member = "SetSingleLine", ReturnType = typeof(void))]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>), Member = "SetMultiline", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 3)]
			[Token(Token = "0x6000730")]
			 set { } //Length: 575
		}

		[Token(Token = "0x17000110")]
		private TextField parentTextField
		{
			[Address(RVA = "0x1C13C50", Offset = "0x1C12E50", Length = "0x71")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x600072E")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x1C13B80", Offset = "0x1C12D80", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000732")]
		public TextInput() { }

		[Address(RVA = "0x1C13BE0", Offset = "0x1C12DE0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600072F")]
		public bool get_multiline() { }

		[Address(RVA = "0x1C13C50", Offset = "0x1C12E50", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600072E")]
		private TextField get_parentTextField() { }

		[Address(RVA = "0x1C13CD0", Offset = "0x1C12ED0", Length = "0x23F")]
		[CalledBy(Type = typeof(TextField), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>), Member = "SetMultiline", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>), Member = "SetSingleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000730")]
		public void set_multiline(bool value) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000731")]
		protected virtual string StringToValue(string str) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000EA")]
	internal class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
	{

		[Address(RVA = "0x1C157B0", Offset = "0x1C149B0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600072A")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000EB")]
	internal class UxmlTraits : UxmlTraits<String>
	{
		[Token(Token = "0x4000471")]
		private static readonly UxmlStringAttributeDescription k_Value; //Field offset: 0x0
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4000472")]
		private UxmlBoolAttributeDescription m_Multiline; //Field offset: 0x120

		[Address(RVA = "0x1C16610", Offset = "0x1C15810", Length = "0x10A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600072D")]
		private static UxmlTraits() { }

		[Address(RVA = "0x1C16730", Offset = "0x1C15930", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600072C")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C15FE0", Offset = "0x1C151E0", Length = "0x217")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextField), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600072B")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400046D")]
	internal static readonly BindingId multilineProperty; //Field offset: 0x0
	[Token(Token = "0x400046E")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x400046F")]
	public static readonly string labelUssClassName; //Field offset: 0xA0
	[Token(Token = "0x4000470")]
	public static readonly string inputUssClassName; //Field offset: 0xA8

	[CreateProperty]
	[Token(Token = "0x1700010E")]
	public bool multiline
	{
		[Address(RVA = "0x1C13820", Offset = "0x1C12A20", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextField), Member = "get_textInput", ReturnType = typeof(TextInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600071C")]
		 get { } //Length: 108
		[Address(RVA = "0x1C13950", Offset = "0x1C12B50", Length = "0x175")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(bool), typeof(char)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextField), Member = "get_textInput", ReturnType = typeof(TextInput))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(TextInput), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600071D")]
		 set { } //Length: 373
	}

	[Token(Token = "0x1700010D")]
	private TextInput textInput
	{
		[Address(RVA = "0x1C13890", Offset = "0x1C12A90", Length = "0x7A")]
		[CalledBy(Type = typeof(TextField), Member = "get_multiline", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextField), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextField), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600071B")]
		private get { } //Length: 122
	}

	[Token(Token = "0x1700010F")]
	public virtual string value
	{
		[Address(RVA = "0x1C13910", Offset = "0x1C12B10", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000721")]
		 get { } //Length: 57
		[Address(RVA = "0x1C13AD0", Offset = "0x1C12CD0", Length = "0xAE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000722")]
		 set { } //Length: 174
	}

	[Address(RVA = "0x1C13330", Offset = "0x1C12530", Length = "0x22C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000729")]
	private static TextField() { }

	[Address(RVA = "0x1C137F0", Offset = "0x1C129F0", Length = "0x2E")]
	[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateTextFieldVisibility", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(bool), typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x600071E")]
	public TextField() { }

	[Address(RVA = "0x1C137C0", Offset = "0x1C129C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(bool), typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x600071F")]
	public TextField(string label) { }

	[Address(RVA = "0x1C13560", Offset = "0x1C12760", Length = "0x25E")]
	[CalledBy(Type = typeof(TextField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextField), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000720")]
	public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) { }

	[Address(RVA = "0x1C13820", Offset = "0x1C12A20", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextField), Member = "get_textInput", ReturnType = typeof(TextInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600071C")]
	public bool get_multiline() { }

	[Address(RVA = "0x1C13890", Offset = "0x1C12A90", Length = "0x7A")]
	[CalledBy(Type = typeof(TextField), Member = "get_multiline", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextField), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600071B")]
	private TextInput get_textInput() { }

	[Address(RVA = "0x1C13910", Offset = "0x1C12B10", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000721")]
	public virtual string get_value() { }

	[Address(RVA = "0x1C12EB0", Offset = "0x1C120B0", Length = "0x1FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "get_isDelayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FocusOutEvent)})]
	[Token(Token = "0x6000725")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1C130B0", Offset = "0x1C122B0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000726")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1C13950", Offset = "0x1C12B50", Length = "0x175")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(bool), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextField), Member = "get_textInput", ReturnType = typeof(TextInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextInput), Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600071D")]
	public void set_multiline(bool value) { }

	[Address(RVA = "0x1C13AD0", Offset = "0x1C12CD0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000722")]
	public virtual void set_value(string value) { }

	[Address(RVA = "0x1C13140", Offset = "0x1C12340", Length = "0x183")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextField), Member = "get_textInput", ReturnType = typeof(TextInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000723")]
	public virtual void SetValueWithoutNotify(string newValue) { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000728")]
	protected virtual string StringToValue(string str) { }

	[Address(RVA = "0x1C132D0", Offset = "0x1C124D0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000724")]
	internal virtual void UpdateTextFromValue() { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000727")]
	protected virtual string ValueToString(string value) { }

}

