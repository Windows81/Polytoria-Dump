namespace RLD;

[Token(Token = "0x20001CB")]
public static class TorusMesh
{

	[Address(RVA = "0x588ED0", Offset = "0x5880D0", Length = "0xF1B")]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitCylindricalTorus", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "GetFilledColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001226")]
	public static Mesh CreateCylindricalTorus(Vector3 center, float coreRadius, float tubeHrzRadius, float tubeVertRadius, int numTubeSlices, Color color) { }

	[Address(RVA = "0x589DF0", Offset = "0x588FF0", Length = "0x58E")]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitTorus", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "GetFilledColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001227")]
	public static Mesh CreateTorus(Vector3 center, float coreRadius, float tubeRadius, int numTubeSlices, int numSlices, Color color) { }

}

