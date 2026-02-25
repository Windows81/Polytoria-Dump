namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200001E")]
public abstract class Graphic : UIBehaviour, ICanvasElement
{
	[Token(Token = "0x400006D")]
	protected static Material s_DefaultUI; //Field offset: 0x0
	[Token(Token = "0x400006E")]
	protected static Texture2D s_WhiteTexture; //Field offset: 0x8
	[Token(Token = "0x400007E")]
	protected static Mesh s_Mesh; //Field offset: 0x10
	[Token(Token = "0x400007F")]
	private static readonly VertexHelper s_VertexHelper; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	[Token(Token = "0x400006F")]
	protected Material m_Material; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000070")]
	private Color m_Color; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000071")]
	protected bool m_SkipLayoutUpdate; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000072")]
	protected bool m_SkipMaterialUpdate; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x4000073")]
	private bool m_RaycastTarget; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000074")]
	private bool m_RaycastTargetCache; //Field offset: 0x3B
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000075")]
	private Vector4 m_RaycastPadding; //Field offset: 0x3C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000076")]
	private RectTransform m_RectTransform; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000077")]
	private CanvasRenderer m_CanvasRenderer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000078")]
	private Canvas m_Canvas; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000079")]
	private bool m_VertsDirty; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400007A")]
	private bool m_MaterialDirty; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400007B")]
	protected UnityAction m_OnDirtyLayoutCallback; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400007C")]
	protected UnityAction m_OnDirtyVertsCallback; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400007D")]
	protected UnityAction m_OnDirtyMaterialCallback; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000080")]
	protected Mesh m_CachedMesh; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000081")]
	protected Vector2[] m_CachedUvs; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000082")]
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000083")]
	private bool <useLegacyMeshGeneration>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x1700003C")]
	public Canvas canvas
	{
		[Address(RVA = "0x1A883D0", Offset = "0x1A875D0", Length = "0x6C")]
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 108
	}

