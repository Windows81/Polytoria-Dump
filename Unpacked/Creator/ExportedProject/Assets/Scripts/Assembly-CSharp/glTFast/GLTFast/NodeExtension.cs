namespace GLTFast;

[Extension]
[Token(Token = "0x2000049")]
public static class NodeExtension
{

	[Address(RVA = "0x10782F0", Offset = "0x10774F0", Length = "0x4E3")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<>c__DisplayClass124_0", Member = "<InstantiateSceneInternal>g__CreateHierarchy|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Nullable`1<System.UInt32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathematics), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(float3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000138")]
	public static void GetTransform(NodeBase node, out Vector3 position, out Quaternion rotation, out Vector3 scale) { }

}

