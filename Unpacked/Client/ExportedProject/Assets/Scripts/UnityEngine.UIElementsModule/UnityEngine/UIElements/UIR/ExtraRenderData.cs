namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000589")]
internal class ExtraRenderData : LinkedPoolItem<ExtraRenderData>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400136C")]
	public BasicNode<MeshHandle> extraMesh; //Field offset: 0x18

	[Address(RVA = "0x1B901D0", Offset = "0x1B8F3D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002767")]
	public ExtraRenderData() { }

}

