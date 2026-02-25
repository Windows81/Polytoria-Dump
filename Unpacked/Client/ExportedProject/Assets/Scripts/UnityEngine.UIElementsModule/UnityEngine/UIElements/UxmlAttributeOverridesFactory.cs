namespace UnityEngine.UIElements;

[Obsolete("UxmlAttributeOverridesFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B6")]
public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
{

	[Token(Token = "0x17000966")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x1B506D0", Offset = "0x1B4F8D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60023AE")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000967")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x1B50700", Offset = "0x1B4F900", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60023AF")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x1B50690", Offset = "0x1B4F890", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60023B1")]
	public UxmlAttributeOverridesFactory() { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B0")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x1B506D0", Offset = "0x1B4F8D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60023AE")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x1B50700", Offset = "0x1B4F900", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023AF")]
	public virtual string get_uxmlQualifiedName() { }

}

