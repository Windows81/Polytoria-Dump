namespace RLD;

[Token(Token = "0x2000107")]
public class MoveGizmoSettings3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000465")]
	private GizmoObjectVertexSnapSettings _vertexSnapSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000466")]
	private GizmoLineSlider3DSettings[] _sglSliderSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000467")]
	private GizmoPlaneSlider3DSettings[] _dblSliderSettings; //Field offset: 0x38

	[Token(Token = "0x17000351")]
	public float BoxSliderHoverEps
	{
		[Address(RVA = "0x5199D0", Offset = "0x518BD0", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A47")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000352")]
	public float CylinderSliderHoverEps
	{
		[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A48")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000356")]
	public float DragSensitivity
	{
		[Address(RVA = "0x51A160", Offset = "0x519360", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A4C")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000350")]
	public float LineSliderHoverEps
	{
		[Address(RVA = "0x519A30", Offset = "0x518C30", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A46")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700034F")]
	public GizmoObjectVertexSnapSettings VertexSnapSettings
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A45")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000353")]
	public float XSnapStep
	{
		[Address(RVA = "0x516260", Offset = "0x515460", Length = "0x31")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A49")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000354")]
	public float YSnapStep
	{
		[Address(RVA = "0x51A1A0", Offset = "0x5193A0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A4A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000355")]
	public float ZSnapStep
	{
		[Address(RVA = "0x51A1E0", Offset = "0x5193E0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000A4B")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x519E70", Offset = "0x519070", Length = "0x2E2")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoPlaneSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoLineSlider3DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(GizmoObjectVertexSnapSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000A4D")]
	public MoveGizmoSettings3D() { }

	[Address(RVA = "0x519A70", Offset = "0x518C70", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A56")]
	public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	[Address(RVA = "0x519AC0", Offset = "0x518CC0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A55")]
	public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5199D0", Offset = "0x518BD0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A47")]
	public float get_BoxSliderHoverEps() { }

	[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A48")]
	public float get_CylinderSliderHoverEps() { }

	[Address(RVA = "0x51A160", Offset = "0x519360", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A4C")]
	public float get_DragSensitivity() { }

	[Address(RVA = "0x519A30", Offset = "0x518C30", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A46")]
	public float get_LineSliderHoverEps() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A45")]
	public GizmoObjectVertexSnapSettings get_VertexSnapSettings() { }

	[Address(RVA = "0x516260", Offset = "0x515460", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A49")]
	public float get_XSnapStep() { }

	[Address(RVA = "0x51A1A0", Offset = "0x5193A0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A4A")]
	public float get_YSnapStep() { }

	[Address(RVA = "0x51A1E0", Offset = "0x5193E0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A4B")]
	public float get_ZSnapStep() { }

	[Address(RVA = "0x519B30", Offset = "0x518D30", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A58")]
	private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId) { }

	[Address(RVA = "0x3E2DE0", Offset = "0x3E1FE0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A57")]
	private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5195F0", Offset = "0x5187F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4F")]
	public void SetBoxSliderHoverEps(float eps) { }

	[Address(RVA = "0x515750", Offset = "0x514950", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A50")]
	public void SetCylinderSliderHoverEps(float eps) { }

	[Address(RVA = "0x519B60", Offset = "0x518D60", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A54")]
	public void SetDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x5196F0", Offset = "0x5188F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A4E")]
	public void SetLineSliderHoverEps(float eps) { }

	[Address(RVA = "0x519C30", Offset = "0x518E30", Length = "0xB7")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetMoveSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000A51")]
	public void SetXSnapStep(float snapStep) { }

	[Address(RVA = "0x519CF0", Offset = "0x518EF0", Length = "0xB7")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetMoveSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000A52")]
	public void SetYSnapStep(float snapStep) { }

	[Address(RVA = "0x519DB0", Offset = "0x518FB0", Length = "0xB7")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetMoveSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000A53")]
	public void SetZSnapStep(float snapStep) { }

}

