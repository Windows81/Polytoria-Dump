namespace RLD;

[Token(Token = "0x2000052")]
public class GizmoSglAxisScaleDrag3D : GizmoPlaneDrag3D
{
	[Token(Token = "0x2000053")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000158")]
		public int AxisIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000159")]
		public Vector3 DragOrigin; //Field offset: 0x4
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015A")]
		public Vector3 Axis; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400015B")]
		public float SnapStep; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400015C")]
		public float EntityScale; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000153")]
	private float _accumSnapDrag; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000154")]
	private WorkData _workData; //Field offset: 0x7C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000155")]
	private float _scale; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000156")]
	private float _relativeScale; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000157")]
	private float _totalScale; //Field offset: 0xA8

	[Token(Token = "0x170000AE")]
	public int AxisIndex
	{
		[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000AD")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000AF")]
	public float RelativeScale
	{
		[Address(RVA = "0x3BC770", Offset = "0x3BB970", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000B0")]
	public float TotalScale
	{
		[Address(RVA = "0x3BC780", Offset = "0x3BB980", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026F")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3BC740", Offset = "0x3BB940", Length = "0x22")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[CalledBy(Type = typeof(BoxGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000274")]
	public GizmoSglAxisScaleDrag3D() { }

	[Address(RVA = "0x3BC440", Offset = "0x3BB640", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(PlaneEx), Member = "GetCameraFacingAxisSlicePlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000271")]
	protected virtual Plane CalculateDragPlane() { }

	[Address(RVA = "0x3BC530", Offset = "0x3BB730", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector3), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000272")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026D")]
	public int get_AxisIndex() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026C")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3BC770", Offset = "0x3BB970", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026E")]
	public float get_RelativeScale() { }

	[Address(RVA = "0x3BC780", Offset = "0x3BB980", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026F")]
	public float get_TotalScale() { }

	[Address(RVA = "0x3BC6B0", Offset = "0x3BB8B0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000273")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3BC6E0", Offset = "0x3BB8E0", Length = "0x53")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000270")]
	public void SetWorkData(WorkData workData) { }

}

