namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder`1))]
[IsReadOnly]
[Token(Token = "0x2000252")]
public struct ValueTask : IEquatable<ValueTask`1<TResult>>
{
	[Token(Token = "0x2000253")]
	private sealed class ValueTaskSourceAsTask : Task<TResult>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000254")]
		private sealed class <>c
		{
			[Token(Token = "0x4000ABA")]
			public static readonly <>c<TResult> <>9; //Field offset: 0x0

			[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001349")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600134A")]
			public <>c() { }

			[Address(RVA = "0x7FA0D0", Offset = "0x7F92D0", Length = "0x1DC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
			[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			[Token(Token = "0x600134B")]
			internal void <.cctor>b__4_0(object state) { }

		}

		[Token(Token = "0x4000AB7")]
		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB8")]
		private IValueTaskSource<TResult> _source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB9")]
		private readonly short _token; //Field offset: 0x0

		[Address(RVA = "0x86FCD0", Offset = "0x86EED0", Length = "0x172")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001348")]
		private static ValueTaskSourceAsTask() { }

		[Address(RVA = "0x870160", Offset = "0x86F360", Length = "0x115")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036B60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001347")]
		public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token) { }

	}

	[Token(Token = "0x4000AB2")]
	private static Task<TResult> s_canceledTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB3")]
	internal readonly object _obj; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB4")]
	internal readonly TResult _result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB5")]
	internal readonly short _token; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB6")]
	internal readonly bool _continueOnCapturedContext; //Field offset: 0x0

	[Token(Token = "0x170001D1")]
	public bool IsCompleted
	{
		[Address(RVA = "0x872400", Offset = "0x871600", Length = "0xFC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001341")]
		 get { } //Length: 252
	}

	[Token(Token = "0x170001D2")]
	public bool IsCompletedSuccessfully
	{
		[Address(RVA = "0x872300", Offset = "0x871500", Length = "0xFD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001342")]
		 get { } //Length: 253
	}

	[Token(Token = "0x170001D3")]
	public TResult Result
	{
		[Address(RVA = "0x872500", Offset = "0x871700", Length = "0x110")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001343")]
		 get { } //Length: 272
	}

	[Address(RVA = "0x8721E0", Offset = "0x8713E0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001338")]
	public ValueTask`1(TResult result) { }

	[Address(RVA = "0x872210", Offset = "0x871410", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001339")]
	public ValueTask`1(Task<TResult> task) { }

	[Address(RVA = "0x8722A0", Offset = "0x8714A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600133A")]
	public ValueTask`1(IValueTaskSource<TResult> source, short token) { }

	[Address(RVA = "0x872260", Offset = "0x871460", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600133B")]
	private ValueTask`1(object obj, TResult result, short token, bool continueOnCapturedContext) { }

	[Address(RVA = "0x870510", Offset = "0x86F710", Length = "0x13A")]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "GetTaskForResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600133F")]
	public Task<TResult> AsTask() { }

	[Address(RVA = "0x870650", Offset = "0x86F850", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001345")]
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0x8707B0", Offset = "0x86F9B0", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x600133D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x870710", Offset = "0x86F910", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600133E")]
	public override bool Equals(ValueTask<TResult> other) { }

	[Address(RVA = "0x872400", Offset = "0x871600", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001341")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x872300", Offset = "0x871500", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001342")]
	public bool get_IsCompletedSuccessfully() { }

	[Address(RVA = "0x872500", Offset = "0x871700", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001343")]
	public TResult get_Result() { }

	[Address(RVA = "0x870E10", Offset = "0x870010", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001344")]
	public ValueTaskAwaiter<TResult> GetAwaiter() { }

	[Address(RVA = "0x871290", Offset = "0x870490", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600133C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x8712F0", Offset = "0x8704F0", Length = "0x52C")]
	[CalledBy(Type = typeof(ValueTask`1), Member = "AsTask", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "GetTaskForResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036B60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001340")]
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }

	[Address(RVA = "0x871E60", Offset = "0x871060", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036D40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036F40")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001346")]
	public virtual string ToString() { }

}

