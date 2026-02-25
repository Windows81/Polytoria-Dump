namespace UnityEngine.UI;

[AddComponentMenu("UI/Rect Mask 2D", 14)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200005F")]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B5")]
	private readonly RectangularVertexClipper m_VertexClipper; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B6")]
	private RectTransform m_RectTransform; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B7")]
	private HashSet<MaskableGraphic> m_MaskableTargets; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B8")]
	private HashSet<IClippable> m_ClipTargets; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001B9")]
	private bool m_ShouldRecalculateClipRects; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BA")]
	private List<RectMask2D> m_Clippers; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001BB")]
	private Rect m_LastClipRectCanvasSpace; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001BC")]
	private bool m_ForceClip; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40001BD")]
	private Vector4 m_Padding; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40001BE")]
	private Vector2Int m_Softness; //Field offset: 0x74
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001BF")]
	private Canvas m_Canvas; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001C0")]
	private Vector3[] m_Corners; //Field offset: 0x88

	[Token(Token = "0x170000E9")]
	internal Canvas Canvas
	{
		[Address(RVA = "0x1CCB980", Offset = "0x1CCAB80", Length = "0x164")]
		[CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RectMask2D), Member = "UpdateClipSoftness", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600038A")]
		internal get { } //Length: 356
	}

	[Token(Token = "0x170000EA")]
	public Rect canvasRect
	{
		[Address(RVA = "0x1CCBAF0", Offset = "0x1CCACF0", Length = "0xB4")]
		[CalledBy(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>), typeof(Boolean&)}, ReturnType = typeof(Rect))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(RectangularVertexClipper), Member = "GetCanvasRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Canvas)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600038B")]
		 get { } //Length: 180
	}

	[Token(Token = "0x170000E7")]
	public Vector4 padding
	{
		[Address(RVA = "0x1CCBBB0", Offset = "0x1CCADB0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000386")]
		 get { } //Length: 11
		[Address(RVA = "0x1CCBE20", Offset = "0x1CCB020", Length = "0xE")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000387")]
		 set { } //Length: 14
	}

	[Token(Token = "0x170000EB")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x1CCBBC0", Offset = "0x1CCADC0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600038C")]
		 get { } //Length: 99
	}

	[Token(Token = "0x170000EC")]
	private Rect rootCanvasRect
	{
		[Address(RVA = "0x1CCBC30", Offset = "0x1CCAE30", Length = "0x1D3")]
		[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000392")]
		private get { } //Length: 467
	}

	[Token(Token = "0x170000E8")]
	public Vector2Int softness
	{
		[Address(RVA = "0x1CCBE10", Offset = "0x1CCB010", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000388")]
		 get { } //Length: 5
		[Address(RVA = "0x1CCBE30", Offset = "0x1CCB030", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000389")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x1CCB810", Offset = "0x1CCAA10", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectangularVertexClipper), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600038D")]
	protected RectMask2D() { }

	[Address(RVA = "0x1CCA4C0", Offset = "0x1CC96C0", Length = "0x108")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000395")]
	public void AddClippable(IClippable clippable) { }

	[Address(RVA = "0x1CCB980", Offset = "0x1CCAB80", Length = "0x164")]
	[CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RectMask2D), Member = "UpdateClipSoftness", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600038A")]
	internal Canvas get_Canvas() { }

	[Address(RVA = "0x1CCBAF0", Offset = "0x1CCACF0", Length = "0xB4")]
	[CalledBy(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>), typeof(Boolean&)}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(RectangularVertexClipper), Member = "GetCanvasRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Canvas)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600038B")]
	public Rect get_canvasRect() { }

	[Address(RVA = "0x1CCBBB0", Offset = "0x1CCADB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000386")]
	public Vector4 get_padding() { }

	[Address(RVA = "0x1CCBBC0", Offset = "0x1CCADC0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600038C")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x1CCBC30", Offset = "0x1CCAE30", Length = "0x1D3")]
	[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000392")]
	private Rect get_rootCanvasRect() { }

	[Address(RVA = "0x1CCBE10", Offset = "0x1CCB010", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000388")]
	public Vector2Int get_softness() { }

	[Address(RVA = "0x1CCA5D0", Offset = "0x1CC97D0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector4)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000391")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x1CCA6E0", Offset = "0x1CC98E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000398")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1CCA720", Offset = "0x1CC9920", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000390")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1CCA740", Offset = "0x1CC9940", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600038F")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CCA800", Offset = "0x1CC9A00", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600038E")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CCA6E0", Offset = "0x1CC98E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000397")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1CCA830", Offset = "0x1CC9A30", Length = "0xB09")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>), typeof(Boolean&)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectMask2D), typeof(System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_hasMoved", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000393")]
	public override void PerformClipping() { }

	[Address(RVA = "0x1CCB340", Offset = "0x1CCA540", Length = "0x1AF")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000396")]
	public void RemoveClippable(IClippable clippable) { }

	[Address(RVA = "0x1CCBE20", Offset = "0x1CCB020", Length = "0xE")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000387")]
	public void set_padding(Vector4 value) { }

	[Address(RVA = "0x1CCBE30", Offset = "0x1CCB030", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000389")]
	public void set_softness(Vector2Int value) { }

	[Address(RVA = "0x1CCB4F0", Offset = "0x1CCA6F0", Length = "0x316")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000394")]
	public override void UpdateClipSoftness() { }

}

