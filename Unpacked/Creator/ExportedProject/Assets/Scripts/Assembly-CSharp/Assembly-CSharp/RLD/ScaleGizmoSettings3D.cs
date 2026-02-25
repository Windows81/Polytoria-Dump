namespace RLD;

[Token(Token = "0x2000114")]
public class ScaleGizmoSettings3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004C4")]
	private float _uniformSnapStep; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004C5")]
	private GizmoLineSlider3DSettings[] _sglSliderSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004C6")]
	private GizmoPlaneSlider3DSettings[] _dblSliderSettings; //Field offset: 0x38

	[Token(Token = "0x170003CC")]
	public float BoxSliderHoverEps
	{
		[Address(RVA = "0x5199D0", Offset = "0x518BD0", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA4")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003CD")]
	public float CylinderSliderHoverEps
	{
		[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA5")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003D5")]
	public float DragSensitivity
	{
		[Address(RVA = "0x526250", Offset = "0x525450", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BAD")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003CB")]
	public float LineSliderHoverEps
	{
		[Address(RVA = "0x519A30", Offset = "0x518C30", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA3")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003D4")]
	public float UniformSnapStep
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003CE")]
	public float XSnapStep
	{
		[Address(RVA = "0x526290", Offset = "0x525490", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BA6")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003D1")]
	public float XYSnapStep
	{
		[Address(RVA = "0x5262D0", Offset = "0x5254D0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BA9")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003CF")]
	public float YSnapStep
	{
		[Address(RVA = "0x526310", Offset = "0x525510", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BA7")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003D2")]
	public float YZSnapStep
	{
		[Address(RVA = "0x526350", Offset = "0x525550", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BAA")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003D0")]
	public float ZSnapStep
	{
		[Address(RVA = "0x526390", Offset = "0x525590", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BA8")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003D3")]
	public float ZXSnapStep
	{
		[Address(RVA = "0x5263D0", Offset = "0x5255D0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x525F40", Offset = "0x525140", Length = "0x30C")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoLineSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoPlaneSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000BAE")]
	public ScaleGizmoSettings3D() { }

	[Address(RVA = "0x519A70", Offset = "0x518C70", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBB")]
	public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	[Address(RVA = "0x519AC0", Offset = "0x518CC0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBA")]
	public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5199D0", Offset = "0x518BD0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA4")]
	public float get_BoxSliderHoverEps() { }

	[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA5")]
	public float get_CylinderSliderHoverEps() { }

	[Address(RVA = "0x526250", Offset = "0x525450", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BAD")]
	public float get_DragSensitivity() { }

	[Address(RVA = "0x519A30", Offset = "0x518C30", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA3")]
	public float get_LineSliderHoverEps() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAC")]
	public float get_UniformSnapStep() { }

	[Address(RVA = "0x526290", Offset = "0x525490", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BA6")]
	public float get_XSnapStep() { }

	[Address(RVA = "0x5262D0", Offset = "0x5254D0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BA9")]
	public float get_XYSnapStep() { }

	[Address(RVA = "0x526310", Offset = "0x525510", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BA7")]
	public float get_YSnapStep() { }

	[Address(RVA = "0x526350", Offset = "0x525550", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BAA")]
	public float get_YZSnapStep() { }

	[Address(RVA = "0x526390", Offset = "0x525590", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BA8")]
	public float get_ZSnapStep() { }

	[Address(RVA = "0x5263D0", Offset = "0x5255D0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000BAB")]
	public float get_ZXSnapStep() { }

	[Address(RVA = "0x519B30", Offset = "0x518D30", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBD")]
	private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId) { }

	[Address(RVA = "0x3E2DE0", Offset = "0x3E1FE0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBC")]
	private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5195F0", Offset = "0x5187F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB0")]
	public void SetBoxSliderHoverEps(float eps) { }

	[Address(RVA = "0x515750", Offset = "0x514950", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB1")]
	public void SetCylinderSliderHoverEps(float eps) { }

	[Address(RVA = "0x525BD0", Offset = "0x524DD0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BB9")]
	public void SetDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x5196F0", Offset = "0x5188F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAF")]
	public void SetLineSliderHoverEps(float eps) { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB8")]
	public void SetUniformScaleSnapStep(float snapStep) { }

	[Address(RVA = "0x525C40", Offset = "0x524E40", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000BB2")]
	public void SetXSnapStep(float snapStep) { }

	[Address(RVA = "0x525D00", Offset = "0x524F00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BB5")]
	public void SetXYSnapStep(float snapStep) { }

	[Address(RVA = "0x525D40", Offset = "0x524F40", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000BB3")]
	public void SetYSnapStep(float snapStep) { }

	[Address(RVA = "0x525E00", Offset = "0x525000", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BB6")]
	public void SetYZSnapStep(float snapStep) { }

	[Address(RVA = "0x525E40", Offset = "0x525040", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000BB4")]
	public void SetZSnapStep(float snapStep) { }

	[Address(RVA = "0x525F00", Offset = "0x525100", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BB7")]
	public void SetZXSnapStep(float snapStep) { }

}

