namespace RLD;

[Token(Token = "0x200013C")]
public class CameraViewVolume
{
	[Token(Token = "0x200013E")]
	internal enum VPlane
	{
		Left = 0,
		Right = 1,
		Bottom = 2,
		Top = 3,
		Near = 4,
		Far = 5,
	}

	[Token(Token = "0x200013D")]
	internal enum VPoint
	{
		NearTopLeft = 0,
		NearTopRight = 1,
		NearBottomRight = 2,
		NearBottomLeft = 3,
		FarTopLeft = 4,
		FarTopRight = 5,
		FarBottomRight = 6,
		FarBottomLeft = 7,
	}

	[Token(Token = "0x40005A0")]
	private const int _numWorldPoints = 8; //Field offset: 0x0
	[Token(Token = "0x40005A1")]
	private const int _numWorldPlanes = 6; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A2")]
	private Vector3[] _worldPoints; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A3")]
	private Plane[] _worldPlanes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A4")]
	private Vector2 _farPlaneSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005A5")]
	private Vector2 _nearPlaneSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005A6")]
	private AABB _worldAABB; //Field offset: 0x30
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40005A7")]
	private OBB _worldOBB; //Field offset: 0x4C

	[Token(Token = "0x170004F4")]
	public Plane BottomPlane
	{
		[Address(RVA = "0x53E560", Offset = "0x53D760", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E90")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170004FF")]
	public Vector3 FarBottomLeft
	{
		[Address(RVA = "0x53E590", Offset = "0x53D790", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E9B")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004FE")]
	public Vector3 FarBottomRight
	{
		[Address(RVA = "0x53E5D0", Offset = "0x53D7D0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E9A")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004F7")]
	public Plane FarPlane
	{
		[Address(RVA = "0x53E630", Offset = "0x53D830", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E93")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000500")]
	public Vector2 FarPlaneSize
	{
		[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E9C")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170004FC")]
	public Vector3 FarTopLeft
	{
		[Address(RVA = "0x53E660", Offset = "0x53D860", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E98")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004FD")]
	public Vector3 FarTopRight
	{
		[Address(RVA = "0x53E6A0", Offset = "0x53D8A0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E99")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004F2")]
	public Plane LeftPlane
	{
		[Address(RVA = "0x53E6E0", Offset = "0x53D8E0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E8E")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170004FB")]
	public Vector3 NearBottomLeft
	{
		[Address(RVA = "0x53E710", Offset = "0x53D910", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E97")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004FA")]
	public Vector3 NearBottomRight
	{
		[Address(RVA = "0x53E750", Offset = "0x53D950", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E96")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004F6")]
	public Plane NearPlane
	{
		[Address(RVA = "0x53E7B0", Offset = "0x53D9B0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E92")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000501")]
	public Vector2 NearPlaneSize
	{
		[Address(RVA = "0x53E790", Offset = "0x53D990", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E9D")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170004F8")]
	public Vector3 NearTopLeft
	{
		[Address(RVA = "0x53E7E0", Offset = "0x53D9E0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E94")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004F9")]
	public Vector3 NearTopRight
	{
		[Address(RVA = "0x53E820", Offset = "0x53DA20", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E95")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170004F3")]
	public Plane RightPlane
	{
		[Address(RVA = "0x53E860", Offset = "0x53DA60", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E8F")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170004F5")]
	public Plane TopPlane
	{
		[Address(RVA = "0x53E890", Offset = "0x53DA90", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E91")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000502")]
	public AABB WorldAABB
	{
		[Address(RVA = "0x53E8C0", Offset = "0x53DAC0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E9E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000503")]
	public OBB WorldOBB
	{
		[Address(RVA = "0x53E8E0", Offset = "0x53DAE0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E9F")]
		 get { } //Length: 35
	}

	[Address(RVA = "0x53E440", Offset = "0x53D640", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CameraViewVolume), Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EA1")]
	public CameraViewVolume(Camera camera) { }

	[Address(RVA = "0x53E340", Offset = "0x53D540", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EA0")]
	public CameraViewVolume() { }

	[Address(RVA = "0x53C740", Offset = "0x53B940", Length = "0x1146")]
	[CalledBy(Type = typeof(CameraViewVolume), Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EA8")]
	private void CalculateWorldPoints(Camera camera) { }

	[Address(RVA = "0x53D910", Offset = "0x53CB10", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Plane[]))]
	[Calls(Type = typeof(AABB), Member = "ToBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(GeometryUtility), Member = "TestPlanesAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Bounds)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EA6")]
	public static bool CheckAABB(Camera camera, AABB aabb) { }

	[Address(RVA = "0x53D890", Offset = "0x53CA90", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AABB), Member = "ToBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(GeometryUtility), Member = "TestPlanesAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Bounds)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000EA5")]
	public bool CheckAABB(AABB aabb) { }

	[Address(RVA = "0x53D8D0", Offset = "0x53CAD0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AABB), Member = "ToBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(GeometryUtility), Member = "TestPlanesAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Bounds)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000EA7")]
	public static bool CheckAABB(Camera camera, AABB aabb, Plane[] cameraWorldPlanes) { }

	[Address(RVA = "0x53DA80", Offset = "0x53CC80", Length = "0x4EB")]
	[CalledBy(Type = typeof(CameraViewVolume), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "GetVisibleObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraViewVolume), Member = "CalculateWorldPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Plane[]))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EA2")]
	public void FromCamera(Camera camera) { }

	[Address(RVA = "0x53E560", Offset = "0x53D760", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E90")]
	public Plane get_BottomPlane() { }

	[Address(RVA = "0x53E590", Offset = "0x53D790", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E9B")]
	public Vector3 get_FarBottomLeft() { }

	[Address(RVA = "0x53E5D0", Offset = "0x53D7D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E9A")]
	public Vector3 get_FarBottomRight() { }

	[Address(RVA = "0x53E630", Offset = "0x53D830", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E93")]
	public Plane get_FarPlane() { }

	[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9C")]
	public Vector2 get_FarPlaneSize() { }

	[Address(RVA = "0x53E660", Offset = "0x53D860", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E98")]
	public Vector3 get_FarTopLeft() { }

	[Address(RVA = "0x53E6A0", Offset = "0x53D8A0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E99")]
	public Vector3 get_FarTopRight() { }

	[Address(RVA = "0x53E6E0", Offset = "0x53D8E0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E8E")]
	public Plane get_LeftPlane() { }

	[Address(RVA = "0x53E710", Offset = "0x53D910", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E97")]
	public Vector3 get_NearBottomLeft() { }

	[Address(RVA = "0x53E750", Offset = "0x53D950", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E96")]
	public Vector3 get_NearBottomRight() { }

	[Address(RVA = "0x53E7B0", Offset = "0x53D9B0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E92")]
	public Plane get_NearPlane() { }

	[Address(RVA = "0x53E790", Offset = "0x53D990", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9D")]
	public Vector2 get_NearPlaneSize() { }

	[Address(RVA = "0x53E7E0", Offset = "0x53D9E0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E94")]
	public Vector3 get_NearTopLeft() { }

	[Address(RVA = "0x53E820", Offset = "0x53DA20", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E95")]
	public Vector3 get_NearTopRight() { }

	[Address(RVA = "0x53E860", Offset = "0x53DA60", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E8F")]
	public Plane get_RightPlane() { }

	[Address(RVA = "0x53E890", Offset = "0x53DA90", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E91")]
	public Plane get_TopPlane() { }

	[Address(RVA = "0x53E8C0", Offset = "0x53DAC0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E9E")]
	public AABB get_WorldAABB() { }

	[Address(RVA = "0x53E8E0", Offset = "0x53DAE0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E9F")]
	public OBB get_WorldOBB() { }

	[Address(RVA = "0x53DF70", Offset = "0x53D170", Length = "0x115")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Plane[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EA4")]
	public static Plane[] GetCameraWorldPlanes(Camera camera) { }

	[Address(RVA = "0x53E090", Offset = "0x53D290", Length = "0x2A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EA3")]
	public List<Vector3> GetNearPlanePoints() { }

}

