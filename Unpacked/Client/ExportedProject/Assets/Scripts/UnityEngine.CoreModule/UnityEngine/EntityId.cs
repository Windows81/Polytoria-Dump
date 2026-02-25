namespace UnityEngine;

[NativeClass("EntityId")]
[Token(Token = "0x2000168")]
[UsedByNativeCode]
public struct EntityId : IEquatable<EntityId>, IComparable<EntityId>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000593")]
	private int m_Data; //Field offset: 0x0

	[Address(RVA = "0x195F9F0", Offset = "0x195EBF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000A14")]
	public override int CompareTo(EntityId other) { }

	[Address(RVA = "0x195FA00", Offset = "0x195EC00", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A12")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x149FBD0", Offset = "0x149EDD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A13")]
	public override bool Equals(EntityId other) { }

	[Address(RVA = "0x195FA90", Offset = "0x195EC90", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A15")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x64EB60", Offset = "0x64DD60", Length = "0x3")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A16")]
	public static EntityId op_Implicit(int intValue) { }

	[Address(RVA = "0x195FAE0", Offset = "0x195ECE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000A17")]
	public virtual string ToString() { }

}

