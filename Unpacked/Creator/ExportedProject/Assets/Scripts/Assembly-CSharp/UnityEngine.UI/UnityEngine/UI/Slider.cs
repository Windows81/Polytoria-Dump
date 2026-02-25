namespace UnityEngine.UI;

[AddComponentMenu("UI/Slider", 34)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200006D")]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[Token(Token = "0x2000070")]
	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x200006E")]
	internal enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	[Token(Token = "0x200006F")]
	internal class SliderEvent : UnityEvent<Single>
	{

		[Address(RVA = "0x1CD6720", Offset = "0x1CD5920", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600049A")]
		public SliderEvent() { }

	}

	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000222")]
	private RectTransform m_FillRect; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000223")]
	private RectTransform m_HandleRect; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000224")]
	private Direction m_Direction; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x4000225")]
	private float m_MinValue; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000226")]
	private float m_MaxValue; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	[Token(Token = "0x4000227")]
	private bool m_WholeNumbers; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000228")]
	protected float m_Value; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000229")]
	private SliderEvent m_OnValueChanged; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400022A")]
	private Image m_FillImage; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400022B")]
	private Transform m_FillTransform; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400022C")]
	private RectTransform m_FillContainerRect; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400022D")]
	private Transform m_HandleTransform; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400022E")]
	private RectTransform m_HandleContainerRect; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400022F")]
	private Vector2 m_Offset; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000230")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x160
	[FieldOffset(Offset = "0x161")]
	[Token(Token = "0x4000231")]
	private bool m_DelayedUpdateVisuals; //Field offset: 0x161

	[Token(Token = "0x17000131")]
	private Axis axis
	{
		[Address(RVA = "0x1CD8130", Offset = "0x1CD7330", Length = "0x15")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600048B")]
		private get { } //Length: 21
	}

	[Token(Token = "0x17000129")]
	public Direction direction
	{
		[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046F")]
		 get { } //Length: 7
		[Address(RVA = "0x1CD8280", Offset = "0x1CD7480", Length = "0x59")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[Token(Token = "0x6000470")]
		 set { } //Length: 89
	}

	[Token(Token = "0x17000127")]
	public RectTransform fillRect
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046B")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD82E0", Offset = "0x1CD74E0", Length = "0x65")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600046C")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000128")]
	public RectTransform handleRect
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046D")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD8350", Offset = "0x1CD7550", Length = "0x65")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600046E")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700012B")]
	public float maxValue
	{
		[Address(RVA = "0x460150", Offset = "0x45F350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000473")]
		 get { } //Length: 9
		[Address(RVA = "0x1CD83C0", Offset = "0x1CD75C0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000474")]
		 set { } //Length: 125
	}

	[Token(Token = "0x1700012A")]
	public float minValue
	{
		[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000471")]
		 get { } //Length: 9
		[Address(RVA = "0x1CD8440", Offset = "0x1CD7640", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000472")]
		 set { } //Length: 125
	}

	[Token(Token = "0x1700012E")]
	public float normalizedValue
	{
		[Address(RVA = "0x1CD8150", Offset = "0x1CD7350", Length = "0xAC")]
		[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.ColorSlider", Member = "SliderChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600047A")]
		 get { } //Length: 172
		[Address(RVA = "0x1CD84C0", Offset = "0x1CD76C0", Length = "0x50")]
		[CalledBy(Type = "HSVPicker.ColorSlider", Member = "ColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.ColorSlider", Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600047B")]
		 set { } //Length: 80
	}

	[Token(Token = "0x1700012F")]
	public SliderEvent onValueChanged
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600047C")]
		 get { } //Length: 8
		[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600047D")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000132")]
	private bool reverseValue
	{
		[Address(RVA = "0x1CD8200", Offset = "0x1CD7400", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600048C")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000130")]
	private float stepSize
	{
		[Address(RVA = "0x1CD8220", Offset = "0x1CD7420", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600047E")]
		private get { } //Length: 43
	}

	[Token(Token = "0x1700012D")]
	public override float value
	{
		[Address(RVA = "0x1CD8250", Offset = "0x1CD7450", Length = "0x16")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000477")]
		 get { } //Length: 22
		[Address(RVA = "0x1CD8510", Offset = "0x1CD7710", Length = "0x17")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000478")]
		 set { } //Length: 23
	}

	[Token(Token = "0x1700012C")]
	public bool wholeNumbers
	{
		[Address(RVA = "0x1CD8270", Offset = "0x1CD7470", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000475")]
		 get { } //Length: 8
		[Address(RVA = "0x1CD8530", Offset = "0x1CD7730", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000476")]
		 set { } //Length: 125
	}

	[Address(RVA = "0x1CD8030", Offset = "0x1CD7230", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047F")]
	protected Slider() { }

	[Address(RVA = "0x1CD6760", Offset = "0x1CD5960", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000488")]
	private float ClampValue(float input) { }

	[Address(RVA = "0x1CD6790", Offset = "0x1CD5990", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[Token(Token = "0x6000496")]
	public virtual Selectable FindSelectableOnDown() { }

	[Address(RVA = "0x1CD67C0", Offset = "0x1CD59C0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[Token(Token = "0x6000493")]
	public virtual Selectable FindSelectableOnLeft() { }

	[Address(RVA = "0x1CD67F0", Offset = "0x1CD59F0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[Token(Token = "0x6000494")]
	public virtual Selectable FindSelectableOnRight() { }

	[Address(RVA = "0x1CD6820", Offset = "0x1CD5A20", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[Token(Token = "0x6000495")]
	public virtual Selectable FindSelectableOnUp() { }

	[Address(RVA = "0x1CD8130", Offset = "0x1CD7330", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600048B")]
	private Axis get_axis() { }

	[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046F")]
	public Direction get_direction() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046B")]
	public RectTransform get_fillRect() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046D")]
	public RectTransform get_handleRect() { }

	[Address(RVA = "0x460150", Offset = "0x45F350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000473")]
	public float get_maxValue() { }

	[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000471")]
	public float get_minValue() { }

	[Address(RVA = "0x1CD8150", Offset = "0x1CD7350", Length = "0xAC")]
	[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.ColorSlider", Member = "SliderChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600047A")]
	public float get_normalizedValue() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600047C")]
	public SliderEvent get_onValueChanged() { }

	[Address(RVA = "0x1CD8200", Offset = "0x1CD7400", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600048C")]
	private bool get_reverseValue() { }

	[Address(RVA = "0x1CD8220", Offset = "0x1CD7420", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600047E")]
	private float get_stepSize() { }

	[Address(RVA = "0x1CD8250", Offset = "0x1CD7450", Length = "0x16")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000477")]
	public override float get_value() { }

	[Address(RVA = "0x1CD8270", Offset = "0x1CD7470", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000475")]
	public bool get_wholeNumbers() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000482")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000481")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1094120", Offset = "0x1093320", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600048F")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD6850", Offset = "0x1CD5A50", Length = "0x27F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000486")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CD6AD0", Offset = "0x1CD5CD0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000484")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CD6B00", Offset = "0x1CD5D00", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000491")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD6B80", Offset = "0x1CD5D80", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000483")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1094380", Offset = "0x1093580", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000497")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CD6BD0", Offset = "0x1CD5DD0", Length = "0x44F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 14)]
	[Token(Token = "0x6000492")]
	public virtual void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x1CD7020", Offset = "0x1CD6220", Length = "0x257")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000490")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1CD7280", Offset = "0x1CD6480", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048A")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000480")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x1CD74B0", Offset = "0x1CD66B0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Object), Member = "MarkDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000489")]
	protected override void Set(float input, bool sendCallback = true) { }

	[Address(RVA = "0x1CD8280", Offset = "0x1CD7480", Length = "0x59")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Token(Token = "0x6000470")]
	public void set_direction(Direction value) { }

	[Address(RVA = "0x1CD82E0", Offset = "0x1CD74E0", Length = "0x65")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600046C")]
	public void set_fillRect(RectTransform value) { }

	[Address(RVA = "0x1CD8350", Offset = "0x1CD7550", Length = "0x65")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600046E")]
	public void set_handleRect(RectTransform value) { }

	[Address(RVA = "0x1CD83C0", Offset = "0x1CD75C0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000474")]
	public void set_maxValue(float value) { }

	[Address(RVA = "0x1CD8440", Offset = "0x1CD7640", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000472")]
	public void set_minValue(float value) { }

	[Address(RVA = "0x1CD84C0", Offset = "0x1CD76C0", Length = "0x50")]
	[CalledBy(Type = "HSVPicker.ColorSlider", Member = "ColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.ColorSlider", Member = "HSVChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600047B")]
	public void set_normalizedValue(float value) { }

	[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600047D")]
	public void set_onValueChanged(SliderEvent value) { }

	[Address(RVA = "0x1CD8510", Offset = "0x1CD7710", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000478")]
	public override void set_value(float value) { }

	[Address(RVA = "0x1CD8530", Offset = "0x1CD7730", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000476")]
	public void set_wholeNumbers(bool value) { }

	[Address(RVA = "0x1CD72C0", Offset = "0x1CD64C0", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000498")]
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	[Address(RVA = "0x1CD7490", Offset = "0x1CD6690", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000479")]
	public override void SetValueWithoutNotify(float input) { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000499")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x1CD7FE0", Offset = "0x1CD71E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000485")]
	protected override void Update() { }

	[Address(RVA = "0x1CD75A0", Offset = "0x1CD67A0", Length = "0x386")]
	[CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000487")]
	private void UpdateCachedReferences() { }

	[Address(RVA = "0x1CD7930", Offset = "0x1CD6B30", Length = "0x2B9")]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048E")]
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	[Address(RVA = "0x1CD7BF0", Offset = "0x1CD6DF0", Length = "0x3EC")]
	[CalledBy(Type = typeof(Slider), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_wholeNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600048D")]
	private void UpdateVisuals() { }

}

