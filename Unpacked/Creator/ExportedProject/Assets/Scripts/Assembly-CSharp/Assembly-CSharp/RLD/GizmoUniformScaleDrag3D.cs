namespace RLD;

[Token(Token = "0x2000054")]
public class GizmoUniformScaleDrag3D : GizmoPlaneDrag3D
{
	[Token(Token = "0x2000055")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000165")]
		public Vector3 CameraRight; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000166")]
		public Vector3 CameraUp; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000167")]
		public Vector3 DragOrigin; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000168")]
		public float SnapStep; //Field offset: 0x24

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400015D")]
	private WorkData _workData; //Field offset: 0x78
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400015E")]
	private Vector3 _planeAxis0; //Field offset: 0xA0
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400015F")]
	private Vector3 _planeAxis1; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000160")]
	private float _accumSnapDrag; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000161")]
	private float _scale; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000162")]
	private float _relativeScale; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000163")]
	private float _totalScale; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000164")]
	private Vector3 _scaleDragAxis; //Field offset: 0xC8

	[Token(Token = "0x170000B1")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000275")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B3")]
	public float RelativeScale
	{
		[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000277")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000B2")]
	public float TotalScale
	{
		[Address(RVA = "0x3B8240", Offset = "0x3B7440", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000276")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3C3200", Offset = "0x3C2400", Length = "0x22")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600027C")]
	public GizmoUniformScaleDrag3D() { }

	[Address(RVA = "0x3C2DD0", Offset = "0x3C1FD0", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6000279")]
	protected virtual Plane CalculateDragPlane() { }

	[Address(RVA = "0x3C2F30", Offset = "0x3C2130", Length = "0x1CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600027A")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000277")]
	public float get_RelativeScale() { }

	[Address(RVA = "0x3B8240", Offset = "0x3B7440", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000276")]
	public float get_TotalScale() { }

	[Address(RVA = "0x3C3100", Offset = "0x3C2300", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600027B")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3C3120", Offset = "0x3C2320", Length = "0xD1")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000278")]
	public void SetWorkData(WorkData workData) { }

}

