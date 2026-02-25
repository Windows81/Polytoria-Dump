namespace Battlehub.UIControls;

[Token(Token = "0x2000040")]
public class VirtualizingItemsControl : Selectable, IBeginDragHandler, IEventSystemHandler, IDropHandler, IEndDragHandler, IUpdateSelectedHandler, IUpdateFocusedHandler, IPointerClickHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private sealed class <>c
	{
		[Token(Token = "0x400013E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400013F")]
		public static Func<ItemContainerData, Object> <>9__161_0; //Field offset: 0x8

		[Address(RVA = "0x5EE360", Offset = "0x5ED560", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002E7")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E8")]
		public <>c() { }

		[Address(RVA = "0x5EE1C0", Offset = "0x5ED3C0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002E9")]
		internal object <OnItemBeginDrag>b__161_0(ItemContainerData di) { }

	}

	[Token(Token = "0x2000041")]
	private enum ScrollDir
	{
		None = 0,
		Up = 1,
		Down = 2,
		Left = 3,
		Right = 4,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000FD")]
	private EventHandler<ItemArgs> ItemBeginDrag; //Field offset: 0x100
	[CompilerGenerated]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000FE")]
	private EventHandler<ItemDropCancelArgs> ItemBeginDrop; //Field offset: 0x108
	[CompilerGenerated]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000FF")]
	private EventHandler<ItemDropCancelArgs> ItemDragEnter; //Field offset: 0x110
	[CompilerGenerated]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000100")]
	private EventHandler ItemDragExit; //Field offset: 0x118
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000101")]
	private EventHandler<ItemArgs> ItemDrag; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000102")]
	private EventHandler<ItemDropArgs> ItemDrop; //Field offset: 0x128
	[CompilerGenerated]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000103")]
	private EventHandler<ItemArgs> ItemEndDrag; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000104")]
	private EventHandler<SelectionChangedArgs> SelectionChanged; //Field offset: 0x138
	[CompilerGenerated]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000105")]
	private EventHandler<ItemArgs> ItemDoubleClick; //Field offset: 0x140
	[CompilerGenerated]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000106")]
	private EventHandler<ItemArgs> ItemClick; //Field offset: 0x148
	[CompilerGenerated]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000107")]
	private EventHandler<ItemsCancelArgs> ItemsRemoving; //Field offset: 0x150
	[CompilerGenerated]
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000108")]
	private EventHandler<ItemsRemovedArgs> ItemsRemoved; //Field offset: 0x158
	[CompilerGenerated]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000109")]
	private EventHandler IsFocusedChanged; //Field offset: 0x160
	[CompilerGenerated]
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400010A")]
	private EventHandler Submit; //Field offset: 0x168
	[CompilerGenerated]
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400010B")]
	private EventHandler Cancel; //Field offset: 0x170
	[CompilerGenerated]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400010C")]
	private EventHandler<PointerEventArgs> Click; //Field offset: 0x178
	[CompilerGenerated]
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400010D")]
	private EventHandler<PointerEventArgs> PointerEnter; //Field offset: 0x180
	[CompilerGenerated]
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400010E")]
	private EventHandler<PointerEventArgs> PointerExit; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x400010F")]
	public EventSystem m_eventSystem; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000110")]
	public InputProvider InputProvider; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000111")]
	private bool m_isDragInProgress; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A1")]
	[Token(Token = "0x4000112")]
	public bool SelectOnPointerUp; //Field offset: 0x1A1
	[FieldOffset(Offset = "0x1A2")]
	[Token(Token = "0x4000113")]
	public bool SelectUsingLeftButtonOnly; //Field offset: 0x1A2
	[FieldOffset(Offset = "0x1A3")]
	[Token(Token = "0x4000114")]
	public bool CanUnselectAll; //Field offset: 0x1A3
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000115")]
	public bool CanSelectAll; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A5")]
	[Token(Token = "0x4000116")]
	public bool CanMultiSelect; //Field offset: 0x1A5
	[FieldOffset(Offset = "0x1A6")]
	[Token(Token = "0x4000117")]
	public bool CanEdit; //Field offset: 0x1A6
	[FieldOffset(Offset = "0x1A7")]
	[Token(Token = "0x4000118")]
	public bool CanRemove; //Field offset: 0x1A7
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000119")]
	private bool m_prevCanDrag; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1A9")]
	[Token(Token = "0x400011A")]
	public bool CanDrag; //Field offset: 0x1A9
	[FieldOffset(Offset = "0x1AA")]
	[Token(Token = "0x400011B")]
	public bool CanReorder; //Field offset: 0x1AA
	[FieldOffset(Offset = "0x1AB")]
	[Token(Token = "0x400011C")]
	public bool ExpandChildrenWidth; //Field offset: 0x1AB
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x400011D")]
	public bool ExpandChildrenHeight; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1AD")]
	[Token(Token = "0x400011E")]
	private bool m_isDropInProgress; //Field offset: 0x1AD
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400011F")]
	private List<Object> m_selectionBackup; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000120")]
	private bool m_isFocused; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1B9")]
	[Token(Token = "0x4000121")]
	private bool m_isSelected; //Field offset: 0x1B9
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000122")]
	private Canvas m_canvas; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000123")]
	private CanvasGroup m_canvasGroup; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000124")]
	public Camera Camera; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000125")]
	public float ScrollSpeed; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000126")]
	public Vector4 ScrollMargin; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000127")]
	private ScrollDir m_scrollDir; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000128")]
	private PointerEnterExitListener m_pointerEventsListener; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000129")]
	private RectTransformChangeListener m_rtcListener; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400012A")]
	private float m_width; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x400012B")]
	private float m_height; //Field offset: 0x204
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400012C")]
	private VirtualizingItemDropMarker m_dropMarker; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400012D")]
	private Repeater m_repeater; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400012E")]
	private bool m_externalDragOperation; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400012F")]
	private VirtualizingItemContainer m_dropTarget; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000130")]
	private ItemContainerData[] m_dragItems; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000131")]
	private Object[] m_dragItemsData; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000132")]
	private bool m_selectionLocked; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000133")]
	private List<Object> m_selectedItems; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000134")]
	private HashSet<Object> m_selectedItemsHS; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000135")]
	private int m_selectedIndex; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000136")]
	private Dictionary<Object, ItemContainerData> m_itemContainerData; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000137")]
	private VirtualizingScrollRect m_scrollRect; //Field offset: 0x260

	[Token(Token = "0x1400003E")]
	public event EventHandler Cancel
	{
		[Address(RVA = "0x5E3D70", Offset = "0x5E2F70", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000272")]
		 add { } //Length: 162
		[Address(RVA = "0x5E4E60", Offset = "0x5E4060", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000273")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1400003F")]
	public event EventHandler<PointerEventArgs> Click
	{
		[Address(RVA = "0x5E3E20", Offset = "0x5E3020", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000274")]
		 add { } //Length: 186
		[Address(RVA = "0x5E4F10", Offset = "0x5E4110", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000275")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x1400003C")]
	public event EventHandler IsFocusedChanged
	{
		[Address(RVA = "0x5E3EE0", Offset = "0x5E30E0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600026E")]
		 add { } //Length: 162
		[Address(RVA = "0x5E4FD0", Offset = "0x5E41D0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600026F")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000030")]
	public event EventHandler<ItemArgs> ItemBeginDrag
	{
		[Address(RVA = "0x5E3F90", Offset = "0x5E3190", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000256")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5080", Offset = "0x5E4280", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000257")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000031")]
	public event EventHandler<ItemDropCancelArgs> ItemBeginDrop
	{
		[Address(RVA = "0x5E4050", Offset = "0x5E3250", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000258")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5140", Offset = "0x5E4340", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000259")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000039")]
	public event EventHandler<ItemArgs> ItemClick
	{
		[Address(RVA = "0x5E4110", Offset = "0x5E3310", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000268")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5200", Offset = "0x5E4400", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000269")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000038")]
	public event EventHandler<ItemArgs> ItemDoubleClick
	{
		[Address(RVA = "0x5E41D0", Offset = "0x5E33D0", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000266")]
		 add { } //Length: 186
		[Address(RVA = "0x5E52C0", Offset = "0x5E44C0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000267")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000034")]
	public event EventHandler<ItemArgs> ItemDrag
	{
		[Address(RVA = "0x5E4400", Offset = "0x5E3600", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600025E")]
		 add { } //Length: 186
		[Address(RVA = "0x5E54F0", Offset = "0x5E46F0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600025F")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000032")]
	public event EventHandler<ItemDropCancelArgs> ItemDragEnter
	{
		[Address(RVA = "0x5E4290", Offset = "0x5E3490", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600025A")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5380", Offset = "0x5E4580", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600025B")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000033")]
	public event EventHandler ItemDragExit
	{
		[Address(RVA = "0x5E4350", Offset = "0x5E3550", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600025C")]
		 add { } //Length: 162
		[Address(RVA = "0x5E5440", Offset = "0x5E4640", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600025D")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000035")]
	public event EventHandler<ItemDropArgs> ItemDrop
	{
		[Address(RVA = "0x5E44C0", Offset = "0x5E36C0", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000260")]
		 add { } //Length: 186
		[Address(RVA = "0x5E55B0", Offset = "0x5E47B0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000261")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000036")]
	public event EventHandler<ItemArgs> ItemEndDrag
	{
		[Address(RVA = "0x5E4580", Offset = "0x5E3780", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000262")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5670", Offset = "0x5E4870", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000263")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x1400003B")]
	public event EventHandler<ItemsRemovedArgs> ItemsRemoved
	{
		[Address(RVA = "0x5E4640", Offset = "0x5E3840", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600026C")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5730", Offset = "0x5E4930", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600026D")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x1400003A")]
	public event EventHandler<ItemsCancelArgs> ItemsRemoving
	{
		[Address(RVA = "0x5E4700", Offset = "0x5E3900", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600026A")]
		 add { } //Length: 186
		[Address(RVA = "0x5E57F0", Offset = "0x5E49F0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600026B")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000040")]
	public event EventHandler<PointerEventArgs> PointerEnter
	{
		[Address(RVA = "0x5E47C0", Offset = "0x5E39C0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000276")]
		 add { } //Length: 186
		[Address(RVA = "0x5E58B0", Offset = "0x5E4AB0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000277")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000041")]
	public event EventHandler<PointerEventArgs> PointerExit
	{
		[Address(RVA = "0x5E4880", Offset = "0x5E3A80", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000278")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5970", Offset = "0x5E4B70", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000279")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000037")]
	public event EventHandler<SelectionChangedArgs> SelectionChanged
	{
		[Address(RVA = "0x5E4940", Offset = "0x5E3B40", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000264")]
		 add { } //Length: 186
		[Address(RVA = "0x5E5A30", Offset = "0x5E4C30", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000265")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x1400003D")]
	public event EventHandler Submit
	{
		[Address(RVA = "0x5E4A00", Offset = "0x5E3C00", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000270")]
		 add { } //Length: 162
		[Address(RVA = "0x5E5AF0", Offset = "0x5E4CF0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000271")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x17000080")]
	protected override bool CanScroll
	{
		[Address(RVA = "0x5E4AB0", Offset = "0x5E3CB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000086")]
	public Object[] DragItems
	{
		[Address(RVA = "0x5E4AC0", Offset = "0x5E3CC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000283")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000085")]
	public ItemDropAction DropAction
	{
		[Address(RVA = "0x5E4AD0", Offset = "0x5E3CD0", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000282")]
		 get { } //Length: 146
	}

	[Token(Token = "0x17000087")]
	protected VirtualizingItemDropMarker DropMarker
	{
		[Address(RVA = "0x5E4B70", Offset = "0x5E3D70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000284")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000084")]
	public object DropTarget
	{
		[Address(RVA = "0x5E4B80", Offset = "0x5E3D80", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000280")]
		 get { } //Length: 146
	}

	[Token(Token = "0x17000081")]
	public bool IsDropInProgress
	{
		[Address(RVA = "0x5E4C20", Offset = "0x5E3E20", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000082")]
	public bool IsFocused
	{
		[Address(RVA = "0x5E4C30", Offset = "0x5E3E30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027C")]
		 get { } //Length: 8
		[Address(RVA = "0x5E5BA0", Offset = "0x5E4DA0", Length = "0xE1")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600027D")]
		 set { } //Length: 225
	}

	[Token(Token = "0x17000083")]
	public bool IsSelected
	{
		[Address(RVA = "0x5E4C40", Offset = "0x5E3E40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600027E")]
		 get { } //Length: 8
		[Address(RVA = "0x5E5C90", Offset = "0x5E4E90", Length = "0x5D")]
		[CalledBy(Type = typeof(VirtualizingItemsControl`1), Member = "OnItemEndEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600027F")]
		 set { } //Length: 93
	}

	[Token(Token = "0x1700008D")]
	public IEnumerable Items
	{
		[Address(RVA = "0x5E4C80", Offset = "0x5E3E80", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600028E")]
		 get { } //Length: 33
		[Address(RVA = "0x5E5CF0", Offset = "0x5E4EF0", Length = "0xB")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "GameLoaded", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "OnItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ItemDropArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600028F")]
		 set { } //Length: 11
	}

	[Token(Token = "0x1700008C")]
	public int ItemsCount
	{
		[Address(RVA = "0x5E4C50", Offset = "0x5E3E50", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600028D")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700008B")]
	public int SelectedIndex
	{
		[Address(RVA = "0x5E4CB0", Offset = "0x5E3EB0", Length = "0x75")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600028B")]
		 get { } //Length: 117
		[Address(RVA = "0x5E5D00", Offset = "0x5E4F00", Length = "0x528")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SelectRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Enumerable), Member = "Except", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedItem", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600028C")]
		 set { } //Length: 1320
	}

	[Token(Token = "0x1700008A")]
	public object SelectedItem
	{
		[Address(RVA = "0x5E4D30", Offset = "0x5E3F30", Length = "0x66")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000289")]
		 get { } //Length: 102
		[Address(RVA = "0x5E6230", Offset = "0x5E5430", Length = "0x85")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600028A")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000089")]
	public override IEnumerable SelectedItems
	{
		[Address(RVA = "0x5E4DF0", Offset = "0x5E3FF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000287")]
		 get { } //Length: 8
		[Address(RVA = "0x5E62C0", Offset = "0x5E54C0", Length = "0x877")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000288")]
		 set { } //Length: 2167
	}

	[Token(Token = "0x17000088")]
	public int SelectedItemsCount
	{
		[Address(RVA = "0x5E4DA0", Offset = "0x5E3FA0", Length = "0x47")]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "PasteFromClipboard", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "OnTreeSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SelectionChangedArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SelectChildren", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000285")]
		 get { } //Length: 71
	}

	[Token(Token = "0x1700008E")]
	public int VisibleItemIndex
	{
		[Address(RVA = "0x5E4E00", Offset = "0x5E4000", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000290")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700008F")]
	public int VisibleItemsCount
	{
		[Address(RVA = "0x5E4E30", Offset = "0x5E4030", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000291")]
		 get { } //Length: 32
	}

	[Address(RVA = "0x5E3C80", Offset = "0x5E2E80", Length = "0xE2")]
	[CalledBy(Type = typeof(VirtualizingItemsControl`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60002DE")]
	public VirtualizingItemsControl() { }

	[Address(RVA = "0x5DCC80", Offset = "0x5DBE80", Length = "0x81")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E5")]
	private int <DestroyItems>b__199_0(object item) { }

	[Address(RVA = "0x5E21A0", Offset = "0x5E13A0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x60002E4")]
	private int <GetDragItems>b__190_0(ItemContainerData di) { }

	[Address(RVA = "0x5E2230", Offset = "0x5E1430", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x60002E3")]
	private void <OnCanDragChanged>b__171_0(RectTransform c) { }

	[Address(RVA = "0x5E22D0", Offset = "0x5E14D0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x60002E6")]
	private bool <Remove>b__204_0(object item) { }

	[Address(RVA = "0x5E2340", Offset = "0x5E1540", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "UpdateContainerSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x60002E2")]
	private void <SetContainersSize>b__169_0(RectTransform c) { }

	[Address(RVA = "0x5E23A0", Offset = "0x5E15A0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x60002DF")]
	private bool <SetItems>b__135_0(object item) { }

	[Address(RVA = "0x5E2400", Offset = "0x5E1600", Length = "0x314")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainersPerGroup", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60002E0")]
	private void <Update>b__141_0() { }

	[Address(RVA = "0x5E2720", Offset = "0x5E1920", Length = "0x1FD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainersPerGroup", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60002E1")]
	private void <Update>b__141_1() { }

	[Address(RVA = "0x5DB710", Offset = "0x5DA910", Length = "0x4E")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "ChangeParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D2")]
	public ItemContainerData Add(object item) { }

	[Address(RVA = "0x5E3D70", Offset = "0x5E2F70", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000272")]
	public void add_Cancel(EventHandler value) { }

	[Address(RVA = "0x5E3E20", Offset = "0x5E3020", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000274")]
	public void add_Click(EventHandler<PointerEventArgs> value) { }

	[Address(RVA = "0x5E3EE0", Offset = "0x5E30E0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600026E")]
	public void add_IsFocusedChanged(EventHandler value) { }

	[Address(RVA = "0x5E3F90", Offset = "0x5E3190", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000256")]
	public void add_ItemBeginDrag(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E4050", Offset = "0x5E3250", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000258")]
	public void add_ItemBeginDrop(EventHandler<ItemDropCancelArgs> value) { }

	[Address(RVA = "0x5E4110", Offset = "0x5E3310", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000268")]
	public void add_ItemClick(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E41D0", Offset = "0x5E33D0", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000266")]
	public void add_ItemDoubleClick(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E4400", Offset = "0x5E3600", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600025E")]
	public void add_ItemDrag(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E4290", Offset = "0x5E3490", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600025A")]
	public void add_ItemDragEnter(EventHandler<ItemDropCancelArgs> value) { }

	[Address(RVA = "0x5E4350", Offset = "0x5E3550", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600025C")]
	public void add_ItemDragExit(EventHandler value) { }

	[Address(RVA = "0x5E44C0", Offset = "0x5E36C0", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000260")]
	public void add_ItemDrop(EventHandler<ItemDropArgs> value) { }

	[Address(RVA = "0x5E4580", Offset = "0x5E3780", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000262")]
	public void add_ItemEndDrag(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E4640", Offset = "0x5E3840", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600026C")]
	public void add_ItemsRemoved(EventHandler<ItemsRemovedArgs> value) { }

	[Address(RVA = "0x5E4700", Offset = "0x5E3900", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600026A")]
	public void add_ItemsRemoving(EventHandler<ItemsCancelArgs> value) { }

	[Address(RVA = "0x5E47C0", Offset = "0x5E39C0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000276")]
	public void add_PointerEnter(EventHandler<PointerEventArgs> value) { }

	[Address(RVA = "0x5E4880", Offset = "0x5E3A80", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000278")]
	public void add_PointerExit(EventHandler<PointerEventArgs> value) { }

	[Address(RVA = "0x5E4940", Offset = "0x5E3B40", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000264")]
	public void add_SelectionChanged(EventHandler<SelectionChangedArgs> value) { }

	[Address(RVA = "0x5E4A00", Offset = "0x5E3C00", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000270")]
	public void add_Submit(EventHandler value) { }

	[Address(RVA = "0x5DB760", Offset = "0x5DA960", Length = "0x54A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "OnCanDragChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(RectTransformChangeListener), Member = "add_RectTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransformChanged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "add_ItemDataBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBindAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Selectable), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000294")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029B")]
	protected override void AwakeOverride() { }

	[Address(RVA = "0x5DBCB0", Offset = "0x5DAEB0", Length = "0x67")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "CanDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData[]), typeof(ItemContainerData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002C7")]
	protected override bool CanDrop(ItemContainerData[] dragItems, ItemContainerData dropTarget) { }

	[Address(RVA = "0x5DBD20", Offset = "0x5DAF20", Length = "0x1AF")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDoubleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemUnselected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl`1), Member = "OnItemEndEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl`1), Member = "OnItemBeginEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "IsParentOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B6")]
	protected bool CanHandleEvent(object sender) { }

	[Address(RVA = "0x5DBED0", Offset = "0x5DB0D0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000281")]
	public void ClearTarget() { }

	[Address(RVA = "0x5DBF00", Offset = "0x5DB100", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000296")]
	protected override InputProvider CreateInputProviderOverride() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BF")]
	public override void DataBindItem(object item, VirtualizingItemContainer itemContainer) { }

	[Address(RVA = "0x5DBF50", Offset = "0x5DB150", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002BD")]
	public override void DataBindItem(object item) { }

	[Address(RVA = "0x5DBFF0", Offset = "0x5DB1F0", Length = "0x1C2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002BE")]
	public override void DataBindVisible() { }

	[Address(RVA = "0x5DC1C0", Offset = "0x5DB3C0", Length = "0x261")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002D1")]
	protected override void DestroyItems(Object[] items, bool unselect) { }

	[Address(RVA = "0x5DC430", Offset = "0x5DB630", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002C9")]
	protected override void Drop(ItemContainerData[] dragItems, ItemContainerData dropTargetData, ItemDropAction action) { }

	[Address(RVA = "0x5DC5D0", Offset = "0x5DB7D0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002CD")]
	public void ExternalBeginDrag(Vector3 position) { }

	[Address(RVA = "0x5DC6C0", Offset = "0x5DB8C0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CE")]
	public void ExternalItemDrag(Vector3 position) { }

	[Address(RVA = "0x5DC770", Offset = "0x5DB970", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CF")]
	public void ExternalItemDrop() { }

	[Address(RVA = "0x5E4AB0", Offset = "0x5E3CB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600027A")]
	protected override bool get_CanScroll() { }

	[Address(RVA = "0x5E4AC0", Offset = "0x5E3CC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000283")]
	public Object[] get_DragItems() { }

	[Address(RVA = "0x5E4AD0", Offset = "0x5E3CD0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000282")]
	public ItemDropAction get_DropAction() { }

	[Address(RVA = "0x5E4B70", Offset = "0x5E3D70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000284")]
	protected VirtualizingItemDropMarker get_DropMarker() { }

	[Address(RVA = "0x5E4B80", Offset = "0x5E3D80", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000280")]
	public object get_DropTarget() { }

	[Address(RVA = "0x5E4C20", Offset = "0x5E3E20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600027B")]
	public bool get_IsDropInProgress() { }

	[Address(RVA = "0x5E4C30", Offset = "0x5E3E30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600027C")]
	public bool get_IsFocused() { }

	[Address(RVA = "0x5E4C40", Offset = "0x5E3E40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600027E")]
	public bool get_IsSelected() { }

	[Address(RVA = "0x5E4C80", Offset = "0x5E3E80", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600028E")]
	public IEnumerable get_Items() { }

	[Address(RVA = "0x5E4C50", Offset = "0x5E3E50", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600028D")]
	public int get_ItemsCount() { }

	[Address(RVA = "0x5E4CB0", Offset = "0x5E3EB0", Length = "0x75")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600028B")]
	public int get_SelectedIndex() { }

	[Address(RVA = "0x5E4D30", Offset = "0x5E3F30", Length = "0x66")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000289")]
	public object get_SelectedItem() { }

	[Address(RVA = "0x5E4DF0", Offset = "0x5E3FF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000287")]
	public override IEnumerable get_SelectedItems() { }

	[Address(RVA = "0x5E4DA0", Offset = "0x5E3FA0", Length = "0x47")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "PasteFromClipboard", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "OnTreeSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SelectionChangedArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SelectChildren", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000285")]
	public int get_SelectedItemsCount() { }

	[Address(RVA = "0x5E4E00", Offset = "0x5E4000", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000290")]
	public int get_VisibleItemIndex() { }

	[Address(RVA = "0x5E4E30", Offset = "0x5E4030", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000291")]
	public int get_VisibleItemsCount() { }

	[Address(RVA = "0x5DC7C0", Offset = "0x5DB9C0", Length = "0x1F3")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C8")]
	protected ItemContainerData[] GetDragItems() { }

	[Address(RVA = "0x5DC9C0", Offset = "0x5DBBC0", Length = "0xAD")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "SetIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeViewItem), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D8")]
	public object GetItemAt(int index) { }

	[Address(RVA = "0x5DCBD0", Offset = "0x5DBDD0", Length = "0xAD")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetPrevSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "SetIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeViewItem), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "GetTreeViewItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingTreeViewItem))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "UpdateIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetNextSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "MoveSubtree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RectTransform))]
	[Token(Token = "0x60002C4")]
	public VirtualizingItemContainer GetItemContainer(object item) { }

	[Address(RVA = "0x5DCB50", Offset = "0x5DBD50", Length = "0x7C")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "ChangeParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "<DestroyItems>b__42_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeViewExtension), Member = "ExpandTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView), "T", "System.Func`2<T, T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C5")]
	public ItemContainerData GetItemContainerData(object item) { }

	[Address(RVA = "0x5DCA70", Offset = "0x5DBC70", Length = "0xD4")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "FirstChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "NextChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView), typeof(TreeViewItemContainerData)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "LastChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "LastDescendant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(int), typeof(System.Collections.Generic.List`1<System.Object>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "MoveSubtree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "NextChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60002C6")]
	public ItemContainerData GetItemContainerData(int siblingIndex) { }

	[Address(RVA = "0x5DCC80", Offset = "0x5DBE80", Length = "0x81")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C1")]
	public int IndexOf(object obj) { }

	[Address(RVA = "0x5DCD10", Offset = "0x5DBF10", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D3")]
	public override ItemContainerData Insert(int index, object item) { }

	[Address(RVA = "0x5DCE20", Offset = "0x5DC020", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000293")]
	protected override ItemContainerData InstantiateItemContainerData(object item) { }

	[Address(RVA = "0x5DCE90", Offset = "0x5DC090", Length = "0x63")]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "StartOverride", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000286")]
	public bool IsItemSelected(object obj) { }

	[Address(RVA = "0x5DCF00", Offset = "0x5DC100", Length = "0x108")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C3")]
	public ItemContainerData LastItemContainerData() { }

	[Address(RVA = "0x5DD010", Offset = "0x5DC210", Length = "0x8C")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "ForEachContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.RectTransform>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B5")]
	private void OnCanDragChanged() { }

	[Address(RVA = "0x5DD0A0", Offset = "0x5DC2A0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002DA")]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x5DD100", Offset = "0x5DC300", Length = "0x39B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "remove_ItemDataBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBindAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(RectTransformChangeListener), Member = "remove_RectTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransformChanged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029A")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A0")]
	protected override void OnDestroyOverride() { }

	[Address(RVA = "0x5DD4A0", Offset = "0x5DC6A0", Length = "0xAE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "remove_Unselected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000299")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029F")]
	protected override void OnDisableOverride() { }

	[Address(RVA = "0x5DDF90", Offset = "0x5DD190", Length = "0xADA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "add_Unselected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000298")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029E")]
	protected override void OnEnableOverride() { }

	[Address(RVA = "0x5DEA70", Offset = "0x5DDC70", Length = "0x4B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ItemDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(ItemDropAction), typeof(bool), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ItemArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetDragItems", ReturnType = typeof(ItemContainerData[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x60002AB")]
	private void OnItemBeginDrag(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BB")]
	protected override void OnItemBeginEdit(object sender, EventArgs e) { }

	[Address(RVA = "0x5DEF30", Offset = "0x5DE130", Length = "0x1C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002AA")]
	private void OnItemClick(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DF100", Offset = "0x5DE300", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002A9")]
	private void OnItemDoubleClick(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DF270", Offset = "0x5DE470", Length = "0x397")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60002AC")]
	private void OnItemDrag(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DF610", Offset = "0x5DE810", Length = "0x4ED")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(ItemDropAction), typeof(bool), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180021EE0")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "RaiseEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x60002AD")]
	private void OnItemDrop(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DFB00", Offset = "0x5DED00", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "RaiseEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "OnItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AE")]
	private void OnItemEndDrag(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BC")]
	protected override void OnItemEndEdit(object sender, EventArgs e) { }

	[Address(RVA = "0x5DFBB0", Offset = "0x5DEDB0", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A5")]
	private void OnItemPointerDown(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DFCC0", Offset = "0x5DEEC0", Length = "0x1DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(ItemDropAction), typeof(bool), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60002A7")]
	private void OnItemPointerEnter(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DFEA0", Offset = "0x5DF0A0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A8")]
	private void OnItemPointerExit(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5DFFA0", Offset = "0x5DF1A0", Length = "0x23C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60002A6")]
	private void OnItemPointerUp(VirtualizingItemContainer sender, PointerEventData eventData) { }

	[Address(RVA = "0x5E01E0", Offset = "0x5DF3E0", Length = "0x357")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "remove_Unselected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "SelectRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "add_Unselected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60002A1")]
	private void OnItemSelected(object sender, EventArgs e) { }

	[Address(RVA = "0x5E0540", Offset = "0x5DF740", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A3")]
	private void OnItemUnselected(object sender, EventArgs e) { }

	[Address(RVA = "0x5E06A0", Offset = "0x5DF8A0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BA")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x5E0710", Offset = "0x5DF910", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "SetContainersSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002C0")]
	private void OnScrollRectItemDataBinding(RectTransform container, object item) { }

	[Address(RVA = "0x5E0890", Offset = "0x5DFA90", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002D9")]
	public virtual void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x5E08F0", Offset = "0x5DFAF0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DC")]
	public override void OnUpdateFocused(BaseEventData eventData) { }

	[Address(RVA = "0x5E08F0", Offset = "0x5DFAF0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DB")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0x5E0930", Offset = "0x5DFB30", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B1")]
	private void OnViewportPointerEnter(object sender, PointerEventArgs e) { }

	[Address(RVA = "0x5E0960", Offset = "0x5DFB60", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B2")]
	private void OnViewportPointerExit(object sender, PointerEventArgs e) { }

	[Address(RVA = "0x5E0990", Offset = "0x5DFB90", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "SetContainersSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B0")]
	private void OnViewportRectTransformChanged() { }

	[Address(RVA = "0x5E0A20", Offset = "0x5DFC20", Length = "0x10A")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AF")]
	private void RaiseEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x5E0D90", Offset = "0x5DFF90", Length = "0x20E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(ItemsCancelArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ItemsRemovedArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002D6")]
	protected override void Remove(Object[] items) { }

	[Address(RVA = "0x5E0CD0", Offset = "0x5DFED0", Length = "0xBD")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D7")]
	public override void Remove(object item) { }

	[Address(RVA = "0x5E4E60", Offset = "0x5E4060", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000273")]
	public void remove_Cancel(EventHandler value) { }

	[Address(RVA = "0x5E4F10", Offset = "0x5E4110", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000275")]
	public void remove_Click(EventHandler<PointerEventArgs> value) { }

	[Address(RVA = "0x5E4FD0", Offset = "0x5E41D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600026F")]
	public void remove_IsFocusedChanged(EventHandler value) { }

	[Address(RVA = "0x5E5080", Offset = "0x5E4280", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000257")]
	public void remove_ItemBeginDrag(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E5140", Offset = "0x5E4340", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000259")]
	public void remove_ItemBeginDrop(EventHandler<ItemDropCancelArgs> value) { }

	[Address(RVA = "0x5E5200", Offset = "0x5E4400", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000269")]
	public void remove_ItemClick(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E52C0", Offset = "0x5E44C0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000267")]
	public void remove_ItemDoubleClick(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E54F0", Offset = "0x5E46F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600025F")]
	public void remove_ItemDrag(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E5380", Offset = "0x5E4580", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600025B")]
	public void remove_ItemDragEnter(EventHandler<ItemDropCancelArgs> value) { }

	[Address(RVA = "0x5E5440", Offset = "0x5E4640", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600025D")]
	public void remove_ItemDragExit(EventHandler value) { }

	[Address(RVA = "0x5E55B0", Offset = "0x5E47B0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000261")]
	public void remove_ItemDrop(EventHandler<ItemDropArgs> value) { }

	[Address(RVA = "0x5E5670", Offset = "0x5E4870", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000263")]
	public void remove_ItemEndDrag(EventHandler<ItemArgs> value) { }

	[Address(RVA = "0x5E5730", Offset = "0x5E4930", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600026D")]
	public void remove_ItemsRemoved(EventHandler<ItemsRemovedArgs> value) { }

	[Address(RVA = "0x5E57F0", Offset = "0x5E49F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600026B")]
	public void remove_ItemsRemoving(EventHandler<ItemsCancelArgs> value) { }

	[Address(RVA = "0x5E58B0", Offset = "0x5E4AB0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000277")]
	public void remove_PointerEnter(EventHandler<PointerEventArgs> value) { }

	[Address(RVA = "0x5E5970", Offset = "0x5E4B70", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000279")]
	public void remove_PointerExit(EventHandler<PointerEventArgs> value) { }

	[Address(RVA = "0x5E5A30", Offset = "0x5E4C30", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000265")]
	public void remove_SelectionChanged(EventHandler<SelectionChangedArgs> value) { }

	[Address(RVA = "0x5E5AF0", Offset = "0x5E4CF0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000271")]
	public void remove_Submit(EventHandler value) { }

	[Address(RVA = "0x5E0B30", Offset = "0x5DFD30", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ItemsCancelArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ItemsRemovedArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002D0")]
	public void RemoveSelectedItems() { }

	[Address(RVA = "0x5E0FA0", Offset = "0x5E01A0", Length = "0x530")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60002A2")]
	private void SelectRange(VirtualizingItemContainer itemContainer) { }

	[Address(RVA = "0x5E5BA0", Offset = "0x5E4DA0", Length = "0xE1")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600027D")]
	public void set_IsFocused(bool value) { }

	[Address(RVA = "0x5E5C90", Offset = "0x5E4E90", Length = "0x5D")]
	[CalledBy(Type = typeof(VirtualizingItemsControl`1), Member = "OnItemEndEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600027F")]
	protected void set_IsSelected(bool value) { }

	[Address(RVA = "0x5E5CF0", Offset = "0x5E4EF0", Length = "0xB")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "GameLoaded", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "OnItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ItemDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600028F")]
	public void set_Items(IEnumerable value) { }

	[Address(RVA = "0x5E5D00", Offset = "0x5E4F00", Length = "0x528")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SelectRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedItem", ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Except", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600028C")]
	public void set_SelectedIndex(int value) { }

	[Address(RVA = "0x5E6230", Offset = "0x5E5430", Length = "0x85")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600028A")]
	public void set_SelectedItem(object value) { }

	[Address(RVA = "0x5E62C0", Offset = "0x5E54C0", Length = "0x877")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000288")]
	public override void set_SelectedItems(IEnumerable value) { }

	[Address(RVA = "0x5E14E0", Offset = "0x5E06E0", Length = "0x8C")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnViewportRectTransformChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnScrollRectItemDataBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "ForEachContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.RectTransform>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B3")]
	private void SetContainersSize() { }

	[Address(RVA = "0x5E1570", Offset = "0x5E0770", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C2")]
	public override void SetIndex(object obj, int newIndex) { }

	[Address(RVA = "0x5E1660", Offset = "0x5E0860", Length = "0x40A")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000292")]
	public void SetItems(IEnumerable value, bool updateSelection) { }

	[Address(RVA = "0x5E1AB0", Offset = "0x5E0CB0", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D4")]
	public void SetNextSibling(object sibling, object nextSibling) { }

	[Address(RVA = "0x5E1A70", Offset = "0x5E0C70", Length = "0x33")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "MoveSubtree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetNextSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CA")]
	protected override void SetNextSiblingInternal(ItemContainerData sibling, ItemContainerData nextSibling) { }

	[Address(RVA = "0x5E1C90", Offset = "0x5E0E90", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D5")]
	public void SetPrevSibling(object sibling, object prevSibling) { }

	[Address(RVA = "0x5E1C50", Offset = "0x5E0E50", Length = "0x33")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetPrevSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CB")]
	protected override void SetPrevSiblingInternal(ItemContainerData sibling, ItemContainerData prevSibling) { }

	[Address(RVA = "0x5E1E30", Offset = "0x5E1030", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000295")]
	protected virtual void Start() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029C")]
	protected override void StartOverride() { }

	[Address(RVA = "0x5E2010", Offset = "0x5E1210", Length = "0x182")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "SelectRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002A4")]
	private void TryToSelect(VirtualizingItemContainer sender) { }

	[Address(RVA = "0x5E2920", Offset = "0x5E1B20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002B7")]
	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x5E2930", Offset = "0x5E1B30", Length = "0x643")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ItemDropArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object), typeof(ItemDropAction), typeof(bool), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "LastContainer", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x60002B9")]
	private override void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData) { }

	[Address(RVA = "0x5E2F80", Offset = "0x5E2180", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002B8")]
	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x5E2F90", Offset = "0x5E2190", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DD")]
	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x5E3250", Offset = "0x5E2450", Length = "0xA21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Repeater), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ItemsRemovedArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ItemsCancelArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_interactable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Repeater), Member = "Repeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "OnCanDragChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000297")]
	private void Update() { }

	[Address(RVA = "0x5E3060", Offset = "0x5E2260", Length = "0xFD")]
	[CalledBy(Type = typeof(VirtualizingItemContainer), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<SetContainersSize>b__169_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002B4")]
	public void UpdateContainerSize(VirtualizingItemContainer container) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029D")]
	protected override void UpdateOverride() { }

	[Address(RVA = "0x5E3160", Offset = "0x5E2360", Length = "0xE3")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Drop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData[]), typeof(ItemContainerData), typeof(ItemDropAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002CC")]
	protected void UpdateSelectedItemIndex() { }

}

