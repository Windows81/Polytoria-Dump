namespace UnityEngine.UIElements;

[Token(Token = "0x20000F5")]
public class Label : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F6")]
	internal class UxmlFactory : UxmlFactory<Label, UxmlTraits>
	{

		[Address(RVA = "0x1C15930", Offset = "0x1C14B30", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60007AE")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F7")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x1C16720", Offset = "0x1C15920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60007AF")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40004BE")]
	public static readonly string ussClassName; //Field offset: 0x0

	[Address(RVA = "0x1C0A7C0", Offset = "0x1C099C0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60007AD")]
	private static Label() { }

	[Address(RVA = "0x1C0A830", Offset = "0x1C09A30", Length = "0xAF")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "DefaultMakeCellItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "<Create>g__CreateError|82_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass82_0&)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(TemplateAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = "TemplateMakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Column+UxmlObjectTraits`1+<>c__DisplayClass14_0", Member = "<Init>b__0", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = "UnityEngine.UIElements.Column+UxmlObjectTraits`1+<>c__DisplayClass14_1", Member = "<Init>b__1", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "get_mixedValueLabel", ReturnType = typeof(Label))]
	[CalledBy(Type = typeof(HelpBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HelpBoxMessageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HelpBox), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupBox), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[CalledBy(Type = typeof(ListView), Member = "TemplateMakeItem", ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AC")]
	public Label(string text) { }

	[Address(RVA = "0x1C0A8E0", Offset = "0x1C09AE0", Length = "0x19")]
	[CalledBy(Type = typeof(ListViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(TreeViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseBoolField), Member = "InitLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultDragAndDropClient), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StartDragArgs), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumnSortIndicator), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "CreateDefaultHeaderContent", ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007AB")]
	public Label() { }

}

