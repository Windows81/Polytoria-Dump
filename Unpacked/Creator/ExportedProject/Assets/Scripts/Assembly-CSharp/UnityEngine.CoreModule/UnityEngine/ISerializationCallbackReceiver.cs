namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x2000177")]
public interface ISerializationCallbackReceiver
{

	[RequiredByNativeCode]
	[Token(Token = "0x6000A7A")]
	public void OnAfterDeserialize() { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000A79")]
	public void OnBeforeSerialize() { }

}

