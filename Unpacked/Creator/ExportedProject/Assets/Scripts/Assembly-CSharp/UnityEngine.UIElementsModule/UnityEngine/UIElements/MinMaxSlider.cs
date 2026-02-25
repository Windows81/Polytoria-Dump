namespace UnityEngine.UIElements;

[Token(Token = "0x20000FF")]
public class MinMaxSlider : BaseField<Vector2>
{
	[Token(Token = "0x2000102")]
	private enum DragState
	{
		MinThumb = 0,
		MaxThumb = 1,
		MiddleThumb = 2,
		NoThumb = 3,
	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000100")]
	internal class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
	{

		[Address(RVA = "0x1C15830", Offset = "0x1C14A30", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60007FE")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000101")]
	internal class UxmlTraits : UxmlTraits<Vector2>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40004E4")]
		private UxmlFloatAttributeDescription m_MinValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40004E5")]
		private UxmlFloatAttributeDescription m_MaxValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40004E6")]
		private UxmlFloatAttributeDescription m_LowLimit; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40004E7")]
		private UxmlFloatAttributeDescription m_HighLimit; //Field offset: 0xB0

		[Address(RVA = "0x1C168D0", Offset = "0x1C15AD0", Length = "0x1F4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007FF")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C15D60", Offset = "0x1C14F60", Length = "0x271")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MinMaxSlider), Member = "set_lowLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MinMaxSlider), Member = "set_highLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000800")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40004CE")]
	internal static readonly BindingId minValueProperty; //Field offset: 0x0
	[Token(Token = "0x40004CF")]
	internal static readonly BindingId maxValueProperty; //Field offset: 0x98
	[Token(Token = "0x40004D0")]
	internal static readonly BindingId rangeProperty; //Field offset: 0x130
	[Token(Token = "0x40004D1")]
	internal static readonly BindingId lowLimitProperty; //Field offset: 0x1C8
	[Token(Token = "0x40004D2")]
	internal static readonly BindingId highLimitProperty; //Field offset: 0x260
	[Token(Token = "0x40004DC")]
	public static readonly string ussClassName; //Field offset: 0x2F8
	[Token(Token = "0x40004DD")]
	public static readonly string labelUssClassName; //Field offset: 0x300
	[Token(Token = "0x40004DE")]
	public static readonly string inputUssClassName; //Field offset: 0x308
	[Token(Token = "0x40004DF")]
	public static readonly string trackerUssClassName; //Field offset: 0x310
	[Token(Token = "0x40004E0")]
	public static readonly string draggerUssClassName; //Field offset: 0x318
	[Token(Token = "0x40004E1")]
	public static readonly string minThumbUssClassName; //Field offset: 0x320
	[Token(Token = "0x40004E2")]
	public static readonly string maxThumbUssClassName; //Field offset: 0x328
	[Token(Token = "0x40004E3")]
	public static readonly string movableUssClassName; //Field offset: 0x330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x40004D3")]
	private VisualElement <dragElement>k__BackingField; //Field offset: 0x360
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40004D4")]
	private VisualElement <dragMinThumb>k__BackingField; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40004D5")]
	private VisualElement <dragMaxThumb>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x40004D6")]
	private ClampedDragger<Single> <clampedDragger>k__BackingField; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x40004D7")]
	private Vector2 m_DragElementStartPos; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x40004D8")]
	private Vector2 m_ValueStartPos; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x40004D9")]
	private DragState m_DragState; //Field offset: 0x390
	[FieldOffset(Offset = "0x394")]
	[Token(Token = "0x40004DA")]
	private float m_MinLimit; //Field offset: 0x394
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x40004DB")]
	private float m_MaxLimit; //Field offset: 0x398

