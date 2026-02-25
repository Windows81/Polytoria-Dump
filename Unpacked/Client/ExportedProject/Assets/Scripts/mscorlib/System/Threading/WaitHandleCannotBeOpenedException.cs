namespace System.Threading;

[Token(Token = "0x20001FA")]
public class WaitHandleCannotBeOpenedException : ApplicationException
{

	[Address(RVA = "0x151F300", Offset = "0x151E500", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600111B")]
	public WaitHandleCannotBeOpenedException() { }

	[Address(RVA = "0x151F350", Offset = "0x151E550", Length = "0x1E")]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600111C")]
	public WaitHandleCannotBeOpenedException(string message) { }

	[Address(RVA = "0x13BA990", Offset = "0x13B9B90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600111D")]
	protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context) { }

}

