namespace RLD;

[Token(Token = "0x2000122")]
public class SphereTreeNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000535")]
	private SphereTreeNode<T> _stackTop; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000536")]
	private SphereTreeNode<T> _stackPrevious; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000537")]
	private Sphere _sphere; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000538")]
	private T _data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000539")]
	private SphereTreeNode<T> _parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053A")]
	private SphereTreeNode<T>[] _children; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053B")]
	private int _numChildren; //Field offset: 0x0

	[Token(Token = "0x170004AA")]
	public Vector3 Center
	{
		[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE9")]
		 get { } //Length: 19
		[Address(RVA = "0xF5FEF0", Offset = "0xF5F0F0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DEA")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004A6")]
	public SphereTreeNode<T>[] Children
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004AD")]
	public T Data
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DEE")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DEF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170004A8")]
	public bool IsLeaf
	{
		[Address(RVA = "0x3EA4D0", Offset = "0x3E96D0", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170004A7")]
	public int NumChildren
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE3")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004AC")]
	public SphereTreeNode<T> Parent
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004AB")]
	public float Radius
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DEB")]
		 get { } //Length: 6
		[Address(RVA = "0xF5FFC0", Offset = "0xF5F1C0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sphere), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DEC")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170004A9")]
	public Sphere Sphere
	{
		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE7")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE8")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170004AE")]
	public SphereTreeNode<T> StackTop
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xF5F8F0", Offset = "0xF5EAF0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sphere), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE5")]
	public SphereTreeNode`1() { }

	[Address(RVA = "0xF5FB70", Offset = "0xF5ED70", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE6")]
	public SphereTreeNode`1(T data, Sphere sphere) { }

	[Address(RVA = "0xF5DF70", Offset = "0xF5D170", Length = "0x155")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF4")]
	public SphereTreeNode<T> ClosestChild(SphereTreeNode<T> node) { }

	[Address(RVA = "0xF5E330", Offset = "0xF5D530", Length = "0x1F1")]
	[CalledBy(Type = typeof(SphereTreeNode`1), Member = "DebugDraw", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitSphere", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SphereTreeNode`1), Member = "DebugDraw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF7")]
	public void DebugDraw() { }

	[Address(RVA = "0xF5EA90", Offset = "0xF5DC90", Length = "0x226")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "RemoveNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTree`1), Member = "OnNodeSphereUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTree`1), Member = "InsertNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(Sphere), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF6")]
	public void EncapsulateChildrenBottomUp() { }

	[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE9")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE2")]
	public SphereTreeNode<T>[] get_Children() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEE")]
	public T get_Data() { }

	[Address(RVA = "0x3EA4D0", Offset = "0x3E96D0", Length = "0x9")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE4")]
	public bool get_IsLeaf() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE3")]
	public int get_NumChildren() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DED")]
	public SphereTreeNode<T> get_Parent() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEB")]
	public float get_Radius() { }

	[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE7")]
	public Sphere get_Sphere() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF0")]
	public SphereTreeNode<T> get_StackTop() { }

	[Address(RVA = "0xF5ECC0", Offset = "0xF5DEC0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF3")]
	public bool IsOutsideParent() { }

	[Address(RVA = "0xF5FEF0", Offset = "0xF5F0F0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEA")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEF")]
	public void set_Data(T value) { }

	[Address(RVA = "0xF5FFC0", Offset = "0xF5F1C0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sphere), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEC")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE8")]
	public void set_Sphere(Sphere value) { }

	[Address(RVA = "0xF5F350", Offset = "0xF5E550", Length = "0x1CD")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "RemoveNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTree`1), Member = "OnNodeSphereUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereTree`1), Member = "InsertNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.SphereTreeNode`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF5")]
	public void SetParent(SphereTreeNode<T> newParent) { }

	[Address(RVA = "0xF5F5E0", Offset = "0xF5E7E0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF2")]
	public SphereTreeNode<T> StackPop() { }

	[Address(RVA = "0xF5F610", Offset = "0xF5E810", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF1")]
	public void StackPush(SphereTreeNode<T> node) { }

}