	[Token(Token = "0x17000143")]
	internal ClampedDragger<Single> clampedDragger
	{
		[Address(RVA = "0x95D830", Offset = "0x95CA30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D9")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E610", Offset = "0x95D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007DA")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000140")]
	internal VisualElement dragElement
	{
		[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D3")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E630", Offset = "0x95D830", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D4")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000142")]
	internal VisualElement dragMaxThumb
	{
		[Address(RVA = "0x95DD10", Offset = "0x95CF10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D7")]
		internal get { } //Length: 8
		[Address(RVA = "0x95FC40", Offset = "0x95EE40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D8")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000141")]
	internal VisualElement dragMinThumb
	{
		[Address(RVA = "0x95D840", Offset = "0x95CA40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D5")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E650", Offset = "0x95D850", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D6")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x17000149")]
	public float highLimit
	{
		[Address(RVA = "0x95DB70", Offset = "0x95CD70", Length = "0xB")]
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007E5")]
		 get { } //Length: 11
		[Address(RVA = "0x1C0F3B0", Offset = "0x1C0E5B0", Length = "0x14A")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007E6")]
		 set { } //Length: 330
	}

	[CreateProperty]
	[Token(Token = "0x17000148")]
	public float lowLimit
	{
		[Address(RVA = "0x1C0F280", Offset = "0x1C0E480", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60007E3")]
		 get { } //Length: 11
		[Address(RVA = "0x1C0F500", Offset = "0x1C0E700", Length = "0x146")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007E4")]
		 set { } //Length: 326
	}

	[CreateProperty]
	[Token(Token = "0x17000145")]
	public float maxValue
	{
		[Address(RVA = "0x1C0F290", Offset = "0x1C0E490", Length = "0x27")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007DD")]
		 get { } //Length: 39
		[Address(RVA = "0x1C0F650", Offset = "0x1C0E850", Length = "0x115")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60007DE")]
		 set { } //Length: 277
	}

	[CreateProperty]
	[Token(Token = "0x17000144")]
	public float minValue
	{
		[Address(RVA = "0x1C0F2C0", Offset = "0x1C0E4C0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007DB")]
		 get { } //Length: 39
		[Address(RVA = "0x1C0F770", Offset = "0x1C0E970", Length = "0x10E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60007DC")]
		 set { } //Length: 270
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000147")]
	public float range
	{
		[Address(RVA = "0x1C0F2F0", Offset = "0x1C0E4F0", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60007E2")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000146")]
	public virtual Vector2 value
	{
		[Address(RVA = "0x1C0F370", Offset = "0x1C0E570", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60007DF")]
		 get { } //Length: 58
		[Address(RVA = "0x1C0F880", Offset = "0x1C0EA80", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Token(Token = "0x60007E0")]
		 set { } //Length: 91
	}

	[Address(RVA = "0x1C0E130", Offset = "0x1C0D330", Length = "0x726")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007FD")]
	private static MinMaxSlider() { }

	[Address(RVA = "0x1C0E860", Offset = "0x1C0DA60", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007E7")]
	public MinMaxSlider() { }

	[Address(RVA = "0x1C0E8A0", Offset = "0x1C0DAA0", Length = "0x9DE")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "set_rawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.ClampedDragger`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), typeof(Action), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(MinMaxSlider), Member = "set_highLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxSlider), Member = "set_lowLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60007E8")]
	public MinMaxSlider(string label, float minValue = 0, float maxValue = 10, float minLimit = -3.4028235E+38, float maxLimit = 3.4028235E+38) { }

	[Address(RVA = "0x1C0C150", Offset = "0x1C0B350", Length = "0x86")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x60007E9")]
	private Vector2 ClampValues(Vector2 valueToClamp) { }

	[Address(RVA = "0x1C0C1E0", Offset = "0x1C0B3E0", Length = "0x225")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "SetSliderValueFromDrag", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MinMaxSlider), Member = "ComputeValueFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MinMaxSlider), Member = "SetNavigationState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragState)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x60007F9")]
	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	[Address(RVA = "0x1C0C410", Offset = "0x1C0B610", Length = "0x4C6")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "OnNavigationMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseSlider`1), Member = "GetClosestPowerOfTen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseSlider`1), Member = "RoundToMultipleOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BF9E70")]
	[CallsUnknownMethods(Count = 15)]
	[Token(Token = "0x60007F6")]
	private void ComputeValueFromKey(bool leftDirection, bool isShift, DragState moveState) { }

	[Address(RVA = "0x1C0C8E0", Offset = "0x1C0BAE0", Length = "0x94")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "SetSliderValueFromClick", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "ComputeValueFromDraggingThumb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007EE")]
	private float ComputeValueFromPosition(float positionToConvert) { }

	[Address(RVA = "0x95D830", Offset = "0x95CA30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D9")]
	internal ClampedDragger<Single> get_clampedDragger() { }

	[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D3")]
	internal VisualElement get_dragElement() { }

	[Address(RVA = "0x95DD10", Offset = "0x95CF10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D7")]
	internal VisualElement get_dragMaxThumb() { }

	[Address(RVA = "0x95D840", Offset = "0x95CA40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D5")]
	internal VisualElement get_dragMinThumb() { }

	[Address(RVA = "0x95DB70", Offset = "0x95CD70", Length = "0xB")]
	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E5")]
	public float get_highLimit() { }

	[Address(RVA = "0x1C0F280", Offset = "0x1C0E480", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007E3")]
	public float get_lowLimit() { }

	[Address(RVA = "0x1C0F290", Offset = "0x1C0E490", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DD")]
	public float get_maxValue() { }

	[Address(RVA = "0x1C0F2C0", Offset = "0x1C0E4C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DB")]
	public float get_minValue() { }

	[Address(RVA = "0x1C0F2F0", Offset = "0x1C0E4F0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60007E2")]
	public float get_range() { }

	[Address(RVA = "0x1C0F370", Offset = "0x1C0E570", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007DF")]
	public virtual Vector2 get_value() { }

	[Address(RVA = "0x1C0C980", Offset = "0x1C0BB80", Length = "0xCF")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusInEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "OnNavigationMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F0")]
	private DragState GetNavigationState() { }

	[Address(RVA = "0x1C0CA50", Offset = "0x1C0BC50", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GeometryChangedEvent)})]
	[Token(Token = "0x60007EF")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1C0CB90", Offset = "0x1C0BD90", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F3")]
	private void OnBlur(BlurEvent evt) { }

	[Address(RVA = "0x1C0CCB0", Offset = "0x1C0BEB0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MinMaxSlider), Member = "GetNavigationState", ReturnType = typeof(DragState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F2")]
	private void OnFocusIn(FocusInEvent evt) { }

	[Address(RVA = "0x1C0CDE0", Offset = "0x1C0BFE0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MinMaxSlider), Member = "GetNavigationState", ReturnType = typeof(DragState))]
	[Calls(Type = typeof(MinMaxSlider), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(DragState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F5")]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[Address(RVA = "0x1C0CEC0", Offset = "0x1C0C0C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MinMaxSlider), Member = "GetNavigationState", ReturnType = typeof(DragState))]
	[Calls(Type = typeof(MinMaxSlider), Member = "SetNavigationState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragState)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007F4")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x1C0CEF0", Offset = "0x1C0C0F0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007FB")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x95E610", Offset = "0x95D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007DA")]
	private void set_clampedDragger(ClampedDragger<Single> value) { }

	[Address(RVA = "0x95E630", Offset = "0x95D830", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D4")]
	private void set_dragElement(VisualElement value) { }

	[Address(RVA = "0x95FC40", Offset = "0x95EE40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D8")]
	private void set_dragMaxThumb(VisualElement value) { }

	[Address(RVA = "0x95E650", Offset = "0x95D850", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D6")]
	private void set_dragMinThumb(VisualElement value) { }

	[Address(RVA = "0x1C0F3B0", Offset = "0x1C0E5B0", Length = "0x14A")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007E6")]
	public void set_highLimit(float value) { }

	[Address(RVA = "0x1C0F500", Offset = "0x1C0E700", Length = "0x146")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007E4")]
	public void set_lowLimit(float value) { }

	[Address(RVA = "0x1C0F650", Offset = "0x1C0E850", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60007DE")]
	public void set_maxValue(float value) { }

	[Address(RVA = "0x1C0F770", Offset = "0x1C0E970", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60007DC")]
	public void set_minValue(float value) { }

	[Address(RVA = "0x1C0F880", Offset = "0x1C0EA80", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007E0")]
	public virtual void set_value(Vector2 value) { }

	[Address(RVA = "0x1C0D020", Offset = "0x1C0C220", Length = "0x149")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "ComputeValueFromDraggingThumb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F1")]
	private void SetNavigationState(DragState newState) { }

	[Address(RVA = "0x1C0D170", Offset = "0x1C0C370", Length = "0x4D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(MinMaxSlider), Member = "ComputeValueFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F8")]
	private void SetSliderValueFromClick() { }

	[Address(RVA = "0x1C0D650", Offset = "0x1C0C850", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ClampedDragger`1), Member = "get_delta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(MinMaxSlider), Member = "ComputeValueFromDraggingThumb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F7")]
	private void SetSliderValueFromDrag() { }

	[Address(RVA = "0x1C0D6E0", Offset = "0x1C0C8E0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MinMaxSlider), Member = "ClampValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Vector2>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Token(Token = "0x60007E1")]
	public virtual void SetValueWithoutNotify(Vector2 newValue) { }

	[Address(RVA = "0x1C0D750", Offset = "0x1C0C950", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007EC")]
	internal float SliderLerpUnclamped(float a, float b, float interpolant) { }

	[Address(RVA = "0x1C0D770", Offset = "0x1C0C970", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007ED")]
	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	[Address(RVA = "0x1C0D790", Offset = "0x1C0C990", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60007FC")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x1C0D8C0", Offset = "0x1C0CAC0", Length = "0x800")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "set_lowLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "set_highLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60007EB")]
	private void UpdateDragElementPosition() { }

	[Address(RVA = "0x1C0E0D0", Offset = "0x1C0D2D0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007EA")]
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FA")]
	protected virtual void UpdateMixedValueContent() { }

}

