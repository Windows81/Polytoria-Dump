namespace System.Threading;

[Token(Token = "0x200021E")]
public sealed class ExecutionContext : IDisposable, ISerializable
{
	[Flags]
	[Token(Token = "0x2000221")]
	public enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2,
	}

	[Token(Token = "0x200021F")]
	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4,
	}

	[Token(Token = "0x2000220")]
	public struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A15")]
		private ExecutionContext m_ec; //Field offset: 0x0

		[Token(Token = "0x170001B0")]
		public bool IsFlowSuppressed
		{
			[Address(RVA = "0x15162E0", Offset = "0x15154E0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60011FA")]
			 get { } //Length: 20
		}

		[Token(Token = "0x170001AF")]
		public bool IsNull
		{
			[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
			[CallerCount(Count = 8)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x60011F8")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170001B3")]
		public Reader LogicalCallContext
		{
			[Address(RVA = "0x1516300", Offset = "0x1515500", Length = "0x34")]
			[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x60011FD")]
			 get { } //Length: 52
		}

		[Token(Token = "0x170001B1")]
		public SynchronizationContext SynchronizationContext
		{
			[Address(RVA = "0x1516360", Offset = "0x1515560", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60011FB")]
			 get { } //Length: 17
		}

		[Token(Token = "0x170001B2")]
		public SynchronizationContext SynchronizationContextNoFlow
		{
			[Address(RVA = "0x1516340", Offset = "0x1515540", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60011FC")]
			 get { } //Length: 17
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011F6")]
		public Reader(ExecutionContext ec) { }

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011F7")]
		public ExecutionContext DangerousGetRawExecutionContext() { }

		[Address(RVA = "0x15162E0", Offset = "0x15154E0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011FA")]
		public bool get_IsFlowSuppressed() { }

		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60011F8")]
		public bool get_IsNull() { }

		[Address(RVA = "0x1516300", Offset = "0x1515500", Length = "0x34")]
		[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60011FD")]
		public Reader get_LogicalCallContext() { }

		[Address(RVA = "0x1516360", Offset = "0x1515560", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60011FB")]
		public SynchronizationContext get_SynchronizationContext() { }

		[Address(RVA = "0x1516340", Offset = "0x1515540", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60011FC")]
		public SynchronizationContext get_SynchronizationContextNoFlow() { }

		[Address(RVA = "0x1516250", Offset = "0x1515450", Length = "0x24")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011FE")]
		public bool HasSameLocalValues(ExecutionContext other) { }

		[Address(RVA = "0x1516280", Offset = "0x1515480", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60011F9")]
		public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	}

	[Token(Token = "0x4000A0E")]
	private static readonly ExecutionContext s_dummyDefaultEC; //Field offset: 0x0
	[Token(Token = "0x4000A0F")]
	internal static readonly ExecutionContext Default; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A07")]
	private SynchronizationContext _syncContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A08")]
	private SynchronizationContext _syncContextNoFlow; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A09")]
	private LogicalCallContext _logicalCallContext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A0A")]
	private IllogicalCallContext _illogicalCallContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A0B")]
	private Flags _flags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A0C")]
	private Dictionary<IAsyncLocal, Object> _localValues; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A0D")]
	private List<IAsyncLocal> _localChangeNotifications; //Field offset: 0x40

	[Token(Token = "0x170001AC")]
	internal IllogicalCallContext IllogicalCallContext
	{
		[Address(RVA = "0x1512D30", Offset = "0x1511F30", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60011DE")]
		internal get { } //Length: 105
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001A9")]
	internal bool isFlowSuppressed
	{
		[Address(RVA = "0x1512E20", Offset = "0x1512020", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011D6")]
		internal get { } //Length: 8
		[Address(RVA = "0x1512E40", Offset = "0x1512040", Length = "0x19")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011D7")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x170001A8")]
	internal bool isNewCapture
	{
		[Address(RVA = "0x1512E30", Offset = "0x1512030", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011D4")]
		internal get { } //Length: 8
		[Address(RVA = "0x1512E60", Offset = "0x1512060", Length = "0x19")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011D5")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x170001AA")]
	internal bool IsPreAllocatedDefault
	{
		[Address(RVA = "0x1512DA0", Offset = "0x1511FA0", Length = "0x9")]
		[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60011D8")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170001AB")]
	internal LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x1512DB0", Offset = "0x1511FB0", Length = "0x69")]
		[CalledBy(Type = typeof(Reader), Member = "get_LogicalCallContext", ReturnType = typeof(Reader))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
		[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(CallContext), Member = "SetLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(LogicalCallContext))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60011DC")]
		internal get { } //Length: 105
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DD")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001AD")]
	internal SynchronizationContext SynchronizationContext
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60011E0")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60011E1")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001AE")]
	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60011E2")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60011E3")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1512B00", Offset = "0x1511D00", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011F5")]
	private static ExecutionContext() { }

	[Address(RVA = "0x1512BF0", Offset = "0x1511DF0", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F3")]
	private ExecutionContext(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011D9")]
	internal ExecutionContext() { }

	[Address(RVA = "0x1512BC0", Offset = "0x1511DC0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011DA")]
	internal ExecutionContext(bool isPreAllocatedDefault) { }

	[Address(RVA = "0x1511730", Offset = "0x1510930", Length = "0x245")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "FastCapture", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Reader), Member = "Clone", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(Reader), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011F1")]
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options) { }

	[Address(RVA = "0x1511980", Offset = "0x1510B80", Length = "0x48")]
	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+ReadWriteTask", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.RemoteCertificateValidationCallback"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_ServerCertificateValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.RemoteCertificateValidationCallback"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[Token(Token = "0x60011EF")]
	public static ExecutionContext Capture() { }

	[Address(RVA = "0x15119D0", Offset = "0x1510BD0", Length = "0x182")]
	[CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), "System.Security.Cryptography.X509Certificates.X509Chain", "System.Net.Security.SslPolicyErrors"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011EC")]
	public ExecutionContext CreateCopy() { }

	[Address(RVA = "0x1511B60", Offset = "0x1510D60", Length = "0x1A0")]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(IllogicalCallContext), Member = "CreateCopy", ReturnType = typeof(IllogicalCallContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011ED")]
	internal ExecutionContext CreateMutableCopy() { }

	[Address(RVA = "0x40DBA0", Offset = "0x40CDA0", Length = "0x3")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E4")]
	public override void Dispose() { }

	[Address(RVA = "0x1511D10", Offset = "0x1510F10", Length = "0xDB")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011E9")]
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	[Address(RVA = "0x1511DF0", Offset = "0x1510FF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EA")]
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[Address(RVA = "0x1511E60", Offset = "0x1511060", Length = "0x4B")]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[FriendAccessAllowed]
	[Token(Token = "0x60011F0")]
	internal static ExecutionContext FastCapture() { }

	[Address(RVA = "0x1512D30", Offset = "0x1511F30", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011DE")]
	internal IllogicalCallContext get_IllogicalCallContext() { }

	[Address(RVA = "0x1512E20", Offset = "0x1512020", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011D6")]
	internal bool get_isFlowSuppressed() { }

	[Address(RVA = "0x1512E30", Offset = "0x1512030", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011D4")]
	internal bool get_isNewCapture() { }

	[Address(RVA = "0x1512DA0", Offset = "0x1511FA0", Length = "0x9")]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60011D8")]
	internal bool get_IsPreAllocatedDefault() { }

	[Address(RVA = "0x1512DB0", Offset = "0x1511FB0", Length = "0x69")]
	[CalledBy(Type = typeof(Reader), Member = "get_LogicalCallContext", ReturnType = typeof(Reader))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CallContext), Member = "SetLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(LogicalCallContext))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011DC")]
	internal LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011E0")]
	internal SynchronizationContext get_SynchronizationContext() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011E2")]
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[Address(RVA = "0x1511EB0", Offset = "0x15110B0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011F2")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1511FA0", Offset = "0x15111A0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F4")]
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	[Address(RVA = "0x1511FF0", Offset = "0x15111F0", Length = "0x81")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetRequestStreamAsync", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetResponseAsync", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EE")]
	public static bool IsFlowSuppressed() { }

	[Address(RVA = "0x1512080", Offset = "0x1511280", Length = "0x3B4")]
	[CalledBy(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(bool)}, ReturnType = typeof(ExecutionContextSwitcher))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019C5D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Environment), Member = "FailFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[HandleProcessCorruptedStateExceptions]
	[Token(Token = "0x60011DB")]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	[Address(RVA = "0x15127F0", Offset = "0x15119F0", Length = "0x15E")]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadHelper), Member = "ThreadStart", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), "System.Security.Cryptography.X509Certificates.X509Chain", "System.Net.Security.SslPolicyErrors"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CancellationCallbackInfo), Member = "ExecuteCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadHelper), Member = "ThreadStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011E5")]
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[Address(RVA = "0x1512760", Offset = "0x1511960", Length = "0x81")]
	[CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveNextRunner), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[FriendAccessAllowed]
	[Token(Token = "0x60011E6")]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[Address(RVA = "0x15126E0", Offset = "0x15118E0", Length = "0x73")]
	[CalledBy(Type = "System.IO.Stream+ReadWriteTask", Member = "System.Threading.Tasks.ITaskCompletionAction.Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011E7")]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[Address(RVA = "0x1512440", Offset = "0x1511640", Length = "0x296")]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(bool)}, ReturnType = typeof(ExecutionContextSwitcher))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[HandleProcessCorruptedStateExceptions]
	[Token(Token = "0x60011E8")]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DF")]
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[Address(RVA = "0x1512E40", Offset = "0x1512040", Length = "0x19")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011D7")]
	internal void set_isFlowSuppressed(bool value) { }

	[Address(RVA = "0x1512E60", Offset = "0x1512060", Length = "0x19")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011D5")]
	internal void set_isNewCapture(bool value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DD")]
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011E1")]
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011E3")]
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	[Address(RVA = "0x1512950", Offset = "0x1511B50", Length = "0x1AD")]
	[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "UndoNoThrow", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ExecutionContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[HandleProcessCorruptedStateExceptions]
	[Token(Token = "0x60011EB")]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

}

