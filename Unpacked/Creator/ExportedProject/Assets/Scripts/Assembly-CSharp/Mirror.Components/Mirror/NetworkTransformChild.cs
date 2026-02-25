namespace Mirror;

[AddComponentMenu(null)]
[Obsolete("NetworkTransformChild is not needed anymore. The .target is now exposed in NetworkTransform itself. Note you can open the Inspector in debug view and replace the source script instead of reassigning everything.")]
[Token(Token = "0x2000037")]
public class NetworkTransformChild : NetworkTransform
{

	[Address(RVA = "0x123A4D0", Offset = "0x12396D0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkTransformUnreliable), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E4")]
	public NetworkTransformChild() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E5")]
	public virtual bool Weaved() { }

}

