namespace HSVPicker;

[AddComponentMenu("UI/BoxSlider", 35)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000014")]
public class BoxSlider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[Token(Token = "0x2000017")]
	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x2000016")]
	internal class BoxSliderEvent : UnityEvent<Single, Single>
	{

		[Address(RVA = "0x10940E0", Offset = "0x10932E0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000087")]
		public BoxSliderEvent() { }

	}

	[Token(Token = "0x2000015")]
	internal enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private RectTransform m_HandleRect; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Space(6)]
	[Token(Token = "0x4000050")]
	private float m_MinValue; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	[Token(Token = "0x4000051")]
	private float m_MaxValue; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000052")]
	private bool m_WholeNumbers; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x4000053")]
	private float m_Value; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000054")]
	private float m_ValueY; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Space(6)]
	[Token(Token = "0x4000055")]
	private BoxSliderEvent m_OnValueChanged; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000056")]
	private Transform m_HandleTransform; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000057")]
	private RectTransform m_HandleContainerRect; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000058")]
	private Vector2 m_Offset; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000059")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x140

	[Token(Token = "0x1700000D")]
	public RectTransform handleRect
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005F")]
		 get { } //Length: 8
		[Address(RVA = "0x1095020", Offset = "0x1094220", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BoxSlider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000060")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700000F")]
	public float maxValue
	{
		[Address(RVA = "0x420990", Offset = "0x41FB90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 get { } //Length: 9
		[Address(RVA = "0x1095090", Offset = "0x1094290", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000064")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700000E")]
	public float minValue
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000061")]
		 get { } //Length: 9
		[Address(RVA = "0x1095120", Offset = "0x1094320", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000062")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000012")]
	public float normalizedValue
	{
		[Address(RVA = "0x1094F00", Offset = "0x1094100", Length = "0xAB")]
		[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000069")]
		 get { } //Length: 171
		[Address(RVA = "0x1095200", Offset = "0x1094400", Length = "0x47")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600006A")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000014")]
	public float normalizedValueY
	{
		[Address(RVA = "0x1094E50", Offset = "0x1094050", Length = "0xAB")]
		[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600006D")]
		 get { } //Length: 171
		[Address(RVA = "0x10951B0", Offset = "0x10943B0", Length = "0x47")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600006E")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000015")]
	public BoxSliderEvent onValueChanged
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006F")]
		 get { } //Length: 8
		[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000070")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000016")]
	private float stepSize
	{
		[Address(RVA = "0x1094FB0", Offset = "0x10941B0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000071")]
		private get { } //Length: 43
	}

	[Token(Token = "0x17000011")]
	public float value
	{
		[Address(RVA = "0x1095000", Offset = "0x1094200", Length = "0x16")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000067")]
		 get { } //Length: 22
		[Address(RVA = "0x1094710", Offset = "0x1093910", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000068")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000013")]
	public float valueY
	{
		[Address(RVA = "0x1094FE0", Offset = "0x10941E0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x600006B")]
		 get { } //Length: 22
		[Address(RVA = "0x1094700", Offset = "0x1093900", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600006C")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000010")]
	public bool wholeNumbers
	{
		[Address(RVA = "0x4671D0", Offset = "0x4663D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		 get { } //Length: 8
		[Address(RVA = "0x1095250", Offset = "0x1094450", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000066")]
		 set { } //Length: 136
	}

	[Address(RVA = "0x1094D40", Offset = "0x1093F40", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	protected BoxSlider() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public RectTransform get_handleRect() { }

	[Address(RVA = "0x420990", Offset = "0x41FB90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public float get_maxValue() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public float get_minValue() { }

	[Address(RVA = "0x1094F00", Offset = "0x1094100", Length = "0xAB")]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000069")]
	public float get_normalizedValue() { }

	[Address(RVA = "0x1094E50", Offset = "0x1094050", Length = "0xAB")]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006D")]
	public float get_normalizedValueY() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006F")]
	public BoxSliderEvent get_onValueChanged() { }

	[Address(RVA = "0x1094FB0", Offset = "0x10941B0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000071")]
	private float get_stepSize() { }

	[Address(RVA = "0x1095000", Offset = "0x1094200", Length = "0x16")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000067")]
	public float get_value() { }

	[Address(RVA = "0x1094FE0", Offset = "0x10941E0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600006B")]
	public float get_valueY() { }

	[Address(RVA = "0x4671D0", Offset = "0x4663D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public bool get_wholeNumbers() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1094120", Offset = "0x1093320", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1094190", Offset = "0x1093390", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x10941C0", Offset = "0x10933C0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000084")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1094240", Offset = "0x1093440", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Token(Token = "0x6000078")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1094380", Offset = "0x1093580", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000085")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x10943A0", Offset = "0x10935A0", Length = "0x242")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000083")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x10945F0", Offset = "0x10937F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600007F")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000073")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x1094710", Offset = "0x1093910", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	private void Set(float input) { }

	[Address(RVA = "0x1094720", Offset = "0x1093920", Length = "0xE4")]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_wholeNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_normalizedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`2), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007C")]
	private void Set(float input, bool sendCallback) { }

	[Address(RVA = "0x1095020", Offset = "0x1094220", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	public void set_handleRect(RectTransform value) { }

	[Address(RVA = "0x1095090", Offset = "0x1094290", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000064")]
	public void set_maxValue(float value) { }

	[Address(RVA = "0x1095120", Offset = "0x1094320", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000062")]
	public void set_minValue(float value) { }

	[Address(RVA = "0x1095200", Offset = "0x1094400", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006A")]
	public void set_normalizedValue(float value) { }

	[Address(RVA = "0x10951B0", Offset = "0x10943B0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006E")]
	public void set_normalizedValueY(float value) { }

	[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000070")]
	public void set_onValueChanged(BoxSliderEvent value) { }

	[Address(RVA = "0x1094710", Offset = "0x1093910", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000068")]
	public void set_value(float value) { }

	[Address(RVA = "0x1094700", Offset = "0x1093900", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600006C")]
	public void set_valueY(float value) { }

	[Address(RVA = "0x1095250", Offset = "0x1094450", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public void set_wholeNumbers(bool value) { }

	[Address(RVA = "0x684ED0", Offset = "0x6840D0", Length = "0x5F")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public static bool SetClass(ref T currentValue, T newValue) { }

	[Address(RVA = "0x684F30", Offset = "0x684130", Length = "0x90")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public static bool SetStruct(ref T currentValue, T newValue) { }

	[Address(RVA = "0x1094700", Offset = "0x1093900", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	private void SetY(float input) { }

	[Address(RVA = "0x1094610", Offset = "0x1093810", Length = "0xE4")]
	[CalledBy(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_wholeNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_valueY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_normalizedValueY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BoxSlider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEvent`2), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Token(Token = "0x600007E")]
	private void SetY(float input, bool sendCallback) { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000086")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x1094820", Offset = "0x1093A20", Length = "0x138")]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600007A")]
	private void UpdateCachedReferences() { }

	[Address(RVA = "0x1094960", Offset = "0x1093B60", Length = "0x289")]
	[CalledBy(Type = typeof(BoxSlider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000081")]
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	[Address(RVA = "0x1094BF0", Offset = "0x1093DF0", Length = "0x142")]
	[CalledBy(Type = typeof(BoxSlider), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_wholeNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxSlider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxSlider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(BoxSlider), Member = "get_normalizedValueY", ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000080")]
	private void UpdateVisuals() { }

}

