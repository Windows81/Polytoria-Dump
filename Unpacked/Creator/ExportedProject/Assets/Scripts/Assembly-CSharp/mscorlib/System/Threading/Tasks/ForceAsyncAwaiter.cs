namespace System.Threading.Tasks;

[IsReadOnly]
[Token(Token = "0x2000256")]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ABB")]
	private readonly Task _task; //Field offset: 0x0

	[Token(Token = "0x170001D4")]
	public bool IsCompleted
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600134F")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600134D")]
	internal ForceAsyncAwaiter(Task task) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600134F")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600134E")]
	public ForceAsyncAwaiter GetAwaiter() { }

	[Address(RVA = "0x1529FE0", Offset = "0x15291E0", Length = "0x3B")]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001350")]
	public void GetResult() { }

	[Address(RVA = "0x152A020", Offset = "0x1529220", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001351")]
	public override void UnsafeOnCompleted(Action action) { }

}

