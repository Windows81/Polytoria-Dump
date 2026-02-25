namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000574")]
internal class BasicNode : LinkedPoolItem<BasicNode`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D9")]
	public BasicNode<T> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012DA")]
	public T data; //Field offset: 0x0

	[Address(RVA = "0x963BC0", Offset = "0x962DC0", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002706")]
	public BasicNode`1() { }

	[Address(RVA = "0x963A10", Offset = "0x962C10", Length = "0x6B")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "InsertTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(Texture), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002705")]
	public void InsertFirst(ref BasicNode<T>& first) { }

}

