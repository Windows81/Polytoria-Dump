namespace RLD;

[Token(Token = "0x2000044")]
public class GizmoDblAxisScaleDrag3D : GizmoPlaneDrag3D
{
	[Token(Token = "0x2000045")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011D")]
		public int AxisIndex0; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400011E")]
		public int AxisIndex1; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400011F")]
		public Vector3 DragOrigin; //Field offset: 0x8
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000120")]
		public Vector3 Axis0; //Field offset: 0x14
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000121")]
		public Vector3 Axis1; //Field offset: 0x20
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000122")]
		public float SnapStep; //Field offset: 0x2C

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000113")]
	private WorkData _workData; //Field offset: 0x78
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000114")]
	private float _accumSnapDrag0; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000115")]
	private float _accumSnapDrag1; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000116")]
	private float _scale0; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000117")]
	private float _scale1; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000118")]
	private float _relativeScale0; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000119")]
	private float _relativeScale1; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400011A")]
	private float _totalScale0; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400011B")]
	private float _totalScale1; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400011C")]
	private Vector3 _scaleDragAxis; //Field offset: 0xC8

	[Token(Token = "0x1700008B")]
	public int AxisIndex0
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000208")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008C")]
	public int AxisIndex1
	{
		[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000209")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008A")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000207")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700008D")]
	public float RelativeScale0
	{
		[Address(RVA = "0x3B8210", Offset = "0x3B7410", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700008E")]
	public float RelativeScale1
	{
		[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020B")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700008F")]
	public float TotalScale0
	{
		[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020C")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000090")]
	public float TotalScale1
	{
		[Address(RVA = "0x3B8240", Offset = "0x3B7440", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020D")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3B8600", Offset = "0x3B7800", Length = "0x36")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000212")]
	public GizmoDblAxisScaleDrag3D() { }

	[Address(RVA = "0x3B74D0", Offset = "0x3B66D0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600020F")]
	protected virtual Plane CalculateDragPlane() { }

	[Address(RVA = "0x3B8250", Offset = "0x3B7450", Length = "0x284")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000210")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000208")]
	public int get_AxisIndex0() { }

	[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000209")]
	public int get_AxisIndex1() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000207")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3B8210", Offset = "0x3B7410", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020A")]
	public float get_RelativeScale0() { }

	[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020B")]
	public float get_RelativeScale1() { }

	[Address(RVA = "0x3B8230", Offset = "0x3B7430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020C")]
	public float get_TotalScale0() { }

	[Address(RVA = "0x3B8240", Offset = "0x3B7440", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020D")]
	public float get_TotalScale1() { }

	[Address(RVA = "0x3B84E0", Offset = "0x3B76E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000211")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3B8520", Offset = "0x3B7720", Length = "0xE0")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020E")]
	public void SetWorkData(WorkData workData) { }

}

