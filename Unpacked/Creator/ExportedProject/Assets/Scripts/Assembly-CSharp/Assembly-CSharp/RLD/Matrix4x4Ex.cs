namespace RLD;

[Extension]
[Token(Token = "0x2000166")]
public static class Matrix4x4Ex
{

	[Address(RVA = "0x543290", Offset = "0x542490", Length = "0xAA5")]
	[CallerCount(Count = 0)]
	[Extension]
	[Token(Token = "0x6001008")]
	public static Matrix4x4 GetInverse(Matrix4x4 mtx) { }

	[Address(RVA = "0x543D40", Offset = "0x542F40", Length = "0x1E1")]
	[CalledBy(Type = typeof(OBB), Member = "GetPointFaceNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x600100F")]
	public static Vector3[] GetNormalizedAxes(Matrix4x4 matrix) { }

	[Address(RVA = "0x543F30", Offset = "0x543130", Length = "0x5F")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Update3DAxes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Update2DAxes", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Extension]
	[Token(Token = "0x600100E")]
	public static Vector3 GetNormalizedAxis(Matrix4x4 matrix, int axisIndex) { }

	[Address(RVA = "0x543F90", Offset = "0x543190", Length = "0xB2")]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Extension]
	[Token(Token = "0x6001009")]
	public static Matrix4x4 GetRelativeTransform(Matrix4x4 matrix, Matrix4x4 referenceTransform) { }

	[Address(RVA = "0x544050", Offset = "0x543250", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Extension]
	[Token(Token = "0x600100D")]
	public static Vector3 GetScale(Matrix4x4 matrix) { }

	[Address(RVA = "0x544160", Offset = "0x543360", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Extension]
	[Token(Token = "0x600100C")]
	public static Vector3 GetTranslation(Matrix4x4 matrix) { }

	[Address(RVA = "0x5441B0", Offset = "0x5433B0", Length = "0x202")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600100B")]
	public static Matrix4x4 RotationMatrixFromRightUp(Vector3 right, Vector3 up) { }

	[Address(RVA = "0x5443C0", Offset = "0x5435C0", Length = "0x273")]
	[CalledBy(Type = typeof(OBB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6001010")]
	public static List<Vector3> TransformPoints(Matrix4x4 matrix, List<Vector3> points) { }

	[Address(RVA = "0x544640", Offset = "0x543840", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600100A")]
	public static Matrix4x4 Translation(Vector3 translation) { }

}

