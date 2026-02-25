namespace System.Reflection;

[Token(Token = "0x20004F2")]
public class TargetException : ApplicationException
{

	[Address(RVA = "0x13CCFC0", Offset = "0x13CC1C0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C1")]
	public TargetException() { }

	[Address(RVA = "0x13CCFF0", Offset = "0x13CC1F0", Length = "0x21")]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C2")]
	public TargetException(string message) { }

	[Address(RVA = "0x13CCFA0", Offset = "0x13CC1A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C3")]
	public TargetException(string message, Exception inner) { }

	[Address(RVA = "0x13BA990", Offset = "0x13B9B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60022C4")]
	protected TargetException(SerializationInfo info, StreamingContext context) { }

}

