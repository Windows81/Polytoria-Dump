namespace RLD;

[Token(Token = "0x2000040")]
public class GizmoDblAxisOffsetDrag3D : GizmoPlaneDrag3D
{
	[Token(Token = "0x2000041")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FF")]
		public Vector3 DragOrigin; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000100")]
		public Vector3 Axis0; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000101")]
		public Vector3 Axis1; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000102")]
		public float SnapStep0; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000103")]
		public float SnapStep1; //Field offset: 0x28

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000FC")]
	private float _accumSnapDrag0; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000FD")]
	private float _accumSnapDrag1; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000FE")]
	private WorkData _workData; //Field offset: 0x80

	[Token(Token = "0x17000084")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F8")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x3B7910", Offset = "0x3B6B10", Length = "0xE")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FD")]
	public GizmoDblAxisOffsetDrag3D() { }

	[Address(RVA = "0x3B74D0", Offset = "0x3B66D0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FA")]
	protected virtual Plane CalculateDragPlane() { }

	[Address(RVA = "0x3B7610", Offset = "0x3B6810", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001FB")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F8")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3B78A0", Offset = "0x3B6AA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001FC")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3B78B0", Offset = "0x3B6AB0", Length = "0x5D")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F9")]
	public void SetWorkData(WorkData workData) { }

}

