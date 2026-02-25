namespace RLD;

[Token(Token = "0x2000285")]
public static class ObjectCloning
{
	[Token(Token = "0x2000287")]
	internal struct Config
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E6")]
		public Transform Parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009E7")]
		public TransformFlags TransformFlags; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40009E8")]
		public int Layer; //Field offset: 0xC

	}

	[Flags]
	[Token(Token = "0x2000286")]
	internal enum TransformFlags
	{
		None = 0,
		Position = 1,
		Rotation = 2,
		Scale = 4,
		All = 7,
	}

	[Token(Token = "0x40009DF")]
	private static Config _defaultConfig; //Field offset: 0x0

	[Token(Token = "0x17000839")]
	public static Config DefaultConfig
	{
		[Address(RVA = "0x5B8E60", Offset = "0x5B8060", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60018D4")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x5B8DF0", Offset = "0x5B7FF0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60018D3")]
	private static ObjectCloning() { }

	[Address(RVA = "0x5B8910", Offset = "0x5B7B10", Length = "0x244")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectCloning), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60018D5")]
	public static List<GameObject> CloneHierarchies(List<GameObject> roots, Config cloneConfig) { }

	[Address(RVA = "0x5B8B60", Offset = "0x5B7D60", Length = "0x285")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuplicateObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectCloning), Member = "CloneHierarchies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Config)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Instance), Member = "Clone", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Token(Token = "0x60018D6")]
	public static GameObject CloneHierarchy(GameObject root, Config cloneConfig) { }

	[Address(RVA = "0x5B8E60", Offset = "0x5B8060", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60018D4")]
	public static Config get_DefaultConfig() { }

}

