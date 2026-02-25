namespace System;

[Token(Token = "0x200013A")]
public class SystemException : Exception
{

	[Address(RVA = "0x14C2B90", Offset = "0x14C1D90", Length = "0x65")]
	[CalledBy(Type = typeof(XmlSyntaxException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSyntaxException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSyntaxException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.InternalException", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A06")]
	public SystemException() { }

	[Address(RVA = "0x14C2C00", Offset = "0x14C1E00", Length = "0x61")]
	[CallerCount(Count = 111)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A07")]
	public SystemException(string message) { }

	[Address(RVA = "0x14C2B10", Offset = "0x14C1D10", Length = "0x71")]
	[CalledBy(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]", typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Authentication.AuthenticationException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]", typeof(Exception), typeof(string), typeof(int), typeof(int), "System.Xml.Schema.XmlSchemaObject"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BadImageFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A08")]
	public SystemException(string message, Exception innerException) { }

	[Address(RVA = "0x14B40D0", Offset = "0x14B32D0", Length = "0x74")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A09")]
	protected SystemException(SerializationInfo info, StreamingContext context) { }

}

