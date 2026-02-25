namespace System;

[Token(Token = "0x2000120")]
public class OperationCanceledException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400044C")]
	private CancellationToken _cancellationToken; //Field offset: 0x90

	[Token(Token = "0x1700009B")]
	public private CancellationToken CancellationToken
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000920")]
		 get { } //Length: 8
		[Address(RVA = "0x14BB690", Offset = "0x14BA890", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000921")]
		private set { } //Length: 21
	}

	[Address(RVA = "0x14BB500", Offset = "0x14BA700", Length = "0x81")]
	[CalledBy(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetCanceled", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "SetCanceled", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000922")]
	public OperationCanceledException() { }

	[Address(RVA = "0x14BB590", Offset = "0x14BA790", Length = "0x61")]
	[CalledBy(Type = typeof(TaskCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000923")]
	public OperationCanceledException(string message) { }

	[Address(RVA = "0x14BB600", Offset = "0x14BA800", Length = "0x82")]
	[CalledBy(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AggregateException))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000924")]
	public OperationCanceledException(string message, CancellationToken token) { }

	[Address(RVA = "0x14B40D0", Offset = "0x14B32D0", Length = "0x74")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000925")]
	protected OperationCanceledException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000920")]
	public CancellationToken get_CancellationToken() { }

	[Address(RVA = "0x14BB690", Offset = "0x14BA890", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000921")]
	private void set_CancellationToken(CancellationToken value) { }

}

