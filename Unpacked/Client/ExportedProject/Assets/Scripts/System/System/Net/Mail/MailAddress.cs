namespace System.Net.Mail;

[Token(Token = "0x200030E")]
public class MailAddress
{
	[Token(Token = "0x4000E51")]
	private static readonly EncodedStreamFactory s_encoderFactory; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E4D")]
	private readonly Encoding _displayNameEncoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E4E")]
	private readonly string _displayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E4F")]
	private readonly string _userName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E50")]
	private readonly string _host; //Field offset: 0x28

	[Token(Token = "0x1700041E")]
	public string Address
	{
		[Address(RVA = "0x171A460", Offset = "0x1719660", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x60013C1")]
		 get { } //Length: 65
	}

	[Token(Token = "0x1700041D")]
	public string DisplayName
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013C0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700041F")]
	private string SmtpAddress
	{
		[Address(RVA = "0x171A4B0", Offset = "0x17196B0", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x60013C2")]
		private get { } //Length: 130
	}

	[Address(RVA = "0x171A050", Offset = "0x1719250", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013C6")]
	private static MailAddress() { }

	[Address(RVA = "0x171A3B0", Offset = "0x17195B0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013BD")]
	internal MailAddress(string displayName, string userName, string domain) { }

	[Address(RVA = "0x171A390", Offset = "0x1719590", Length = "0x1D")]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+EmailAddress", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MailAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013BE")]
	public MailAddress(string address) { }

	[Address(RVA = "0x171A0D0", Offset = "0x17192D0", Length = "0x2BA")]
	[CalledBy(Type = typeof(MailAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MailAddressParser), Member = "ParseAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(MailAddress))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MailAddressParser), Member = "NormalizeOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60013BF")]
	public MailAddress(string address, string displayName, Encoding displayNameEncoding) { }

	[Address(RVA = "0x1719E60", Offset = "0x1719060", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013C4")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x171A460", Offset = "0x1719660", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60013C1")]
	public string get_Address() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013C0")]
	public string get_DisplayName() { }

	[Address(RVA = "0x171A4B0", Offset = "0x17196B0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60013C2")]
	private string get_SmtpAddress() { }

	[Address(RVA = "0x1719EE0", Offset = "0x17190E0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013C5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1719F20", Offset = "0x1719120", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60013C3")]
	public virtual string ToString() { }

}

