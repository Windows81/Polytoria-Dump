namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003AF")]
public class NetworkEventProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF9")]
	private readonly NetworkEvent networkEvent; //Field offset: 0x18

	[LuaEventParameter((Type) null, "sender", False)]
	[LuaEventParameter(typeof(NetMessage), "message", False)]
	[Token(Token = "0x17000BBD")]
	public LuaEvent InvokedClient
	{
		[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002797")]
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Player), "sender", False)]
	[LuaEventParameter(typeof(NetMessage), "message", False)]
	[Token(Token = "0x17000BBC")]
	public LuaEvent InvokedServer
	{
		[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002796")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002795")]
	public NetworkEventProxy(NetworkEvent target) { }

	[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002797")]
	public LuaEvent get_InvokedClient() { }

	[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002796")]
	public LuaEvent get_InvokedServer() { }

	[Address(RVA = "0x4A62D0", Offset = "0x4A54D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkEvent), Member = "InvokeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetMessage), typeof(Player)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002799")]
	public void InvokeClient(NetMessage msg, Player player) { }

	[Address(RVA = "0x4A62F0", Offset = "0x4A54F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkEvent), Member = "InvokeClients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279A")]
	public void InvokeClients(NetMessage msg) { }

	[Address(RVA = "0x4A6310", Offset = "0x4A5510", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002798")]
	public void InvokeServer(NetMessage msg) { }

}

