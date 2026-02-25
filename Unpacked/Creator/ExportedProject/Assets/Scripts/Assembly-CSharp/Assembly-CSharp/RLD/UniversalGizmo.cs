namespace RLD;

[Token(Token = "0x2000115")]
public class UniversalGizmo : GizmoBehaviour
{
	[Token(Token = "0x2000116")]
	internal enum MvVertexSnapState
	{
		SelectingPivot = 0,
		Snapping = 1,
		Inactive = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C7")]
	private GizmoLineSlider3D _mvPXSlider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004C8")]
	private GizmoLineSlider3D _mvPYSlider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C9")]
	private GizmoLineSlider3D _mvPZSlider; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004CA")]
	private GizmoLineSlider3D _mvNXSlider; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004CB")]
	private GizmoLineSlider3D _mvNYSlider; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004CC")]
	private GizmoLineSlider3D _mvNZSlider; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004CD")]
	private GizmoLineSlider3DCollection _mvAxesSliders; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004CE")]
	private GizmoPlaneSlider3D _mvXYSlider; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004CF")]
	private GizmoPlaneSlider3D _mvYZSlider; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004D0")]
	private GizmoPlaneSlider3D _mvZXSlider; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40004D1")]
	private GizmoPlaneSlider3DCollection _mvDblSliders; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004D2")]
	private bool _isMvVertexSnapEnabled; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004D3")]
	private GizmoCap2D _mvVertSnapCap; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004D4")]
	private GizmoObjectVertexSnapDrag3D _mvVertexSnapDrag; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40004D5")]
	private Vector3 _mvPostVSnapPosRestore; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40004D6")]
	private GizmoLineSlider2D _mvP2DModeXSlider; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40004D7")]
	private GizmoLineSlider2D _mvP2DModeYSlider; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40004D8")]
	private GizmoLineSlider2D _mvN2DModeXSlider; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40004D9")]
	private GizmoLineSlider2D _mvN2DModeYSlider; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40004DA")]
	private GizmoLineSlider2DCollection _mv2DModeSliders; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40004DB")]
	private GizmoPlaneSlider2D _mv2DModeDblSlider; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40004DC")]
	private GizmoPlaneSlider3D _rtXSlider; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40004DD")]
	private GizmoPlaneSlider3D _rtYSlider; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40004DE")]
	private GizmoPlaneSlider3D _rtZSlider; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40004DF")]
	private GizmoPlaneSlider3DCollection _rtAxesSliders; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40004E0")]
	private GizmoCap3D _rtMidCap; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40004E1")]
	private GizmoDblAxisRotationDrag3D _rtCamXYRotationDrag; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40004E2")]
	private GizmoPlaneSlider2D _rtCamLookSlider; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40004E3")]
	private GizmoCap3D _scMidCap; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40004E4")]
	private GizmoUniformScaleDrag3D _scUnformScaleDrag; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40004E5")]
	private GizmoScaleGuide _scScaleGuide; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40004E6")]
	private IEnumerable<GameObject> _scScaleGuideTargetObjects; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40004E7")]
	private bool _is2DModeEnabled; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x40004E8")]
	private UniversalGizmoSettings2D _settings2D; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40004E9")]
	private UniversalGizmoSettings2D _sharedSettings2D; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x40004EA")]
	private UniversalGizmoSettings3D _settings3D; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40004EB")]
	private UniversalGizmoSettings3D _sharedSettings3D; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x40004EC")]
	private UniversalGizmoLookAndFeel2D _lookAndFeel2D; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40004ED")]
	private UniversalGizmoLookAndFeel2D _sharedLookAndFeel2D; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x40004EE")]
	private UniversalGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40004EF")]
	private UniversalGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x40004F0")]
	private UniversalGizmoHotkeys _hotkeys; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40004F1")]
	private UniversalGizmoHotkeys _sharedHotkeys; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x40004F2")]
	private bool _useSnapEnableHotkey; //Field offset: 0x180
	[FieldOffset(Offset = "0x181")]
	[SerializeField]
	[Token(Token = "0x40004F3")]
	private bool _useVertSnapEnableHotkey; //Field offset: 0x181
	[FieldOffset(Offset = "0x182")]
	[SerializeField]
	[Token(Token = "0x40004F4")]
	private bool _use2DModeEnableHotkey; //Field offset: 0x182

