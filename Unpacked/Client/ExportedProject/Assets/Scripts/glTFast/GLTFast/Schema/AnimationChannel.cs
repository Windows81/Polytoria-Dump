namespace GLTFast.Schema;

[Token(Token = "0x2000082")]
public class AnimationChannel : AnimationChannelBase<AnimationChannelTarget>
{

	[Address(RVA = "0x10730E0", Offset = "0x10722E0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BC")]
	public AnimationChannel() { }

}

