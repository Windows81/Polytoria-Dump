namespace RLD;

[Token(Token = "0x2000050")]
public class GizmoSglAxisRotationDrag3D : GizmoScreenDrag
{
	[Token(Token = "0x2000051")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014F")]
		public Vector3 RotationPlanePos; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000150")]
		public Vector3 Axis; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000151")]
		public GizmoSnapMode SnapMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000152")]
		public float SnapStep; //Field offset: 0x1C

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000148")]
	private float _accumSnapDrag; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000149")]
	private Plane _rotationPlane; //Field offset: 0x7C
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400014A")]
	private Vector3 _screenDragCircleTangent; //Field offset: 0x8C
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400014B")]
	private WorkData _workData; //Field offset: 0x98
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400014C")]
	private bool _adjustRotationForAbsSnap; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x400014D")]
	private float _relativeRotation; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400014E")]
	private float _totalRotation; //Field offset: 0xC0

	[Token(Token = "0x170000A9")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000263")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000AA")]
	public float RelativeRotation
	{
		[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000264")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000AC")]
	public Plane RotationPlane
	{
		[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000266")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000AB")]
	public float TotalRotation
	{
		[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000265")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3B7910", Offset = "0x3B6B10", Length = "0xE")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600026B")]
	public GizmoSglAxisRotationDrag3D() { }

	[Address(RVA = "0x3BB960", Offset = "0x3BAB60", Length = "0x429")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Calls(Type = typeof(SnapMath), Member = "CalculateNumSnapSteps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(NumSnapSteps))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000268")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000263")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000264")]
	public float get_RelativeRotation() { }

	[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000266")]
	public Plane get_RotationPlane() { }

	[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000265")]
	public float get_TotalRotation() { }

	[Address(RVA = "0x3BBD90", Offset = "0x3BAF90", Length = "0x53D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Ex), Member = "GetNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001AA10")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000269")]
	protected virtual void OnSessionBegin() { }

	[Address(RVA = "0x3BC2D0", Offset = "0x3BB4D0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600026A")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3BC350", Offset = "0x3BB550", Length = "0xE7")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000267")]
	public void SetWorkData(WorkData workData) { }

}

