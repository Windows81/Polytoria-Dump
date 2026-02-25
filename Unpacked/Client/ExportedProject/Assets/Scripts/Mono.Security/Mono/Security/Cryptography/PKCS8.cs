namespace Mono.Security.Cryptography;

[Token(Token = "0x200004E")]
public sealed class PKCS8
{
	[Token(Token = "0x2000050")]
	internal class EncryptedPrivateKeyInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000220")]
		private string _algorithm; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000221")]
		private Byte[] _salt; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000222")]
		private int _iterations; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000223")]
		private Byte[] _data; //Field offset: 0x28

		[Token(Token = "0x1700007D")]
		public string Algorithm
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001B7")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001B8")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700007E")]
		public Byte[] EncryptedData
		{
			[Address(RVA = "0x12C7FC0", Offset = "0x12C71C0", Length = "0x79")]
			[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001B9")]
			 get { } //Length: 121
			[Address(RVA = "0x12C8110", Offset = "0x12C7310", Length = "0x98")]
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001BA")]
			 set { } //Length: 152
		}

		[Token(Token = "0x17000080")]
		public int IterationCount
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001BC")]
			 get { } //Length: 4
			[Address(RVA = "0x12C81B0", Offset = "0x12C73B0", Length = "0x7E")]
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60001BD")]
			 set { } //Length: 126
		}

		[Token(Token = "0x1700007F")]
		public Byte[] Salt
		{
			[Address(RVA = "0x12C8040", Offset = "0x12C7240", Length = "0xC9")]
			[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60001BB")]
			 get { } //Length: 201
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B5")]
		public EncryptedPrivateKeyInfo() { }

		[Address(RVA = "0x12C7F90", Offset = "0x12C7190", Length = "0x2F")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(EncryptedPrivateKeyInfo), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001B6")]
		public EncryptedPrivateKeyInfo(Byte[] data) { }

		[Address(RVA = "0x12C79E0", Offset = "0x12C6BE0", Length = "0x3A5")]
		[CalledBy(Type = typeof(EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001BE")]
		private void Decode(Byte[] data) { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B7")]
		public string get_Algorithm() { }

		[Address(RVA = "0x12C7FC0", Offset = "0x12C71C0", Length = "0x79")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001B9")]
		public Byte[] get_EncryptedData() { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BC")]
		public int get_IterationCount() { }

		[Address(RVA = "0x12C8040", Offset = "0x12C7240", Length = "0xC9")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BB")]
		public Byte[] get_Salt() { }

		[Address(RVA = "0x12C7D90", Offset = "0x12C6F90", Length = "0x1F0")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001BF")]
		public Byte[] GetBytes() { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B8")]
		public void set_Algorithm(string value) { }

		[Address(RVA = "0x12C8110", Offset = "0x12C7310", Length = "0x98")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001BA")]
		public void set_EncryptedData(Byte[] value) { }

		[Address(RVA = "0x12C81B0", Offset = "0x12C73B0", Length = "0x7E")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60001BD")]
		public void set_IterationCount(int value) { }

	}

	[Token(Token = "0x200004F")]
	internal class PrivateKeyInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400021C")]
		private int _version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400021D")]
		private string _algorithm; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400021E")]
		private Byte[] _key; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400021F")]
		private ArrayList _list; //Field offset: 0x28

		[Token(Token = "0x1700007B")]
		public string Algorithm
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001A8")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001A9")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700007C")]
		public Byte[] PrivateKey
		{
			[Address(RVA = "0x12D0F80", Offset = "0x12D0180", Length = "0x7B")]
			[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001AA")]
			 get { } //Length: 123
			[Address(RVA = "0x12D1000", Offset = "0x12D0200", Length = "0xFC")]
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60001AB")]
			 set { } //Length: 252
		}

		[Address(RVA = "0x12D0E80", Offset = "0x12D0080", Length = "0x6D")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001A6")]
		public PrivateKeyInfo() { }

		[Address(RVA = "0x12D0EF0", Offset = "0x12D00F0", Length = "0x88")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001A7")]
		public PrivateKeyInfo(Byte[] data) { }

		[Address(RVA = "0x12D01C0", Offset = "0x12CF3C0", Length = "0x2FC")]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001AC")]
		private void Decode(Byte[] data) { }

		[Address(RVA = "0x12CFB10", Offset = "0x12CED10", Length = "0x1B8")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "RemoveLeadingZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001B2")]
		public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

		[Address(RVA = "0x12CFCD0", Offset = "0x12CEED0", Length = "0x4E9")]
		[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "GetRSAPrivateKey", ReturnType = typeof(RSA))]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspProviderFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CspParameters), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "RemoveLeadingZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001B0")]
		public static RSA DecodeRSA(Byte[] keypair) { }

		[Address(RVA = "0x12D0520", Offset = "0x12CF720", Length = "0x220")]
		[CalledBy(Type = "Mono.Btls.MonoBtlsKey", Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = "Mono.Btls.MonoBtlsKey")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001B1")]
		public static Byte[] Encode(RSA rsa) { }

		[Address(RVA = "0x12D04C0", Offset = "0x12CF6C0", Length = "0x5D")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001B3")]
		public static Byte[] Encode(DSA dsa) { }

		[Address(RVA = "0x12D0750", Offset = "0x12CF950", Length = "0x1D0")]
		[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001B4")]
		public static Byte[] Encode(AsymmetricAlgorithm aa) { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		public string get_Algorithm() { }

		[Address(RVA = "0x12D0F80", Offset = "0x12D0180", Length = "0x7B")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001AA")]
		public Byte[] get_PrivateKey() { }

		[Address(RVA = "0x12D0930", Offset = "0x12CFB30", Length = "0x3EC")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60001AD")]
		public Byte[] GetBytes() { }

		[Address(RVA = "0x12D0D20", Offset = "0x12CFF20", Length = "0xA9")]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60001AF")]
		private static Byte[] Normalize(Byte[] bigInt, int length) { }

		[Address(RVA = "0x12D0DD0", Offset = "0x12CFFD0", Length = "0xA5")]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(DSAParameters)}, ReturnType = typeof(DSA))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001AE")]
		private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		public void set_Algorithm(string value) { }

		[Address(RVA = "0x12D1000", Offset = "0x12D0200", Length = "0xFC")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001AB")]
		public void set_PrivateKey(Byte[] value) { }

	}


}

