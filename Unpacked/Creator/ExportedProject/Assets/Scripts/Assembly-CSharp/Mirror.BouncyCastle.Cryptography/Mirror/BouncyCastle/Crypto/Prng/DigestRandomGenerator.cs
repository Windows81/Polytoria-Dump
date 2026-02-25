namespace Mirror.BouncyCastle.Crypto.Prng;

[Token(Token = "0x200011D")]
public sealed class DigestRandomGenerator : IRandomGenerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023A")]
	private long stateCounter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023B")]
	private long seedCounter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023C")]
	private IDigest digest; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400023D")]
	private Byte[] state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400023E")]
	private Byte[] seed; //Field offset: 0x30

	[Address(RVA = "0x11E1A40", Offset = "0x11E0C40", Length = "0xD5")]
	[CalledBy(Type = typeof(SecureRandom), Member = "CreatePrng", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(DigestRandomGenerator))]
	[CalledBy(Type = typeof(SecureRandom), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B54")]
	public DigestRandomGenerator(IDigest digest) { }

	[Address(RVA = "0x11E1210", Offset = "0x11E0410", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000B55")]
	public override void AddSeedMaterial(Byte[] inSeed) { }

	[Address(RVA = "0x11E10C0", Offset = "0x11E02C0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DigestRandomGenerator), Member = "DigestAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000B56")]
	public override void AddSeedMaterial(long rSeed) { }

	[Address(RVA = "0x11E13F0", Offset = "0x11E05F0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(DigestRandomGenerator), Member = "DigestAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B59")]
	private void CycleSeed() { }

	[Address(RVA = "0x11E14D0", Offset = "0x11E06D0", Length = "0x118")]
	[CalledBy(Type = typeof(DigestRandomGenerator), Member = "AddSeedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DigestRandomGenerator), Member = "CycleSeed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DigestRandomGenerator), Member = "GenerateState", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B5B")]
	private void DigestAddCounter(long seedVal) { }

	[Address(RVA = "0x11E15F0", Offset = "0x11E07F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B5D")]
	private void DigestDoFinal(Byte[] result) { }

	[Address(RVA = "0x11E1660", Offset = "0x11E0860", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B5C")]
	private void DigestUpdate(Byte[] inSeed) { }

	[Address(RVA = "0x11E16D0", Offset = "0x11E08D0", Length = "0x206")]
	[CalledBy(Type = typeof(DigestRandomGenerator), Member = "NextBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DigestRandomGenerator), Member = "DigestAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181D50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B5A")]
	private void GenerateState() { }

	[Address(RVA = "0x11E18E0", Offset = "0x11E0AE0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DigestRandomGenerator), Member = "NextBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B57")]
	public override void NextBytes(Byte[] bytes) { }

	[Address(RVA = "0x11E1910", Offset = "0x11E0B10", Length = "0x12C")]
	[CalledBy(Type = typeof(DigestRandomGenerator), Member = "NextBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DigestRandomGenerator), Member = "GenerateState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000B58")]
	public override void NextBytes(Byte[] bytes, int start, int len) { }

}

