namespace RLD;

[Extension]
[Token(Token = "0x200016D")]
public static class SpriteRendererEx
{

	[Address(RVA = "0x56BEE0", Offset = "0x56B0E0", Length = "0x11A")]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig), typeof(GameObjectType)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(SpriteRendererEx), Member = "GetWorldCenterPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(SpriteRendererEx), Member = "GetModelSpaceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(SpriteRendererEx), Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "BuildVertOverlapAABBs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Sprite), typeof(RTMesh)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.AABB>))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SpriteRenderer), Member = "get_sprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Extension]
	[Token(Token = "0x600102F")]
	public static AABB GetModelSpaceAABB(SpriteRenderer spriteRenderer) { }

	[Address(RVA = "0x56C000", Offset = "0x56B200", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteRendererEx), Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = typeof(AABB))]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600102E")]
	public static Vector3 GetModelSpaceSize(SpriteRenderer spriteRenderer) { }

	[Address(RVA = "0x56C030", Offset = "0x56B230", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SpriteRendererEx), Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600102D")]
	public static Vector3 GetWorldCenterPoint(SpriteRenderer spriteRenderer) { }

	[Address(RVA = "0x56C0E0", Offset = "0x56B2E0", Length = "0x3EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpriteRenderer), Member = "get_sprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SpriteRendererEx), Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(AABB), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6001030")]
	public static bool IsPixelFullyTransparent(SpriteRenderer spriteRenderer, Vector3 worldPos) { }

}

