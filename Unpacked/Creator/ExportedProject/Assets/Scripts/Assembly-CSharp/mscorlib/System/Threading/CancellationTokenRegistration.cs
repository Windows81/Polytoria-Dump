namespace System.Threading;

[IsReadOnly]
[Token(Token = "0x2000202")]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009B6")]
	private readonly CancellationCallbackInfo m_callbackInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009B7")]
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; //Field offset: 0x8

	[Address(RVA = "0xC89A40", Offset = "0xC88C40", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001155")]
	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[Address(RVA = "0x1508F40", Offset = "0x1508140", Length = "0x140")]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+Linked1CancellationTokenSource", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+Linked2CancellationTokenSource", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContingentProperties), Member = "UnregisterCancellationCallback", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001157")]
	public override void Dispose() { }

	[Address(RVA = "0x1509120", Offset = "0x1508320", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001158")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1509090", Offset = "0x1508290", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001159")]
	public override bool Equals(CancellationTokenRegistration other) { }

	[Address(RVA = "0x1509210", Offset = "0x1508410", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600115A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x15092C0", Offset = "0x15084C0", Length = "0x88")]
	[CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SparselyPopulatedArrayFragment`1), Member = "SafeAtomicRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001156")]
	public bool Unregister() { }

}

