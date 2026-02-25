namespace RLD;

[Token(Token = "0x2000106")]
public class MoveGizmoSettings2D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000463")]
	private GizmoPlaneSlider2DSettings _dblSliderSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000464")]
	private GizmoLineSlider2DSettings[] _sglSliderSettings; //Field offset: 0x30

	[Token(Token = "0x1700034B")]
	public float BoxSliderHoverEps
	{
		[Address(RVA = "0x5199D0", Offset = "0x518BD0", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A38")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700034E")]
	public float DragSensitivity
	{
		[Address(RVA = "0x519A10", Offset = "0x518C10", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A3B")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700034A")]
	public float LineSliderHoverEps
	{
		[Address(RVA = "0x519A30", Offset = "0x518C30", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A37")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700034C")]
	public float XSnapStep
	{
		[Address(RVA = "0x516240", Offset = "0x515440", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A39")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700034D")]
	public float YSnapStep
	{
		[Address(RVA = "0x516220", Offset = "0x515420", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A3A")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x519860", Offset = "0x518A60", Length = "0x164")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoPlaneSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A3C")]
	public MoveGizmoSettings2D() { }

	[Address(RVA = "0x519550", Offset = "0x518750", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A43")]
	public void ConnectDblSliderSettings(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x519580", Offset = "0x518780", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A42")]
	public void ConnectSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5199D0", Offset = "0x518BD0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A38")]
	public float get_BoxSliderHoverEps() { }

	[Address(RVA = "0x519A10", Offset = "0x518C10", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3B")]
	public float get_DragSensitivity() { }

	[Address(RVA = "0x519A30", Offset = "0x518C30", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A37")]
	public float get_LineSliderHoverEps() { }

	[Address(RVA = "0x516240", Offset = "0x515440", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A39")]
	public float get_XSnapStep() { }

	[Address(RVA = "0x516220", Offset = "0x515420", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3A")]
	public float get_YSnapStep() { }

	[Address(RVA = "0x514E60", Offset = "0x514060", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A44")]
	private GizmoLineSlider2DSettings GetSliderSettings(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5195F0", Offset = "0x5187F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3E")]
	public void SetBoxSliderHoverEps(float eps) { }

	[Address(RVA = "0x519660", Offset = "0x518860", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A41")]
	public void SetDragSensitivity(float sensitivity) { }

	[Address(RVA = "0x5196F0", Offset = "0x5188F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3D")]
	public void SetLineSliderHoverEps(float eps) { }

	[Address(RVA = "0x519760", Offset = "0x518960", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = "set_OffsetSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A3F")]
	public void SetXSnapStep(float snapStep) { }

	[Address(RVA = "0x5197E0", Offset = "0x5189E0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = "set_OffsetSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A40")]
	public void SetYSnapStep(float snapStep) { }

}

