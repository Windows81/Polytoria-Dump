namespace UnityEngine.Rendering;

[Token(Token = "0x20002F6")]
public struct LODParameters : IEquatable<LODParameters>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400092E")]
	private int m_IsOrthographic; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400092F")]
	private Vector3 m_CameraPosition; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000930")]
	private float m_FieldOfView; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000931")]
	private float m_OrthoSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000932")]
	private int m_CameraPixelHeight; //Field offset: 0x18

	[Address(RVA = "0x1983230", Offset = "0x1982430", Length = "0x9F")]
	[CalledBy(Type = typeof(LODParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E3B")]
	public override bool Equals(LODParameters other) { }

	[Address(RVA = "0x19832D0", Offset = "0x19824D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(LODParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E3C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1983380", Offset = "0x1982580", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000E3D")]
	public virtual int GetHashCode() { }

}

