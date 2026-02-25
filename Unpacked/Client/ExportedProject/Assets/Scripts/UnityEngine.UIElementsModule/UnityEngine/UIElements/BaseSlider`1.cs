namespace UnityEngine.UIElements;

[Token(Token = "0x200007D")]
public abstract class BaseSlider : BaseField<TValueType>, IValueField<TValueType>
{
	[Token(Token = "0x200007F")]
	public enum SliderKey
	{
		None = 0,
		Lowest = 1,
		LowerPage = 2,
		Lower = 3,
		Higher = 4,
		HigherPage = 5,
		Highest = 6,
	}

	[Obsolete("UxmlTraits<TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200007E")]
	internal class UxmlTraits : BaseFieldTraits<TValueType, TValueUxmlAttributeType>
	{

		[Address(RVA = "0x84C280", Offset = "0x84B480", Length = "0x62")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseFieldTraits`2<System.Int32, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C9")]
		public UxmlTraits`1() { }

	}

	[Token(Token = "0x4000297")]
	internal static readonly BindingId lowValueProperty; //Field offset: 0x0
	[Token(Token = "0x40002BB")]
	public static readonly string textFieldClassName; //Field offset: 0x0
	[Token(Token = "0x40002BA")]
	public static readonly string draggerBorderUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B9")]
	public static readonly string draggerUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B8")]
	public static readonly string trackerUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B7")]
	public static readonly string dragContainerUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B6")]
	public static readonly string verticalVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B5")]
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B4")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B3")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002B2")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40002BC")]
	public static readonly string fillUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002BD")]
	public static readonly string movableUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000298")]
	internal static readonly BindingId highValueProperty; //Field offset: 0x0
	[Token(Token = "0x4000299")]
	internal static readonly BindingId rangeProperty; //Field offset: 0x0
	[Token(Token = "0x400029A")]
	internal static readonly BindingId pageSizeProperty; //Field offset: 0x0
	[Token(Token = "0x400029B")]
	internal static readonly BindingId showInputFieldProperty; //Field offset: 0x0
	[Token(Token = "0x400029C")]
	internal static readonly BindingId directionProperty; //Field offset: 0x0
	[Token(Token = "0x400029D")]
	internal static readonly BindingId invertedProperty; //Field offset: 0x0
	[Token(Token = "0x400029E")]
	internal static readonly BindingId fillProperty; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A4")]
	private VisualElement <fillElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029F")]
	private VisualElement <dragContainer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A0")]
	private VisualElement <dragElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A1")]
	private VisualElement <trackElement>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B1")]
	private bool m_Inverted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B0")]
	private SliderDirection m_Direction; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AF")]
	private Action<TValueType> onSetValueWithoutNotify; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AE")]
	private Rect m_DragElementStartPos; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AD")]
	private ClampedDragger<TValueType> <clampedDragger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AC")]
	private bool <clamped>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AB")]
	private bool m_ShowInputField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A2")]
	private VisualElement <dragBorderElement>k__BackingField; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40002A9")]
	private TValueType m_HighValue; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40002A8")]
	private TValueType m_LowValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A7")]
	private bool m_Fill; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A6")]
	private bool m_IsEditingTextField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A5")]
	private float m_AdjustedPageSizeFromClick; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A3")]
	private TextField <inputTextField>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AA")]
	private float m_PageSize; //Field offset: 0x0

	[Token(Token = "0x14000011")]
	internal event Action<TValueType> onSetValueWithoutNotify
	{
		[Address(RVA = "0x95D4E0", Offset = "0x95C6E0", Length = "0xC5")]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600049E")]
		internal add { } //Length: 197
		[Address(RVA = "0x95DE80", Offset = "0x95D080", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600049F")]
		internal remove { } //Length: 197
	}

	[Token(Token = "0x170000AB")]
	virtual bool canSwitchToMixedValue
	{
		[Address(RVA = "0x95D6F0", Offset = "0x95C8F0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000486")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000B2")]
	internal bool clamped
	{
		[Address(RVA = "0x95D7E0", Offset = "0x95C9E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000493")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E0F0", Offset = "0x95D2F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000494")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170000B3")]
	internal ClampedDragger<TValueType> clampedDragger
	{
		[Address(RVA = "0x95D7A0", Offset = "0x95C9A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000495")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E0D0", Offset = "0x95D2D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000496")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000B5")]
	public SliderDirection direction
	{
		[Address(RVA = "0x95D820", Offset = "0x95CA20", Length = "0x9")]
		[CalledBy(Type = typeof(Scroller), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A1")]
		 get { } //Length: 9
		[Address(RVA = "0x95E430", Offset = "0x95D630", Length = "0x1DC")]
		[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scroller), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A2")]
		 set { } //Length: 476
	}

	[Token(Token = "0x170000A8")]
	internal VisualElement dragBorderElement
	{
		[Address(RVA = "0x95D830", Offset = "0x95CA30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000480")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E610", Offset = "0x95D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000481")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000A5")]
	internal VisualElement dragContainer
	{
		[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047A")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E630", Offset = "0x95D830", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047B")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000A6")]
	internal VisualElement dragElement
	{
		[Address(RVA = "0x95D840", Offset = "0x95CA40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047C")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E650", Offset = "0x95D850", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047D")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000B1")]
	public bool fill
	{
		[Address(RVA = "0x95D8C0", Offset = "0x95CAC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000491")]
		 get { } //Length: 8
		[Address(RVA = "0x95E7F0", Offset = "0x95D9F0", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000492")]
		 set { } //Length: 226
	}

	[Token(Token = "0x170000AA")]
	internal VisualElement fillElement
	{
		[Address(RVA = "0x95D850", Offset = "0x95CA50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000484")]
		internal get { } //Length: 8
		[Address(RVA = "0x95E670", Offset = "0x95D870", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000485")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000AD")]
	public TValueType highValue
	{
		[Address(RVA = "0x95D8D0", Offset = "0x95CAD0", Length = "0x9")]
		[CalledBy(Type = typeof(SliderInt), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderInt), Member = "SliderRange", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000489")]
		 get { } //Length: 9
		[Address(RVA = "0x95EE50", Offset = "0x95E050", Length = "0x144")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
		[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048A")]
		 set { } //Length: 324
	}

	[Token(Token = "0x170000A9")]
	internal TextField inputTextField
	{
		[Address(RVA = "0x95DA00", Offset = "0x95CC00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000482")]
		internal get { } //Length: 8
		[Address(RVA = "0x95EFA0", Offset = "0x95E1A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000483")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000B6")]
	public bool inverted
	{
		[Address(RVA = "0x95DA40", Offset = "0x95CC40", Length = "0xA")]
		[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A3")]
		 get { } //Length: 10
		[Address(RVA = "0x95F170", Offset = "0x95E370", Length = "0xAB")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A4")]
		 set { } //Length: 171
	}

	[CreateProperty]
	[Token(Token = "0x170000AC")]
	public TValueType lowValue
	{
		[Address(RVA = "0x95DA50", Offset = "0x95CC50", Length = "0x9")]
		[CalledBy(Type = typeof(SliderInt), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderInt), Member = "SliderRange", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000487")]
		 get { } //Length: 9
		[Address(RVA = "0x95F540", Offset = "0x95E740", Length = "0x13D")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
		[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000488")]
		 set { } //Length: 317
	}

	[CreateProperty]
	[Token(Token = "0x170000AF")]
	public override float pageSize
	{
		[Address(RVA = "0x95DB80", Offset = "0x95CD80", Length = "0xB")]
		[CalledBy(Type = typeof(SliderInt), Member = "get_pageSize", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048D")]
		 get { } //Length: 11
		[Address(RVA = "0x95F7D0", Offset = "0x95E9D0", Length = "0x9C")]
		[CalledBy(Type = typeof(SliderInt), Member = "set_pageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600048E")]
		 set { } //Length: 156
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000AE")]
	public TValueType range
	{
		[Address(RVA = "0x95DBC0", Offset = "0x95CDC0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048C")]
		 get { } //Length: 20
	}

	[CreateProperty]
	[Token(Token = "0x170000B0")]
	public override bool showInputField
	{
		[Address(RVA = "0x95DCD0", Offset = "0x95CED0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048F")]
		 get { } //Length: 10
		[Address(RVA = "0x95FA50", Offset = "0x95EC50", Length = "0xAE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseSlider`1), Member = "UpdateTextFieldVisibility", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000490")]
		 set { } //Length: 174
	}

	[Token(Token = "0x170000A7")]
	internal VisualElement trackElement
	{
		[Address(RVA = "0x95DD10", Offset = "0x95CF10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047E")]
		internal get { } //Length: 8
		[Address(RVA = "0x95FC40", Offset = "0x95EE40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047F")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000B4")]
	public virtual TValueType value
	{
		[Address(RVA = "0x95DE50", Offset = "0x95D050", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000499")]
		 get { } //Length: 38
		[Address(RVA = "0x95FEE0", Offset = "0x95F0E0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D530")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600049A")]
		 set { } //Length: 83
	}

	[Address(RVA = "0x959510", Offset = "0x958710", Length = "0x173A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C8")]
	private static BaseSlider`1() { }

	[Address(RVA = "0x95C7C0", Offset = "0x95B9C0", Length = "0xC00")]
	[CalledBy(Type = typeof(SliderInt), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateTextFieldVisibility", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClampedDragger`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseSlider`1<T>", typeof(Action), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldMouseDragger`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IValueField`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(BaseSlider`1), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseFieldMouseDragger), Member = "SetDragZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A5")]
	internal BaseSlider`1(string label, TValueType start, TValueType end, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x95D4E0", Offset = "0x95C6E0", Length = "0xC5")]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600049E")]
	internal void add_onSetValueWithoutNotify(Action<TValueType> value) { }

	[Address(RVA = "0x94ABE0", Offset = "0x949DE0", Length = "0x446")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleFloat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B6")]
	public void AdjustDragElement(float factor) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049B")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	[Address(RVA = "0x94B6E0", Offset = "0x94A8E0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000497")]
	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }

	[Address(RVA = "0x94B690", Offset = "0x94A890", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A8")]
	private void ClampValue() { }

	[Address(RVA = "0x94C380", Offset = "0x94B580", Length = "0x24D")]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B5")]
	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	[Address(RVA = "0x94CA00", Offset = "0x94BC00", Length = "0x16A")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "SetSliderValueFromDrag", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "SetSliderValueFromClick", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B0")]
	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }

	[Token(Token = "0x60004AD")]
	internal abstract void ComputeValueFromKey(SliderKey<TValueType> sliderKey, bool isShift) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", False)]
	[Token(Token = "0x60004BD")]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[Address(RVA = "0x95D6F0", Offset = "0x95C8F0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000486")]
	virtual bool get_canSwitchToMixedValue() { }

	[Address(RVA = "0x95D7E0", Offset = "0x95C9E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000493")]
	internal bool get_clamped() { }

	[Address(RVA = "0x95D7A0", Offset = "0x95C9A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000495")]
	internal ClampedDragger<TValueType> get_clampedDragger() { }

	[Address(RVA = "0x95D820", Offset = "0x95CA20", Length = "0x9")]
	[CalledBy(Type = typeof(Scroller), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A1")]
	public SliderDirection get_direction() { }

	[Address(RVA = "0x95D830", Offset = "0x95CA30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000480")]
	internal VisualElement get_dragBorderElement() { }

	[Address(RVA = "0x826C60", Offset = "0x825E60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047A")]
	internal VisualElement get_dragContainer() { }

	[Address(RVA = "0x95D840", Offset = "0x95CA40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047C")]
	internal VisualElement get_dragElement() { }

	[Address(RVA = "0x95D8C0", Offset = "0x95CAC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000491")]
	public bool get_fill() { }

	[Address(RVA = "0x95D850", Offset = "0x95CA50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000484")]
	internal VisualElement get_fillElement() { }

	[Address(RVA = "0x95D8D0", Offset = "0x95CAD0", Length = "0x9")]
	[CalledBy(Type = typeof(SliderInt), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "SliderRange", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000489")]
	public TValueType get_highValue() { }

	[Address(RVA = "0x95DA00", Offset = "0x95CC00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000482")]
	internal TextField get_inputTextField() { }

	[Address(RVA = "0x95DA40", Offset = "0x95CC40", Length = "0xA")]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A3")]
	public bool get_inverted() { }

	[Address(RVA = "0x95DA50", Offset = "0x95CC50", Length = "0x9")]
	[CalledBy(Type = typeof(SliderInt), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "SliderRange", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000487")]
	public TValueType get_lowValue() { }

	[Address(RVA = "0x95DB80", Offset = "0x95CD80", Length = "0xB")]
	[CalledBy(Type = typeof(SliderInt), Member = "get_pageSize", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048D")]
	public override float get_pageSize() { }

	[Address(RVA = "0x95DBC0", Offset = "0x95CDC0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048C")]
	public TValueType get_range() { }

	[Address(RVA = "0x95DCD0", Offset = "0x95CED0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048F")]
	public override bool get_showInputField() { }

	[Address(RVA = "0x95DD10", Offset = "0x95CF10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047E")]
	internal VisualElement get_trackElement() { }

	[Address(RVA = "0x95DE50", Offset = "0x95D050", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000499")]
	public virtual TValueType get_value() { }

	[Address(RVA = "0x94CE00", Offset = "0x94C000", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000498")]
	private TValueType GetClampedValue(TValueType newValue) { }

	[Address(RVA = "0x94D340", Offset = "0x94C540", Length = "0x44")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), "UnityEngine.UIElements.MinMaxSlider+DragState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F2B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A6")]
	protected private static float GetClosestPowerOfTen(float positiveNumber) { }

	[Address(RVA = "0x94D4D0", Offset = "0x94C6D0", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GeometryChangedEvent)})]
	[Token(Token = "0x60004BC")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x94D7D0", Offset = "0x94C9D0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C0")]
	private void OnFocusIn(FocusInEvent evt) { }

	[Address(RVA = "0x94D9D0", Offset = "0x94CBD0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C1")]
	private void OnFocusOut(FocusOutEvent evt) { }

	[Address(RVA = "0x94DA70", Offset = "0x94CC70", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B2")]
	private void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x94E060", Offset = "0x94D260", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B3")]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[Address(RVA = "0x94E3D0", Offset = "0x94D5D0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B4")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x94E640", Offset = "0x94D840", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C2")]
	private void OnTextFieldFocusIn(FocusInEvent evt) { }

	[Address(RVA = "0x94E750", Offset = "0x94D950", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D7B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C3")]
	private void OnTextFieldFocusOut(FocusOutEvent evt) { }

	[Address(RVA = "0x94E790", Offset = "0x94D990", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C4")]
	private void OnTextFieldValueChange(ChangeEvent<String> evt) { }

	[Address(RVA = "0x94ED10", Offset = "0x94DF10", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B8")]
	internal virtual void OnViewDataReady() { }

	[Token(Token = "0x60004AC")]
	internal abstract TValueType ParseStringToValue(string previousValue, string newValue) { }

	[Address(RVA = "0x94F1B0", Offset = "0x94E3B0", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C6")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x95DE80", Offset = "0x95D080", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600049F")]
	internal void remove_onSetValueWithoutNotify(Action<TValueType> value) { }

	[Address(RVA = "0x94F330", Offset = "0x94E530", Length = "0x2D")]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), "UnityEngine.UIElements.MinMaxSlider+DragState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderInt), Member = "ComputeValueFromKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.BaseSlider`1+SliderKey<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A7")]
	protected private static float RoundToMultipleOf(float value, float roundingValue) { }

	[Address(RVA = "0x94F360", Offset = "0x94E560", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B9")]
	private bool SameValues(float a, float b, float epsilon) { }

	[Address(RVA = "0x95E0F0", Offset = "0x95D2F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000494")]
	internal void set_clamped(bool value) { }

	[Address(RVA = "0x95E0D0", Offset = "0x95D2D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000496")]
	private void set_clampedDragger(ClampedDragger<TValueType> value) { }

	[Address(RVA = "0x95E430", Offset = "0x95D630", Length = "0x1DC")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scroller), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A2")]
	public void set_direction(SliderDirection value) { }

	[Address(RVA = "0x95E610", Offset = "0x95D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000481")]
	private void set_dragBorderElement(VisualElement value) { }

	[Address(RVA = "0x95E630", Offset = "0x95D830", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047B")]
	private void set_dragContainer(VisualElement value) { }

	[Address(RVA = "0x95E650", Offset = "0x95D850", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047D")]
	private void set_dragElement(VisualElement value) { }

	[Address(RVA = "0x95E7F0", Offset = "0x95D9F0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000492")]
	public void set_fill(bool value) { }

	[Address(RVA = "0x95E670", Offset = "0x95D870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000485")]
	private void set_fillElement(VisualElement value) { }

	[Address(RVA = "0x95EE50", Offset = "0x95E050", Length = "0x144")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048A")]
	public void set_highValue(TValueType value) { }

	[Address(RVA = "0x95EFA0", Offset = "0x95E1A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000483")]
	private void set_inputTextField(TextField value) { }

	[Address(RVA = "0x95F170", Offset = "0x95E370", Length = "0xAB")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A4")]
	public void set_inverted(bool value) { }

	[Address(RVA = "0x95F540", Offset = "0x95E740", Length = "0x13D")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000488")]
	public void set_lowValue(TValueType value) { }

	[Address(RVA = "0x95F7D0", Offset = "0x95E9D0", Length = "0x9C")]
	[CalledBy(Type = typeof(SliderInt), Member = "set_pageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600048E")]
	public override void set_pageSize(float value) { }

	[Address(RVA = "0x95FA50", Offset = "0x95EC50", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateTextFieldVisibility", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000490")]
	public override void set_showInputField(bool value) { }

	[Address(RVA = "0x95FC40", Offset = "0x95EE40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047F")]
	private void set_trackElement(VisualElement value) { }

	[Address(RVA = "0x95FEE0", Offset = "0x95F0E0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D530")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600049A")]
	public virtual void set_value(TValueType value) { }

	[Address(RVA = "0x94F420", Offset = "0x94E620", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D530")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048B")]
	internal void SetHighValueWithoutNotify(TValueType newHighValue) { }

	[Address(RVA = "0x950B90", Offset = "0x94FD90", Length = "0x79D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D8B0")]
	[Calls(Type = typeof(BaseSlider`1), Member = "ComputeValueAndDirectionFromDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B1")]
	private void SetSliderValueFromClick() { }

	[Address(RVA = "0x951790", Offset = "0x950990", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ClampedDragger`1), Member = "get_delta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(BaseSlider`1), Member = "ComputeValueAndDirectionFromDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004AF")]
	private void SetSliderValueFromDrag() { }

	[Address(RVA = "0x951CB0", Offset = "0x950EB0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D530")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D7B0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A0")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x951D60", Offset = "0x950F60", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004AE")]
	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }

	[Token(Token = "0x60004A9")]
	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant) { }

	[Token(Token = "0x60004AA")]
	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }

	[Token(Token = "0x60004AB")]
	internal abstract TValueType SliderRange() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049C")]
	private override void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049D")]
	private override void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }

	[Address(RVA = "0x952080", Offset = "0x951280", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C7")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x952550", Offset = "0x951750", Length = "0x4DE")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "ComputeValueAndDirectionFromDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "set_inverted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "set_fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D8B0")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BA")]
	private void UpdateDragElementPosition() { }

	[Address(RVA = "0x953780", Offset = "0x952980", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B7")]
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	[Address(RVA = "0x9541D0", Offset = "0x9533D0", Length = "0x7DD")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Length), Member = "Percent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BB")]
	private void UpdateFill(float normalizedValue) { }

	[Address(RVA = "0x9553F0", Offset = "0x9545F0", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C5")]
	protected virtual void UpdateMixedValueContent() { }

	[Address(RVA = "0x955760", Offset = "0x954960", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BF")]
	private void UpdateTextFieldValue() { }

	[Address(RVA = "0x956240", Offset = "0x955440", Length = "0x44B")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "set_showInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextField), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "UnregisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D7B0")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BE")]
	private void UpdateTextFieldVisibility() { }

}

