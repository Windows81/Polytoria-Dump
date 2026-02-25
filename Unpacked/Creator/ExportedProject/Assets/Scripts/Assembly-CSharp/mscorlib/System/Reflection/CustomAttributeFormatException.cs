namespace System.Reflection;

[Token(Token = "0x20004CB")]
public class CustomAttributeFormatException : FormatException
{

	[Address(RVA = "0x13B6F20", Offset = "0x13B6120", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x600215D")]
	public CustomAttributeFormatException() { }

	[Address(RVA = "0x13B6F70", Offset = "0x13B6170", Length = "0x21")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x600215E")]
	public CustomAttributeFormatException(string message) { }

	[Address(RVA = "0x13B6FA0", Offset = "0x13B61A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x600215F")]
	public CustomAttributeFormatException(string message, Exception inner) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002160")]
	protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context) { }

}

