namespace RLD;

[Token(Token = "0x2000077")]
public class GizmoHandleHoverData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A9")]
	private int _handleId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001AA")]
	private Gizmo _gizmo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001AB")]
	private GizmoDimension _handleDimension; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001AC")]
	private Ray _hoverRay; //Field offset: 0x24
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001AD")]
	private Vector3 _hoverPoint; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AE")]
	private float _hoverEnter3D; //Field offset: 0x48

	[Token(Token = "0x170000F5")]
	public Gizmo Gizmo
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F6")]
	public GizmoDimension HandleDimension
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003BA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000F4")]
	public int HandleId
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000F9")]
	public float HoverEnter3D
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003BD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000F8")]
	public Vector3 HoverPoint
	{
		[Address(RVA = "0x3CDF90", Offset = "0x3CD190", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003BC")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000F7")]
	public Ray HoverRay
	{
		[Address(RVA = "0x3CDFB0", Offset = "0x3CD1B0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003BB")]
		 get { } //Length: 21
	}

	[Address(RVA = "0x3CDDD0", Offset = "0x3CCFD0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003BE")]
	public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, float hoverEnter3D) { }

	[Address(RVA = "0x3CDEC0", Offset = "0x3CD0C0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003BF")]
	public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, Vector2 hoverPt2D) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B9")]
	public Gizmo get_Gizmo() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BA")]
	public GizmoDimension get_HandleDimension() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B8")]
	public int get_HandleId() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BD")]
	public float get_HoverEnter3D() { }

	[Address(RVA = "0x3CDF90", Offset = "0x3CD190", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003BC")]
	public Vector3 get_HoverPoint() { }

	[Address(RVA = "0x3CDFB0", Offset = "0x3CD1B0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60003BB")]
	public Ray get_HoverRay() { }

}

