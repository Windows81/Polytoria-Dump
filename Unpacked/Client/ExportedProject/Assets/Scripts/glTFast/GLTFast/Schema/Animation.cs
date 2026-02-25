namespace GLTFast.Schema;

[Token(Token = "0x200008E")]
public class Animation : AnimationBase<AnimationChannel, AnimationSampler>
{

	[Address(RVA = "0x10731C0", Offset = "0x10723C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001CE")]
	public Animation() { }

}

