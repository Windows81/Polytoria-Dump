namespace System.Threading.Tasks;

[Token(Token = "0x200024C")]
internal static class TaskToApm
{
	[CompilerGenerated]
	[Token(Token = "0x200024E")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AA8")]
		public AsyncCallback callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA9")]
		public IAsyncResult asyncResult; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001323")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x1512E80", Offset = "0x1512080", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001324")]
		internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

	}

	[Token(Token = "0x200024D")]
	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AA5")]
		internal readonly Task Task; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA6")]
		private readonly object _state; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AA7")]
		private readonly bool _completedSynchronously; //Field offset: 0x20

		[Token(Token = "0x170001CB")]
		private override object System.IAsyncResult.AsyncState
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x600131F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001CE")]
		private override WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[Address(RVA = "0x15300F0", Offset = "0x152F2F0", Length = "0xBC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x6001322")]
			private get { } //Length: 188
		}

		[Token(Token = "0x170001CC")]
		private override bool System.IAsyncResult.CompletedSynchronously
		{
			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001320")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001CD")]
		private override bool System.IAsyncResult.IsCompleted
		{
			[Address(RVA = "0x15301B0", Offset = "0x152F3B0", Length = "0x5C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001321")]
			private get { } //Length: 92
		}

		[Address(RVA = "0x13A9EC0", Offset = "0x13A90C0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131E")]
		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously) { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131F")]
		private override object System.IAsyncResult.get_AsyncState() { }

		[Address(RVA = "0x15300F0", Offset = "0x152F2F0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001322")]
		private override WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001320")]
		private override bool System.IAsyncResult.get_CompletedSynchronously() { }

		[Address(RVA = "0x15301B0", Offset = "0x152F3B0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001321")]
		private override bool System.IAsyncResult.get_IsCompleted() { }

	}


	[Address(RVA = "0x152FCB0", Offset = "0x152EEB0", Length = "0x221")]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginAuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Security.Cryptography.X509Certificates.X509CertificateCollection", "System.Security.Authentication.SslProtocols", typeof(bool), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(CryptoStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(CryptoStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600131A")]
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	[Address(RVA = "0x152FEE0", Offset = "0x152F0E0", Length = "0xF4")]
	[CalledBy(Type = typeof(CryptoStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "EndAuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600131B")]
	public static void End(IAsyncResult asyncResult) { }

	[Address(RVA = "0x76ADB0", Offset = "0x769FB0", Length = "0x110")]
	[CalledBy(Type = typeof(CryptoStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600131C")]
	public static TResult End(IAsyncResult asyncResult) { }

	[Address(RVA = "0x152FFE0", Offset = "0x152F1E0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600131D")]
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

