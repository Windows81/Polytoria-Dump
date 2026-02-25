namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[Token(Token = "0x2000016")]
[UsedByNativeCode]
public struct MeshId : IEquatable<MeshId>
{
	[Token(Token = "0x400005F")]
	private static MeshId s_InvalidId; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000060")]
	private ulong m_SubId1; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000061")]
	private ulong m_SubId2; //Field offset: 0x8

	[Address(RVA = "0x1D02130", Offset = "0x1D01330", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600002A")]
	private static MeshId() { }

	[Address(RVA = "0x1D02000", Offset = "0x1D01200", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1946070", Offset = "0x1945270", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	public override bool Equals(MeshId other) { }

	[Address(RVA = "0x1945D00", Offset = "0x1944F00", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000027")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1D020B0", Offset = "0x1D012B0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000026")]
	public virtual string ToString() { }

}

