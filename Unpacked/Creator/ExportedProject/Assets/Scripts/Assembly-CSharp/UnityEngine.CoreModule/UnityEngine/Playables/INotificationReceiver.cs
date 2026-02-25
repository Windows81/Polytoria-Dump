namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x2000293")]
public interface INotificationReceiver
{

	[RequiredByNativeCode]
	[Token(Token = "0x6000D19")]
	public void OnNotify(Playable origin, INotification notification, object context) { }

}

