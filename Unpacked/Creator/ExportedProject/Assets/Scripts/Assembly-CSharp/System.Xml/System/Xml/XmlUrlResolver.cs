namespace System.Xml;

[Token(Token = "0x20000BB")]
public class XmlUrlResolver : XmlResolver
{
	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private struct <GetEntityAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000441")]
		public Type ofObjectToReturn; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000442")]
		public Uri absoluteUri; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000443")]
		public XmlUrlResolver <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000444")]
		private ConfiguredTaskAwaiter<Stream> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x16B3580", Offset = "0x16B2780", Length = "0x333")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<GetEntityAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<GetEntityAsync>d__15&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlDownloadManager), Member = "GetStreamAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
		[Calls(Type = typeof(XmlUrlResolver), Member = "get_DownloadManager", ReturnType = typeof(XmlDownloadManager))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x6000835")]
		private override void MoveNext() { }

		[Address(RVA = "0x16B38C0", Offset = "0x16B2AC0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000836")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x400043B")]
	private static object s_DownloadManager; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400043C")]
	private ICredentials _credentials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400043D")]
	private IWebProxy _proxy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400043E")]
	private RequestCachePolicy _cachePolicy; //Field offset: 0x20

	[Token(Token = "0x170001D5")]
	private static XmlDownloadManager DownloadManager
	{
		[Address(RVA = "0x16BAA00", Offset = "0x16B9C00", Length = "0xD8")]
		[CalledBy(Type = typeof(<GetEntityAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlUrlResolver), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000830")]
		private get { } //Length: 216
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000831")]
	public XmlUrlResolver() { }

	[Address(RVA = "0x16BAA00", Offset = "0x16B9C00", Length = "0xD8")]
	[CalledBy(Type = typeof(<GetEntityAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUrlResolver), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000830")]
	private static XmlDownloadManager get_DownloadManager() { }

	[Address(RVA = "0x16BA870", Offset = "0x16B9A70", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUrlResolver), Member = "get_DownloadManager", ReturnType = typeof(XmlDownloadManager))]
	[Calls(Type = typeof(XmlDownloadManager), Member = "GetStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000832")]
	public virtual object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[Address(RVA = "0x16BA720", Offset = "0x16B9920", Length = "0x148")]
	[AsyncStateMachine(typeof(<GetEntityAsync>d__15))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetEntityAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetEntityAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000834")]
	public virtual Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[Address(RVA = "0x16BA9F0", Offset = "0x16B9BF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(Uri))]
	[Token(Token = "0x6000833")]
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

}

