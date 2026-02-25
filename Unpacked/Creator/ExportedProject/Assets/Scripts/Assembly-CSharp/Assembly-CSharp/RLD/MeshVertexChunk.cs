namespace RLD;

[DefaultMember("Item")]
[Token(Token = "0x20001CF")]
public class MeshVertexChunk : IEnumerable<Vector3>, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400072A")]
	private List<Vector3> _modelSpaceVerts; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400072B")]
	private AABB _modelSpaceAABB; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400072C")]
	private Mesh _mesh; //Field offset: 0x38

	[Token(Token = "0x170005BF")]
	public Vector3 Item
	{
		[Address(RVA = "0x576B10", Offset = "0x575D10", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600123B")]
		 get { } //Length: 122
	}

	[Token(Token = "0x170005C0")]
	public Mesh Mesh
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600123C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005C2")]
	public AABB ModelSpaceAABB
	{
		[Address(RVA = "0x576B90", Offset = "0x575D90", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600123E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170005C1")]
	public int VertexCount
	{
		[Address(RVA = "0x576BB0", Offset = "0x575DB0", Length = "0x3C")]
		[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600123D")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x5769E0", Offset = "0x575BE0", Length = "0x123")]
	[CalledBy(Type = typeof(MeshVertexChunkCollection), Member = "FromMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600123F")]
	public MeshVertexChunk(List<Vector3> modelSpaceVerts, Mesh mesh) { }

	[Address(RVA = "0x576B10", Offset = "0x575D10", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600123B")]
	public Vector3 get_Item(int vertexIndex) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600123C")]
	public Mesh get_Mesh() { }

	[Address(RVA = "0x576B90", Offset = "0x575D90", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600123E")]
	public AABB get_ModelSpaceAABB() { }

	[Address(RVA = "0x576BB0", Offset = "0x575DB0", Length = "0x3C")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600123D")]
	public int get_VertexCount() { }

	[Address(RVA = "0x576700", Offset = "0x575900", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001240")]
	public override IEnumerator<Vector3> GetEnumerator() { }

	[Address(RVA = "0x576780", Offset = "0x575980", Length = "0x25E")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001242")]
	public Vector3 GetWorldVertClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera) { }

	[Address(RVA = "0x576700", Offset = "0x575900", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001241")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

