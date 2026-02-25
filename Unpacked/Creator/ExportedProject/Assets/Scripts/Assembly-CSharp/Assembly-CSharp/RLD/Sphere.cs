namespace RLD;

[Token(Token = "0x20001C1")]
public struct Sphere
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400071E")]
	private Vector3 _center; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400071F")]
	private float _radius; //Field offset: 0xC

	[Token(Token = "0x170005B8")]
	public Vector3 Center
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001209")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600120A")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170005B9")]
	public float Radius
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600120B")]
		 get { } //Length: 6
		[Address(RVA = "0x587EE0", Offset = "0x5870E0", Length = "0xF")]
		[CalledBy(Type = typeof(SphereTreeNode`1), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SphereTreeNode`1), Member = "EncapsulateChildrenBottomUp", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x600120C")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x587AC0", Offset = "0x586CC0", Length = "0x1B")]
	[CalledBy(Type = typeof(SphereTree`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTree`1), Member = "InsertNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTreeNode`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600120D")]
	public Sphere(Vector3 center, float radius) { }

	[Address(RVA = "0x587AE0", Offset = "0x586CE0", Length = "0x4D")]
	[CalledBy(Type = typeof(SceneTree), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SceneTree), Member = "OnObjectTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSpawnUtil), Member = "SpawnInFrontOfCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(Config)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(EditorPrefabPreviewGen), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600120E")]
	public Sphere(AABB aabb) { }

	[Address(RVA = "0x587B30", Offset = "0x586D30", Length = "0x3A0")]
	[CalledBy(Type = typeof(MeshTree), Member = "Build", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600120F")]
	public Sphere(IEnumerable<Vector3> pointCloud) { }

	[Address(RVA = "0x5877E0", Offset = "0x5869E0", Length = "0x52")]
	[CalledBy(Type = typeof(OBB), Member = "IntersectsSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sphere)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001210")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x587840", Offset = "0x586A40", Length = "0x217")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001212")]
	public void Encapsulate(Sphere sphere) { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001209")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600120B")]
	public float get_Radius() { }

	[Address(RVA = "0x587A60", Offset = "0x586C60", Length = "0x60")]
	[CalledBy(Type = typeof(CameraEx), Member = "GetVisibleSphereExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Sphere)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SphereMath), Member = "CalcRightUpExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x6001211")]
	public List<Vector3> GetRightUpExtents(Vector3 right, Vector3 up) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600120A")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x587EE0", Offset = "0x5870E0", Length = "0xF")]
	[CalledBy(Type = typeof(SphereTreeNode`1), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTreeNode`1), Member = "EncapsulateChildrenBottomUp", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600120C")]
	public void set_Radius(float value) { }

}

