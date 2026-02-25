namespace System.Reflection;

[Token(Token = "0x20004F3")]
public sealed class TargetInvocationException : ApplicationException
{

	[Address(RVA = "0x13CD020", Offset = "0x13CC220", Length = "0x53")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C5")]
	public TargetInvocationException(Exception inner) { }

	[Address(RVA = "0x13CD080", Offset = "0x13CC280", Length = "0x1E")]
	[CalledBy(Type = "UnityEngine.AndroidJavaProxy", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "UnityEngine.AndroidJavaObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C6")]
	public TargetInvocationException(string message, Exception inner) { }

	[Address(RVA = "0x13BA990", Offset = "0x13B9B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60022C7")]
	internal TargetInvocationException(SerializationInfo info, StreamingContext context) { }

}