	[Token(Token = "0x170003DE")]
	public UniversalGizmoHotkeys Hotkeys
	{
		[Address(RVA = "0x538990", Offset = "0x537B90", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BCA")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003DA")]
	public UniversalGizmoLookAndFeel2D LookAndFeel2D
	{
		[Address(RVA = "0x5389B0", Offset = "0x537BB0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BC4")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003DC")]
	public UniversalGizmoLookAndFeel3D LookAndFeel3D
	{
		[Address(RVA = "0x5389D0", Offset = "0x537BD0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BC7")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003D6")]
	public UniversalGizmoSettings2D Settings2D
	{
		[Address(RVA = "0x5389F0", Offset = "0x537BF0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BBE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003D8")]
	public UniversalGizmoSettings3D Settings3D
	{
		[Address(RVA = "0x538A10", Offset = "0x537C10", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BC1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003DF")]
	public UniversalGizmoHotkeys SharedHotkeys
	{
		[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCB")]
		 get { } //Length: 8
		[Address(RVA = "0x538A60", Offset = "0x537C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCC")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170003DB")]
	public UniversalGizmoLookAndFeel2D SharedLookAndFeel2D
	{
		[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC5")]
		 get { } //Length: 8
		[Address(RVA = "0x538A80", Offset = "0x537C80", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x6000BC6")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170003DD")]
	public UniversalGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC8")]
		 get { } //Length: 8
		[Address(RVA = "0x538AB0", Offset = "0x537CB0", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x6000BC9")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170003D7")]
	public UniversalGizmoSettings2D SharedSettings2D
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBF")]
		 get { } //Length: 8
		[Address(RVA = "0x538AE0", Offset = "0x537CE0", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[Token(Token = "0x6000BC0")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170003D9")]
	public UniversalGizmoSettings3D SharedSettings3D
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC2")]
		 get { } //Length: 8
		[Address(RVA = "0x538B10", Offset = "0x537D10", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[Token(Token = "0x6000BC3")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170003E2")]
	public bool Use2DModeEnableHotkey
	{
		[Address(RVA = "0x538A30", Offset = "0x537C30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BD1")]
		 get { } //Length: 8
		[Address(RVA = "0x538B40", Offset = "0x537D40", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BD2")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170003E0")]
	public bool UseSnapEnableHotkey
	{
		[Address(RVA = "0x538A40", Offset = "0x537C40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BCD")]
		 get { } //Length: 8
		[Address(RVA = "0x538B50", Offset = "0x537D50", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BCE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170003E1")]
	public bool UseVertSnapEnableHotkey
	{
		[Address(RVA = "0x538A50", Offset = "0x537C50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000BCF")]
		 get { } //Length: 8
		[Address(RVA = "0x538B60", Offset = "0x537D60", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000BD0")]
		 set { } //Length: 86
	}

	[Address(RVA = "0x538520", Offset = "0x537720", Length = "0x464")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateUniversalGizmo", ReturnType = typeof(UniversalGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoUniformScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BFE")]
	public UniversalGizmo() { }

	[Address(RVA = "0x538990", Offset = "0x537B90", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BCA")]
	public UniversalGizmoHotkeys get_Hotkeys() { }

	[Address(RVA = "0x5389B0", Offset = "0x537BB0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BC4")]
	public UniversalGizmoLookAndFeel2D get_LookAndFeel2D() { }

	[Address(RVA = "0x5389D0", Offset = "0x537BD0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BC7")]
	public UniversalGizmoLookAndFeel3D get_LookAndFeel3D() { }

	[Address(RVA = "0x5389F0", Offset = "0x537BF0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BBE")]
	public UniversalGizmoSettings2D get_Settings2D() { }

	[Address(RVA = "0x538A10", Offset = "0x537C10", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BC1")]
	public UniversalGizmoSettings3D get_Settings3D() { }

	[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BCB")]
	public UniversalGizmoHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC5")]
	public UniversalGizmoLookAndFeel2D get_SharedLookAndFeel2D() { }

	[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC8")]
	public UniversalGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBF")]
	public UniversalGizmoSettings2D get_SharedSettings2D() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC2")]
	public UniversalGizmoSettings3D get_SharedSettings3D() { }

	[Address(RVA = "0x538A30", Offset = "0x537C30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BD1")]
	public bool get_Use2DModeEnableHotkey() { }

	[Address(RVA = "0x538A40", Offset = "0x537C40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BCD")]
	public bool get_UseSnapEnableHotkey() { }

	[Address(RVA = "0x538A50", Offset = "0x537C50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BCF")]
	public bool get_UseVertSnapEnableHotkey() { }

	[Address(RVA = "0x533C50", Offset = "0x532E50", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BD3")]
	public MvVertexSnapState GetMvVertexSnapState() { }

	[Address(RVA = "0x533CA0", Offset = "0x532EA0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BD5")]
	public float GetMvZoomFactor(Vector3 position, Camera camera) { }

	[Address(RVA = "0x533D80", Offset = "0x532F80", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BD4")]
	public float GetMvZoomFactor(Vector3 position) { }

	[Address(RVA = "0x533E60", Offset = "0x533060", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BD6")]
	public float GetRtZoomFactor(Vector3 position) { }

	[Address(RVA = "0x533F30", Offset = "0x533130", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BD7")]
	public float GetRtZoomFactor(Vector3 position, Camera camera) { }

	[Address(RVA = "0x534000", Offset = "0x533200", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BD9")]
	public float GetScZoomFactor(Vector3 position, Camera camera) { }

	[Address(RVA = "0x5340D0", Offset = "0x5332D0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BD8")]
	public float GetScZoomFactor(Vector3 position) { }

	[Address(RVA = "0x5341A0", Offset = "0x5333A0", Length = "0x6B")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Set2DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BF9")]
	private void Hide2DModeHandles() { }

	[Address(RVA = "0x534210", Offset = "0x533410", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsMoveHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000BDA")]
	public bool IsDraggingMoveHandle() { }

	[Address(RVA = "0x534260", Offset = "0x533460", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsRotationHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000BDB")]
	public bool IsDraggingRotationHandle() { }

	[Address(RVA = "0x5342B0", Offset = "0x5334B0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BDC")]
	public bool IsDraggingScaleHandle() { }

	[Address(RVA = "0x534320", Offset = "0x533520", Length = "0xC7")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "IsDraggingMoveHandle", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OwnsHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BDD")]
	public bool IsMoveHandle(int handleId) { }

	[Address(RVA = "0x5343F0", Offset = "0x5335F0", Length = "0x73")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "IsDraggingRotationHandle", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OwnsHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BDE")]
	public bool IsRotationHandle(int handleId) { }

	[Address(RVA = "0x534470", Offset = "0x533670", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BDF")]
	public bool IsScaleHandle(int handleId) { }

	[Address(RVA = "0x5344A0", Offset = "0x5336A0", Length = "0xFFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSlider), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Priority), Member = "MakeLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Set2DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandleId), Member = "get_MidScaleCap", ReturnType = typeof(int))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Priority), Member = "MakeHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = "get_HoverPriority3D", ReturnType = typeof(Priority))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandleId), Member = "get_VertSnap", ReturnType = typeof(int))]
	[Calls(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 42)]
	[Token(Token = "0x6000BE8")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x5354A0", Offset = "0x5346A0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BE9")]
	public virtual void OnDetached() { }

	[Address(RVA = "0x535540", Offset = "0x534740", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BEB")]
	public virtual void OnDisabled() { }

	[Address(RVA = "0x5355E0", Offset = "0x5347E0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BEA")]
	public virtual void OnEnabled() { }

	[Address(RVA = "0x535680", Offset = "0x534880", Length = "0x3A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "get_Position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoUniformScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "get_RtSnapMode", ReturnType = typeof(GizmoSnapMode))]
	[Calls(Type = typeof(GizmoDblAxisRotationDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000BF2")]
	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	[Address(RVA = "0x535A30", Offset = "0x534C30", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsMoveHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsRotationHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetMoveHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetRotationHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Set3DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BF0")]
	public virtual void OnGizmoDragBegin(int handleId) { }

	[Address(RVA = "0x535B50", Offset = "0x534D50", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BF1")]
	public virtual void OnGizmoDragEnd(int handleId) { }

	[Address(RVA = "0x535BB0", Offset = "0x534DB0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "get_RelativeDragOffset", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BEF")]
	public virtual void OnGizmoDragUpdate(int handleId) { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BEC")]
	public virtual void OnGizmoEnabled() { }

	[Address(RVA = "0x535C40", Offset = "0x534E40", Length = "0x514")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoScaleGuide), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "GetRenderSortedSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoLineSlider3D>))]
	[Calls(Type = typeof(UniversalGizmo), Member = "UpdateRtCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "get_NumRenderCameras", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	[Token(Token = "0x6000BEE")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x536160", Offset = "0x535360", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(UniversalGizmo), Member = "UpdateRtCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BF8")]
	private void OnGizmoTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x5361C0", Offset = "0x5353C0", Length = "0x105D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsMoveHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalGizmo), Member = "UpdateRtCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "get_RtDragSensitivity", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsRotationHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "SelectSnapPivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetRotationHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "get_ScDragSensitivity", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BED")]
	public virtual void OnGizmoUpdateBegin() { }

	[Address(RVA = "0x537220", Offset = "0x536420", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsMoveHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalGizmo), Member = "IsRotationHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BE0")]
	public bool OwnsHandle(int handleId) { }

	[Address(RVA = "0x51C390", Offset = "0x51B590", Length = "0x108")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF3")]
	private void PlaceMvDblSlidersInSliderPlanes(Camera camera) { }

	[Address(RVA = "0x538A60", Offset = "0x537C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BCC")]
	public void set_SharedHotkeys(UniversalGizmoHotkeys value) { }

	[Address(RVA = "0x538A80", Offset = "0x537C80", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x6000BC6")]
	public void set_SharedLookAndFeel2D(UniversalGizmoLookAndFeel2D value) { }

	[Address(RVA = "0x538AB0", Offset = "0x537CB0", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x6000BC9")]
	public void set_SharedLookAndFeel3D(UniversalGizmoLookAndFeel3D value) { }

	[Address(RVA = "0x538AE0", Offset = "0x537CE0", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Token(Token = "0x6000BC0")]
	public void set_SharedSettings2D(UniversalGizmoSettings2D value) { }

	[Address(RVA = "0x538B10", Offset = "0x537D10", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Token(Token = "0x6000BC3")]
	public void set_SharedSettings3D(UniversalGizmoSettings3D value) { }

	[Address(RVA = "0x538B40", Offset = "0x537D40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BD2")]
	public void set_Use2DModeEnableHotkey(bool value) { }

	[Address(RVA = "0x538B50", Offset = "0x537D50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BCE")]
	public void set_UseSnapEnableHotkey(bool value) { }

	[Address(RVA = "0x538B60", Offset = "0x537D60", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000BD0")]
	public void set_UseVertSnapEnableHotkey(bool value) { }

	[Address(RVA = "0x537290", Offset = "0x536490", Length = "0x1D1")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalGizmo), Member = "Hide2DModeHandles", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Set2DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetOffsetDragOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetMoveHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetRotationHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000BE3")]
	public void Set2DModeEnabled(bool isEnabled) { }

	[Address(RVA = "0x537470", Offset = "0x536670", Length = "0x5B")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Set3DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BFB")]
	private void SetMoveHandlesVisible(bool visible) { }

	[Address(RVA = "0x527D70", Offset = "0x526F70", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSlider), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BE5")]
	public void SetMvAxesLinesHoverable(bool hoverable) { }

	[Address(RVA = "0x5374D0", Offset = "0x5366D0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetRotationHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BE2")]
	public void SetMvVertexSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x5375A0", Offset = "0x5367A0", Length = "0x21")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "SetTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BE4")]
	public void SetMvVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects) { }

	[Address(RVA = "0x5375D0", Offset = "0x5367D0", Length = "0x61")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetMvVertexSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BFC")]
	private void SetRotationHandlesVisible(bool visible) { }

	[Address(RVA = "0x537640", Offset = "0x536840", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BE6")]
	public void SetRtMidCapHoverable(bool hoverable) { }

	[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BE7")]
	public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects) { }

	[Address(RVA = "0x537690", Offset = "0x536890", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BFD")]
	private void SetScaleHandlesVisible(bool visible) { }

	[Address(RVA = "0x5376C0", Offset = "0x5368C0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000BE1")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x5377B0", Offset = "0x5369B0", Length = "0x6C8")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "set_SharedLookAndFeel2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BF4")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x537E80", Offset = "0x537080", Length = "0x3B9")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "set_SharedSettings2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoSettings2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoSettings3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "ConnectMvSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "ConnectMvDblSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(PlaneId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings2D), Member = "ConnectMvSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings2D), Member = "ConnectMvDblSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "set_Settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectVertexSnapSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "ConnectRtSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "ConnectRtCamLookSliderSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BF5")]
	private void SetupSharedSettings() { }

	[Address(RVA = "0x51D300", Offset = "0x51C500", Length = "0x9A")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF6")]
	private void Update2DGizmoPosition() { }

	[Address(RVA = "0x538240", Offset = "0x537440", Length = "0x1C5")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "set_StartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BF7")]
	private void Update2DModeHandlePositions() { }

	[Address(RVA = "0x538410", Offset = "0x537610", Length = "0x10A")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "MakePolySphereBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BFA")]
	private void UpdateRtCamLookSlider(Camera camera) { }

}

