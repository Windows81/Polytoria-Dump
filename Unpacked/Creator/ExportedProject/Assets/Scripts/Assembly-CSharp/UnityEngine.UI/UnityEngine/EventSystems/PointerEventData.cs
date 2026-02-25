namespace UnityEngine.EventSystems;

[Token(Token = "0x200009D")]
public class PointerEventData : BaseEventData
{
	[Token(Token = "0x200009F")]
	internal enum FramePressState
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3,
	}

	[Token(Token = "0x200009E")]
	internal enum InputButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D0")]
	private GameObject <pointerEnter>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D1")]
	private GameObject m_PointerPress; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D2")]
	private GameObject <lastPress>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D3")]
	private GameObject <rawPointerPress>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D4")]
	private GameObject <pointerDrag>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D5")]
	private GameObject <pointerClick>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002D6")]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40002D7")]
	private RaycastResult <pointerPressRaycast>k__BackingField; //Field offset: 0xC0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40002D8")]
	public List<GameObject> hovered; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40002D9")]
	private bool <eligibleForClick>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x40002DA")]
	private int <displayIndex>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40002DB")]
	private int <pointerId>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40002DC")]
	private Vector2 <position>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40002DD")]
	private Vector2 <delta>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40002DE")]
	private Vector2 <pressPosition>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x40002DF")]
	private Vector3 <worldPosition>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40002E0")]
	private Vector3 <worldNormal>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x40002E1")]
	private float <clickTime>k__BackingField; //Field offset: 0x174
	[CompilerGenerated]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40002E2")]
	private int <clickCount>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x40002E3")]
	private Vector2 <scrollDelta>k__BackingField; //Field offset: 0x17C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x40002E4")]
	private bool <useDragThreshold>k__BackingField; //Field offset: 0x184
	[CompilerGenerated]
	[FieldOffset(Offset = "0x185")]
	[Token(Token = "0x40002E5")]
	private bool <dragging>k__BackingField; //Field offset: 0x185
	[CompilerGenerated]
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40002E6")]
	private InputButton <button>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x40002E7")]
	private float <pressure>k__BackingField; //Field offset: 0x18C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40002E8")]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x40002E9")]
	private float <altitudeAngle>k__BackingField; //Field offset: 0x194
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40002EA")]
	private float <azimuthAngle>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x40002EB")]
	private float <twist>k__BackingField; //Field offset: 0x19C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40002EC")]
	private Vector2 <tilt>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40002ED")]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x40002EE")]
	private Vector2 <radius>k__BackingField; //Field offset: 0x1AC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x40002EF")]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x1B4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40002F0")]
	private bool <fullyExited>k__BackingField; //Field offset: 0x1BC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1BD")]
	[Token(Token = "0x40002F1")]
	private bool <reentered>k__BackingField; //Field offset: 0x1BD

	[Token(Token = "0x170001B8")]
	public float altitudeAngle
	{
		[Address(RVA = "0x1CE9E80", Offset = "0x1CE9080", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000667")]
		 get { } //Length: 9
		[Address(RVA = "0x1A32EE0", Offset = "0x1A320E0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000668")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001B9")]
	public float azimuthAngle
	{
		[Address(RVA = "0x18B1A10", Offset = "0x18B0C10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000669")]
		 get { } //Length: 9
		[Address(RVA = "0x1A32C60", Offset = "0x1A31E60", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600066A")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001B5")]
	public InputButton button
	{
		[Address(RVA = "0x18B1580", Offset = "0x18B0780", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000661")]
		 get { } //Length: 7
		[Address(RVA = "0x1CEA220", Offset = "0x1CE9420", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000662")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B1")]
	public int clickCount
	{
		[Address(RVA = "0x1CE9E90", Offset = "0x1CE9090", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000659")]
		 get { } //Length: 7
		[Address(RVA = "0x1CEA230", Offset = "0x1CE9430", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600065A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B0")]
	public float clickTime
	{
		[Address(RVA = "0x1CE9EA0", Offset = "0x1CE90A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000657")]
		 get { } //Length: 9
		[Address(RVA = "0x1CEA240", Offset = "0x1CE9440", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000658")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001AC")]
	public Vector2 delta
	{
		[Address(RVA = "0x1CE9EB0", Offset = "0x1CE90B0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600064F")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA250", Offset = "0x1CE9450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000650")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001A9")]
	public int displayIndex
	{
		[Address(RVA = "0x1CE9ED0", Offset = "0x1CE90D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000649")]
		 get { } //Length: 7
		[Address(RVA = "0x1CEA260", Offset = "0x1CE9460", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600064A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B4")]
	public bool dragging
	{
		[Address(RVA = "0x1CE9EE0", Offset = "0x1CE90E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600065F")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA270", Offset = "0x1CE9470", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000660")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001A8")]
	public bool eligibleForClick
	{
		[Address(RVA = "0x1CE9EF0", Offset = "0x1CE90F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000647")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA280", Offset = "0x1CE9480", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000648")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001C1")]
	public Camera enterEventCamera
	{
		[Address(RVA = "0x1CE9F00", Offset = "0x1CE9100", Length = "0x98")]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600067C")]
		 get { } //Length: 152
	}

	[Token(Token = "0x170001BF")]
	public bool fullyExited
	{
		[Address(RVA = "0x497970", Offset = "0x496B70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000675")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA290", Offset = "0x1CE9490", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000676")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001A2")]
	public private GameObject lastPress
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063B")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001BC")]
	public PenStatus penStatus
	{
		[Address(RVA = "0x460460", Offset = "0x45F660", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600066F")]
		 get { } //Length: 7
		[Address(RVA = "0x1CEA2A0", Offset = "0x1CE94A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000670")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001A5")]
	public GameObject pointerClick
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000641")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000642")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001A6")]
	public RaycastResult pointerCurrentRaycast
	{
		[Address(RVA = "0x1CE9FA0", Offset = "0x1CE91A0", Length = "0x47")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000643")]
		 get { } //Length: 71
		[Address(RVA = "0x1CEA2B0", Offset = "0x1CE94B0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000644")]
		 set { } //Length: 78
	}

	[Token(Token = "0x170001A4")]
	public GameObject pointerDrag
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063F")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000640")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001A1")]
	public GameObject pointerEnter
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000639")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001AA")]
	public int pointerId
	{
		[Address(RVA = "0x460200", Offset = "0x45F400", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600064B")]
		 get { } //Length: 7
		[Address(RVA = "0x1CEA300", Offset = "0x1CE9500", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600064C")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001C3")]
	public GameObject pointerPress
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067E")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEA370", Offset = "0x1CE9570", Length = "0x8D")]
		[CalledBy(Type = typeof(PointerInputModule), Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600067F")]
		 set { } //Length: 141
	}

	[Token(Token = "0x170001A7")]
	public RaycastResult pointerPressRaycast
	{
		[Address(RVA = "0x1CE9FF0", Offset = "0x1CE91F0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000645")]
		 get { } //Length: 80
		[Address(RVA = "0x1CEA310", Offset = "0x1CE9510", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000646")]
		 set { } //Length: 90
	}

	[Token(Token = "0x170001AB")]
	public Vector2 position
	{
		[Address(RVA = "0x1CEA040", Offset = "0x1CE9240", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600064D")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA400", Offset = "0x1CE9600", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600064E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001C2")]
	public Camera pressEventCamera
	{
		[Address(RVA = "0x1CEA060", Offset = "0x1CE9260", Length = "0x9E")]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnResizeStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnDragStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField+<MouseDragOutsideRect>d__314", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600067D")]
		 get { } //Length: 158
	}

	[Token(Token = "0x170001AD")]
	public Vector2 pressPosition
	{
		[Address(RVA = "0x1CEA100", Offset = "0x1CE9300", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000651")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA410", Offset = "0x1CE9610", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000652")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B6")]
	public float pressure
	{
		[Address(RVA = "0x1CEA120", Offset = "0x1CE9320", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000663")]
		 get { } //Length: 9
		[Address(RVA = "0x1CEA420", Offset = "0x1CE9620", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000664")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001BD")]
	public Vector2 radius
	{
		[Address(RVA = "0x1CEA150", Offset = "0x1CE9350", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000671")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA440", Offset = "0x1CE9640", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000672")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001BE")]
	public Vector2 radiusVariance
	{
		[Address(RVA = "0x1CEA130", Offset = "0x1CE9330", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000673")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA430", Offset = "0x1CE9630", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000674")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001A3")]
	public GameObject rawPointerPress
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063D")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001C0")]
	public bool reentered
	{
		[Address(RVA = "0x4979A0", Offset = "0x496BA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000677")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA450", Offset = "0x1CE9650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000678")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B2")]
	public Vector2 scrollDelta
	{
		[Address(RVA = "0x1CEA170", Offset = "0x1CE9370", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600065B")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA460", Offset = "0x1CE9660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600065C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B7")]
	public float tangentialPressure
	{
		[Address(RVA = "0x1CEA190", Offset = "0x1CE9390", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000665")]
		 get { } //Length: 9
		[Address(RVA = "0x1A32EF0", Offset = "0x1A320F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000666")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001BB")]
	public Vector2 tilt
	{
		[Address(RVA = "0x1CEA1A0", Offset = "0x1CE93A0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600066D")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA470", Offset = "0x1CE9670", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600066E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001BA")]
	public float twist
	{
		[Address(RVA = "0x1CEA1C0", Offset = "0x1CE93C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600066B")]
		 get { } //Length: 9
		[Address(RVA = "0x1A32C50", Offset = "0x1A31E50", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600066C")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001B3")]
	public bool useDragThreshold
	{
		[Address(RVA = "0x1CEA1D0", Offset = "0x1CE93D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600065D")]
		 get { } //Length: 8
		[Address(RVA = "0x1B91920", Offset = "0x1B90B20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600065E")]
		 set { } //Length: 7
	}

	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	[Token(Token = "0x170001AF")]
	public Vector3 worldNormal
	{
		[Address(RVA = "0x1CEA1E0", Offset = "0x1CE93E0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000655")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA480", Offset = "0x1CE9680", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000656")]
		 set { } //Length: 22
	}

	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	[Token(Token = "0x170001AE")]
	public Vector3 worldPosition
	{
		[Address(RVA = "0x1CEA200", Offset = "0x1CE9400", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000653")]
		 get { } //Length: 25
		[Address(RVA = "0x1CEA4A0", Offset = "0x1CE96A0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000654")]
		 set { } //Length: 22
	}

	[Address(RVA = "0x1CE9C00", Offset = "0x1CE8E00", Length = "0x272")]
	[CalledBy(Type = "RLD.RTScene", Member = "GetHoveredUIElements", ReturnType = "System.Collections.Generic.List`1<RaycastResult>")]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "IsCursorOverUi", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "IsPointerOverUIObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000679")]
	public PointerEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x1CE9E80", Offset = "0x1CE9080", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000667")]
	public float get_altitudeAngle() { }

	[Address(RVA = "0x18B1A10", Offset = "0x18B0C10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000669")]
	public float get_azimuthAngle() { }

	[Address(RVA = "0x18B1580", Offset = "0x18B0780", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000661")]
	public InputButton get_button() { }

	[Address(RVA = "0x1CE9E90", Offset = "0x1CE9090", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000659")]
	public int get_clickCount() { }

	[Address(RVA = "0x1CE9EA0", Offset = "0x1CE90A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000657")]
	public float get_clickTime() { }

	[Address(RVA = "0x1CE9EB0", Offset = "0x1CE90B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600064F")]
	public Vector2 get_delta() { }

	[Address(RVA = "0x1CE9ED0", Offset = "0x1CE90D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000649")]
	public int get_displayIndex() { }

	[Address(RVA = "0x1CE9EE0", Offset = "0x1CE90E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600065F")]
	public bool get_dragging() { }

	[Address(RVA = "0x1CE9EF0", Offset = "0x1CE90F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000647")]
	public bool get_eligibleForClick() { }

	[Address(RVA = "0x1CE9F00", Offset = "0x1CE9100", Length = "0x98")]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067C")]
	public Camera get_enterEventCamera() { }

	[Address(RVA = "0x497970", Offset = "0x496B70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000675")]
	public bool get_fullyExited() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063B")]
	public GameObject get_lastPress() { }

	[Address(RVA = "0x460460", Offset = "0x45F660", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600066F")]
	public PenStatus get_penStatus() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000641")]
	public GameObject get_pointerClick() { }

	[Address(RVA = "0x1CE9FA0", Offset = "0x1CE91A0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000643")]
	public RaycastResult get_pointerCurrentRaycast() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063F")]
	public GameObject get_pointerDrag() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000639")]
	public GameObject get_pointerEnter() { }

	[Address(RVA = "0x460200", Offset = "0x45F400", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600064B")]
	public int get_pointerId() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067E")]
	public GameObject get_pointerPress() { }

	[Address(RVA = "0x1CE9FF0", Offset = "0x1CE91F0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000645")]
	public RaycastResult get_pointerPressRaycast() { }

	[Address(RVA = "0x1CEA040", Offset = "0x1CE9240", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600064D")]
	public Vector2 get_position() { }

	[Address(RVA = "0x1CEA060", Offset = "0x1CE9260", Length = "0x9E")]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField+<MouseDragOutsideRect>d__314", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnDragStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnResizeStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.BoxSlider", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067D")]
	public Camera get_pressEventCamera() { }

	[Address(RVA = "0x1CEA100", Offset = "0x1CE9300", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000651")]
	public Vector2 get_pressPosition() { }

	[Address(RVA = "0x1CEA120", Offset = "0x1CE9320", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000663")]
	public float get_pressure() { }

	[Address(RVA = "0x1CEA150", Offset = "0x1CE9350", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000671")]
	public Vector2 get_radius() { }

	[Address(RVA = "0x1CEA130", Offset = "0x1CE9330", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000673")]
	public Vector2 get_radiusVariance() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063D")]
	public GameObject get_rawPointerPress() { }

	[Address(RVA = "0x4979A0", Offset = "0x496BA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000677")]
	public bool get_reentered() { }

	[Address(RVA = "0x1CEA170", Offset = "0x1CE9370", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600065B")]
	public Vector2 get_scrollDelta() { }

	[Address(RVA = "0x1CEA190", Offset = "0x1CE9390", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000665")]
	public float get_tangentialPressure() { }

	[Address(RVA = "0x1CEA1A0", Offset = "0x1CE93A0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600066D")]
	public Vector2 get_tilt() { }

	[Address(RVA = "0x1CEA1C0", Offset = "0x1CE93C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600066B")]
	public float get_twist() { }

	[Address(RVA = "0x1CEA1D0", Offset = "0x1CE93D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600065D")]
	public bool get_useDragThreshold() { }

	[Address(RVA = "0x1CEA1E0", Offset = "0x1CE93E0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000655")]
	public Vector3 get_worldNormal() { }

	[Address(RVA = "0x1CEA200", Offset = "0x1CE9400", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000653")]
	public Vector3 get_worldPosition() { }

	[Address(RVA = "0x1CE94A0", Offset = "0x1CE86A0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067A")]
	public bool IsPointerMoving() { }

	[Address(RVA = "0x1CE94D0", Offset = "0x1CE86D0", Length = "0x26")]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067B")]
	public bool IsScrolling() { }

	[Address(RVA = "0x1A32EE0", Offset = "0x1A320E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000668")]
	public void set_altitudeAngle(float value) { }

	[Address(RVA = "0x1A32C60", Offset = "0x1A31E60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600066A")]
	public void set_azimuthAngle(float value) { }

	[Address(RVA = "0x1CEA220", Offset = "0x1CE9420", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000662")]
	public void set_button(InputButton value) { }

	[Address(RVA = "0x1CEA230", Offset = "0x1CE9430", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600065A")]
	public void set_clickCount(int value) { }

	[Address(RVA = "0x1CEA240", Offset = "0x1CE9440", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000658")]
	public void set_clickTime(float value) { }

	[Address(RVA = "0x1CEA250", Offset = "0x1CE9450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000650")]
	public void set_delta(Vector2 value) { }

	[Address(RVA = "0x1CEA260", Offset = "0x1CE9460", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600064A")]
	public void set_displayIndex(int value) { }

	[Address(RVA = "0x1CEA270", Offset = "0x1CE9470", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000660")]
	public void set_dragging(bool value) { }

	[Address(RVA = "0x1CEA280", Offset = "0x1CE9480", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000648")]
	public void set_eligibleForClick(bool value) { }

	[Address(RVA = "0x1CEA290", Offset = "0x1CE9490", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000676")]
	public void set_fullyExited(bool value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063C")]
	private void set_lastPress(GameObject value) { }

	[Address(RVA = "0x1CEA2A0", Offset = "0x1CE94A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000670")]
	public void set_penStatus(PenStatus value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000642")]
	public void set_pointerClick(GameObject value) { }

	[Address(RVA = "0x1CEA2B0", Offset = "0x1CE94B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000644")]
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000640")]
	public void set_pointerDrag(GameObject value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063A")]
	public void set_pointerEnter(GameObject value) { }

	[Address(RVA = "0x1CEA300", Offset = "0x1CE9500", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600064C")]
	public void set_pointerId(int value) { }

	[Address(RVA = "0x1CEA370", Offset = "0x1CE9570", Length = "0x8D")]
	[CalledBy(Type = typeof(PointerInputModule), Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600067F")]
	public void set_pointerPress(GameObject value) { }

	[Address(RVA = "0x1CEA310", Offset = "0x1CE9510", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000646")]
	public void set_pointerPressRaycast(RaycastResult value) { }

	[Address(RVA = "0x1CEA400", Offset = "0x1CE9600", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600064E")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x1CEA410", Offset = "0x1CE9610", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000652")]
	public void set_pressPosition(Vector2 value) { }

	[Address(RVA = "0x1CEA420", Offset = "0x1CE9620", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000664")]
	public void set_pressure(float value) { }

	[Address(RVA = "0x1CEA440", Offset = "0x1CE9640", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000672")]
	public void set_radius(Vector2 value) { }

	[Address(RVA = "0x1CEA430", Offset = "0x1CE9630", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000674")]
	public void set_radiusVariance(Vector2 value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063E")]
	public void set_rawPointerPress(GameObject value) { }

	[Address(RVA = "0x1CEA450", Offset = "0x1CE9650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000678")]
	public void set_reentered(bool value) { }

	[Address(RVA = "0x1CEA460", Offset = "0x1CE9660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600065C")]
	public void set_scrollDelta(Vector2 value) { }

	[Address(RVA = "0x1A32EF0", Offset = "0x1A320F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000666")]
	public void set_tangentialPressure(float value) { }

	[Address(RVA = "0x1CEA470", Offset = "0x1CE9670", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600066E")]
	public void set_tilt(Vector2 value) { }

	[Address(RVA = "0x1A32C50", Offset = "0x1A31E50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600066C")]
	public void set_twist(float value) { }

	[Address(RVA = "0x1B91920", Offset = "0x1B90B20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600065E")]
	public void set_useDragThreshold(bool value) { }

	[Address(RVA = "0x1CEA480", Offset = "0x1CE9680", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000656")]
	public void set_worldNormal(Vector3 value) { }

	[Address(RVA = "0x1CEA4A0", Offset = "0x1CE96A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000654")]
	public void set_worldPosition(Vector3 value) { }

	[Address(RVA = "0x1CE9500", Offset = "0x1CE8700", Length = "0x6F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180866B80")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000680")]
	public virtual string ToString() { }

}

