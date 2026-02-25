namespace UnityEngine.UI;

[AddComponentMenu("UI/Mask", 13)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000055")]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000198")]
	private RectTransform m_RectTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000199")]
	private bool m_ShowMaskGraphic; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400019A")]
	private Graphic m_Graphic; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019B")]
	private Material m_MaskMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019C")]
	private Material m_UnmaskMaterial; //Field offset: 0x40

	[Token(Token = "0x170000D8")]
	public Graphic graphic
	{
		[Address(RVA = "0x1CC6370", Offset = "0x1CC5570", Length = "0x63")]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Mask), Member = "set_showMaskGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Mask), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Mask), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000341")]
		 get { } //Length: 99
	}

	[Token(Token = "0x170000D6")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x1CC63E0", Offset = "0x1CC55E0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600033E")]
		 get { } //Length: 99
	}

	[Token(Token = "0x170000D7")]
	public bool showMaskGraphic
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033F")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC6450", Offset = "0x1CC5650", Length = "0xDD")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000340")]
		 set { } //Length: 221
	}

	[Address(RVA = "0x1CC6360", Offset = "0x1CC5560", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000342")]
	protected Mask() { }

	[Address(RVA = "0x1CC6370", Offset = "0x1CC5570", Length = "0x63")]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Mask), Member = "set_showMaskGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mask), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000341")]
	public Graphic get_graphic() { }

	[Address(RVA = "0x1CC63E0", Offset = "0x1CC55E0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600033E")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033F")]
	public bool get_showMaskGraphic() { }

	[Address(RVA = "0x1CC58A0", Offset = "0x1CC4AA0", Length = "0x30D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_popMaterialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_hasPopInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetPopMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000348")]
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x1CC5BB0", Offset = "0x1CC4DB0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000347")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x1CC5CA0", Offset = "0x1CC4EA0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000343")]
	public override bool MaskEnabled() { }

	[Address(RVA = "0x1CC5D60", Offset = "0x1CC4F60", Length = "0x361")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_hasPopInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_popMaterialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000346")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CC60D0", Offset = "0x1CC52D0", Length = "0x285")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_hasPopInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000345")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Obsolete("Not used anymore.")]
	[Token(Token = "0x6000344")]
	public override void OnSiblingGraphicEnabledDisabled() { }

	[Address(RVA = "0x1CC6450", Offset = "0x1CC5650", Length = "0xDD")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000340")]
	public void set_showMaskGraphic(bool value) { }

}

