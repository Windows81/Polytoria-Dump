namespace RLD;

[Token(Token = "0x2000042")]
public class GizmoDblAxisRotationDrag3D : GizmoScreenDrag
{
	[Token(Token = "0x2000043")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010C")]
		public Vector2 ScreenAxis0; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400010D")]
		public Vector2 ScreenAxis1; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010E")]
		public Vector3 Axis0; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400010F")]
		public Vector3 Axis1; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000110")]
		public GizmoSnapMode SnapMode; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000111")]
		public float SnapStep0; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000112")]
		public float SnapStep1; //Field offset: 0x30

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000104")]
	private WorkData _workData; //Field offset: 0x78
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000105")]
	private bool _adjustRotationForAbsSnap; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000106")]
	private float _accumSnapDrag0; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000107")]
	private float _accumSnapDrag1; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000108")]
	private float _relativeRotation0; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000109")]
	private float _relativeRotation1; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400010A")]
	private float _totalRotation0; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400010B")]
	private float _totalRotation1; //Field offset: 0xC4

	[Token(Token = "0x17000085")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000086")]
	public float RelativeRotation0
	{
		[Address(RVA = "0x3B8210", Offset = "0x3B7410", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000087")]
	public float RelativeRotation1
	{
		[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000200")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000088")]
	public float TotalRotation0
	{
		[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000201")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000089")]
	public float TotalRotation1
	{
		[Address(RVA = "0x3B8240", Offset = "0x3B7440", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000202")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3B7910", Offset = "0x3B6B10", Length = "0xE")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000206")]
	public GizmoDblAxisRotationDrag3D() { }

	[Address(RVA = "0x3B7920", Offset = "0x3B6B20", Length = "0x865")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Calls(Type = typeof(SnapMath), Member = "CalculateNumSnapSteps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(NumSnapSteps))]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000204")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FE")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3B8210", Offset = "0x3B7410", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FF")]
	public float get_RelativeRotation0() { }

	[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000200")]
	public float get_RelativeRotation1() { }

	[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000201")]
	public float get_TotalRotation0() { }

	[Address(RVA = "0x3B8240", Offset = "0x3B7440", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000202")]
	public float get_TotalRotation1() { }

	[Address(RVA = "0x3B8190", Offset = "0x3B7390", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000205")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3B81B0", Offset = "0x3B73B0", Length = "0x58")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000203")]
	public void SetWorkData(WorkData workData) { }

}

