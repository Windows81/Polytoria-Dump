namespace RLD;

[Token(Token = "0x20001CA")]
public static class SphereMesh
{

	[Address(RVA = "0x587190", Offset = "0x586390", Length = "0x649")]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitSphere", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "GetFilledColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001225")]
	public static Mesh CreateSphere(float radius, int numSlices, int numStacks, Color color) { }

}

