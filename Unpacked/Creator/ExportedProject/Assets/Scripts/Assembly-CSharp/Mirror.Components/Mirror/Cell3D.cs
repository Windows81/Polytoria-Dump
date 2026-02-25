namespace Mirror;

[Token(Token = "0x2000012")]
internal struct Cell3D
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003D")]
	internal readonly int q; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400003E")]
	internal readonly int r; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003F")]
	internal readonly int layer; //Field offset: 0x8

	[Address(RVA = "0x58D8C0", Offset = "0x58CAC0", Length = "0xB")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	internal Cell3D(int q, int r, int layer) { }

	[Address(RVA = "0x120B3B0", Offset = "0x120A5B0", Length = "0xA1")]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "OnCheckObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x120B460", Offset = "0x120A660", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004C")]
	public virtual int GetHashCode() { }

}

