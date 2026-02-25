namespace RLD;

[Token(Token = "0x2000281")]
public static class ObjectAlign
{
	[Token(Token = "0x2000282")]
	internal enum Result
	{
		Err_NoObjects = 0,
		Success = 1,
	}


	[Address(RVA = "0x5B6580", Offset = "0x5B5780", Length = "0x43D")]
	[CalledBy(Type = typeof(ObjectAlign), Member = "AlignToWorldAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Axis), typeof(Vector3)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ObjectAlign), Member = "AlignToWorldPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Plane)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(OBB), Member = "GetInvalid", ReturnType = typeof(OBB))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60018C0")]
	private static void AlignRootsToPlane(List<GameObject> roots, Plane alignmentPlane) { }

	[Address(RVA = "0x5B69C0", Offset = "0x5B5BC0", Length = "0x1C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(ObjectAlign), Member = "AlignRootsToPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Plane)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018BE")]
	public static Result AlignToWorldAxis(IEnumerable<GameObject> gameObjects, Axis axis, Vector3 alignmentPlaneOrigin) { }

	[Address(RVA = "0x5B6B90", Offset = "0x5B5D90", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(ObjectAlign), Member = "AlignRootsToPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Plane)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018BF")]
	public static Result AlignToWorldPlane(IEnumerable<GameObject> gameObjects, Plane alignmentPlane) { }

}

