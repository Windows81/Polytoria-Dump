namespace System.Threading.Tasks;

[Token(Token = "0x2000249")]
public class TaskCanceledException : OperationCanceledException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000AA3")]
	private readonly Task _canceledTask; //Field offset: 0x98

	[Address(RVA = "0x152D810", Offset = "0x152CA10", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001309")]
	public TaskCanceledException() { }

	[Address(RVA = "0x152D770", Offset = "0x152C970", Length = "0x9B")]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600130A")]
	public TaskCanceledException(Task task) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600130B")]
	protected TaskCanceledException(SerializationInfo info, StreamingContext context) { }

}

