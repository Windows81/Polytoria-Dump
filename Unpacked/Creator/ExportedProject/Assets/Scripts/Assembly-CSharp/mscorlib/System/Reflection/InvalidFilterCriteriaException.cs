namespace System.Reflection;

[Token(Token = "0x20004D7")]
public class InvalidFilterCriteriaException : ApplicationException
{

	[Address(RVA = "0x13BA9D0", Offset = "0x13B9BD0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002197")]
	public InvalidFilterCriteriaException() { }

	[Address(RVA = "0x13BA960", Offset = "0x13B9B60", Length = "0x21")]
	[CalledBy(Type = typeof(Type), Member = "FilterAttributeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "FilterNameImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "FilterNameIgnoreCaseImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "FilterTypeNameImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "FilterTypeNameIgnoreCaseImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002198")]
	public InvalidFilterCriteriaException(string message) { }

	[Address(RVA = "0x13BA9B0", Offset = "0x13B9BB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002199")]
	public InvalidFilterCriteriaException(string message, Exception inner) { }

	[Address(RVA = "0x13BA990", Offset = "0x13B9B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600219A")]
	protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context) { }

}

