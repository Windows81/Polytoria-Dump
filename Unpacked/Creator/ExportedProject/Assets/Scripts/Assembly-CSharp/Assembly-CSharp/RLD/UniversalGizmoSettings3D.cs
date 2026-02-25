namespace RLD;

[Token(Token = "0x200011B")]
public class UniversalGizmoSettings3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400051C")]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400051D")]
	private GizmoObjectVertexSnapSettings _mvVertexSnapSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400051E")]
	private GizmoLineSlider3DSettings[] _mvSglSliderSettings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400051F")]
	private GizmoPlaneSlider3DSettings[] _mvDblSliderSettings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000520")]
	private float _rtCamRightSnapStep; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000521")]
	private float _rtCamUpSnapStep; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000522")]
	private GizmoPlaneSlider3DSettings[] _rtSliderSettings; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000523")]
	private GizmoPlaneSlider2DSettings _rtCamLookSliderSettings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000524")]
	private float _scUniformSnapStep; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000525")]
	private GizmoLineSlider3DSettings[] _scSglSliderSettings; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000526")]
	private GizmoPlaneSlider3DSettings[] _scDblSliderSettings; //Field offset: 0x70

	[Token(Token = "0x170004A2")]
	public UniversalGizmoSettingsCategory DisplayCategory
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D94")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D95")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000484")]
	public float MvBoxSliderHoverEps
	{
		[Address(RVA = "0x54F0F0", Offset = "0x54E2F0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D76")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000485")]
	public float MvCylinderSliderHoverEps
	{
		[Address(RVA = "0x52A7C0", Offset = "0x5299C0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D77")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000489")]
	public float MvDragSensitivity
	{
		[Address(RVA = "0x551200", Offset = "0x550400", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D7B")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000483")]
	public float MvLineSliderHoverEps
	{
		[Address(RVA = "0x54F130", Offset = "0x54E330", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D75")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000486")]
	public float MvXSnapStep
	{
		[Address(RVA = "0x4FA3B0", Offset = "0x4F95B0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D78")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000487")]
	public float MvYSnapStep
	{
		[Address(RVA = "0x551240", Offset = "0x550440", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D79")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000488")]
	public float MvZSnapStep
	{
		[Address(RVA = "0x551280", Offset = "0x550480", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D7A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700048A")]
	public float RtAxisLineHoverEps
	{
		[Address(RVA = "0x5512C0", Offset = "0x5504C0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D7C")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700048B")]
	public float RtAxisTorusHoverEps
	{
		[Address(RVA = "0x532820", Offset = "0x531A20", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D7D")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700048C")]
	public float RtCamLookLineHoverEps
	{
		[Address(RVA = "0x551300", Offset = "0x550500", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D7E")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000495")]
	public float RtCamLookSnapStep
	{
		[Address(RVA = "0x551320", Offset = "0x550520", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D87")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700048D")]
	public float RtCamLookThickHoverEps
	{
		[Address(RVA = "0x551340", Offset = "0x550540", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D7F")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000493")]
	public float RtCamRightSnapStep
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D85")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000494")]
	public float RtCamUpSnapStep
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D86")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700048E")]
	public bool RtCanHoverCulledPixels
	{
		[Address(RVA = "0x551360", Offset = "0x550560", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D80")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000496")]
	public float RtDragSensitivity
	{
		[Address(RVA = "0x5513A0", Offset = "0x5505A0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D88")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700048F")]
	public GizmoSnapMode RtSnapMode
	{
		[Address(RVA = "0x5513E0", Offset = "0x5505E0", Length = "0x2F")]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D81")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000490")]
	public float RtXSnapStep
	{
		[Address(RVA = "0x5324E0", Offset = "0x5316E0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D82")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000491")]
	public float RtYSnapStep
	{
		[Address(RVA = "0x551410", Offset = "0x550610", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D83")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000492")]
	public float RtZSnapStep
	{
		[Address(RVA = "0x551450", Offset = "0x550650", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D84")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000498")]
	public float ScBoxSliderHoverEps
	{
		[Address(RVA = "0x551490", Offset = "0x550690", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D8A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000499")]
	public float ScCylinderSliderHoverEps
	{
		[Address(RVA = "0x5514D0", Offset = "0x5506D0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D8B")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170004A1")]
	public float ScDragSensitivity
	{
		[Address(RVA = "0x551510", Offset = "0x550710", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D93")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000497")]
	public float ScLineSliderHoverEps
	{
		[Address(RVA = "0x551550", Offset = "0x550750", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D89")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170004A0")]
	public float ScUniformSnapStep
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D92")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700049A")]
	public float ScXSnapStep
	{
		[Address(RVA = "0x551590", Offset = "0x550790", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D8C")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700049D")]
	public float ScXYSnapStep
	{
		[Address(RVA = "0x5515D0", Offset = "0x5507D0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D8F")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700049B")]
	public float ScYSnapStep
	{
		[Address(RVA = "0x551610", Offset = "0x550810", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D8D")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700049E")]
	public float ScYZSnapStep
	{
		[Address(RVA = "0x551650", Offset = "0x550850", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D90")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700049C")]
	public float ScZSnapStep
	{
		[Address(RVA = "0x551690", Offset = "0x550890", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D8E")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700049F")]
	public float ScZXSnapStep
	{
		[Address(RVA = "0x5516D0", Offset = "0x5508D0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D91")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000482")]
	public GizmoObjectVertexSnapSettings VertexSnapSettings
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D74")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x550AA0", Offset = "0x54FCA0", Length = "0x75F")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoPlaneSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoLineSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(GizmoObjectVertexSnapSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6000D96")]
	public UniversalGizmoSettings3D() { }

	[Address(RVA = "0x54F170", Offset = "0x54E370", Length = "0x45")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D9F")]
	public void ConnectMvDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	[Address(RVA = "0x54F1C0", Offset = "0x54E3C0", Length = "0x63")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D9E")]
	public void ConnectMvSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x54F230", Offset = "0x54E430", Length = "0x2C")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DAF")]
	public void ConnectRtCamLookSliderSettings(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x54F260", Offset = "0x54E460", Length = "0x45")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DAE")]
	public void ConnectRtSliderSettings(GizmoPlaneSlider3D slider, int axisIndex) { }

	[Address(RVA = "0x54F2B0", Offset = "0x54E4B0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DBD")]
	public void ConnectScDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	[Address(RVA = "0x54F300", Offset = "0x54E500", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DBC")]
	public void ConnectScSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D94")]
	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	[Address(RVA = "0x54F0F0", Offset = "0x54E2F0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D76")]
	public float get_MvBoxSliderHoverEps() { }

	[Address(RVA = "0x52A7C0", Offset = "0x5299C0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D77")]
	public float get_MvCylinderSliderHoverEps() { }

	[Address(RVA = "0x551200", Offset = "0x550400", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7B")]
	public float get_MvDragSensitivity() { }

	[Address(RVA = "0x54F130", Offset = "0x54E330", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D75")]
	public float get_MvLineSliderHoverEps() { }

	[Address(RVA = "0x4FA3B0", Offset = "0x4F95B0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D78")]
	public float get_MvXSnapStep() { }

	[Address(RVA = "0x551240", Offset = "0x550440", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D79")]
	public float get_MvYSnapStep() { }

	[Address(RVA = "0x551280", Offset = "0x550480", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7A")]
	public float get_MvZSnapStep() { }

	[Address(RVA = "0x5512C0", Offset = "0x5504C0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7C")]
	public float get_RtAxisLineHoverEps() { }

	[Address(RVA = "0x532820", Offset = "0x531A20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D7D")]
	public float get_RtAxisTorusHoverEps() { }

	[Address(RVA = "0x551300", Offset = "0x550500", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D7E")]
	public float get_RtCamLookLineHoverEps() { }

	[Address(RVA = "0x551320", Offset = "0x550520", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D87")]
	public float get_RtCamLookSnapStep() { }

	[Address(RVA = "0x551340", Offset = "0x550540", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D7F")]
	public float get_RtCamLookThickHoverEps() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D85")]
	public float get_RtCamRightSnapStep() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D86")]
	public float get_RtCamUpSnapStep() { }

	[Address(RVA = "0x551360", Offset = "0x550560", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D80")]
	public bool get_RtCanHoverCulledPixels() { }

	[Address(RVA = "0x5513A0", Offset = "0x5505A0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D88")]
	public float get_RtDragSensitivity() { }

	[Address(RVA = "0x5513E0", Offset = "0x5505E0", Length = "0x2F")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D81")]
	public GizmoSnapMode get_RtSnapMode() { }

	[Address(RVA = "0x5324E0", Offset = "0x5316E0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D82")]
	public float get_RtXSnapStep() { }

	[Address(RVA = "0x551410", Offset = "0x550610", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D83")]
	public float get_RtYSnapStep() { }

	[Address(RVA = "0x551450", Offset = "0x550650", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D84")]
	public float get_RtZSnapStep() { }

	[Address(RVA = "0x551490", Offset = "0x550690", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D8A")]
	public float get_ScBoxSliderHoverEps() { }

	[Address(RVA = "0x5514D0", Offset = "0x5506D0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D8B")]
	public float get_ScCylinderSliderHoverEps() { }

	[Address(RVA = "0x551510", Offset = "0x550710", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D93")]
	public float get_ScDragSensitivity() { }

	[Address(RVA = "0x551550", Offset = "0x550750", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D89")]
	public float get_ScLineSliderHoverEps() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D92")]
	public float get_ScUniformSnapStep() { }

	[Address(RVA = "0x551590", Offset = "0x550790", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D8C")]
	public float get_ScXSnapStep() { }

	[Address(RVA = "0x5515D0", Offset = "0x5507D0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D8F")]
	public float get_ScXYSnapStep() { }

	[Address(RVA = "0x551610", Offset = "0x550810", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D8D")]
	public float get_ScYSnapStep() { }

	[Address(RVA = "0x551650", Offset = "0x550850", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D90")]
	public float get_ScYZSnapStep() { }

	[Address(RVA = "0x551690", Offset = "0x550890", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D8E")]
	public float get_ScZSnapStep() { }

	[Address(RVA = "0x5516D0", Offset = "0x5508D0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D91")]
	public float get_ScZXSnapStep() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D74")]
	public GizmoObjectVertexSnapSettings get_VertexSnapSettings() { }

	[Address(RVA = "0x54F370", Offset = "0x54E570", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DA2")]
	private GizmoPlaneSlider3DSettings GetMvDblSliderSettings(PlaneId planeId) { }

	[Address(RVA = "0x3D74E0", Offset = "0x3D66E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA1")]
	private GizmoLineSlider3DSettings GetMvSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x54F3A0", Offset = "0x54E5A0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DC0")]
	private GizmoPlaneSlider3DSettings GetScDblSliderSettings(PlaneId planeId) { }

	[Address(RVA = "0x54F3D0", Offset = "0x54E5D0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DBF")]
	private GizmoLineSlider3DSettings GetScSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x54FBA0", Offset = "0x54EDA0", Length = "0x434")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = "get_DragSensitivity", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = "get_YSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = "get_ZSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoObjectVertexSnapSettings), Member = "Transfer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectVertexSnapSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 21)]
	[Token(Token = "0x6000DA0")]
	public void Inherit(MoveGizmoSettings3D settings) { }

	[Address(RVA = "0x54F730", Offset = "0x54E930", Length = "0x468")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_DragSensitivity", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "SetScDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_XSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_YSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_ZSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_XYSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_YZSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = "get_ZXSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 21)]
	[Token(Token = "0x6000DBE")]
	public void Inherit(ScaleGizmoSettings3D settings) { }

	[Address(RVA = "0x54F420", Offset = "0x54E620", Length = "0x306")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = "SetRtAxisTorusHoverEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_CamLookThickHoverEps", ReturnType = typeof(float))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_CamLookLineHoverEps", ReturnType = typeof(float))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_CanHoverCulledPixels", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_DragSensitivity", ReturnType = typeof(float))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_SnapMode", ReturnType = typeof(GizmoSnapMode))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_XSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_YSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "get_ZSnapStep", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6000DB0")]
	public void Inherit(RotationGizmoSettings3D settings) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D95")]
	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	[Address(RVA = "0x54ECE0", Offset = "0x54DEE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D98")]
	public void SetMvBoxSliderHoverEps(float eps) { }

	[Address(RVA = "0x529B90", Offset = "0x528D90", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D99")]
	public void SetMvCylinderSliderHoverEps(float eps) { }

	[Address(RVA = "0x54FFE0", Offset = "0x54F1E0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D9D")]
	public void SetMvDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x54EDE0", Offset = "0x54DFE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D97")]
	public void SetMvLineSliderHoverEps(float eps) { }

	[Address(RVA = "0x5500B0", Offset = "0x54F2B0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000D9A")]
	public void SetMvXSnapStep(float snapStep) { }

	[Address(RVA = "0x550170", Offset = "0x54F370", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000D9B")]
	public void SetMvYSnapStep(float snapStep) { }

	[Address(RVA = "0x550230", Offset = "0x54F430", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000D9C")]
	public void SetMvZSnapStep(float snapStep) { }

	[Address(RVA = "0x5502F0", Offset = "0x54F4F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DA4")]
	public void SetRtAxisLineHoverEps(float eps) { }

	[Address(RVA = "0x550360", Offset = "0x54F560", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DA8")]
	public void SetRtAxisSnapStep(int axisIndex, float snapStep) { }

	[Address(RVA = "0x5503A0", Offset = "0x54F5A0", Length = "0x6F")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DA5")]
	public void SetRtAxisTorusHoverEps(float eps) { }

	[Address(RVA = "0x550410", Offset = "0x54F610", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DA6")]
	public void SetRtCamLookLineHoverEps(float eps) { }

	[Address(RVA = "0x550430", Offset = "0x54F630", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DAB")]
	public void SetRtCamLookSnapStep(float snapStep) { }

	[Address(RVA = "0x550450", Offset = "0x54F650", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DA7")]
	public void SetRtCamLookThickHoverEps(float eps) { }

	[Address(RVA = "0x508FF0", Offset = "0x5081F0", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA9")]
	public void SetRtCamRightSnapStep(float snapStep) { }

	[Address(RVA = "0x509010", Offset = "0x508210", Length = "0x14")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAA")]
	public void SetRtCamUpSnapStep(float snapStep) { }

	[Address(RVA = "0x550470", Offset = "0x54F670", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DA3")]
	public void SetRtCanHoverCulledPixels(bool canHover) { }

	[Address(RVA = "0x5504D0", Offset = "0x54F6D0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000DAD")]
	public void SetRtDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x550560", Offset = "0x54F760", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DAC")]
	public void SetRtSnapMode(GizmoSnapMode snapMode) { }

	[Address(RVA = "0x5505C0", Offset = "0x54F7C0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB2")]
	public void SetScBoxSliderHoverEps(float eps) { }

	[Address(RVA = "0x550630", Offset = "0x54F830", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB3")]
	public void SetScCylinderSliderHoverEps(float eps) { }

	[Address(RVA = "0x5506A0", Offset = "0x54F8A0", Length = "0x6F")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DBB")]
	public void SetScDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x550710", Offset = "0x54F910", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB1")]
	public void SetScLineSliderHoverEps(float eps) { }

	[Address(RVA = "0x550780", Offset = "0x54F980", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000DBA")]
	public void SetScUniformScaleSnapStep(float snapStep) { }

	[Address(RVA = "0x5507A0", Offset = "0x54F9A0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000DB4")]
	public void SetScXSnapStep(float snapStep) { }

	[Address(RVA = "0x550860", Offset = "0x54FA60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB7")]
	public void SetScXYSnapStep(float snapStep) { }

	[Address(RVA = "0x5508A0", Offset = "0x54FAA0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000DB5")]
	public void SetScYSnapStep(float snapStep) { }

	[Address(RVA = "0x550960", Offset = "0x54FB60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB8")]
	public void SetScYZSnapStep(float snapStep) { }

	[Address(RVA = "0x5509A0", Offset = "0x54FBA0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000DB6")]
	public void SetScZSnapStep(float snapStep) { }

	[Address(RVA = "0x550A60", Offset = "0x54FC60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DB9")]
	public void SetScZXSnapStep(float snapStep) { }

}

