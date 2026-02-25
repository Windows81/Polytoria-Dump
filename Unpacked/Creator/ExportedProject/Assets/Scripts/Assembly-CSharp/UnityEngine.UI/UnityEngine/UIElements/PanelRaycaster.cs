namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
[Token(Token = "0x2000095")]
public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
{
	[Token(Token = "0x40002B3")]
	private static ScreenOverlayPanelPicker panelPicker; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B2")]
	private BaseRuntimePanel m_Panel; //Field offset: 0x28

	[Token(Token = "0x17000192")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000600")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700018E")]
	public override IPanel panel
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F7")]
		 get { } //Length: 5
		[Address(RVA = "0x1CE7F90", Offset = "0x1CE7190", Length = "0x16F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60005F8")]
		 set { } //Length: 367
	}

	[Token(Token = "0x17000191")]
	public virtual int renderOrderPriority
	{
		[Address(RVA = "0x1CE7E80", Offset = "0x1CE7080", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60005FE")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700018F")]
	private GameObject selectableGameObject
	{
		[Address(RVA = "0x1CE7F00", Offset = "0x1CE7100", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005FC")]
		private get { } //Length: 18
	}

	[Token(Token = "0x17000190")]
	public virtual int sortOrderPriority
	{
		[Address(RVA = "0x1CE7F20", Offset = "0x1CE7120", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Token(Token = "0x60005FD")]
		 get { } //Length: 102
	}

	[Address(RVA = "0x1CE7E00", Offset = "0x1CE7000", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000602")]
	private static PanelRaycaster() { }

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000601")]
	public PanelRaycaster() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000600")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F7")]
	public override IPanel get_panel() { }

	[Address(RVA = "0x1CE7E80", Offset = "0x1CE7080", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60005FE")]
	public virtual int get_renderOrderPriority() { }

	[Address(RVA = "0x1CE7F00", Offset = "0x1CE7100", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005FC")]
	private GameObject get_selectableGameObject() { }

	[Address(RVA = "0x1CE7F20", Offset = "0x1CE7120", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Token(Token = "0x60005FD")]
	public virtual int get_sortOrderPriority() { }

	[Address(RVA = "0x1CE7750", Offset = "0x1CE6950", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005FB")]
	private void OnPanelDestroyed() { }

	[Address(RVA = "0x1CE7880", Offset = "0x1CE6A80", Length = "0x450")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.ScreenOverlayPanelPicker", Member = "TryPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel", typeof(int), typeof(Vector2), typeof(Vector2), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4600")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005FF")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x1CE7CE0", Offset = "0x1CE6EE0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005F9")]
	private void RegisterCallbacks() { }

	[Address(RVA = "0x1CE7F90", Offset = "0x1CE7190", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005F8")]
	public override void set_panel(IPanel value) { }

	[Address(RVA = "0x1CE7D70", Offset = "0x1CE6F70", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005FA")]
	private void UnregisterCallbacks() { }

}

