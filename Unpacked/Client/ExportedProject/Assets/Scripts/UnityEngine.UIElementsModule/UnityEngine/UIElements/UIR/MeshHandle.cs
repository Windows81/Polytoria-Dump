namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200054B")]
internal class MeshHandle : LinkedPoolItem<MeshHandle>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001192")]
	internal Alloc allocVerts; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001193")]
	internal Alloc allocIndices; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001194")]
	internal uint triangleCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001195")]
	internal Page allocPage; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001196")]
	internal uint allocTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001197")]
	internal uint updateAllocID; //Field offset: 0x5C

	[Address(RVA = "0x1B66960", Offset = "0x1B65B60", Length = "0x39")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice+<>c", Member = "<.ctor>b__59_0", ReturnType = typeof(MeshHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002637")]
	public MeshHandle() { }

}

