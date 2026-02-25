namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000010")]
public struct AudioPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

}

