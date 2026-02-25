namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x200002C")]
internal static class Nat384
{

	[Address(RVA = "0x1154190", Offset = "0x1153390", Length = "0x1A9")]
	[CalledBy(Type = typeof(SecP384R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Nat192), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat192), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat192), Member = "AddToEachOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat192), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat192), Member = "Create", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat192), Member = "Diff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat192), Member = "CreateExt", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat), Member = "SubFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "AddWordAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60001F6")]
	public static void Mul(UInt32[] x, UInt32[] y, UInt32[] zz) { }

	[Address(RVA = "0x1154340", Offset = "0x1153540", Length = "0x13B")]
	[CalledBy(Type = typeof(SecP384R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Nat192), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat192), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat192), Member = "AddToEachOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat192), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat192), Member = "Create", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat192), Member = "Diff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat192), Member = "CreateExt", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat), Member = "SubFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "AddWordAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60001F7")]
	public static void Square(UInt32[] x, UInt32[] zz) { }

}

