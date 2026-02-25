namespace GLTFast.Schema;

[Token(Token = "0x20000C6")]
public class Root : RootBase5<Accessor, Animation, Asset, Buffer, BufferView, Camera, RootExtensions, Image, Material, Mesh, Node, Sampler, Scene, Skin, Texture>
{

	[Address(RVA = "0x107A070", Offset = "0x1079270", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RootBase`15), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600023C")]
	public Root() { }

}

