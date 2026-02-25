namespace GLTFast;

[Extension]
[Token(Token = "0x2000043")]
public static class Mathematics
{

	[Address(RVA = "0x1076640", Offset = "0x1075840", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathematics), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(float3&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600012A")]
	public static void Decompose(Matrix4x4 m, out Vector3 translation, out Quaternion rotation, out Vector3 scale) { }

	[Address(RVA = "0x10761B0", Offset = "0x10753B0", Length = "0x483")]
	[CalledBy(Type = typeof(Mathematics), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Vector3&), typeof(Quaternion&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NodeExtension), Member = "GetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeBase), typeof(Vector3&), typeof(Quaternion&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181072800")]
	[Calls(Type = typeof(quaternion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x600012B")]
	private static void Decompose(float3x3 m, out quaternion rotation, out float3 scale) { }

	[Address(RVA = "0x1076880", Offset = "0x1075A80", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600012C")]
	private static bool IsNegative(float3x3 m) { }

}

