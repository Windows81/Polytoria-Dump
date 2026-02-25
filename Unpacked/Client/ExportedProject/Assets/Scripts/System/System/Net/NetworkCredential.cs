namespace System.Net;

[Token(Token = "0x2000237")]
public class NetworkCredential : ICredentials
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400091A")]
	private string m_domain; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400091B")]
	private string m_userName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400091C")]
	private SecureString m_password; //Field offset: 0x20

	[Token(Token = "0x170002D0")]
	public string Domain
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E28")]
		 get { } //Length: 5
		[Address(RVA = "0x17DF250", Offset = "0x17DE450", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000E29")]
		 set { } //Length: 41
	}

	[Token(Token = "0x170002CF")]
	public string Password
	{
		[Address(RVA = "0x17DF0D0", Offset = "0x17DE2D0", Length = "0xB")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(SecureStringHelper), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E26")]
		 get { } //Length: 11
		[Address(RVA = "0x17DF280", Offset = "0x17DE480", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000E27")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170002CE")]
	public string UserName
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E24")]
		 get { } //Length: 5
		[Address(RVA = "0x17DF2B0", Offset = "0x17DE4B0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000E25")]
		 set { } //Length: 41
	}

	[Address(RVA = "0x17DF190", Offset = "0x17DE390", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E22")]
	public NetworkCredential(string userName, string password) { }

	[Address(RVA = "0x17DF0E0", Offset = "0x17DE2E0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E23")]
	public NetworkCredential(string userName, string password, string domain) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E28")]
	public string get_Domain() { }

	[Address(RVA = "0x17DF0D0", Offset = "0x17DE2D0", Length = "0xB")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E26")]
	public string get_Password() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E24")]
	public string get_UserName() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2D")]
	public override NetworkCredential GetCredential(Uri uri, string authType) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2C")]
	internal string InternalGetDomain() { }

	[Address(RVA = "0x17DF0D0", Offset = "0x17DE2D0", Length = "0xB")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2B")]
	internal string InternalGetPassword() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2A")]
	internal string InternalGetUserName() { }

	[Address(RVA = "0x17DF250", Offset = "0x17DE450", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E29")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x17DF280", Offset = "0x17DE480", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E27")]
	public void set_Password(string value) { }

	[Address(RVA = "0x17DF2B0", Offset = "0x17DE4B0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E25")]
	public void set_UserName(string value) { }

}

