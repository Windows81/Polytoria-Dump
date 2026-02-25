namespace System.Runtime.ExceptionServices;

[Token(Token = "0x200045A")]
public sealed class ExceptionDispatchInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001235")]
	private Exception m_Exception; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001236")]
	private object m_stackTrace; //Field offset: 0x18

	[Token(Token = "0x170003F0")]
	internal object BinaryStackTraceArray
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FFB")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003F1")]
	public Exception SourceException
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FFD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13B8430", Offset = "0x13B7630", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FFA")]
	private ExceptionDispatchInfo(Exception exception) { }

	[Address(RVA = "0x13B81A0", Offset = "0x13B73A0", Length = "0x204")]
	[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "SetExceptionFromNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = "System.ValueTuple`2<ExceptionDispatchInfo, Boolean>")]
	[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetCanceled", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutProcessorNative", Member = "UnityEngine.UIElements.Layout.ILayoutProcessor.CalculateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.LayoutNode", typeof(float), typeof(float), "UnityEngine.UIElements.Layout.LayoutDirection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+SynchronousAsyncResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationCanceledException)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomMarshaler))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "SetCancellationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LazyHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeAugments), Member = "ReportUnhandledException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001FFC")]
	public static ExceptionDispatchInfo Capture(Exception source) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FFB")]
	internal object get_BinaryStackTraceArray() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FFD")]
	public Exception get_SourceException() { }

	[Address(RVA = "0x13B83B0", Offset = "0x13B75B0", Length = "0x42")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Exception), Member = "RestoreExceptionDispatchInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[StackTraceHidden]
	[Token(Token = "0x6001FFE")]
	public void Throw() { }

	[Address(RVA = "0x13B8400", Offset = "0x13B7600", Length = "0x22")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.IO.WaitForChangedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.WatcherChangeTypes", typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpDataStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "CheckError", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "DataStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CloseExState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExceptionHelpers", Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[StackTraceHidden]
	[Token(Token = "0x6001FFF")]
	public static void Throw(Exception source) { }

}

