namespace System.Security.Cryptography;

[Token(Token = "0x2000317")]
internal static class Utils
{
	[Token(Token = "0x4000D3A")]
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	[Token(Token = "0x17000293")]
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		[Address(RVA = "0x1353B40", Offset = "0x1352D40", Length = "0xF9")]
		[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C240")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60018D1")]
		internal get { } //Length: 249
	}

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018DF")]
	internal static bool _ProduceLegacyHmacValues() { }

	[Address(RVA = "0x1353120", Offset = "0x1352320", Length = "0x45")]
	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018D6")]
	internal static int ConvertByteArrayToInt(Byte[] input) { }

	[Address(RVA = "0x1353170", Offset = "0x1352370", Length = "0x114")]
	[CalledBy(Type = typeof(DSA), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018D7")]
	internal static Byte[] ConvertIntToByteArray(int dwInput) { }

	[Address(RVA = "0x13534F0", Offset = "0x13526F0", Length = "0x16D")]
	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018D4")]
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	[Address(RVA = "0x1353660", Offset = "0x1352860", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018D5")]
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x1353290", Offset = "0x1352490", Length = "0x41")]
	[CalledBy(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60018DB")]
	internal static void DWORDFromBigEndian(UInt32* x, int digits, Byte* block) { }

	[Address(RVA = "0x13532E0", Offset = "0x13524E0", Length = "0x4F")]
	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "MDTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60018D9")]
	internal static void DWORDFromLittleEndian(UInt32* x, int digits, Byte* block) { }

	[Address(RVA = "0x1353330", Offset = "0x1352530", Length = "0xD7")]
	[CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018DC")]
	internal static void DWORDToBigEndian(Byte[] block, UInt32[] x, int digits) { }

	[Address(RVA = "0x1353410", Offset = "0x1352610", Length = "0xD7")]
	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018DA")]
	internal static void DWORDToLittleEndian(Byte[] block, UInt32[] x, int digits) { }

	[Address(RVA = "0x1353800", Offset = "0x1352A00", Length = "0xCB")]
	[CalledBy(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018D8")]
	internal static Byte[] FixupKeyParity(Byte[] key) { }

	[Address(RVA = "0x13538D0", Offset = "0x1352AD0", Length = "0x69")]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACMD5), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018D2")]
	internal static Byte[] GenerateRandom(int keySize) { }

	[Address(RVA = "0x1353B40", Offset = "0x1352D40", Length = "0xF9")]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C240")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018D1")]
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018D3")]
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	[Address(RVA = "0x1353940", Offset = "0x1352B40", Length = "0x82")]
	[CalledBy(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60018DD")]
	internal static void QuadWordFromBigEndian(UInt64* x, int digits, Byte* block) { }

	[Address(RVA = "0x13539D0", Offset = "0x1352BD0", Length = "0x164")]
	[CalledBy(Type = typeof(SHA384Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018DE")]
	internal static void QuadWordToBigEndian(Byte[] block, UInt64[] x, int digits) { }

}

