namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000081")]
internal static class MeshUtilities
{
	[Token(Token = "0x4000250")]
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; //Field offset: 0x0
	[Token(Token = "0x4000251")]
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; //Field offset: 0x8

	[Address(RVA = "0x1840F20", Offset = "0x1840120", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001ED")]
	private static MeshUtilities() { }

	[Address(RVA = "0x1840A50", Offset = "0x183FC50", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "CreatePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrimitiveType)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F0")]
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

	[Address(RVA = "0x1840AF0", Offset = "0x183FCF0", Length = "0x2A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(GameObject), Member = "CreatePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrimitiveType)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EE")]
	internal static Mesh GetColliderMesh(Collider collider) { }

	[Address(RVA = "0x1840DA0", Offset = "0x183FFA0", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "CreatePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrimitiveType)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001EF")]
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

}

