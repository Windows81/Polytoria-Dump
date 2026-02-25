namespace Mirror.RemoteCalls;

[Token(Token = "0x20000A6")]
public static class RemoteProcedureCalls
{
	[Token(Token = "0x4000225")]
	public const string InvokeRpcPrefix = "InvokeUserCode_"; //Field offset: 0x0
	[Token(Token = "0x4000226")]
	private static readonly Dictionary<UInt16, Invoker> remoteCallDelegates; //Field offset: 0x0

	[Address(RVA = "0x12A3040", Offset = "0x12A2240", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000529")]
	private static RemoteProcedureCalls() { }

	[Address(RVA = "0x12A24E0", Offset = "0x12A16E0", Length = "0x364")]
	[CalledBy(Type = typeof(RemoteProcedureCalls), Member = "RegisterDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallType), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600051F")]
	private static bool CheckIfDelegateExists(Type componentType, RemoteCallType remoteCallType, RemoteCallDelegate func, ushort functionHash) { }

	[Address(RVA = "0x12A2850", Offset = "0x12A1A50", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000527")]
	internal static bool CommandRequiresAuthority(ushort cmdHash) { }

	[Address(RVA = "0x12A2930", Offset = "0x12A1B30", Length = "0xA1")]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler+MessageStats", Member = "RecordRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(MessageInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000528")]
	public static RemoteCallDelegate GetDelegate(ushort functionHash) { }

	[Address(RVA = "0x12A29E0", Offset = "0x12A1BE0", Length = "0x13D")]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnCommandMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(CommandMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000524")]
	internal static bool GetFunctionMethodName(ushort functionHash, out string methodName) { }

	[Address(RVA = "0x12A2B20", Offset = "0x12A1D20", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000525")]
	private static bool GetInvokerForHash(ushort functionHash, RemoteCallType remoteCallType, out Invoker invoker) { }

	[Address(RVA = "0x12A2BE0", Offset = "0x12A1DE0", Length = "0x14C")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "HandleRemoteCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ushort), typeof(RemoteCallType), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000526")]
	internal static bool Invoke(ushort functionHash, RemoteCallType remoteCallType, NetworkReader reader, NetworkBehaviour component, NetworkConnectionToClient senderConnection = null) { }

	[Address(RVA = "0x12A2D30", Offset = "0x12A1F30", Length = "0x85")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkLerpRigidbody", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviourHybrid), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ChatService", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.RemoteEvent", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PlayerDefaults", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NetworkEvent", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.DynamicInstance", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "PurchasesService", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 56)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallType), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000521")]
	public static void RegisterCommand(Type componentType, string functionFullName, RemoteCallDelegate func, bool requiresAuthority) { }

	[Address(RVA = "0x12A2DC0", Offset = "0x12A1FC0", Length = "0x179")]
	[CalledBy(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "CheckIfDelegateExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RemoteCallType), typeof(RemoteCallDelegate), typeof(ushort)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000520")]
	internal static ushort RegisterDelegate(Type componentType, string functionFullName, RemoteCallType remoteCallType, RemoteCallDelegate func, bool cmdRequiresAuthority = true) { }

	[Address(RVA = "0x12A2F40", Offset = "0x12A2140", Length = "0x7B")]
	[CallerCount(Count = 114)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallType), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000522")]
	public static void RegisterRpc(Type componentType, string functionFullName, RemoteCallDelegate func) { }

	[Address(RVA = "0x12A2FC0", Offset = "0x12A21C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000523")]
	internal static void RemoveDelegate(ushort hash) { }

}

