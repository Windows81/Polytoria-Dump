namespace UnityEngine.Playables;

[Token(Token = "0x2000294")]
public interface IPlayableBehaviour
{

	[RequiredByNativeCode]
	[Token(Token = "0x6000D1F")]
	public void OnBehaviourPause(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D1E")]
	public void OnBehaviourPlay(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D1A")]
	public void OnGraphStart(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D1B")]
	public void OnGraphStop(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D1C")]
	public void OnPlayableCreate(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D1D")]
	public void OnPlayableDestroy(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D20")]
	public void PrepareFrame(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	[Token(Token = "0x6000D21")]
	public void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

