namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005D2")]
internal struct ComponentType
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001514")]
	public int Size; //Field offset: 0x0

	[Address(RVA = "0x6893B0", Offset = "0x6885B0", Length = "0x1A")]
	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x600296C")]
	public static ComponentType Create() { }

}

