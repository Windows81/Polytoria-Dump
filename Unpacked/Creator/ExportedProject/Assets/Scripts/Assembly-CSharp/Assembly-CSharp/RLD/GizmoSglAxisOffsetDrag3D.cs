namespace RLD;

[Token(Token = "0x200004E")]
public class GizmoSglAxisOffsetDrag3D : GizmoPlaneDrag3D
{
	[Token(Token = "0x200004F")]
	internal struct WorkData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000145")]
		public Vector3 DragOrigin; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000146")]
		public Vector3 Axis; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000147")]
		public float SnapStep; //Field offset: 0x18

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000143")]
	private float _accumSnapDrag; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000144")]
	private WorkData _workData; //Field offset: 0x7C

	[Token(Token = "0x170000A7")]
	public Vector3 Axis
	{
		[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025C")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000A8")]
	public virtual GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x3B7910", Offset = "0x3B6B10", Length = "0xE")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoDragSession), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000262")]
	public GizmoSglAxisOffsetDrag3D() { }

	[Address(RVA = "0x3BB650", Offset = "0x3BA850", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(PlaneEx), Member = "GetCameraFacingAxisSlicePlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025F")]
	protected virtual Plane CalculateDragPlane() { }

	[Address(RVA = "0x3BB740", Offset = "0x3BA940", Length = "0x191")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SnapMath), Member = "CanExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapMath), Member = "ExtractSnap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000260")]
	protected virtual void CalculateDragValues() { }

	[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025C")]
	public Vector3 get_Axis() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025D")]
	public virtual GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3BB8E0", Offset = "0x3BAAE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000261")]
	protected virtual void OnSessionEnd() { }

	[Address(RVA = "0x3BB8F0", Offset = "0x3BAAF0", Length = "0x4F")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600025E")]
	public void SetWorkData(WorkData workData) { }

}

