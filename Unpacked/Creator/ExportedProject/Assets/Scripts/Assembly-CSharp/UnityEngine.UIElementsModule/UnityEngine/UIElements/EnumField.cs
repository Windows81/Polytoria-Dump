namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000C3")]
public class EnumField : BaseField<Enum>
{
	[CompilerGenerated]
	[Token(Token = "0x20000C6")]
	private sealed class <>c
	{
		[Token(Token = "0x40003DE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003DF")]
		public static EventCallback<MouseDownEvent> <>9__31_0; //Field offset: 0x8

		[Address(RVA = "0x1BE4C50", Offset = "0x1BE3E50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000643")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000644")]
		public <>c() { }

		[Address(RVA = "0x1BE49F0", Offset = "0x1BE3BF0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000645")]
		internal void <.ctor>b__31_0(MouseDownEvent e) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000C4")]
	internal class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
	{

		[Address(RVA = "0x1BE5540", Offset = "0x1BE4740", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000640")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000C5")]
	internal class UxmlTraits : UxmlTraits<Enum>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003DB")]
		private UxmlTypeAttributeDescription<Enum> m_Type; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003DC")]
		private UxmlStringAttributeDescription m_Value; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003DD")]
		private UxmlBoolAttributeDescription m_IncludeObsoleteValues; //Field offset: 0xA8

		[Address(RVA = "0x1BE9AC0", Offset = "0x1BE8CC0", Length = "0xCB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000642")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE67F0", Offset = "0x1BE59F0", Length = "0x3A5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumField), Member = "PopulateDataFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(EnumFieldHelpers), Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000641")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003CF")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x40003D6")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x40003D7")]
	public static readonly string textUssClassName; //Field offset: 0xA0
	[Token(Token = "0x40003D8")]
	public static readonly string arrowUssClassName; //Field offset: 0xA8
	[Token(Token = "0x40003D9")]
	public static readonly string labelUssClassName; //Field offset: 0xB0
	[Token(Token = "0x40003DA")]
	public static readonly string inputUssClassName; //Field offset: 0xB8
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x40003D0")]
	private Type m_EnumType; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40003D1")]
	private bool m_IncludeObsoleteValues; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40003D2")]
	private TextElement m_TextElement; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x40003D3")]
	private VisualElement m_ArrowElement; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x40003D4")]
	private EnumData m_EnumData; //Field offset: 0x380
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x40003D5")]
	internal Func<IGenericMenu> createMenuCallback; //Field offset: 0x3C0

	[Token(Token = "0x170000E4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool includeObsoleteValues
	{
		[Address(RVA = "0x1BDC3B0", Offset = "0x1BDB5B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600062C")]
		internal get { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000E5")]
	public string text
	{
		[Address(RVA = "0x1BDC3C0", Offset = "0x1BDB5C0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600062D")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x1BDBD60", Offset = "0x1BDAF60", Length = "0x2F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600063E")]
	private static EnumField() { }

	[Address(RVA = "0x1BDC3A0", Offset = "0x1BDB5A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Enum)}, ReturnType = typeof(void))]
	[Token(Token = "0x600062F")]
	public EnumField() { }

	[Address(RVA = "0x1BDC050", Offset = "0x1BDB250", Length = "0x347")]
	[CalledBy(Type = typeof(EnumField), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000630")]
	public EnumField(string label, Enum defaultValue = null) { }

	[Address(RVA = "0x1BDB0B0", Offset = "0x1BDA2B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063F")]
	private void <ShowMenu>b__42_0(object contentView) { }

	[Address(RVA = "0x1BDB0B0", Offset = "0x1BDA2B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063C")]
	private void ChangeValueFromMenu(object menuItem) { }

	[Address(RVA = "0x1BDB110", Offset = "0x1BDA310", Length = "0x84")]
	[CalledBy(Type = typeof(EnumField), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000638")]
	private bool ContainsPointer(int pointerId) { }

	[Address(RVA = "0x1BDC3B0", Offset = "0x1BDB5B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600062C")]
	internal bool get_includeObsoleteValues() { }

	[Address(RVA = "0x1BDC3C0", Offset = "0x1BDB5C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062D")]
	public string get_text() { }

	[Address(RVA = "0x1BDB1A0", Offset = "0x1BDA3A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000631")]
	public void Init(Enum defaultValue) { }

	[Address(RVA = "0x1BDB1B0", Offset = "0x1BDA3B0", Length = "0x107")]
	[CalledBy(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(EnumField), Member = "PopulateDataFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000632")]
	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	[Address(RVA = "0x1BDB2C0", Offset = "0x1BDA4C0", Length = "0x1D9")]
	[CalledBy(Type = typeof(EnumField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Enum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600062E")]
	private void Initialize(Enum defaultValue) { }

	[Address(RVA = "0x1BDB4A0", Offset = "0x1BDA6A0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "ShowMenu", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600063A")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x1BDB4D0", Offset = "0x1BDA6D0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EnumField), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000636")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x1BDB520", Offset = "0x1BDA720", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EnumField), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000637")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x1BDB5A0", Offset = "0x1BDA7A0", Length = "0x11A")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.EnumDataUtility", Member = "GetCachedEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "UnityEngine.EnumDataUtility+CachedType", typeof(System.Func`2<System.String, System.String>)}, ReturnType = "UnityEngine.EnumData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000633")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void PopulateDataFromType(Type enumType) { }

	[Address(RVA = "0x69E470", Offset = "0x69D670", Length = "0x167")]
	[CalledBy(Type = typeof(EnumField), Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(EnumField), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000639")]
	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	[Address(RVA = "0x1BDB6C0", Offset = "0x1BDA8C0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000634")]
	public virtual void SetValueWithoutNotify(Enum newValue) { }

	[Address(RVA = "0x1BDB780", Offset = "0x1BDA980", Length = "0x36C")]
	[CalledBy(Type = typeof(EnumField), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600063B")]
	internal void ShowMenu() { }

	[Address(RVA = "0x1BDBAF0", Offset = "0x1BDACF0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600063D")]
	protected virtual void UpdateMixedValueContent() { }

	[Address(RVA = "0x1BDBC60", Offset = "0x1BDAE60", Length = "0xF2")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "UpdateMixedValueContent", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000635")]
	private void UpdateValueLabel(Enum value) { }

}

