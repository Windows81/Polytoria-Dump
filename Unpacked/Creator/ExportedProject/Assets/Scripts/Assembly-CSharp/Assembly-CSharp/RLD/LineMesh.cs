namespace RLD;

[Token(Token = "0x20001C6")]
public static class LineMesh
{

	[Address(RVA = "0x572EF0", Offset = "0x5720F0", Length = "0x2E4")]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitCoordSystem", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "GetFilledColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600121C")]
	public static Mesh CreateCoordSystemAxesLines(float axisLength, Color color) { }

	[Address(RVA = "0x5731E0", Offset = "0x5723E0", Length = "0x166")]
	[CalledBy(Type = typeof(MeshPool), Member = "get_UnitSegmentX", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "GetFilledColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600121D")]
	public static Mesh CreateLine(Vector3 startPoint, Vector3 endPoint, Color color) { }

}

