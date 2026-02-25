namespace UnityEngine.UIElements;

[Obsolete("UxmlFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E2")]
public class UxmlFactory : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlFactory, IBaseUxmlFactory
{

	[Address(RVA = "0x849890", Offset = "0x848A90", Length = "0x14")]
	[CallerCount(Count = 59)]
	[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600242F")]
	public UxmlFactory`2() { }

	[Address(RVA = "0x8497E0", Offset = "0x8489E0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242E")]
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

}

