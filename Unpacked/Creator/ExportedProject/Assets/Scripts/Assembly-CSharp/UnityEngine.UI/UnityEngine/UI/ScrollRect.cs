namespace UnityEngine.UI;

[AddComponentMenu("UI/Scroll Rect", 37)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[SelectionBase]
[Token(Token = "0x2000065")]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
{
	[Token(Token = "0x2000066")]
	internal enum MovementType
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	[Token(Token = "0x2000067")]
	internal enum ScrollbarVisibility
	{
		Permanent = 0,
		AutoHide = 1,
		AutoHideAndExpandViewport = 2,
	}

	[Token(Token = "0x2000068")]
	internal class ScrollRectEvent : UnityEvent<Vector2>
	{

		[Address(RVA = "0x1CCCF00", Offset = "0x1CCC100", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000428")]
		public ScrollRectEvent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001DA")]
	private RectTransform m_Content; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001DB")]
	private bool m_Horizontal; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	[Token(Token = "0x40001DC")]
	private bool m_Vertical; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40001DD")]
	private MovementType m_MovementType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001DE")]
	private float m_Elasticity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40001DF")]
	private bool m_Inertia; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001E0")]
	private float m_DecelerationRate; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40001E1")]
	private float m_ScrollSensitivity; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001E2")]
	private RectTransform m_Viewport; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40001E3")]
	private Scrollbar m_HorizontalScrollbar; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40001E4")]
	private Scrollbar m_VerticalScrollbar; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40001E5")]
	private ScrollbarVisibility m_HorizontalScrollbarVisibility; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40001E6")]
	private ScrollbarVisibility m_VerticalScrollbarVisibility; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	private float m_HorizontalScrollbarSpacing; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40001E8")]
	private float m_VerticalScrollbarSpacing; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40001E9")]
	private ScrollRectEvent m_OnValueChanged; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001EA")]
	private Vector2 m_PointerStartLocalCursor; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001EB")]
	protected Vector2 m_ContentStartPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001EC")]
	private RectTransform m_ViewRect; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001ED")]
	protected Bounds m_ContentBounds; //Field offset: 0x88
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001EE")]
	private Bounds m_ViewBounds; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001EF")]
	private Vector2 m_Velocity; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001F0")]
	private bool m_Dragging; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x40001F1")]
	private bool m_Scrolling; //Field offset: 0xC1
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40001F2")]
	private Vector2 m_PrevPosition; //Field offset: 0xC4
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40001F3")]
	private Bounds m_PrevContentBounds; //Field offset: 0xCC
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40001F4")]
	private Bounds m_PrevViewBounds; //Field offset: 0xE4
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40001F5")]
	private bool m_HasRebuiltLayout; //Field offset: 0xFC
	[FieldOffset(Offset = "0xFD")]
	[Token(Token = "0x40001F6")]
	private bool m_HSliderExpand; //Field offset: 0xFD
	[FieldOffset(Offset = "0xFE")]
	[Token(Token = "0x40001F7")]
	private bool m_VSliderExpand; //Field offset: 0xFE
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40001F8")]
	private float m_HSliderHeight; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40001F9")]
	private float m_VSliderWidth; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40001FA")]
	private RectTransform m_Rect; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40001FB")]
	private RectTransform m_HorizontalScrollbarRect; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40001FC")]
	private RectTransform m_VerticalScrollbarRect; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001FD")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001FE")]
	private readonly Vector3[] m_Corners; //Field offset: 0x128

	[Token(Token = "0x170000F8")]
	public RectTransform content
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CD")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000FE")]
	public float decelerationRate
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D9")]
		 get { } //Length: 6
		[Address(RVA = "0x1A23940", Offset = "0x1A22B40", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DA")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000FC")]
	public float elasticity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D5")]
		 get { } //Length: 6
		[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D6")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000115")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000418")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000112")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000415")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000F9")]
	public bool horizontal
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CF")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010C")]
	public float horizontalNormalizedPosition
	{
		[Address(RVA = "0x1CD1280", Offset = "0x1CD0480", Length = "0x101")]
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000406")]
		 get { } //Length: 257
		[Address(RVA = "0x1CCEFE0", Offset = "0x1CCE1E0", Length = "0x17")]
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000407")]
		 set { } //Length: 23
	}

	[Token(Token = "0x17000101")]
	public Scrollbar horizontalScrollbar
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DF")]
		 get { } //Length: 5
		[Address(RVA = "0x1CD1770", Offset = "0x1CD0970", Length = "0x18B")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60003E0")]
		 set { } //Length: 395
	}

	[Token(Token = "0x17000105")]
	public float horizontalScrollbarSpacing
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 6
		[Address(RVA = "0x1CD1750", Offset = "0x1CD0950", Length = "0xC")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60003E8")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000103")]
	public ScrollbarVisibility horizontalScrollbarVisibility
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E3")]
		 get { } //Length: 4
		[Address(RVA = "0x1CD1760", Offset = "0x1CD0960", Length = "0xA")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[Token(Token = "0x60003E4")]
		 set { } //Length: 10
	}

	[Token(Token = "0x1700010E")]
	private bool hScrollingNeeded
	{
		[Address(RVA = "0x1CD11F0", Offset = "0x1CD03F0", Length = "0x81")]
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600040F")]
		private get { } //Length: 129
	}

	[Token(Token = "0x170000FD")]
	public bool inertia
	{
		[Address(RVA = "0x500BB0", Offset = "0x4FFDB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D7")]
		 get { } //Length: 5
		[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000116")]
	public override int layoutPriority
	{
		[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000419")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000113")]
	public override float minHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000416")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000110")]
	public override float minWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000413")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000FB")]
	public MovementType movementType
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D3")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010B")]
	public Vector2 normalizedPosition
	{
		[Address(RVA = "0x1CD1390", Offset = "0x1CD0590", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
		[Token(Token = "0x6000404")]
		 get { } //Length: 53
		[Address(RVA = "0x1CD1900", Offset = "0x1CD0B00", Length = "0x52")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000405")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000107")]
	public ScrollRectEvent onValueChanged
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 5
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000114")]
	public override float preferredHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000417")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000111")]
	public override float preferredWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000414")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700010A")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x1CD13D0", Offset = "0x1CD05D0", Length = "0x99")]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60003F0")]
		private get { } //Length: 153
	}

	[Token(Token = "0x170000FF")]
	public float scrollSensitivity
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DB")]
		 get { } //Length: 6
		[Address(RVA = "0x1A823D0", Offset = "0x1A815D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DC")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000109")]
	public Vector2 velocity
	{
		[Address(RVA = "0x1CD14F0", Offset = "0x1CD06F0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 25
		[Address(RVA = "0x1CD1960", Offset = "0x1CD0B60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003EF")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170000FA")]
	public bool vertical
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D1")]
		 get { } //Length: 5
		[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010D")]
	public float verticalNormalizedPosition
	{
		[Address(RVA = "0x1CD1510", Offset = "0x1CD0710", Length = "0x10D")]
		[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000408")]
		 get { } //Length: 269
		[Address(RVA = "0x1CCFD90", Offset = "0x1CCEF90", Length = "0x1A")]
		[CallerCount(Count = 26)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000409")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000102")]
	public Scrollbar verticalScrollbar
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E1")]
		 get { } //Length: 5
		[Address(RVA = "0x1CD1990", Offset = "0x1CD0B90", Length = "0x18B")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60003E2")]
		 set { } //Length: 395
	}

	[Token(Token = "0x17000106")]
	public float verticalScrollbarSpacing
	{
		[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E9")]
		 get { } //Length: 6
		[Address(RVA = "0x1CD1970", Offset = "0x1CD0B70", Length = "0xC")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60003EA")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000104")]
	public ScrollbarVisibility verticalScrollbarVisibility
	{
		[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 4
		[Address(RVA = "0x1CD1980", Offset = "0x1CD0B80", Length = "0xA")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[Token(Token = "0x60003E6")]
		 set { } //Length: 10
	}

	[Token(Token = "0x17000100")]
	public RectTransform viewport
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DD")]
		 get { } //Length: 5
		[Address(RVA = "0x1CD1B20", Offset = "0x1CD0D20", Length = "0x25")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[Token(Token = "0x60003DE")]
		 set { } //Length: 37
	}

	[Token(Token = "0x17000108")]
	protected RectTransform viewRect
	{
		[Address(RVA = "0x1CD1620", Offset = "0x1CD0820", Length = "0x125")]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60003ED")]
		 get { } //Length: 293
	}

	[Token(Token = "0x1700010F")]
	private bool vScrollingNeeded
	{
		[Address(RVA = "0x1CD1470", Offset = "0x1CD0670", Length = "0x79")]
		[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000410")]
		private get { } //Length: 121
	}

	[Address(RVA = "0x1CD1050", Offset = "0x1CD0250", Length = "0x19D")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003F1")]
	protected ScrollRect() { }

	[Address(RVA = "0x1CCCF40", Offset = "0x1CCC140", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000420")]
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000411")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000412")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CCCFE0", Offset = "0x1CCC1E0", Length = "0x1D5")]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000423")]
	private Vector2 CalculateOffset(Vector2 delta) { }

	[Address(RVA = "0x1CCD1C0", Offset = "0x1CCC3C0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Token(Token = "0x60003F9")]
	private void EnsureLayoutHasRebuilt() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CD")]
	public RectTransform get_content() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D9")]
	public float get_decelerationRate() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D5")]
	public float get_elasticity() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000418")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000415")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CF")]
	public bool get_horizontal() { }

	[Address(RVA = "0x1CD1280", Offset = "0x1CD0480", Length = "0x101")]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000406")]
	public float get_horizontalNormalizedPosition() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DF")]
	public Scrollbar get_horizontalScrollbar() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E7")]
	public float get_horizontalScrollbarSpacing() { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E3")]
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	[Address(RVA = "0x1CD11F0", Offset = "0x1CD03F0", Length = "0x81")]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600040F")]
	private bool get_hScrollingNeeded() { }

	[Address(RVA = "0x500BB0", Offset = "0x4FFDB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D7")]
	public bool get_inertia() { }

	[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000419")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000416")]
	public override float get_minHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000413")]
	public override float get_minWidth() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D3")]
	public MovementType get_movementType() { }

	[Address(RVA = "0x1CD1390", Offset = "0x1CD0590", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Token(Token = "0x6000404")]
	public Vector2 get_normalizedPosition() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EB")]
	public ScrollRectEvent get_onValueChanged() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000417")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000414")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x1CD13D0", Offset = "0x1CD05D0", Length = "0x99")]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003F0")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DB")]
	public float get_scrollSensitivity() { }

	[Address(RVA = "0x1CD14F0", Offset = "0x1CD06F0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60003EE")]
	public Vector2 get_velocity() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D1")]
	public bool get_vertical() { }

	[Address(RVA = "0x1CD1510", Offset = "0x1CD0710", Length = "0x10D")]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Battlehub.UIControls.ItemsControl", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000408")]
	public float get_verticalNormalizedPosition() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E1")]
	public Scrollbar get_verticalScrollbar() { }

	[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E9")]
	public float get_verticalScrollbarSpacing() { }

	[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E5")]
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DD")]
	public RectTransform get_viewport() { }

	[Address(RVA = "0x1CD1620", Offset = "0x1CD0820", Length = "0x125")]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60003ED")]
	protected RectTransform get_viewRect() { }

	[Address(RVA = "0x1CD1470", Offset = "0x1CD0670", Length = "0x79")]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000410")]
	private bool get_vScrollingNeeded() { }

	[Address(RVA = "0x1CCD220", Offset = "0x1CCC420", Length = "0x13B")]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(ScrollRect), Member = "InternalGetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Matrix4x4&)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000421")]
	private Bounds GetBounds() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F4")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x1CCD360", Offset = "0x1CCC560", Length = "0x1AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000424")]
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) { }

	[Address(RVA = "0x1CCD510", Offset = "0x1CCC710", Length = "0x279")]
	[CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000422")]
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	[Address(RVA = "0x1CCD790", Offset = "0x1CCC990", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIBehaviour), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60003F8")]
	public virtual bool IsActive() { }

	[Address(RVA = "0x1CCD800", Offset = "0x1CCCA00", Length = "0xA0B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateOneScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(ScrollbarVisibility), typeof(Scrollbar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdatePrevData", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Vector2>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000401")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F3")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1CCE210", Offset = "0x1CCD410", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FD")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CCE380", Offset = "0x1CCD580", Length = "0x234")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60003F7")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CCE5C0", Offset = "0x1CCD7C0", Length = "0x240")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "RubberDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003FF")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CCE810", Offset = "0x1CCDA10", Length = "0x1AA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60003F6")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CCE9C0", Offset = "0x1CCDBC0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FE")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CCE9F0", Offset = "0x1CCDBF0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FC")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CCEA60", Offset = "0x1CCDC60", Length = "0x7")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600040E")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1CCEA70", Offset = "0x1CCDC70", Length = "0x218")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = "IsScrolling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003FB")]
	public override void OnScroll(PointerEventData data) { }

	[Address(RVA = "0x1CCEC90", Offset = "0x1CCDE90", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdatePrevData", ReturnType = typeof(void))]
	[Token(Token = "0x60003F2")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x1CCED20", Offset = "0x1CCDF20", Length = "0x51")]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600040D")]
	private static float RubberDelta(float overStretching, float viewSize) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CE")]
	public void set_content(RectTransform value) { }

	[Address(RVA = "0x1A23940", Offset = "0x1A22B40", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DA")]
	public void set_decelerationRate(float value) { }

	[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D6")]
	public void set_elasticity(float value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D0")]
	public void set_horizontal(bool value) { }

	[Address(RVA = "0x1CCEFE0", Offset = "0x1CCE1E0", Length = "0x17")]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000407")]
	public void set_horizontalNormalizedPosition(float value) { }

	[Address(RVA = "0x1CD1770", Offset = "0x1CD0970", Length = "0x18B")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60003E0")]
	public void set_horizontalScrollbar(Scrollbar value) { }

	[Address(RVA = "0x1CD1750", Offset = "0x1CD0950", Length = "0xC")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60003E8")]
	public void set_horizontalScrollbarSpacing(float value) { }

	[Address(RVA = "0x1CD1760", Offset = "0x1CD0960", Length = "0xA")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[Token(Token = "0x60003E4")]
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D8")]
	public void set_inertia(bool value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D4")]
	public void set_movementType(MovementType value) { }

	[Address(RVA = "0x1CD1900", Offset = "0x1CD0B00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000405")]
	public void set_normalizedPosition(Vector2 value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EC")]
	public void set_onValueChanged(ScrollRectEvent value) { }

	[Address(RVA = "0x1A823D0", Offset = "0x1A815D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DC")]
	public void set_scrollSensitivity(float value) { }

	[Address(RVA = "0x1CD1960", Offset = "0x1CD0B60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60003EF")]
	public void set_velocity(Vector2 value) { }

	[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D2")]
	public void set_vertical(bool value) { }

	[Address(RVA = "0x1CCFD90", Offset = "0x1CCEF90", Length = "0x1A")]
	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000409")]
	public void set_verticalNormalizedPosition(float value) { }

	[Address(RVA = "0x1CD1990", Offset = "0x1CD0B90", Length = "0x18B")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60003E2")]
	public void set_verticalScrollbar(Scrollbar value) { }

	[Address(RVA = "0x1CD1970", Offset = "0x1CD0B70", Length = "0xC")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60003EA")]
	public void set_verticalScrollbarSpacing(float value) { }

	[Address(RVA = "0x1CD1980", Offset = "0x1CD0B80", Length = "0xA")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[Token(Token = "0x60003E6")]
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	[Address(RVA = "0x1CD1B20", Offset = "0x1CD0D20", Length = "0x25")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[Token(Token = "0x60003DE")]
	public void set_viewport(RectTransform value) { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCDF80", Length = "0x116")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000400")]
	protected override void SetContentAnchoredPosition(Vector2 position) { }

	[Address(RVA = "0x1CCEF60", Offset = "0x1CCE160", Length = "0x76")]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbarSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbarSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000425")]
	protected void SetDirty() { }

	[Address(RVA = "0x1CCEEA0", Offset = "0x1CCE0A0", Length = "0xBF")]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollbarVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollbarVisibility)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000426")]
	protected void SetDirtyCaching() { }

	[Address(RVA = "0x1CCEFE0", Offset = "0x1CCE1E0", Length = "0x17")]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040A")]
	private void SetHorizontalNormalizedPosition(float value) { }

	[Address(RVA = "0x1CCF000", Offset = "0x1CCE200", Length = "0x737")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600041A")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x1CCF740", Offset = "0x1CCE940", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600041B")]
	public override void SetLayoutVertical() { }

	[Address(RVA = "0x1CCF870", Offset = "0x1CCEA70", Length = "0x515")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600040C")]
	protected override void SetNormalizedPosition(float value, int axis) { }

	[Address(RVA = "0x1CCFD90", Offset = "0x1CCEF90", Length = "0x1A")]
	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040B")]
	private void SetVerticalNormalizedPosition(float value) { }

	[Address(RVA = "0x1CCFDB0", Offset = "0x1CCEFB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60003FA")]
	public override void StopMovement() { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000427")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x1CCFE10", Offset = "0x1CCF010", Length = "0x654")]
	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
	[Token(Token = "0x600041F")]
	protected void UpdateBounds() { }

	[Address(RVA = "0x1CD0470", Offset = "0x1CCF670", Length = "0x39F")]
	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F5")]
	private void UpdateCachedData() { }

	[Address(RVA = "0x1CD0810", Offset = "0x1CCFA10", Length = "0xEE")]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600041D")]
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	[Address(RVA = "0x1CD0900", Offset = "0x1CCFB00", Length = "0x112")]
	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000402")]
	protected void UpdatePrevData() { }

	[Address(RVA = "0x1CD0A20", Offset = "0x1CCFC20", Length = "0x3D3")]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600041E")]
	private void UpdateScrollbarLayout() { }

	[Address(RVA = "0x1CD0E60", Offset = "0x1CD0060", Length = "0x1E8")]
	[CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000403")]
	private void UpdateScrollbars(Vector2 offset) { }

	[Address(RVA = "0x1CD0E00", Offset = "0x1CD0000", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "UpdateOneScrollbarVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(ScrollbarVisibility), typeof(Scrollbar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
	[Token(Token = "0x600041C")]
	private void UpdateScrollbarVisibility() { }

}

