namespace Polytoria.Datamodel.Services;

[Token(Token = "0x2000385")]
public class HttpService : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000386")]
	private sealed class <DoRequest>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F64")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000F65")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000F66")]
		public string url; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000F67")]
		public string method; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000F68")]
		public string body; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000F69")]
		public Table headers; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000F6A")]
		public DynValue callback; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000F6B")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x48

		[Token(Token = "0x17000B45")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60025E4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000B46")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60025E6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60025E0")]
		public <DoRequest>d__11(int <>1__state) { }

		[Address(RVA = "0x4910E0", Offset = "0x4902E0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60025E3")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x490670", Offset = "0x48F870", Length = "0x99B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400290")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(ScriptService), Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180482060")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DownloadHandlerBuffer), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Table), Member = "get_Pairs", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.TablePair>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DynValue), Member = "CastToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025E2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60025E4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60025E6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x491010", Offset = "0x490210", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60025E5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x491050", Offset = "0x490250", Length = "0x8C")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180481EA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x60025E1")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000F60")]
	public static HttpService instance; //Field offset: 0x0
	[Token(Token = "0x4000F61")]
	private static int maxRequestsPerMinute; //Field offset: 0x8
	[Token(Token = "0x4000F62")]
	private static int requestsThisMinute; //Field offset: 0xC
	[Token(Token = "0x4000F63")]
	private static int currentMinute; //Field offset: 0x10

	[Address(RVA = "0x487C10", Offset = "0x486E10", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60025DF")]
	private static HttpService() { }

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025DE")]
	public HttpService() { }

	[Address(RVA = "0x487160", Offset = "0x486360", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60025D6")]
	private void Awake() { }

	[Address(RVA = "0x4871D0", Offset = "0x4863D0", Length = "0xE1")]
	[CalledBy(Type = typeof(HttpServiceProxy), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpService), Member = "DoRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025DB")]
	public static void Delete(string url, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x4872C0", Offset = "0x4864C0", Length = "0xD2")]
	[CalledBy(Type = typeof(HttpService), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Put", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Patch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoRequest>d__11))]
	[Token(Token = "0x60025DD")]
	private static IEnumerator DoRequest(string method, string url, string body = null, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x4873A0", Offset = "0x4865A0", Length = "0xE1")]
	[CalledBy(Type = typeof(HttpServiceProxy), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpService), Member = "DoRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025D8")]
	public static void Get(string url, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x487490", Offset = "0x486690", Length = "0xF0")]
	[CalledBy(Type = typeof(HttpServiceProxy), Member = "Patch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpService), Member = "DoRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025DC")]
	public static void Patch(string url, string body, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x487590", Offset = "0x486790", Length = "0xF0")]
	[CalledBy(Type = typeof(HttpServiceProxy), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpService), Member = "DoRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025D9")]
	public static void Post(string url, string body, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x487690", Offset = "0x486890", Length = "0xF0")]
	[CalledBy(Type = typeof(HttpServiceProxy), Member = "Put", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpService), Member = "DoRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025DA")]
	public static void Put(string url, string body, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x487790", Offset = "0x486990", Length = "0x47B")]
	[CalledBy(Type = typeof(HttpService), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Put", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpService), Member = "Patch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptService), Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025D7")]
	private static bool RateLimit(DynValue callback = null) { }

}

