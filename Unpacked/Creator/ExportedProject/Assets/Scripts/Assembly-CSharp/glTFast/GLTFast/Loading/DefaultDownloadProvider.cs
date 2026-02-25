namespace GLTFast.Loading;

[Token(Token = "0x20000E4")]
public class DefaultDownloadProvider : IDownloadProvider
{
	[CompilerGenerated]
	[Token(Token = "0x20000E5")]
	private struct <Request>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000393")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder<IDownload> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000395")]
		public Uri url; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000396")]
		private AwaitableDownload <req>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000397")]
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1093560", Offset = "0x1092760", Length = "0x235")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AwaitableDownload), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<Request>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<Request>d__0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60002AB")]
		private override void MoveNext() { }

		[Address(RVA = "0x10937A0", Offset = "0x10929A0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60002AC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E6")]
	private struct <RequestTexture>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000398")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000399")]
		public AsyncTaskMethodBuilder<ITextureDownload> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400039A")]
		public Uri url; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400039B")]
		public bool nonReadable; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400039C")]
		private AwaitableTextureDownload <req>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400039D")]
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x1093290", Offset = "0x1092490", Length = "0x251")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AwaitableDownload), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<RequestTexture>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<RequestTexture>d__1&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60002AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x10934F0", Offset = "0x10926F0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60002AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AA")]
	public DefaultDownloadProvider() { }

	[Address(RVA = "0x108C8E0", Offset = "0x108BAE0", Length = "0xEC")]
	[AsyncStateMachine(typeof(<Request>d__0))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Request>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Request>d__0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002A8")]
	public override Task<IDownload> Request(Uri url) { }

	[Address(RVA = "0x108C7D0", Offset = "0x108B9D0", Length = "0x10E")]
	[AsyncStateMachine(typeof(<RequestTexture>d__1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestTexture>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestTexture>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002A9")]
	public override Task<ITextureDownload> RequestTexture(Uri url, bool nonReadable) { }

}

