namespace UnityEngine.Rendering;

[Token(Token = "0x20002FD")]
public struct ShaderTagId : IEquatable<ShaderTagId>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000946")]
	private int m_Id; //Field offset: 0x0

	[Address(RVA = "0x198EA90", Offset = "0x198DC90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000E85")]
	public ShaderTagId(string name) { }

	[Address(RVA = "0x198E9E0", Offset = "0x198DBE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E86")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E87")]
	public override bool Equals(ShaderTagId other) { }

	[Address(RVA = "0x198EA70", Offset = "0x198DC70", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E88")]
	public virtual int GetHashCode() { }

}

