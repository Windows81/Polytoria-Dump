namespace UnityEngine.UI;

[AddComponentMenu("UI/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000075")]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
{
	[Token(Token = "0x2000077")]
	internal class ToggleEvent : UnityEvent<Boolean>
	{

		[Address(RVA = "0x1CDB3E0", Offset = "0x1CDA5E0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60004F2")]
		public ToggleEvent() { }

	}

	[Token(Token = "0x2000076")]
	internal enum ToggleTransition
	{
		None = 0,
		Fade = 1,
	}

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000250")]
	public ToggleTransition toggleTransition; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000251")]
	public Graphic graphic; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000252")]
	private ToggleGroup m_Group; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000253")]
	public ToggleEvent onValueChanged; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000254")]
	[Tooltip("Is the toggle currently on or off?")]
	private bool m_IsOn; //Field offset: 0x120

	[Token(Token = "0x1700014F")]
	public ToggleGroup group
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DD")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDCA30", Offset = "0x1CDBC30", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60004DE")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000150")]
	public bool isOn
	{
		[Address(RVA = "0x1CDCA20", Offset = "0x1CDBC20", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDCA60", Offset = "0x1CDBC60", Length = "0xB")]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60004E9")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x1CDC960", Offset = "0x1CDBB60", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004DF")]
	protected Toggle() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DD")]
	public ToggleGroup get_group() { }

	[Address(RVA = "0x1CDCA20", Offset = "0x1CDBC20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004E8")]
	public bool get_isOn() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E2")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x1CDC1C0", Offset = "0x1CDB3C0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EE")]
	private void InternalToggle() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E1")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1CDC220", Offset = "0x1CDB420", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004E3")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1CDC2B0", Offset = "0x1CDB4B0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "GetColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E6")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CDC380", Offset = "0x1CDB580", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[Token(Token = "0x60004E5")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CDC3B0", Offset = "0x1CDB5B0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004E4")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CDC3F0", Offset = "0x1CDB5F0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004EF")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1CDC1C0", Offset = "0x1CDB3C0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F0")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x1CDC470", Offset = "0x1CDB670", Length = "0xBF")]
	[CalledBy(Type = typeof(Toggle), Member = "set_group", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004EC")]
	private void PlayEffect(bool instant) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E0")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x1CDC7C0", Offset = "0x1CDB9C0", Length = "0x183")]
	[CalledBy(Type = typeof(ToggleGroup), Member = "SetAllTogglesOff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "InternalToggle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "AnyTogglesOn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004EB")]
	private void Set(bool value, bool sendCallback = true) { }

	[Address(RVA = "0x1CDCA30", Offset = "0x1CDBC30", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004DE")]
	public void set_group(ToggleGroup value) { }

	[Address(RVA = "0x1CDCA60", Offset = "0x1CDBC60", Length = "0xB")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004E9")]
	public void set_isOn(bool value) { }

	[Address(RVA = "0x1CDC530", Offset = "0x1CDB730", Length = "0xB")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004EA")]
	public void SetIsOnWithoutNotify(bool value) { }

	[Address(RVA = "0x1CDC540", Offset = "0x1CDB740", Length = "0x27A")]
	[CalledBy(Type = typeof(Toggle), Member = "set_group", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004E7")]
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	[Address(RVA = "0x1CDC950", Offset = "0x1CDBB50", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004ED")]
	protected virtual void Start() { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F1")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

