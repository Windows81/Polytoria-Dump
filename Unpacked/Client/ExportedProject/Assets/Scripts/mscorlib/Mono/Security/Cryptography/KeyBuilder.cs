namespace Mono.Security.Cryptography;

[Token(Token = "0x2000063")]
internal sealed class KeyBuilder
{
	[Token(Token = "0x40001E2")]
	private static RandomNumberGenerator rng; //Field offset: 0x0

	[Token(Token = "0x1700001D")]
	private static RandomNumberGenerator Rng
	{
		[Address(RVA = "0x12F29B0", Offset = "0x12F1BB0", Length = "0x78")]
		[CalledBy(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(KeyBuilder), Member = "IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(SymmetricTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600014B")]
		private get { } //Length: 120
	}

	[Address(RVA = "0x12F29B0", Offset = "0x12F1BB0", Length = "0x78")]
	[CalledBy(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(KeyBuilder), Member = "IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SymmetricTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600014B")]
	private static RandomNumberGenerator get_Rng() { }

	[Address(RVA = "0x12F28D0", Offset = "0x12F1AD0", Length = "0x69")]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "GenerateIV", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014D")]
	public static Byte[] IV(int size) { }

	[Address(RVA = "0x12F2940", Offset = "0x12F1B40", Length = "0x69")]
	[CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DESTransform), Member = "GetStrongKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RC2), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESTransform), Member = "GetStrongKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "GenerateKey", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014C")]
	public static Byte[] Key(int size) { }

}

