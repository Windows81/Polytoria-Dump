namespace UnityEngine.UI;

[AddComponentMenu("UI/Image", 11)]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000024")]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	[Token(Token = "0x2000026")]
	internal enum FillMethod
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4,
	}

	[Token(Token = "0x200002A")]
	internal enum Origin180
	{
		Bottom = 0,
		Left = 1,
		Top = 2,
		Right = 3,
	}

	[Token(Token = "0x200002B")]
	internal enum Origin360
	{
		Bottom = 0,
		Right = 1,
		Top = 2,
		Left = 3,
	}

	[Token(Token = "0x2000029")]
	internal enum Origin90
	{
		BottomLeft = 0,
		TopLeft = 1,
		TopRight = 2,
		BottomRight = 3,
	}

	[Token(Token = "0x2000027")]
	internal enum OriginHorizontal
	{
		Left = 0,
		Right = 1,
	}

	[Token(Token = "0x2000028")]
	internal enum OriginVertical
	{
		Bottom = 0,
		Top = 1,
	}

	[Token(Token = "0x2000025")]
	internal enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
	}

	[Token(Token = "0x4000096")]
	protected static Material s_ETC1DefaultUI; //Field offset: 0x0
	[Token(Token = "0x40000A5")]
	private static SecondarySpriteTexture[] s_TempNewSecondaryTextures; //Field offset: 0x8
	[Token(Token = "0x40000A7")]
	private static readonly Vector2[] s_VertScratch; //Field offset: 0x10
	[Token(Token = "0x40000A8")]
	private static readonly Vector2[] s_UVScratch; //Field offset: 0x18
	[Token(Token = "0x40000A9")]
	private static readonly Vector3[] s_Xy; //Field offset: 0x20
	[Token(Token = "0x40000AA")]
	private static readonly Vector3[] s_Uv; //Field offset: 0x28
	[Token(Token = "0x40000AB")]
	private static List<Image> m_TrackedTexturelessImages; //Field offset: 0x30
	[Token(Token = "0x40000AC")]
	private static bool s_Initialized; //Field offset: 0x38
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private Sprite m_Sprite; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000098")]
	private Sprite m_OverrideSprite; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000099")]
	private Type m_Type; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x400009A")]
	private bool m_PreserveAspect; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF5")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	private bool m_FillCenter; //Field offset: 0xF5
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x400009C")]
	private FillMethod m_FillMethod; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x400009D")]
	private float m_FillAmount; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x400009E")]
	private bool m_FillClockwise; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	[Token(Token = "0x400009F")]
	private int m_FillOrigin; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000A0")]
	private float m_AlphaHitTestMinimumThreshold; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40000A1")]
	private bool m_Tracked; //Field offset: 0x10C
	[FieldOffset(Offset = "0x10D")]
	[SerializeField]
	[Token(Token = "0x40000A2")]
	private bool m_UseSpriteMesh; //Field offset: 0x10D
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40000A3")]
	private float m_PixelsPerUnitMultiplier; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40000A4")]
	private float m_CachedReferencePixelsPerUnit; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40000A6")]
	private SecondarySpriteTexture[] m_SecondaryTextures; //Field offset: 0x118

	[Token(Token = "0x1700004D")]
	private Sprite activeSprite
	{
		[Address(RVA = "0x1A900C0", Offset = "0x1A8F2C0", Length = "0x7A")]
		[CallerCount(Count = 62)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000143")]
		private get { } //Length: 122
	}

	[Token(Token = "0x17000056")]
	public float alphaHitTestMinimumThreshold
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000154")]
		 get { } //Length: 9
		[Address(RVA = "0x1A90AB0", Offset = "0x1A8FCB0", Length = "0x159")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000155")]
		 set { } //Length: 345
	}

	[Token(Token = "0x17000058")]
	public static Material defaultETC1GraphicMaterial
	{
		[Address(RVA = "0x1A90140", Offset = "0x1A8F340", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000159")]
		 get { } //Length: 242
	}

	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	[Token(Token = "0x17000055")]
	public float eventAlphaThreshold
	{
		[Address(RVA = "0x1A90240", Offset = "0x1A8F440", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000152")]
		 get { } //Length: 17
		[Address(RVA = "0x1A90C10", Offset = "0x1A8FE10", Length = "0x162")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000153")]
		 set { } //Length: 354
	}

	[Token(Token = "0x17000052")]
	public float fillAmount
	{
		[Address(RVA = "0x465050", Offset = "0x464250", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014C")]
		 get { } //Length: 9
		[Address(RVA = "0x1A90D80", Offset = "0x1A8FF80", Length = "0x85")]
		[CalledBy(Type = "Polytoria.UI.UIStaminaBar", Member = "SetFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.LoadScreenController", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetHealthFilled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600014D")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000050")]
	public bool fillCenter
	{
		[Address(RVA = "0x1A90260", Offset = "0x1A8F460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000148")]
		 get { } //Length: 8
		[Address(RVA = "0x1A90E10", Offset = "0x1A90010", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000149")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000053")]
	public bool fillClockwise
	{
		[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014E")]
		 get { } //Length: 8
		[Address(RVA = "0x1A90E80", Offset = "0x1A90080", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600014F")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000051")]
	public FillMethod fillMethod
	{
		[Address(RVA = "0x4209D0", Offset = "0x41FBD0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014A")]
		 get { } //Length: 7
		[Address(RVA = "0x1A90EF0", Offset = "0x1A900F0", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600014B")]
		 set { } //Length: 111
	}

	[Token(Token = "0x17000054")]
	public int fillOrigin
	{
		[Address(RVA = "0x426C50", Offset = "0x425E50", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000150")]
		 get { } //Length: 7
		[Address(RVA = "0x1A90F60", Offset = "0x1A90160", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000151")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000065")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000183")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000062")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000180")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700005A")]
	public bool hasBorder
	{
		[Address(RVA = "0x1A90270", Offset = "0x1A8F470", Length = "0xE8")]
		[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600015B")]
		 get { } //Length: 232
	}

	[Token(Token = "0x17000066")]
	public override int layoutPriority
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000184")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000059")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x1A90360", Offset = "0x1A8F560", Length = "0x18A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600015A")]
		 get { } //Length: 394
	}

	[Token(Token = "0x1700005E")]
	public virtual Material material
	{
		[Address(RVA = "0x1A904F0", Offset = "0x1A8F6F0", Length = "0x219")]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "get_material", ReturnType = typeof(Material))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000160")]
		 get { } //Length: 537
		[Address(RVA = "0x1A88B40", Offset = "0x1A87D40", Length = "0x92")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000161")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000063")]
	public override float minHeight
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000181")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000060")]
	public override float minWidth
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700005D")]
	protected float multipliedPixelsPerUnit
	{
		[Address(RVA = "0x1A90710", Offset = "0x1A8F910", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Token(Token = "0x600015F")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700004C")]
	public Sprite overrideSprite
	{
		[Address(RVA = "0x1A90730", Offset = "0x1A8F930", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Token(Token = "0x6000141")]
		 get { } //Length: 7
		[Address(RVA = "0x1A90FD0", Offset = "0x1A901D0", Length = "0x71")]
		[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000142")]
		 set { } //Length: 113
	}

	[Token(Token = "0x1700005C")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x1A90740", Offset = "0x1A8F940", Length = "0x13E")]
		[CalledBy(Type = typeof(Image), Member = "get_multipliedPixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Image), Member = "SetNativeSize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Image), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600015E")]
		 get { } //Length: 318
	}

	[Token(Token = "0x1700005B")]
	public float pixelsPerUnitMultiplier
	{
		[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015C")]
		 get { } //Length: 9
		[Address(RVA = "0x1A91050", Offset = "0x1A90250", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.UIView", Member = "UpdateBorder", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600015D")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000064")]
	public override float preferredHeight
	{
		[Address(RVA = "0x1A90880", Offset = "0x1A8FA80", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000182")]
		 get { } //Length: 259
	}

	[Token(Token = "0x17000061")]
	public override float preferredWidth
	{
		[Address(RVA = "0x1A90990", Offset = "0x1A8FB90", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600017F")]
		 get { } //Length: 259
	}

	[Token(Token = "0x1700004F")]
	public bool preserveAspect
	{
		[Address(RVA = "0x1A58350", Offset = "0x1A57550", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000146")]
		 get { } //Length: 8
		[Address(RVA = "0x1A91080", Offset = "0x1A90280", Length = "0x68")]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "Init", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000147")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700005F")]
	internal SecondarySpriteTexture[] secondaryTextures
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700004B")]
	public Sprite sprite
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013E")]
		 get { } //Length: 8
		[Address(RVA = "0x1A910F0", Offset = "0x1A902F0", Length = "0x38E")]
		[CallerCount(Count = 80)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
		[Calls(Type = typeof(Image), Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Sprite), Member = "GetSecondaryTextureCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "ClearArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600013F")]
		 set { } //Length: 910
	}

	[Token(Token = "0x1700004E")]
	public Type type
	{
		[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000144")]
		 get { } //Length: 7
		[Address(RVA = "0x1A91480", Offset = "0x1A90680", Length = "0x65")]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000145")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000057")]
	public bool useSpriteMesh
	{
		[Address(RVA = "0x1A90AA0", Offset = "0x1A8FCA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000156")]
		 get { } //Length: 8
		[Address(RVA = "0x1A914F0", Offset = "0x1A906F0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000157")]
		 set { } //Length: 104
	}

	[Address(RVA = "0x1A8FE50", Offset = "0x1A8F050", Length = "0x205")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600018B")]
	private static Image() { }

	[Address(RVA = "0x1A90060", Offset = "0x1A8F260", Length = "0x53")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000158")]
	protected Image() { }

	[Address(RVA = "0x1A8F850", Offset = "0x1A8EA50", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecondarySpriteTexture), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture), typeof(SecondarySpriteTexture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CompilerGenerated]
	[Token(Token = "0x600018E")]
	internal static bool <CheckSecondaryTexturesChanged>g__Compare|93_0(SecondarySpriteTexture[] array1, SecondarySpriteTexture[] array2) { }

	[Address(RVA = "0x1A8F910", Offset = "0x1A8EB10", Length = "0x1A4")]
	[CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600018C")]
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[Address(RVA = "0x1A8FAC0", Offset = "0x1A8ECC0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600018D")]
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }

	[Address(RVA = "0x1A88F00", Offset = "0x1A88100", Length = "0x178")]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000176")]
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	[Address(RVA = "0x1A88CC0", Offset = "0x1A87EC0", Length = "0x231")]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000177")]
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017C")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1A89110", Offset = "0x1A88310", Length = "0x207")]
	[CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Image), Member = "SetSecondaryTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasRenderer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecondarySpriteTexture), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture), typeof(SecondarySpriteTexture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "GetSecondaryTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "ClearArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "GetSecondaryTextureCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600016E")]
	private bool CheckSecondaryTexturesChanged(Sprite sprite, ref SecondarySpriteTexture[] newSecondaryTextures) { }

	[Address(RVA = "0x1A89080", Offset = "0x1A88280", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "ClearArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600016D")]
	private bool CheckSecondaryTexturesChanged(Sprite sprite) { }

	[Address(RVA = "0x1A89320", Offset = "0x1A88520", Length = "0xA1")]
	[CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Image), Member = "SetSecondaryTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasRenderer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600016C")]
	private static void ClearArray(ref SecondarySpriteTexture[] array) { }

	[Address(RVA = "0x1A893D0", Offset = "0x1A885D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000140")]
	public void DisableSpriteOptimizations() { }

	[Address(RVA = "0x1A893E0", Offset = "0x1A885E0", Length = "0x13E1")]
	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Image), Member = "RadialCut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Vector3[]), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000179")]
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	[Address(RVA = "0x1A8A7D0", Offset = "0x1A899D0", Length = "0x3BD")]
	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000172")]
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	[Address(RVA = "0x1A8AB90", Offset = "0x1A89D90", Length = "0xA34")]
	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	[Address(RVA = "0x1A8B5D0", Offset = "0x1A8A7D0", Length = "0x5D3")]
	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Sprite), Member = "get_triangles", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sprite), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000173")]
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	[Address(RVA = "0x1A8BBB0", Offset = "0x1A8ADB0", Length = "0x13DF")]
	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Texture), Member = "get_wrapMode", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000175")]
	private void GenerateTiledSprite(VertexHelper toFill) { }

	[Address(RVA = "0x1A900C0", Offset = "0x1A8F2C0", Length = "0x7A")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000143")]
	private Sprite get_activeSprite() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000154")]
	public float get_alphaHitTestMinimumThreshold() { }

	[Address(RVA = "0x1A90140", Offset = "0x1A8F340", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000159")]
	public static Material get_defaultETC1GraphicMaterial() { }

	[Address(RVA = "0x1A90240", Offset = "0x1A8F440", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000152")]
	public float get_eventAlphaThreshold() { }

	[Address(RVA = "0x465050", Offset = "0x464250", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014C")]
	public float get_fillAmount() { }

	[Address(RVA = "0x1A90260", Offset = "0x1A8F460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000148")]
	public bool get_fillCenter() { }

	[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014E")]
	public bool get_fillClockwise() { }

	[Address(RVA = "0x4209D0", Offset = "0x41FBD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014A")]
	public FillMethod get_fillMethod() { }

	[Address(RVA = "0x426C50", Offset = "0x425E50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000150")]
	public int get_fillOrigin() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000183")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1A90270", Offset = "0x1A8F470", Length = "0xE8")]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600015B")]
	public bool get_hasBorder() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000184")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x1A90360", Offset = "0x1A8F560", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600015A")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x1A904F0", Offset = "0x1A8F6F0", Length = "0x219")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "get_material", ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000160")]
	public virtual Material get_material() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000181")]
	public override float get_minHeight() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017E")]
	public override float get_minWidth() { }

	[Address(RVA = "0x1A90710", Offset = "0x1A8F910", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Token(Token = "0x600015F")]
	protected float get_multipliedPixelsPerUnit() { }

	[Address(RVA = "0x1A90730", Offset = "0x1A8F930", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Token(Token = "0x6000141")]
	public Sprite get_overrideSprite() { }

	[Address(RVA = "0x1A90740", Offset = "0x1A8F940", Length = "0x13E")]
	[CalledBy(Type = typeof(Image), Member = "get_multipliedPixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "SetNativeSize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600015E")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015C")]
	public float get_pixelsPerUnitMultiplier() { }

	[Address(RVA = "0x1A90880", Offset = "0x1A8FA80", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000182")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x1A90990", Offset = "0x1A8FB90", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600017F")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x1A58350", Offset = "0x1A57550", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000146")]
	public bool get_preserveAspect() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016B")]
	internal SecondarySpriteTexture[] get_secondaryTextures() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013E")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000144")]
	public Type get_type() { }

	[Address(RVA = "0x1A90AA0", Offset = "0x1A8FCA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000156")]
	public bool get_useSpriteMesh() { }

	[Address(RVA = "0x1A8CF90", Offset = "0x1A8C190", Length = "0x355")]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Vector4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000178")]
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	[Address(RVA = "0x1A8D2F0", Offset = "0x1A8C4F0", Length = "0x360")]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000165")]
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	[Address(RVA = "0x1A8D660", Offset = "0x1A8C860", Length = "0x47D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000185")]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	[Address(RVA = "0x1A8DAE0", Offset = "0x1A8CCE0", Length = "0x6C7")]
	[CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000186")]
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	[Address(RVA = "0x1A8E1B0", Offset = "0x1A8D3B0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000163")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000162")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x1A8E220", Offset = "0x1A8D420", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000171")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1A8E380", Offset = "0x1A8D580", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018A")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1A8E3D0", Offset = "0x1A8D5D0", Length = "0xC0")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016A")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1A8E4A0", Offset = "0x1A8D6A0", Length = "0x1F")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
	[Token(Token = "0x6000169")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1A8E4C0", Offset = "0x1A8D6C0", Length = "0x144")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000167")]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[Address(RVA = "0x1A8E610", Offset = "0x1A8D810", Length = "0x175")]
	[CalledBy(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000164")]
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	[Address(RVA = "0x1A8E790", Offset = "0x1A8D990", Length = "0x14A")]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "RadialCut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(float), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600017A")]
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	[Address(RVA = "0x1A8E8E0", Offset = "0x1A8DAE0", Length = "0x4D7")]
	[CalledBy(Type = typeof(Image), Member = "RadialCut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Vector3[]), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600017B")]
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	[Address(RVA = "0x1A8EDC0", Offset = "0x1A8DFC0", Length = "0x1FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(SpriteAtlas), Member = "CanBindTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000187")]
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	[Address(RVA = "0x1A90AB0", Offset = "0x1A8FCB0", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000155")]
	public void set_alphaHitTestMinimumThreshold(float value) { }

	[Address(RVA = "0x1A90C10", Offset = "0x1A8FE10", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000153")]
	public void set_eventAlphaThreshold(float value) { }

	[Address(RVA = "0x1A90D80", Offset = "0x1A8FF80", Length = "0x85")]
	[CalledBy(Type = "Polytoria.UI.UIStaminaBar", Member = "SetFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.LoadScreenController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetHealthFilled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014D")]
	public void set_fillAmount(float value) { }

	[Address(RVA = "0x1A90E10", Offset = "0x1A90010", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000149")]
	public void set_fillCenter(bool value) { }

	[Address(RVA = "0x1A90E80", Offset = "0x1A90080", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014F")]
	public void set_fillClockwise(bool value) { }

	[Address(RVA = "0x1A90EF0", Offset = "0x1A900F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014B")]
	public void set_fillMethod(FillMethod value) { }

	[Address(RVA = "0x1A90F60", Offset = "0x1A90160", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000151")]
	public void set_fillOrigin(int value) { }

	[Address(RVA = "0x1A88B40", Offset = "0x1A87D40", Length = "0x92")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000161")]
	public virtual void set_material(Material value) { }

	[Address(RVA = "0x1A90FD0", Offset = "0x1A901D0", Length = "0x71")]
	[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000142")]
	public void set_overrideSprite(Sprite value) { }

	[Address(RVA = "0x1A91050", Offset = "0x1A90250", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.UIView", Member = "UpdateBorder", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015D")]
	public void set_pixelsPerUnitMultiplier(float value) { }

	[Address(RVA = "0x1A91080", Offset = "0x1A90280", Length = "0x68")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000147")]
	public void set_preserveAspect(bool value) { }

	[Address(RVA = "0x1A910F0", Offset = "0x1A902F0", Length = "0x38E")]
	[CallerCount(Count = 80)]
	[Calls(Type = typeof(Image), Member = "ClearArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "GetSecondaryTextureCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Image), Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013F")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x1A91480", Offset = "0x1A90680", Length = "0x65")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000145")]
	public void set_type(Type value) { }

	[Address(RVA = "0x1A914F0", Offset = "0x1A906F0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000157")]
	public void set_useSpriteMesh(bool value) { }

	[Address(RVA = "0x1A8EFC0", Offset = "0x1A8E1C0", Length = "0x21D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000166")]
	public virtual void SetNativeSize() { }

	[Address(RVA = "0x1A8F1E0", Offset = "0x1A8E3E0", Length = "0x2B3")]
	[CalledBy(Type = typeof(Image), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "ClearArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetSecondaryTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetSecondaryTextureCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Image), Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(SecondarySpriteTexture[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x600016F")]
	internal void SetSecondaryTextures(CanvasRenderer renderer) { }

	[Address(RVA = "0x1A8F4A0", Offset = "0x1A8E6A0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000188")]
	private static void TrackImage(Image g) { }

	[Address(RVA = "0x1A8F610", Offset = "0x1A8E810", Length = "0x23E")]
	[CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000168")]
	private void TrackSprite() { }

	[Address(RVA = "0x1A8FC00", Offset = "0x1A8EE00", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000189")]
	private static void UnTrackImage(Image g) { }

	[Address(RVA = "0x1A8FC80", Offset = "0x1A8EE80", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetAlphaTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "SetSecondaryTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasRenderer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000170")]
	protected virtual void UpdateMaterial() { }

}

