namespace System.Net;

[Token(Token = "0x200022D")]
public class IPHostEntry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008FD")]
	private string hostName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008FE")]
	private String[] aliases; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008FF")]
	private IPAddress[] addressList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000900")]
	internal bool isTrustedHost; //Field offset: 0x28

	[Token(Token = "0x170002C5")]
	public IPAddress[] AddressList
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E07")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E08")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002C4")]
	public String[] Aliases
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E06")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002C3")]
	public string HostName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E04")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E05")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x17DD6B0", Offset = "0x17DC8B0", Length = "0xB")]
	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E09")]
	public IPHostEntry() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E07")]
	public IPAddress[] get_AddressList() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E04")]
	public string get_HostName() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E08")]
	public void set_AddressList(IPAddress[] value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E06")]
	public void set_Aliases(String[] value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E05")]
	public void set_HostName(string value) { }

}

