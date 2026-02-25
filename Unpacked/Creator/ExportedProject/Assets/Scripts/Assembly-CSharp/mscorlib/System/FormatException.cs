namespace System;

[Token(Token = "0x20000D9")]
public class FormatException : SystemException
{

	[Address(RVA = "0x149A150", Offset = "0x1499350", Length = "0x44")]
	[CalledBy(Type = typeof(Uri), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.UriFormatException", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.CookieException", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.HttpHeaders", Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IEnumerable`1<String>", "System.Net.Http.Headers.HeaderInfo", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AA")]
	public FormatException() { }

	[Address(RVA = "0x149A110", Offset = "0x1499310", Length = "0x1E")]
	[CallerCount(Count = 141)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AB")]
	public FormatException(string message) { }

	[Address(RVA = "0x149A130", Offset = "0x1499330", Length = "0x1E")]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.CookieException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", typeof(bool)}, ReturnType = "System.Net.IPAddress")]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.Mail.MailAddressParser", Member = "NormalizeOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.BooleanConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CustomAttributeFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomAttributeFormatException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Guid), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(Int64&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Guid+GuidResult", Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(CustomAttributeFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(string), "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006AC")]
	public FormatException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AD")]
	protected FormatException(SerializationInfo info, StreamingContext context) { }

}

