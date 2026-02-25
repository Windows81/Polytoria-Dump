namespace GLTFast.Loading;

[Token(Token = "0x20000EE")]
internal class TextureDownload : TextureDownloadBase
{
	[CompilerGenerated]
	[Token(Token = "0x20000EF")]
	private struct <Load>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A8")]
		public TextureDownload<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A9")]
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x812A40", Offset = "0x811C40", Length = "0x201")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), "GLTFast.Loading.TextureDownload`1<Object>+<Load>d__2<Object>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<Load>d__2<Object>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x812FE0", Offset = "0x8121E0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003A5")]
	private Task<T> m_Task; //Field offset: 0x0

	[Address(RVA = "0xFF7F30", Offset = "0xFF7130", Length = "0x31")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Uri), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CB")]
	public TextureDownload`1(Task<T> task) { }

	[Address(RVA = "0xFF7E60", Offset = "0xFF7060", Length = "0xD0")]
	[AsyncStateMachine(typeof(<Load>d__2))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Loading.TextureDownload`1<Object>+<Load>d__2<Object>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__2<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CC")]
	public virtual Task Load() { }

}

