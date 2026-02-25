namespace GLTFast.Loading;

[Token(Token = "0x20000E7")]
public class AwaitableDownload : IDownload, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20000E8")]
	private struct <WaitAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003A2")]
		public AwaitableDownload <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003A3")]
		private YieldAwaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1093810", Offset = "0x1092A10", Length = "0x1F7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AsyncOperation), Member = "get_isDone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60002B9")]
		private override void MoveNext() { }

		[Address(RVA = "0x1093A10", Offset = "0x1092C10", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60002BA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039E")]
	protected UnityWebRequest m_Request; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400039F")]
	protected UnityWebRequestAsyncOperation m_AsyncOperation; //Field offset: 0x18

	[Token(Token = "0x1700008C")]
	public override Byte[] Data
	{
		[Address(RVA = "0x1087FF0", Offset = "0x10871F0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60002B5")]
		 get { } //Length: 51
	}

	[Token(Token = "0x1700008B")]
	public override string Error
	{
		[Address(RVA = "0x1088030", Offset = "0x1087230", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Token(Token = "0x60002B4")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700008E")]
	public override Nullable<Boolean> IsBinary
	{
		[Address(RVA = "0x1088080", Offset = "0x1087280", Length = "0x126")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetResponseHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60002B7")]
		 get { } //Length: 294
	}

	[Token(Token = "0x1700008A")]
	public override bool Success
	{
		[Address(RVA = "0x10881B0", Offset = "0x10873B0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60002B3")]
		 get { } //Length: 72
	}

	[Token(Token = "0x1700008D")]
	public override string Text
	{
		[Address(RVA = "0x1088200", Offset = "0x1087400", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60002B6")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AF")]
	protected AwaitableDownload() { }

	[Address(RVA = "0x1087F80", Offset = "0x1087180", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B0")]
	public AwaitableDownload(Uri url) { }

	[Address(RVA = "0x1087E10", Offset = "0x1087010", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002B8")]
	public override void Dispose() { }

	[Address(RVA = "0x1087FF0", Offset = "0x10871F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002B5")]
	public override Byte[] get_Data() { }

	[Address(RVA = "0x1088030", Offset = "0x1087230", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[Token(Token = "0x60002B4")]
	public override string get_Error() { }

	[Address(RVA = "0x1088080", Offset = "0x1087280", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetResponseHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002B7")]
	public override Nullable<Boolean> get_IsBinary() { }

	[Address(RVA = "0x10881B0", Offset = "0x10873B0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B3")]
	public override bool get_Success() { }

	[Address(RVA = "0x1088200", Offset = "0x1087400", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002B6")]
	public override string get_Text() { }

	[Address(RVA = "0x1087E50", Offset = "0x1087050", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002B1")]
	private void Init(Uri url) { }

	[Address(RVA = "0x1087EB0", Offset = "0x10870B0", Length = "0xC5")]
	[AsyncStateMachine(typeof(<WaitAsync>d__7))]
	[CalledBy(Type = "GLTFast.Loading.DefaultDownloadProvider+<Request>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Loading.DefaultDownloadProvider+<RequestTexture>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitAsync>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitAsync>d__7&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B2")]
	public Task WaitAsync() { }

}

