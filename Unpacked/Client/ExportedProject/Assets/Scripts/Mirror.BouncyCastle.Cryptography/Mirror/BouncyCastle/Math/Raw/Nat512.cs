namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x200002E")]
internal static class Nat512
{

	[Address(RVA = "0x1154910", Offset = "0x1153B10", Length = "0x1A9")]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Nat256), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "AddToEachOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat256), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat256), Member = "Create", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat256), Member = "Diff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat), Member = "SubFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "AddWordAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000200")]
	public static void Mul(UInt32[] x, UInt32[] y, UInt32[] zz) { }

	[Address(RVA = "0x1154AC0", Offset = "0x1153CC0", Length = "0x13B")]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "ImplSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP521R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat256), Member = "Diff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat256), Member = "Create", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat256), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat), Member = "AddWordAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat256), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat), Member = "SubFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat256), Member = "AddToEachOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000201")]
	public static void Square(UInt32[] x, UInt32[] zz) { }

}

