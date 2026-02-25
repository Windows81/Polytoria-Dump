namespace RLD;

[Token(Token = "0x20001C5")]
public static class CylinderMesh
{

	[Address(RVA = "0x571AF0", Offset = "0x570CF0", Length = "0xEFB")]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitCone", ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitCylinder", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "GetFilledColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600121B")]
	public static Mesh CreateCylinder(float bottomRadius, float topRadius, float height, int numSlices, int numStacks, int numBottomCapRings, int numTopCapRings, Color color) { }

}

