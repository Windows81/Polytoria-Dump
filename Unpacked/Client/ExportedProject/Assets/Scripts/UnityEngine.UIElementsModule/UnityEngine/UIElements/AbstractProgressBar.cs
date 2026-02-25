namespace UnityEngine.UIElements;

[Token(Token = "0x200012A")]
public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<Single>
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200012B")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40005CC")]
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40005CD")]
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40005CE")]
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40005CF")]
		private UxmlStringAttributeDescription m_Title; //Field offset: 0xA8

		[Address(RVA = "0x1C302D0", Offset = "0x1C2F4D0", Length = "0x1F5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000941")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2E970", Offset = "0x1C2DB70", Length = "0x43D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x6000940")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005BC")]
	internal static readonly BindingId titleProperty; //Field offset: 0x0
	[Token(Token = "0x40005BD")]
	internal static readonly BindingId lowValueProperty; //Field offset: 0x98
	[Token(Token = "0x40005BE")]
	internal static readonly BindingId highValueProperty; //Field offset: 0x130
	[Token(Token = "0x40005BF")]
	internal static readonly BindingId valueProperty; //Field offset: 0x1C8
	[Token(Token = "0x40005C0")]
	public static readonly string ussClassName; //Field offset: 0x260
	[Token(Token = "0x40005C1")]
	public static readonly string containerUssClassName; //Field offset: 0x268
	[Token(Token = "0x40005C2")]
	public static readonly string titleUssClassName; //Field offset: 0x270
	[Token(Token = "0x40005C3")]
	public static readonly string titleContainerUssClassName; //Field offset: 0x278
	[Token(Token = "0x40005C4")]
	public static readonly string progressUssClassName; //Field offset: 0x280
	[Token(Token = "0x40005C5")]
	public static readonly string backgroundUssClassName; //Field offset: 0x288
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40005C6")]
	private readonly VisualElement m_Background; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40005C7")]
	private readonly VisualElement m_Progress; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40005C8")]
	private readonly Label m_Title; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40005C9")]
	private float m_LowValue; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x40005CA")]
	private float m_HighValue; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x40005CB")]
	private float m_Value; //Field offset: 0x300

	[CreateProperty]
	[Token(Token = "0x1700018D")]
	public float highValue
	{
		[Address(RVA = "0x18CE820", Offset = "0x18CDA20", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000936")]
		 get { } //Length: 9
		[Address(RVA = "0x1C17AD0", Offset = "0x1C16CD0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000937")]
		 set { } //Length: 180
	}

	[CreateProperty]
	[Token(Token = "0x1700018C")]
	public float lowValue
	{
		[Address(RVA = "0x1C17A80", Offset = "0x1C16C80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000934")]
		 get { } //Length: 9
		[Address(RVA = "0x1C17B90", Offset = "0x1C16D90", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000935")]
		 set { } //Length: 180
	}

	[CreateProperty]
	[Token(Token = "0x1700018B")]
	public string title
	{
		[Address(RVA = "0x1C17A90", Offset = "0x1C16C90", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000932")]
		 get { } //Length: 45
		[Address(RVA = "0x1C17C50", Offset = "0x1C16E50", Length = "0xF5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000933")]
		 set { } //Length: 245
	}

	[CreateProperty]
	[Token(Token = "0x1700018E")]
	public override float value
	{
		[Address(RVA = "0x1C17AC0", Offset = "0x1C16CC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600093A")]
		 get { } //Length: 11
		[Address(RVA = "0x1C17D50", Offset = "0x1C16F50", Length = "0x323")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Single>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Single>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Single>), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Single>))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600093B")]
		 set { } //Length: 803
	}

	[Address(RVA = "0x1C17190", Offset = "0x1C16390", Length = "0x59F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600093F")]
	private static AbstractProgressBar() { }

	[Address(RVA = "0x1C17730", Offset = "0x1C16930", Length = "0x340")]
	[CalledBy(Type = typeof(ProgressBar), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000938")]
	public AbstractProgressBar() { }

	[Address(RVA = "0x1C16DD0", Offset = "0x1C15FD0", Length = "0x1EA")]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600093E")]
	private float CalculateOppositeProgressWidth(float width) { }

	[Address(RVA = "0x18CE820", Offset = "0x18CDA20", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000936")]
	public float get_highValue() { }

	[Address(RVA = "0x1C17A80", Offset = "0x1C16C80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000934")]
	public float get_lowValue() { }

	[Address(RVA = "0x1C17A90", Offset = "0x1C16C90", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000932")]
	public string get_title() { }

	[Address(RVA = "0x1C17AC0", Offset = "0x1C16CC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600093A")]
	public override float get_value() { }

	[Address(RVA = "0x1C16FC0", Offset = "0x1C161C0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000939")]
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	[Address(RVA = "0x1C17AD0", Offset = "0x1C16CD0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000937")]
	public void set_highValue(float value) { }

	[Address(RVA = "0x1C17B90", Offset = "0x1C16D90", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000935")]
	public void set_lowValue(float value) { }

	[Address(RVA = "0x1C17C50", Offset = "0x1C16E50", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000933")]
	public void set_title(string value) { }

	[Address(RVA = "0x1C17D50", Offset = "0x1C16F50", Length = "0x323")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Single>), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Single>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Single>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Single>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600093B")]
	public override void set_value(float value) { }

	[Address(RVA = "0x1C16FF0", Offset = "0x1C161F0", Length = "0x15E")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractProgressBar), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractProgressBar), Member = "CalculateOppositeProgressWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600093D")]
	private void SetProgress(float p) { }

	[Address(RVA = "0x1C17150", Offset = "0x1C16350", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractProgressBar), Member = "SetProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600093C")]
	public override void SetValueWithoutNotify(float newValue) { }

}

