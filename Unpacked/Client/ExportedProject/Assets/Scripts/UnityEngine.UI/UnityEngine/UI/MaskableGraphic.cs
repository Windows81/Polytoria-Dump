namespace UnityEngine.UI;

[Token(Token = "0x2000056")]
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
{
	[Token(Token = "0x2000057")]
	internal class CullStateChangedEvent : UnityEvent<Boolean>
	{

		[Address(RVA = "0x1CB30F0", Offset = "0x1CB22F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000360")]
		public CullStateChangedEvent() { }

	}

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400019D")]
	protected bool m_ShouldRecalculateStencil; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400019E")]
	protected Material m_MaskMaterial; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400019F")]
	private RectMask2D m_ParentMask; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x40001A0")]
	private bool m_Maskable; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x40001A1")]
	private bool m_IsMaskingGraphic; //Field offset: 0xC1
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0xC2")]
	[Obsolete("Not used anymore.", True)]
	[Token(Token = "0x40001A2")]
	protected bool m_IncludeForMasking; //Field offset: 0xC2
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x40001A3")]
	private CullStateChangedEvent m_OnCullStateChanged; //Field offset: 0xC8
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0xD0")]
	[Obsolete("Not used anymore", True)]
	[Token(Token = "0x40001A4")]
	protected bool m_ShouldRecalculate; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40001A5")]
	protected int m_StencilValue; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001A6")]
	private readonly Vector3[] m_Corners; //Field offset: 0xD8

	[Token(Token = "0x170000DB")]
	public bool isMaskingGraphic
	{
		[Address(RVA = "0x1CC6EC0", Offset = "0x1CC60C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600034D")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC71A0", Offset = "0x1CC63A0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600034E")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170000DA")]
	public bool maskable
	{
		[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034B")]
		 get { } //Length: 8
		[Address(RVA = "0x1CC71B0", Offset = "0x1CC63B0", Length = "0x2A")]
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600034C")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170000D9")]
	public CullStateChangedEvent onCullStateChanged
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000349")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600034A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170000DC")]
	private Rect rootCanvasRect
	{
		[Address(RVA = "0x1CC6ED0", Offset = "0x1CC60D0", Length = "0x2CC")]
		[CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000359")]
		private get { } //Length: 716
	}

	[Address(RVA = "0x1CC6DC0", Offset = "0x1CC5FC0", Length = "0xF6")]
	[CalledBy(Type = "TMPro.TMP_SelectionCaret", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600035E")]
	protected MaskableGraphic() { }

	[Address(RVA = "0x1CC6530", Offset = "0x1CC5730", Length = "0x169")]
	[CalledBy(Type = "TMPro.TMP_SelectionCaret", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaskableGraphic), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000350")]
	public override void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x1CC6EC0", Offset = "0x1CC60C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034D")]
	public bool get_isMaskingGraphic() { }

	[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034B")]
	public bool get_maskable() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000349")]
	public CullStateChangedEvent get_onCullStateChanged() { }

	[Address(RVA = "0x1CC6ED0", Offset = "0x1CC60D0", Length = "0x2CC")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000359")]
	private Rect get_rootCanvasRect() { }

	[Address(RVA = "0x1CC66A0", Offset = "0x1CC58A0", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600034F")]
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x1CC6800", Offset = "0x1CC5A00", Length = "0x51")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000358")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1CC6860", Offset = "0x1CC5A60", Length = "0xB7")]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000355")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CC6920", Offset = "0x1CC5B20", Length = "0x55")]
	[CalledBy(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000354")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CC6980", Offset = "0x1CC5B80", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000356")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	[Token(Token = "0x6000357")]
	public override void ParentMaskStateChanged() { }

	[Address(RVA = "0x1CC69E0", Offset = "0x1CC5BE0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035D")]
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x1CC6A10", Offset = "0x1CC5C10", Length = "0x7")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "RecalculateClipping", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "RecalculateClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[Token(Token = "0x600035B")]
	public override void RecalculateClipping() { }

	[Address(RVA = "0x1CC6A20", Offset = "0x1CC5C20", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600035C")]
	public override void RecalculateMasking() { }

	[Address(RVA = "0x1CC71A0", Offset = "0x1CC63A0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600034E")]
	public void set_isMaskingGraphic(bool value) { }

	[Address(RVA = "0x1CC71B0", Offset = "0x1CC63B0", Length = "0x2A")]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034C")]
	public void set_maskable(bool value) { }

	[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600034A")]
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	[Address(RVA = "0x1CC6AB0", Offset = "0x1CC5CB0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "DisableRectClipping", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "EnableRectClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000352")]
	public override void SetClipRect(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x1CC6B10", Offset = "0x1CC5D10", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_clippingSoftness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000353")]
	public override void SetClipSoftness(Vector2 clipSoftness) { }

	[Address(RVA = "0x1CC6B50", Offset = "0x1CC5D50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Token(Token = "0x600035F")]
	private override GameObject UnityEngine.UI.IClippable.get_gameObject() { }

	[Address(RVA = "0x1CC6B60", Offset = "0x1CC5D60", Length = "0x185")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "RecalculateClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MaskUtilities), Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClippable)}, ReturnType = typeof(RectMask2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectMask2D), Member = "RemoveClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClippable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectMask2D), Member = "AddClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClippable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600035A")]
	private void UpdateClipParent() { }

	[Address(RVA = "0x1CC6CF0", Offset = "0x1CC5EF0", Length = "0xC8")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000351")]
	private void UpdateCull(bool cull) { }

}

