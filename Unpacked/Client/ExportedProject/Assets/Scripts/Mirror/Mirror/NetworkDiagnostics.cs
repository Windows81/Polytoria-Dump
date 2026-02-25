namespace Mirror;

[Token(Token = "0x2000049")]
public static class NetworkDiagnostics
{
	[IsReadOnly]
	[Token(Token = "0x200004A")]
	internal struct MessageInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E8")]
		public readonly NetworkMessage message; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000E9")]
		public readonly int channel; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000EA")]
		public readonly int bytes; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EB")]
		public readonly int count; //Field offset: 0x10

		[Address(RVA = "0x1251860", Offset = "0x1250A60", Length = "0x3D")]
		[CalledBy(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkDiagnostics), Member = "OnSend", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkDiagnostics), Member = "OnReceive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001E4")]
		internal MessageInfo(NetworkMessage message, int channel, int bytes, int count) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x40000E6")]
	private static Action<MessageInfo> OutMessageEvent; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40000E7")]
	private static Action<MessageInfo> InMessageEvent; //Field offset: 0x8

	[Token(Token = "0x14000003")]
	public static event Action<MessageInfo> InMessageEvent
	{
		[Address(RVA = "0x1265B60", Offset = "0x1264D60", Length = "0xDF")]
		[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60001DF")]
		 add { } //Length: 223
		[Address(RVA = "0x1265D20", Offset = "0x1264F20", Length = "0xDF")]
		[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60001E0")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x14000002")]
	public static event Action<MessageInfo> OutMessageEvent
	{
		[Address(RVA = "0x1265C40", Offset = "0x1264E40", Length = "0xD7")]
		[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60001DD")]
		 add { } //Length: 215
		[Address(RVA = "0x1265E00", Offset = "0x1265000", Length = "0xD7")]
		[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60001DE")]
		 remove { } //Length: 215
	}

	[Address(RVA = "0x1265B60", Offset = "0x1264D60", Length = "0xDF")]
	[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60001DF")]
	public static void add_InMessageEvent(Action<MessageInfo> value) { }

	[Address(RVA = "0x1265C40", Offset = "0x1264E40", Length = "0xD7")]
	[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60001DD")]
	public static void add_OutMessageEvent(Action<MessageInfo> value) { }

	[Address(RVA = "0x7104D0", Offset = "0x70F6D0", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(MessageInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkMessage), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E3")]
	internal static void OnReceive(T message, int channel, int bytes) { }

	[Address(RVA = "0x710C50", Offset = "0x70FE50", Length = "0x102")]
	[CalledBy(Type = typeof(NetworkServer), Member = "SendToAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SendToObservers", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), "T", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(MessageInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkMessage), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E2")]
	internal static void OnSend(T message, int channel, int bytes, int count) { }

	[Address(RVA = "0x1265D20", Offset = "0x1264F20", Length = "0xDF")]
	[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60001E0")]
	public static void remove_InMessageEvent(Action<MessageInfo> value) { }

	[Address(RVA = "0x1265E00", Offset = "0x1265000", Length = "0xD7")]
	[CalledBy(Type = "Mirror.NetworkDiagnosticsDebugger", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBandwidthGraph", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60001DE")]
	public static void remove_OutMessageEvent(Action<MessageInfo> value) { }

	[Address(RVA = "0x1265AE0", Offset = "0x1264CE0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x60001E1")]
	private static void ResetStatics() { }

}