	[Token(Token = "0x1700003D")]
	public CanvasRenderer canvasRenderer
	{
		[Address(RVA = "0x1A88330", Offset = "0x1A87530", Length = "0x9B")]
		[CallerCount(Count = 49)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000036")]
	public override Color color
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 11
		[Address(RVA = "0x1A88AF0", Offset = "0x1A87CF0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 72
	}

	[Token(Token = "0x17000035")]
	public static Material defaultGraphicMaterial
	{
		[Address(RVA = "0x1A88440", Offset = "0x1A87640", Length = "0xF2")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateCaretMaterial", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 242
	}

	[Token(Token = "0x1700003E")]
	public override Material defaultMaterial
	{
		[Address(RVA = "0x1A88540", Offset = "0x1A87740", Length = "0x120")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000FA")]
		 get { } //Length: 288
	}

	[Token(Token = "0x1700003A")]
	public int depth
	{
		[Address(RVA = "0x1A88660", Offset = "0x1A87860", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000041")]
	public override Texture mainTexture
	{
		[Address(RVA = "0x1A88690", Offset = "0x1A87890", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60000FE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700003F")]
	public override Material material
	{
		[Address(RVA = "0x1A888B0", Offset = "0x1A87AB0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 131
		[Address(RVA = "0x1A88B40", Offset = "0x1A87D40", Length = "0x92")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000040")]
	public override Material materialForRendering
	{
		[Address(RVA = "0x1A886E0", Offset = "0x1A878E0", Length = "0x1CF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 463
	}

	[Token(Token = "0x17000038")]
	public Vector4 raycastPadding
	{
		[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 11
		[Address(RVA = "0x599560", Offset = "0x598760", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E9")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000037")]
	public override bool raycastTarget
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 5
		[Address(RVA = "0x1A88BE0", Offset = "0x1A87DE0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
		[Token(Token = "0x60000E7")]
		 set { } //Length: 219
	}

	[Token(Token = "0x1700003B")]
	public override RectTransform rectTransform
	{
		[Address(RVA = "0x1A88940", Offset = "0x1A87B40", Length = "0x55")]
		[CallerCount(Count = 53)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000039")]
	protected bool useLegacyMeshGeneration
	{
		[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 8
		[Address(RVA = "0x184DF50", Offset = "0x184D150", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EB")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000042")]
	protected static Mesh workerMesh
	{
		[Address(RVA = "0x1A889A0", Offset = "0x1A87BA0", Length = "0x14F")]
		[CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphic), Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 335
	}

	[Address(RVA = "0x1A88190", Offset = "0x1A87390", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600011F")]
	private static Graphic() { }

	[Address(RVA = "0x1A88260", Offset = "0x1A87460", Length = "0xCF")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.NonDrawingGraphic", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000EC")]
	protected Graphic() { }

	[Address(RVA = "0x1A85410", Offset = "0x1A84610", Length = "0x17F")]
	[CalledBy(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[CalledBy(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000F8")]
	private void CacheCanvas() { }

	[Address(RVA = "0x1A85590", Offset = "0x1A84790", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000117")]
	private static Color CreateColorFromAlpha(float alpha) { }

	[Address(RVA = "0x1A855B0", Offset = "0x1A847B0", Length = "0xC9")]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CrossFadeAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000118")]
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x1A85680", Offset = "0x1A84880", Length = "0x2DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "GetColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ColorTween), Member = "AddOnChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Color>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenRunner`1), Member = "StartTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000116")]
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	[Address(RVA = "0x1A85960", Offset = "0x1A84B60", Length = "0x40")]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CrossFadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000115")]
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x1A859A0", Offset = "0x1A84BA0", Length = "0x4E5")]
	[CalledBy(Type = typeof(Graphic), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Graphic), Member = "get_workerMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600010A")]
	private void DoLegacyMeshGeneration() { }

	[Address(RVA = "0x1A85E90", Offset = "0x1A85090", Length = "0x53F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_workerMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000109")]
	private void DoMeshGeneration() { }

	[Address(RVA = "0x1A883D0", Offset = "0x1A875D0", Length = "0x6C")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Token(Token = "0x60000F7")]
	public Canvas get_canvas() { }

	[Address(RVA = "0x1A88330", Offset = "0x1A87530", Length = "0x9B")]
	[CallerCount(Count = 49)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F9")]
	public CanvasRenderer get_canvasRenderer() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E4")]
	public override Color get_color() { }

	[Address(RVA = "0x1A88440", Offset = "0x1A87640", Length = "0xF2")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateCaretMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000E3")]
	public static Material get_defaultGraphicMaterial() { }

	[Address(RVA = "0x1A88540", Offset = "0x1A87740", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000FA")]
	public override Material get_defaultMaterial() { }

	[Address(RVA = "0x1A88660", Offset = "0x1A87860", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F5")]
	public int get_depth() { }

	[Address(RVA = "0x1A88690", Offset = "0x1A87890", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000FE")]
	public override Texture get_mainTexture() { }

	[Address(RVA = "0x1A888B0", Offset = "0x1A87AB0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FB")]
	public override Material get_material() { }

	[Address(RVA = "0x1A886E0", Offset = "0x1A878E0", Length = "0x1CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000FD")]
	public override Material get_materialForRendering() { }

	[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E8")]
	public Vector4 get_raycastPadding() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E6")]
	public override bool get_raycastTarget() { }

	[Address(RVA = "0x1A88940", Offset = "0x1A87B40", Length = "0x55")]
	[CallerCount(Count = 53)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000F6")]
	public override RectTransform get_rectTransform() { }

	[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EA")]
	protected bool get_useLegacyMeshGeneration() { }

	[Address(RVA = "0x1A889A0", Offset = "0x1A87BA0", Length = "0x14F")]
	[CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600010B")]
	protected static Mesh get_workerMesh() { }

	[Address(RVA = "0x1A863D0", Offset = "0x1A855D0", Length = "0x1E0")]
	[CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "CalculateInfo", ReturnType = "UnityEngine.UI.ProceduralImage.ProceduralImageInfo")]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Canvas), Member = "get_pixelPerfect", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransformUtility), Member = "PixelAdjustRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Canvas)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000114")]
	public Rect GetPixelAdjustedRect() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1A865C0", Offset = "0x1A857C0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000F3")]
	protected virtual void OnBeforeTransformParentChanged() { }

	[Address(RVA = "0x1A866E0", Offset = "0x1A858E0", Length = "0x152")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000102")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1A86840", Offset = "0x1A85A40", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000103")]
	public override void OnCullingChanged() { }

	[Address(RVA = "0x1A86910", Offset = "0x1A85B10", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000101")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1A86A70", Offset = "0x1A85C70", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010F")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1A86A90", Offset = "0x1A85C90", Length = "0x1B1")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000100")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1A86C50", Offset = "0x1A85E50", Length = "0x188")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FF")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	[Token(Token = "0x600010C")]
	protected override void OnFillVBO(List<UIVertex> vbo) { }

	[Address(RVA = "0x1A86E80", Offset = "0x1A86080", Length = "0x206")]
	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010E")]
	protected override void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x1A86DE0", Offset = "0x1A85FE0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	[Token(Token = "0x600010D")]
	protected override void OnPopulateMesh(Mesh m) { }

	[Address(RVA = "0x1A87090", Offset = "0x1A86290", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000F2")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1A87180", Offset = "0x1A86380", Length = "0xBC")]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000F4")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1A87240", Offset = "0x1A86440", Length = "0x18F")]
	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Canvas), Member = "get_pixelPerfect", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Transform), typeof(Canvas)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000113")]
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	[Address(RVA = "0x1A877D0", Offset = "0x1A869D0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000111")]
	public override bool Raycast(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x1A873D0", Offset = "0x1A865D0", Length = "0x3F2")]
	[CalledBy(Type = typeof(Graphic), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaskableGraphic), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_ignoreParentGroups", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A8B0")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000112")]
	protected bool Raycast(Vector2 sp, Camera eventCamera, bool ignoreMasks) { }

	[Address(RVA = "0x1A877F0", Offset = "0x1A869F0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000104")]
	public override void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x1A878D0", Offset = "0x1A86AD0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000119")]
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	[Address(RVA = "0x1A87970", Offset = "0x1A86B70", Length = "0xAB")]
	[CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "FindGraphic", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600011D")]
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	[Address(RVA = "0x1A87A20", Offset = "0x1A86C20", Length = "0x9F")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "FindGraphic", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600011B")]
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	[Address(RVA = "0x1A88AF0", Offset = "0x1A87CF0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E5")]
	public override void set_color(Color value) { }

	[Address(RVA = "0x1A88B40", Offset = "0x1A87D40", Length = "0x92")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public override void set_material(Material value) { }

	[Address(RVA = "0x599560", Offset = "0x598760", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E9")]
	public void set_raycastPadding(Vector4 value) { }

	[Address(RVA = "0x1A88BE0", Offset = "0x1A87DE0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E7")]
	public override void set_raycastTarget(bool value) { }

	[Address(RVA = "0x184DF50", Offset = "0x184D150", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EB")]
	protected void set_useLegacyMeshGeneration(bool value) { }

	[Address(RVA = "0x1A87AC0", Offset = "0x1A86CC0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000ED")]
	public override void SetAllDirty() { }

	[Address(RVA = "0x1A87B30", Offset = "0x1A86D30", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000EE")]
	public override void SetLayoutDirty() { }

	[Address(RVA = "0x1A87C10", Offset = "0x1A86E10", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000F0")]
	public override void SetMaterialDirty() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000110")]
	public override void SetNativeSize() { }

	[Address(RVA = "0x1A87CF0", Offset = "0x1A86EF0", Length = "0xD3")]
	[CalledBy(Type = typeof(Graphic), Member = "SetAllDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000F1")]
	public void SetRaycastDirty() { }

	[Address(RVA = "0x1A87DD0", Offset = "0x1A86FD0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000EF")]
	public override void SetVerticesDirty() { }

	[Address(RVA = "0x1094810", Offset = "0x1093A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000120")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x1A87EB0", Offset = "0x1A870B0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600011A")]
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	[Address(RVA = "0x1A87F50", Offset = "0x1A87150", Length = "0xAB")]
	[CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600011E")]
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	[Address(RVA = "0x1A88000", Offset = "0x1A87200", Length = "0x9F")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600011C")]
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	[Address(RVA = "0x1A880A0", Offset = "0x1A872A0", Length = "0x15")]
	[CalledBy(Type = typeof(Text), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000108")]
	protected override void UpdateGeometry() { }

	[Address(RVA = "0x1A880C0", Offset = "0x1A872C0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000107")]
	protected override void UpdateMaterial() { }

}

