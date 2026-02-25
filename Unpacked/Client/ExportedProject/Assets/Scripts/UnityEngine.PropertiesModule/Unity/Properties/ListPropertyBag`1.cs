namespace Unity.Properties;

[Token(Token = "0x200003F")]
public class ListPropertyBag : IndexedCollectionPropertyBag<List`1<TElement>, TElement>
{

	[Token(Token = "0x17000030")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xCF4AF0", Offset = "0xCF3CF0", Length = "0x14")]
	[CalledBy(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndexedCollectionPropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EE")]
	public ListPropertyBag`1() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EB")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0xCF4A30", Offset = "0xCF3C30", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	protected virtual List<TElement> Instantiate() { }

	[Address(RVA = "0xCF4950", Offset = "0xCF3B50", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	protected virtual List<TElement> InstantiateWithCount(int count) { }

}

