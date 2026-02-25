namespace System.Reflection;

[Token(Token = "0x20004F4")]
public sealed class TargetParameterCountException : ApplicationException
{

	[Address(RVA = "0x13CD0C0", Offset = "0x13CC2C0", Length = "0x44")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binder), typeof(Object[]), typeof(ParameterInfo[]), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C8")]
	public TargetParameterCountException() { }

	[Address(RVA = "0x13CD0A0", Offset = "0x13CC2A0", Length = "0x1E")]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C9")]
	public TargetParameterCountException(string message) { }

	[Address(RVA = "0x13BA990", Offset = "0x13B9B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60022CA")]
	internal TargetParameterCountException(SerializationInfo info, StreamingContext context) { }

}

