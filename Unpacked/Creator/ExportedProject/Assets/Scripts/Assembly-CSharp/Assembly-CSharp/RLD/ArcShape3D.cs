namespace RLD;

[Token(Token = "0x200023A")]
public class ArcShape3D : Shape3D
{
	[Token(Token = "0x200023C")]
	internal class WireRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008D4")]
		private WireRenderFlags _wireFlags; //Field offset: 0x10

		[Token(Token = "0x170006DE")]
		public WireRenderFlags WireFlags
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001581")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001582")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5A7820", Offset = "0x5A6A20", Length = "0xE")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001583")]
		public WireRenderDescriptor() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001581")]
		public WireRenderFlags get_WireFlags() { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001582")]
		public void set_WireFlags(WireRenderFlags value) { }

	}

	[Token(Token = "0x200023B")]
	internal enum WireRenderFlags
	{
		None = 0,
		ExtremitiesBorder = 1,
		ArcBorder = 2,
		All = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008C1")]
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008C2")]
	private Vector3 _startPoint; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008C3")]
	private Vector3 _endPoint; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008C4")]
	private Vector3 _origin; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008C5")]
	private Plane _plane; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40008C6")]
	private float _radius; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008C7")]
	private AABB _aabb; //Field offset: 0x50
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40008C8")]
	private float _degreeAngleFromStart; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008C9")]
	private bool _forceShortestArc; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008CA")]
	private List<Vector3> _borderPoints; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008CB")]
	private int _numBorderPoints; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40008CC")]
	private bool _areBorderPointsDirty; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008CD")]
	private ArcEpsilon _epsilon; //Field offset: 0x88
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40008CE")]
	private Shape3DRaycastMode _raycastMode; //Field offset: 0x94

	[Token(Token = "0x170006D1")]
	public float AbsDegreeAngleFromStart
	{
		[Address(RVA = "0x5A7540", Offset = "0x5A6740", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001563")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170006D9")]
	public float AreaEps
	{
		[Address(RVA = "0x5A7550", Offset = "0x5A6750", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600156E")]
		 get { } //Length: 9
		[Address(RVA = "0x5A7590", Offset = "0x5A6790", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600156F")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170006D0")]
	public float DegreeAngleFromStart
	{
		[Address(RVA = "0x3BAC50", Offset = "0x3B9E50", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001561")]
		 get { } //Length: 6
		[Address(RVA = "0x5A75A0", Offset = "0x5A67A0", Length = "0x35")]
		[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
		[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001562")]
		 set { } //Length: 53
	}

	[Token(Token = "0x170006D5")]
	public Vector3 EndPoint
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001569")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170006D8")]
	public ArcEpsilon Epsilon
	{
		[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600156C")]
		 get { } //Length: 25
		[Address(RVA = "0x5A75E0", Offset = "0x5A67E0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600156D")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170006DA")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x508E40", Offset = "0x508040", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001570")]
		 get { } //Length: 9
		[Address(RVA = "0x5A7600", Offset = "0x5A6800", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001571")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170006CF")]
	public bool ForceShortestArc
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600155F")]
		 get { } //Length: 5
		[Address(RVA = "0x5A7610", Offset = "0x5A6810", Length = "0x20")]
		[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc3DLookAndFeel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001560")]
		 set { } //Length: 32
	}

	[Token(Token = "0x170006D7")]
	public Vector3 Normal
	{
		[Address(RVA = "0x5A7560", Offset = "0x5A6760", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600156B")]
		 get { } //Length: 21
	}

	[Token(Token = "0x170006D2")]
	public int NumBorderPoints
	{
		[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001564")]
		 get { } //Length: 7
		[Address(RVA = "0x5A7630", Offset = "0x5A6830", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001565")]
		 set { } //Length: 26
	}

	[Token(Token = "0x170006D3")]
	public Vector3 Origin
	{
		[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001566")]
		 get { } //Length: 19
		[Address(RVA = "0x5A7650", Offset = "0x5A6850", Length = "0xDE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x6001567")]
		 set { } //Length: 222
	}

	[Token(Token = "0x170006D6")]
	public Plane Plane
	{
		[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600156A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170006CE")]
	public float Radius
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600155D")]
		 get { } //Length: 6
		[Address(RVA = "0x5A7730", Offset = "0x5A6930", Length = "0xD7")]
		[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
		[Token(Token = "0x600155E")]
		 set { } //Length: 215
	}

	[Token(Token = "0x170006DD")]
	public Shape3DRaycastMode RaycastMode
	{
		[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001575")]
		 get { } //Length: 7
		[Address(RVA = "0x508EF0", Offset = "0x5080F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001576")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170006D4")]
	public Vector3 StartPoint
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001568")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170006DB")]
	public float WireEps
	{
		[Address(RVA = "0x5A7580", Offset = "0x5A6780", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001572")]
		 get { } //Length: 9
		[Address(RVA = "0x5A7810", Offset = "0x5A6A10", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001573")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170006DC")]
	public WireRenderDescriptor WireRenderDesc
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001574")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5A74C0", Offset = "0x5A66C0", Length = "0x7E")]
	[CalledBy(Type = typeof(GizmoRotationArc3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001580")]
	public ArcShape3D() { }

	[Address(RVA = "0x5A6860", Offset = "0x5A5A60", Length = "0xE9")]
	[CalledBy(Type = typeof(ArcShape3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "set_ForceShortestArc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "set_DegreeAngleFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "set_Origin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600157F")]
	private void CalculateEndPoint() { }

	[Address(RVA = "0x5A6950", Offset = "0x5A5B50", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcMath), Member = "LgArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArcMath), Member = "ShArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600157C")]
	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	[Address(RVA = "0x5A7540", Offset = "0x5A6740", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001563")]
	public float get_AbsDegreeAngleFromStart() { }

	[Address(RVA = "0x5A7550", Offset = "0x5A6750", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600156E")]
	public float get_AreaEps() { }

	[Address(RVA = "0x3BAC50", Offset = "0x3B9E50", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001561")]
	public float get_DegreeAngleFromStart() { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001569")]
	public Vector3 get_EndPoint() { }

	[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600156C")]
	public ArcEpsilon get_Epsilon() { }

	[Address(RVA = "0x508E40", Offset = "0x508040", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001570")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600155F")]
	public bool get_ForceShortestArc() { }

	[Address(RVA = "0x5A7560", Offset = "0x5A6760", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600156B")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001564")]
	public int get_NumBorderPoints() { }

	[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001566")]
	public Vector3 get_Origin() { }

	[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600156A")]
	public Plane get_Plane() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600155D")]
	public float get_Radius() { }

	[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001575")]
	public Shape3DRaycastMode get_RaycastMode() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001568")]
	public Vector3 get_StartPoint() { }

	[Address(RVA = "0x5A7580", Offset = "0x5A6780", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001572")]
	public float get_WireEps() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001574")]
	public WireRenderDescriptor get_WireRenderDesc() { }

	[Address(RVA = "0x5A6AC0", Offset = "0x5A5CC0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcShape3D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600157D")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5A6B10", Offset = "0x5A5D10", Length = "0xFB")]
	[CalledBy(Type = typeof(ArcShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate3DArcBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Plane), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x600157E")]
	private void OnBorderPointsFoundDirty() { }

	[Address(RVA = "0x5A6D90", Offset = "0x5A5F90", Length = "0x2E0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcMath), Member = "RaycastLgArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArcMath), Member = "RaycastShArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArcMath), Member = "RaycastLgArc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArcMath), Member = "RaycastShArc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600157A")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5A6C10", Offset = "0x5A5E10", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcMath), Member = "RaycastLgArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArcMath), Member = "RaycastShArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600157B")]
	public virtual bool RaycastWire(Ray ray, out float t) { }

	[Address(RVA = "0x5A7070", Offset = "0x5A6270", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArcShape3D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001577")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5A70C0", Offset = "0x5A62C0", Length = "0x289")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArcShape3D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLines3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001578")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5A7590", Offset = "0x5A6790", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600156F")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x5A75A0", Offset = "0x5A67A0", Length = "0x35")]
	[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001562")]
	public void set_DegreeAngleFromStart(float value) { }

	[Address(RVA = "0x5A75E0", Offset = "0x5A67E0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600156D")]
	public void set_Epsilon(ArcEpsilon value) { }

	[Address(RVA = "0x5A7600", Offset = "0x5A6800", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001571")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x5A7610", Offset = "0x5A6810", Length = "0x20")]
	[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc3DLookAndFeel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001560")]
	public void set_ForceShortestArc(bool value) { }

	[Address(RVA = "0x5A7630", Offset = "0x5A6830", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001565")]
	public void set_NumBorderPoints(int value) { }

	[Address(RVA = "0x5A7650", Offset = "0x5A6850", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001567")]
	public void set_Origin(Vector3 value) { }

	[Address(RVA = "0x5A7730", Offset = "0x5A6930", Length = "0xD7")]
	[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x600155E")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x508EF0", Offset = "0x5080F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001576")]
	public void set_RaycastMode(Shape3DRaycastMode value) { }

	[Address(RVA = "0x5A7810", Offset = "0x5A6A10", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001573")]
	public void set_WireEps(float value) { }

	[Address(RVA = "0x5A7350", Offset = "0x5A6550", Length = "0x169")]
	[CalledBy(Type = typeof(GizmoRotationArc3D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ArcShape3D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[Token(Token = "0x6001579")]
	public void SetArcData(Plane plane, Vector3 origin, Vector3 startPoint, float radius) { }

}

