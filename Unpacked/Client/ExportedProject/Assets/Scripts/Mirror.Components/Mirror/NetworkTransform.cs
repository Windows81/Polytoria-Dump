namespace Mirror;

[AddComponentMenu(null)]
[Obsolete("NetworkTransform was renamed to NetworkTransformUnreliable.\nYou can easily swap the component's script by going into the Unity Inspector debug mode:\n1. Click the vertical dots on the top right in the Inspector tab.\n2. Find your NetworkTransform component\n3. Drag NetworkTransformUnreliable into the 'Script' field in the Inspector.\n4. Find the three dots and return to Normal mode.")]
[Token(Token = "0x2000036")]
public class NetworkTransform : NetworkTransformUnreliable
{

	[Address(RVA = "0x123A4D0", Offset = "0x12396D0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkTransformUnreliable), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E2")]
	public NetworkTransform() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E3")]
	public virtual bool Weaved() { }

}

