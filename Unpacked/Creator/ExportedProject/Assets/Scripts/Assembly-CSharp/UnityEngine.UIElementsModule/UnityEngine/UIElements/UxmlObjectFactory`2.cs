namespace UnityEngine.UIElements;

[Obsolete("UxmlObjectFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E3")]
internal class UxmlObjectFactory : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType>, IBaseUxmlObjectFactory, IBaseUxmlFactory
{

	[Address(RVA = "0x84A160", Offset = "0x849360", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002431")]
	public UxmlObjectFactory`2() { }

	[Address(RVA = "0x84A0B0", Offset = "0x8492B0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002430")]
	public override TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

