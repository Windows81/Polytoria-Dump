namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event Trigger")]
[Token(Token = "0x20000B6")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
{
	[Token(Token = "0x20000B8")]
	internal class Entry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400030F")]
		public EventTriggerType eventID; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000310")]
		public TriggerEvent callback; //Field offset: 0x18

		[Address(RVA = "0x1CE0A30", Offset = "0x1CDFC30", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60006CD")]
		public Entry() { }

	}

	[Token(Token = "0x20000B7")]
	internal class TriggerEvent : UnityEvent<BaseEventData>
	{

		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1BE0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60006CC")]
		public TriggerEvent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("delegates")]
	[SerializeField]
	[Token(Token = "0x400030E")]
	private List<Entry> m_Delegates; //Field offset: 0x20

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	[Token(Token = "0x170001D0")]
	public List<Entry> delegates
	{
		[Address(RVA = "0x1CE2EF0", Offset = "0x1CE20F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
		[Token(Token = "0x60006B5")]
		 get { } //Length: 7
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001D1")]
	public List<Entry> triggers
	{
		[Address(RVA = "0x1CE2F00", Offset = "0x1CE2100", Length = "0x7A")]
		[CalledBy(Type = typeof(EventTrigger), Member = "get_delegates", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 122
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B7")]
	protected EventTrigger() { }

	[Address(RVA = "0x1CE2C40", Offset = "0x1CE1E40", Length = "0x197")]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnInitializePotentialDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60006BA")]
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	[Address(RVA = "0x1CE2EF0", Offset = "0x1CE20F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
	[Token(Token = "0x60006B5")]
	public List<Entry> get_delegates() { }

	[Address(RVA = "0x1CE2F00", Offset = "0x1CE2100", Length = "0x7A")]
	[CalledBy(Type = typeof(EventTrigger), Member = "get_delegates", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B8")]
	public List<Entry> get_triggers() { }

	[Address(RVA = "0x1CE2DE0", Offset = "0x1CE1FE0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C8")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2DF0", Offset = "0x1CE1FF0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006CB")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x1CE2E00", Offset = "0x1CE2000", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C3")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x1CE2E10", Offset = "0x1CE2010", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BD")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E20", Offset = "0x1CE2020", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BE")]
	public override void OnDrop(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E30", Offset = "0x1CE2030", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C9")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E40", Offset = "0x1CE2040", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C7")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E50", Offset = "0x1CE2050", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C5")]
	public override void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x1CE2E60", Offset = "0x1CE2060", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C1")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E70", Offset = "0x1CE2070", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BF")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E80", Offset = "0x1CE2080", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BB")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2E90", Offset = "0x1CE2090", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006BC")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2EA0", Offset = "0x1CE20A0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C0")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2EB0", Offset = "0x1CE20B0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C4")]
	public override void OnScroll(PointerEventData eventData) { }

	[Address(RVA = "0x1CE2EC0", Offset = "0x1CE20C0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C2")]
	public override void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x1CE2ED0", Offset = "0x1CE20D0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006CA")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x1CE2EE0", Offset = "0x1CE20E0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C6")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B6")]
	public void set_delegates(List<Entry> value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B9")]
	public void set_triggers(List<Entry> value) { }

}

