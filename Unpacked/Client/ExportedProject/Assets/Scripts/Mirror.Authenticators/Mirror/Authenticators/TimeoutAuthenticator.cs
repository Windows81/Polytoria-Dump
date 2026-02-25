namespace Mirror.Authenticators;

[AddComponentMenu("Network/ Authenticators/Timeout Authenticator")]
[Token(Token = "0x200000B")]
public class TimeoutAuthenticator : NetworkAuthenticator
{
	[CompilerGenerated]
	[Token(Token = "0x200000C")]
	private sealed class <BeginAuthentication>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000017")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000018")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000019")]
		public TimeoutAuthenticator <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400001A")]
		public NetworkConnection conn; //Field offset: 0x28

		[Token(Token = "0x17000003")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000029")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000004")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600002B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000026")]
		public <BeginAuthentication>d__9(int <>1__state) { }

		[Address(RVA = "0x10AA220", Offset = "0x10A9420", Length = "0x12A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000029")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600002B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x10AA350", Offset = "0x10A9550", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600002A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000015")]
	public NetworkAuthenticator authenticator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0, 600)]
	[Token(Token = "0x4000016")]
	[Tooltip("Timeout to auto-disconnect in seconds. Set to 0 for no timeout.")]
	public float timeout; //Field offset: 0x38

	[Address(RVA = "0x10AA210", Offset = "0x10A9410", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkAuthenticator), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000024")]
	public TimeoutAuthenticator() { }

	[Address(RVA = "0x10AA1B0", Offset = "0x10A93B0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	private void <Awake>b__2_0(NetworkConnectionToClient connection) { }

	[Address(RVA = "0x10A9E00", Offset = "0x10A9000", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600001C")]
	public void Awake() { }

	[Address(RVA = "0x10A9F10", Offset = "0x10A9110", Length = "0x84")]
	[CalledBy(Type = typeof(TimeoutAuthenticator), Member = "OnServerAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeoutAuthenticator), Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<BeginAuthentication>d__9))]
	[Token(Token = "0x6000023")]
	private IEnumerator BeginAuthentication(NetworkConnection conn) { }

	[Address(RVA = "0x10A9FA0", Offset = "0x10A91A0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeoutAuthenticator), Member = "BeginAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnection)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public virtual void OnClientAuthenticate() { }

	[Address(RVA = "0x10AA080", Offset = "0x10A9280", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeoutAuthenticator), Member = "BeginAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnection)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public virtual void OnServerAuthenticate(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x10AA0F0", Offset = "0x10A92F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public virtual void OnStartClient() { }

	[Address(RVA = "0x10AA120", Offset = "0x10A9320", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	public virtual void OnStartServer() { }

	[Address(RVA = "0x10AA150", Offset = "0x10A9350", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000020")]
	public virtual void OnStopClient() { }

	[Address(RVA = "0x10AA180", Offset = "0x10A9380", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	public virtual void OnStopServer() { }

}

