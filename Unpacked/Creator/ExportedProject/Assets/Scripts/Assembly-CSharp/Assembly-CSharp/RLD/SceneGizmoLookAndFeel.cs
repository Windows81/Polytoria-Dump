namespace RLD;

[Token(Token = "0x200009C")]
public class SceneGizmoLookAndFeel : Settings
{
	[Token(Token = "0x4000221")]
	private static readonly float _baseScreenSize; //Field offset: 0x0
	[Token(Token = "0x4000222")]
	private static readonly float _invBaseScreenSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000223")]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000224")]
	private GizmoCap3DLookAndFeel[] _axesCapsLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000225")]
	private SceneGizmoScreenCorner _screenCorner; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000226")]
	private Vector2 _screenOffset; //Field offset: 0x3C
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000227")]
	private float _screenSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000228")]
	private Color _axesLabelTint; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000229")]
	private Color _camPrjSwitchLabelTint; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400022A")]
	private bool _isCamPrjSwitchLabelVisible; //Field offset: 0x68

	[Token(Token = "0x170001AC")]
	public GizmoCap3DType AxesCapType
	{
		[Address(RVA = "0x3E36D0", Offset = "0x3E28D0", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000572")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170001A6")]
	public Color AxesLabelTint
	{
		[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000569")]
		 get { } //Length: 11
		[Address(RVA = "0x3E3CA0", Offset = "0x3E2EA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B8")]
	public float AxisCamAlignFadeOutAlpha
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600057E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001B7")]
	public float AxisCamAlignFadeOutDuration
	{
		[Address(RVA = "0x3E3720", Offset = "0x3E2920", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600057D")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001B6")]
	public float AxisCamAlignFadeOutThreshold
	{
		[Address(RVA = "0x3E3730", Offset = "0x3E2930", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600057C")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001A2")]
	private GizmoCap3DLookAndFeel AxisCapLookAndFeel
	{
		[Address(RVA = "0x3E3740", Offset = "0x3E2940", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000562")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170001B0")]
	public float AxisConeHeight
	{
		[Address(RVA = "0x3E3770", Offset = "0x3E2970", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000576")]
		 get { } //Length: 128
	}

	[Token(Token = "0x170001B1")]
	public float AxisConeRadius
	{
		[Address(RVA = "0x3E37F0", Offset = "0x3E29F0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "get_DefaultConeRadius", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000577")]
		 get { } //Length: 128
	}

	[Token(Token = "0x170001B5")]
	public float AxisLabelScreenSize
	{
		[Address(RVA = "0x3E3870", Offset = "0x3E2A70", Length = "0x70")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "GetAxesLabelWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600057B")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170001B4")]
	public float AxisPyramidDepth
	{
		[Address(RVA = "0x3E38E0", Offset = "0x3E2AE0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600057A")]
		 get { } //Length: 128
	}

	[Token(Token = "0x170001B3")]
	public float AxisPyramidHeight
	{
		[Address(RVA = "0x3E3960", Offset = "0x3E2B60", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000579")]
		 get { } //Length: 128
	}

	[Token(Token = "0x170001B2")]
	public float AxisPyramidWidth
	{
		[Address(RVA = "0x3E39E0", Offset = "0x3E2BE0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000578")]
		 get { } //Length: 128
	}

	[Token(Token = "0x170001AA")]
	public Texture2D CamOrthoModeLabelTexture
	{
		[Address(RVA = "0x3E3A60", Offset = "0x3E2C60", Length = "0x65")]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TexturePool), Member = "get_CamOrthoMode", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000570")]
		 get { } //Length: 101
	}

	[Token(Token = "0x170001A9")]
	public Texture2D CamPerspModeLabelTexture
	{
		[Address(RVA = "0x3E3AD0", Offset = "0x3E2CD0", Length = "0x65")]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TexturePool), Member = "get_CamPerspMode", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600056F")]
		 get { } //Length: 101
	}

	[Token(Token = "0x170001A7")]
	public Color CamPrjSwitchLabelTint
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056B")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001AB")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3E3B40", Offset = "0x3E2D40", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000571")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170001A8")]
	public bool IsCamPrjSwitchLabelVisible
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056D")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001AE")]
	public float MidCapBoxSize
	{
		[Address(RVA = "0x3E3B80", Offset = "0x3E2D80", Length = "0x70")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000574")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170001AF")]
	public float MidCapSphereRadius
	{
		[Address(RVA = "0x3E3BF0", Offset = "0x3E2DF0", Length = "0x70")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000575")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170001AD")]
	public GizmoCap3DType MidCapType
	{
		[Address(RVA = "0x3E3C60", Offset = "0x3E2E60", Length = "0x1A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000573")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170001A3")]
	public SceneGizmoScreenCorner ScreenCorner
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000563")]
		 get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000564")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001A4")]
	public Vector2 ScreenOffset
	{
		[Address(RVA = "0x3E3C80", Offset = "0x3E2E80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000565")]
		 get { } //Length: 19
		[Address(RVA = "0x3E3CB0", Offset = "0x3E2EB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000566")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001A5")]
	public float ScreenSize
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000567")]
		 get { } //Length: 6
		[Address(RVA = "0x3E3CC0", Offset = "0x3E2EC0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[Token(Token = "0x6000568")]
		 set { } //Length: 26
	}

	[Address(RVA = "0x3E32D0", Offset = "0x3E24D0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000594")]
	private static SceneGizmoLookAndFeel() { }

	[Address(RVA = "0x3E3330", Offset = "0x3E2530", Length = "0x395")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_CenterAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600057F")]
	public SceneGizmoLookAndFeel() { }

	[Address(RVA = "0x3E26F0", Offset = "0x3E18F0", Length = "0x244")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "UpdateTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamViewportUpdater), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTSceneGizmoCamera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TexturePool), Member = "get_CamOrthoMode", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(TexturePool), Member = "get_CamPerspMode", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600058F")]
	public Vector2 CalculateMaxPrjSwitchLabelRectSize() { }

	[Address(RVA = "0x3E2940", Offset = "0x3E1B40", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000591")]
	public void ConnectAxisCapLookAndFeel(GizmoCap3D axisCap, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3E29B0", Offset = "0x3E1BB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000590")]
	public void ConnectMidCapLookAndFeel(GizmoCap3D midCap) { }

	[Address(RVA = "0x3E36D0", Offset = "0x3E28D0", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000572")]
	public GizmoCap3DType get_AxesCapType() { }

	[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000569")]
	public Color get_AxesLabelTint() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600057E")]
	public float get_AxisCamAlignFadeOutAlpha() { }

	[Address(RVA = "0x3E3720", Offset = "0x3E2920", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600057D")]
	public float get_AxisCamAlignFadeOutDuration() { }

	[Address(RVA = "0x3E3730", Offset = "0x3E2930", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600057C")]
	public float get_AxisCamAlignFadeOutThreshold() { }

	[Address(RVA = "0x3E3740", Offset = "0x3E2940", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000562")]
	private GizmoCap3DLookAndFeel get_AxisCapLookAndFeel() { }

	[Address(RVA = "0x3E3770", Offset = "0x3E2970", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000576")]
	public float get_AxisConeHeight() { }

	[Address(RVA = "0x3E37F0", Offset = "0x3E29F0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "get_DefaultConeRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000577")]
	public float get_AxisConeRadius() { }

	[Address(RVA = "0x3E3870", Offset = "0x3E2A70", Length = "0x70")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "GetAxesLabelWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600057B")]
	public float get_AxisLabelScreenSize() { }

	[Address(RVA = "0x3E38E0", Offset = "0x3E2AE0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600057A")]
	public float get_AxisPyramidDepth() { }

	[Address(RVA = "0x3E3960", Offset = "0x3E2B60", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000579")]
	public float get_AxisPyramidHeight() { }

	[Address(RVA = "0x3E39E0", Offset = "0x3E2BE0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000578")]
	public float get_AxisPyramidWidth() { }

	[Address(RVA = "0x3E3A60", Offset = "0x3E2C60", Length = "0x65")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TexturePool), Member = "get_CamOrthoMode", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000570")]
	public Texture2D get_CamOrthoModeLabelTexture() { }

	[Address(RVA = "0x3E3AD0", Offset = "0x3E2CD0", Length = "0x65")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TexturePool), Member = "get_CamPerspMode", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600056F")]
	public Texture2D get_CamPerspModeLabelTexture() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056B")]
	public Color get_CamPrjSwitchLabelTint() { }

	[Address(RVA = "0x3E3B40", Offset = "0x3E2D40", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000571")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056D")]
	public bool get_IsCamPrjSwitchLabelVisible() { }

	[Address(RVA = "0x3E3B80", Offset = "0x3E2D80", Length = "0x70")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000574")]
	public float get_MidCapBoxSize() { }

	[Address(RVA = "0x3E3BF0", Offset = "0x3E2DF0", Length = "0x70")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000575")]
	public float get_MidCapSphereRadius() { }

	[Address(RVA = "0x3E3C60", Offset = "0x3E2E60", Length = "0x1A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000573")]
	public GizmoCap3DType get_MidCapType() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000563")]
	public SceneGizmoScreenCorner get_ScreenCorner() { }

	[Address(RVA = "0x3E3C80", Offset = "0x3E2E80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000565")]
	public Vector2 get_ScreenOffset() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000567")]
	public float get_ScreenSize() { }

	[Address(RVA = "0x3E29E0", Offset = "0x3E1BE0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000589")]
	public List<Enum> GetAllowedAxesCapTypes() { }

	[Address(RVA = "0x3E2B60", Offset = "0x3E1D60", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000588")]
	public List<Enum> GetAllowedMidCapTypes() { }

	[Address(RVA = "0x3E2CE0", Offset = "0x3E1EE0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "get_AxisLabelScreenSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "ScreenToEstimatedWorldSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600058E")]
	public float GetAxesLabelWorldSize(Camera gizmoCam, Vector3 labelWorldPos) { }

	[Address(RVA = "0x3E2D80", Offset = "0x3E1F80", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000582")]
	public Color GetAxisCapColor(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3E2DE0", Offset = "0x3E1FE0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000592")]
	private GizmoCap3DLookAndFeel GetAxisCapLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3E2E30", Offset = "0x3E2030", Length = "0xE")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600058C")]
	public bool IsAxisCapTypeAllowed(GizmoCap3DType capType) { }

	[Address(RVA = "0x3E2E40", Offset = "0x3E2040", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600058A")]
	public bool IsMidCapTypeAllowed(GizmoCap3DType capType) { }

	[Address(RVA = "0x3E2E50", Offset = "0x3E2050", Length = "0x1FB")]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "set_ScreenSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "get_MidCapSphereRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "get_DefaultConeRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "get_MidCapBoxSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000593")]
	private void OnScreenSizeChanged() { }

	[Address(RVA = "0x3E3CA0", Offset = "0x3E2EA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056A")]
	public void set_AxesLabelTint(Color value) { }

	[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056C")]
	public void set_CamPrjSwitchLabelTint(Color value) { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056E")]
	public void set_IsCamPrjSwitchLabelVisible(bool value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000564")]
	public void set_ScreenCorner(SceneGizmoScreenCorner value) { }

	[Address(RVA = "0x3E3CB0", Offset = "0x3E2EB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000566")]
	public void set_ScreenOffset(Vector2 value) { }

	[Address(RVA = "0x3E3CC0", Offset = "0x3E2EC0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[Token(Token = "0x6000568")]
	public void set_ScreenSize(float value) { }

	[Address(RVA = "0x3E3050", Offset = "0x3E2250", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000581")]
	public void SetAxisCapColor(Color color, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3E30B0", Offset = "0x3E22B0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000585")]
	public void SetAxisCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x3E3110", Offset = "0x3E2310", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000587")]
	public void SetAxisCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x3E3170", Offset = "0x3E2370", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600058D")]
	public void SetAxisCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x3E31D0", Offset = "0x3E23D0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000583")]
	public void SetHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x3E3240", Offset = "0x3E2440", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000580")]
	public void SetMidCapColor(Color color) { }

	[Address(RVA = "0x3E3260", Offset = "0x3E2460", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000584")]
	public void SetMidCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x3E3280", Offset = "0x3E2480", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000586")]
	public void SetMidCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x3E32A0", Offset = "0x3E24A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600058B")]
	public void SetMidCapType(GizmoCap3DType capType) { }

}

