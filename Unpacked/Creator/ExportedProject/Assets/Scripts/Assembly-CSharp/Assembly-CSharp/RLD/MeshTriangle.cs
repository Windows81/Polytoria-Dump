namespace RLD;

[Token(Token = "0x20001D3")]
public class MeshTriangle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000734")]
	private Vector3[] _vertices; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000735")]
	private Vector3 _normal; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000736")]
	private int _triangleIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000737")]
	private Int32[] _vertIndices; //Field offset: 0x28

	[Token(Token = "0x170005D0")]
	public Vector3 Normal
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600125C")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170005CB")]
	public int TriangleIndex
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001257")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170005CD")]
	public Vector3 Vertex0
	{
		[Address(RVA = "0x53E7E0", Offset = "0x53D9E0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001259")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170005CE")]
	public Vector3 Vertex1
	{
		[Address(RVA = "0x53E820", Offset = "0x53DA20", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600125A")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170005CF")]
	public Vector3 Vertex2
	{
		[Address(RVA = "0x53E750", Offset = "0x53D950", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600125B")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170005CC")]
	public Vector3[] Vertices
	{
		[Address(RVA = "0x575210", Offset = "0x574410", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001258")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170005D2")]
	public int VertIndex0
	{
		[Address(RVA = "0x575130", Offset = "0x574330", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600125E")]
		 get { } //Length: 38
	}

	[Token(Token = "0x170005D3")]
	public int VertIndex1
	{
		[Address(RVA = "0x575160", Offset = "0x574360", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600125F")]
		 get { } //Length: 38
	}

	[Token(Token = "0x170005D4")]
	public int VertIndex2
	{
		[Address(RVA = "0x575190", Offset = "0x574390", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001260")]
		 get { } //Length: 38
	}

	[Token(Token = "0x170005D1")]
	public Int32[] VertIndices
	{
		[Address(RVA = "0x5751C0", Offset = "0x5743C0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600125D")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x574EE0", Offset = "0x5740E0", Length = "0x24F")]
	[CalledBy(Type = typeof(RTMesh), Member = "GetTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MeshTriangle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001261")]
	public MeshTriangle(Vector3[] vertices, int triangleIndex, int vertIndex0, int vertIndex1, int vertIndex2) { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600125C")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001257")]
	public int get_TriangleIndex() { }

	[Address(RVA = "0x53E7E0", Offset = "0x53D9E0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001259")]
	public Vector3 get_Vertex0() { }

	[Address(RVA = "0x53E820", Offset = "0x53DA20", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600125A")]
	public Vector3 get_Vertex1() { }

	[Address(RVA = "0x53E750", Offset = "0x53D950", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600125B")]
	public Vector3 get_Vertex2() { }

	[Address(RVA = "0x575210", Offset = "0x574410", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001258")]
	public Vector3[] get_Vertices() { }

	[Address(RVA = "0x575130", Offset = "0x574330", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600125E")]
	public int get_VertIndex0() { }

	[Address(RVA = "0x575160", Offset = "0x574360", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600125F")]
	public int get_VertIndex1() { }

	[Address(RVA = "0x575190", Offset = "0x574390", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001260")]
	public int get_VertIndex2() { }

	[Address(RVA = "0x5751C0", Offset = "0x5743C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600125D")]
	public Int32[] get_VertIndices() { }

	[Address(RVA = "0x574EB0", Offset = "0x5740B0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001262")]
	public int GetVertIndex(int arrayIndex) { }

}

