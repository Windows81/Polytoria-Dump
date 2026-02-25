namespace Mirror;

[Token(Token = "0x2000061")]
public static class NetworkReaderPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000062")]
	private sealed class <>c
	{
		[Token(Token = "0x4000154")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x12A45B0", Offset = "0x12A37B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002F9")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FA")]
		public <>c() { }

		[Address(RVA = "0x12A4230", Offset = "0x12A3430", Length = "0x11A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ArraySegment`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.ArraySegment`1<T>")]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002FB")]
		internal NetworkReaderPooled <.cctor>b__6_0() { }

	}

	[Token(Token = "0x4000153")]
	private static readonly Pool<NetworkReaderPooled> Pool; //Field offset: 0x0

	[Token(Token = "0x1700004E")]
	public static int Count
	{
		[Address(RVA = "0x12934B0", Offset = "0x12926B0", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002F4")]
		 get { } //Length: 111
	}

	[Address(RVA = "0x12933A0", Offset = "0x12925A0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Pool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F8")]
	private static NetworkReaderPool() { }

	[Address(RVA = "0x1293190", Offset = "0x1292390", Length = "0x12A")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "UserCode_CmdOnAnimationServerMessage__Int32__Single__Int32__Single__Byte[]", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(int), typeof(float), "System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "UserCode_CmdOnAnimationParametersServerMessage__Byte[]", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "UserCode_RpcOnAnimationClientMessage__Int32__Single__Int32__Single__Byte[]", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(int), typeof(float), "System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "UserCode_RpcOnAnimationParametersClientMessage__Byte[]", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2+<ReceiveGameBroadcastAsync>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2+<ReceiveRequestAsync>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ArraySegment`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.ArraySegment`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F5")]
	public static NetworkReaderPooled Get(Byte[] bytes) { }

	[Address(RVA = "0x12930B0", Offset = "0x12922B0", Length = "0xDF")]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnCommandMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(CommandMessage), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "RawReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>&", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "RawReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnEntityStateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(EntityStateMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnEntityStateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityStateMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnRPCMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RpcMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviourHybrid), Member = "UserCode_CmdClientToServerDelta__ArraySegment`1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviourHybrid), Member = "UserCode_CmdClientToServerBaseline__ArraySegment`1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviourHybrid), Member = "UserCode_RpcServerToClientDelta__ArraySegment`1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviourHybrid), Member = "UserCode_RpcServerToClientBaseline__ArraySegment`1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F6")]
	public static NetworkReaderPooled Get(ArraySegment<Byte> segment) { }

	[Address(RVA = "0x12934B0", Offset = "0x12926B0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F4")]
	public static int get_Count() { }

	[Address(RVA = "0x12932C0", Offset = "0x12924C0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60002F7")]
	public static void Return(NetworkReaderPooled reader) { }

}

