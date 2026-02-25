namespace UnityEngine;

[Token(Token = "0x2000108")]
internal interface IPlayerEditorConnectionNative
{

	[Token(Token = "0x600085B")]
	public void DisconnectAll() { }

	[Token(Token = "0x600085A")]
	public void Initialize() { }

	[Token(Token = "0x6000861")]
	public bool IsConnected() { }

	[Token(Token = "0x600085E")]
	public void Poll() { }

	[Token(Token = "0x600085F")]
	public void RegisterInternal(Guid messageId) { }

	[Token(Token = "0x600085C")]
	public void SendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Token(Token = "0x600085D")]
	public bool TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Token(Token = "0x6000860")]
	public void UnregisterInternal(Guid messageId) { }

}

