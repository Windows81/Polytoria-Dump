namespace UnityEngine.UI;

[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
[Token(Token = "0x200003C")]
public class CanvasScaler : UIBehaviour
{
	[Token(Token = "0x200003D")]
	internal enum ScaleMode
	{
		ConstantPixelSize = 0,
		ScaleWithScreenSize = 1,
		ConstantPhysicalSize = 2,
	}

	[Token(Token = "0x200003E")]
	internal enum ScreenMatchMode
	{
		MatchWidthOrHeight = 0,
		Expand = 1,
		Shrink = 2,
	}

	[Token(Token = "0x200003F")]
	internal enum Unit
	{
		Centimeters = 0,
		Millimeters = 1,
		Inches = 2,
		Points = 3,
		Picas = 4,
	}

	[Token(Token = "0x400013A")]
	private const float kLogBase = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000134")]
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	private ScaleMode m_UiScaleMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000135")]
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	protected float m_ReferencePixelsPerUnit; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000136")]
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	protected float m_ScaleFactor; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000137")]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution; //Field offset: 0x2C
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000138")]
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	protected ScreenMatchMode m_ScreenMatchMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x4000139")]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	protected float m_MatchWidthOrHeight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400013B")]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected Unit m_PhysicalUnit; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400013C")]
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	protected float m_FallbackScreenDPI; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400013D")]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400013E")]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400013F")]
	private Canvas m_Canvas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000140")]
	private float m_PrevScaleFactor; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000141")]
	private float m_PrevReferencePixelsPerUnit; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000142")]
	protected bool m_PresetInfoIsWorld; //Field offset: 0x60

	[Token(Token = "0x170000A4")]
	public float defaultSpriteDPI
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026F")]
		 get { } //Length: 6
		[Address(RVA = "0x1CB2C90", Offset = "0x1CB1E90", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000270")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170000A5")]
	public float dynamicPixelsPerUnit
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000271")]
		 get { } //Length: 6
		[Address(RVA = "0x1C73610", Offset = "0x1C72810", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000272")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A3")]
	public float fallbackScreenDPI
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026D")]
		 get { } //Length: 6
		[Address(RVA = "0x83D110", Offset = "0x83C310", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A1")]
	public float matchWidthOrHeight
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000269")]
		 get { } //Length: 6
		[Address(RVA = "0x1A23940", Offset = "0x1A22B40", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026A")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A2")]
	public Unit physicalUnit
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026B")]
		 get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009D")]
	public float referencePixelsPerUnit
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000261")]
		 get { } //Length: 6
		[Address(RVA = "0x1900140", Offset = "0x18FF340", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000262")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700009F")]
	public Vector2 referenceResolution
	{
		[Address(RVA = "0x5C02E0", Offset = "0x5BF4E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000265")]
		 get { } //Length: 19
		[Address(RVA = "0x1CB2CB0", Offset = "0x1CB1EB0", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000266")]
		 set { } //Length: 116
	}

	[Token(Token = "0x1700009E")]
	public float scaleFactor
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000263")]
		 get { } //Length: 6
		[Address(RVA = "0x1CB2D30", Offset = "0x1CB1F30", Length = "0x14")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetUISize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000264")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170000A0")]
	public ScreenMatchMode screenMatchMode
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000267")]
		 get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000268")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009C")]
	public ScaleMode uiScaleMode
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025F")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000260")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1CB2C40", Offset = "0x1CB1E40", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000273")]
	protected CanvasScaler() { }

	[Address(RVA = "0x15A4FA0", Offset = "0x15A41A0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	private void Canvas_preWillRenderCanvases() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026F")]
	public float get_defaultSpriteDPI() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000271")]
	public float get_dynamicPixelsPerUnit() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026D")]
	public float get_fallbackScreenDPI() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000269")]
	public float get_matchWidthOrHeight() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026B")]
	public Unit get_physicalUnit() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000261")]
	public float get_referencePixelsPerUnit() { }

	[Address(RVA = "0x5C02E0", Offset = "0x5BF4E0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000265")]
	public Vector2 get_referenceResolution() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000263")]
	public float get_scaleFactor() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000267")]
	public ScreenMatchMode get_screenMatchMode() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025F")]
	public ScaleMode get_uiScaleMode() { }

	[Address(RVA = "0x1CB28D0", Offset = "0x1CB1AD0", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000277")]
	protected override void Handle() { }

	[Address(RVA = "0x1CB2480", Offset = "0x1CB1680", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600027B")]
	protected override void HandleConstantPhysicalSize() { }

	[Address(RVA = "0x1CB2570", Offset = "0x1CB1770", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000279")]
	protected override void HandleConstantPixelSize() { }

	[Address(RVA = "0x1CB25F0", Offset = "0x1CB17F0", Length = "0x256")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "get_renderingDisplaySize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1818288A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600027A")]
	protected override void HandleScaleWithScreenSize() { }

	[Address(RVA = "0x1CB2850", Offset = "0x1CB1A50", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000278")]
	protected override void HandleWorldCanvas() { }

	[Address(RVA = "0x1CB29F0", Offset = "0x1CB1BF0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Canvas), Member = "remove_preWillRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000276")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CB2AE0", Offset = "0x1CB1CE0", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Canvas), Member = "add_preWillRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000274")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CB2C90", Offset = "0x1CB1E90", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000270")]
	public void set_defaultSpriteDPI(float value) { }

	[Address(RVA = "0x1C73610", Offset = "0x1C72810", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000272")]
	public void set_dynamicPixelsPerUnit(float value) { }

	[Address(RVA = "0x83D110", Offset = "0x83C310", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026E")]
	public void set_fallbackScreenDPI(float value) { }

	[Address(RVA = "0x1A23940", Offset = "0x1A22B40", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026A")]
	public void set_matchWidthOrHeight(float value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026C")]
	public void set_physicalUnit(Unit value) { }

	[Address(RVA = "0x1900140", Offset = "0x18FF340", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000262")]
	public void set_referencePixelsPerUnit(float value) { }

	[Address(RVA = "0x1CB2CB0", Offset = "0x1CB1EB0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000266")]
	public void set_referenceResolution(Vector2 value) { }

	[Address(RVA = "0x1CB2D30", Offset = "0x1CB1F30", Length = "0x14")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetUISize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000264")]
	public void set_scaleFactor(float value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000268")]
	public void set_screenMatchMode(ScreenMatchMode value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000260")]
	public void set_uiScaleMode(ScaleMode value) { }

	[Address(RVA = "0x1CB2BA0", Offset = "0x1CB1DA0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600027D")]
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

	[Address(RVA = "0x1CB2BE0", Offset = "0x1CB1DE0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600027C")]
	protected void SetScaleFactor(float scaleFactor) { }

}

