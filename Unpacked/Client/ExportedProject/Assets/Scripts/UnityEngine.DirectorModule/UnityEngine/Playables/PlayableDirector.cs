namespace UnityEngine.Playables;

[HelpURL("https://docs.unity3d.com/ScriptReference/Playables.PlayableDirector.html")]
[NativeHeader("Modules/Director/PlayableDirector.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000004")]
public class PlayableDirector : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private Action<PlayableDirector> played; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000003")]
	private Action<PlayableDirector> paused; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000004")]
	private Action<PlayableDirector> stopped; //Field offset: 0x28

	[Address(RVA = "0x19947B0", Offset = "0x19939B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000006")]
	private void SendOnPlayableDirectorPause() { }

	[Address(RVA = "0x19947D0", Offset = "0x19939D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000005")]
	private void SendOnPlayableDirectorPlay() { }

	[Address(RVA = "0x19947F0", Offset = "0x19939F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000007")]
	private void SendOnPlayableDirectorStop() { }

}

