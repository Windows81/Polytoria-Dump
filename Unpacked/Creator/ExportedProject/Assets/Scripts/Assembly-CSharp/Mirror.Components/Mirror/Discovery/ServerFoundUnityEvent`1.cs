namespace Mirror.Discovery;

[Token(Token = "0x2000054")]
public class ServerFoundUnityEvent : UnityEvent<TResponseType>
{

	[Address(RVA = "0xF11670", Offset = "0xF10870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FF")]
	public ServerFoundUnityEvent`1() { }

}

