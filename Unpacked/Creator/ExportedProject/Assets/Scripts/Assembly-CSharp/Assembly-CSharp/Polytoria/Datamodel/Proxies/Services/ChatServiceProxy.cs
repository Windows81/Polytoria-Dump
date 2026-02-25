namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D3")]
public class ChatServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400101D")]
	private readonly ChatService chatService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600298E")]
	public ChatServiceProxy(ChatService target) { }

	[Address(RVA = "0x4A17B0", Offset = "0x4A09B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatService), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600298F")]
	public void BroadcastMessage(string message) { }

	[Address(RVA = "0x4A17D0", Offset = "0x4A09D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatService), Member = "UnicastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Player)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002990")]
	public void UnicastMessage(string message, Player player) { }

}

