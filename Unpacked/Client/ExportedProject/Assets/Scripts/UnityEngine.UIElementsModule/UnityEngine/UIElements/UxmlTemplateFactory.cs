namespace UnityEngine.UIElements;

[Obsolete("UxmlTemplateFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B4")]
public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
{

	[Token(Token = "0x17000964")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x1B53410", Offset = "0x1B52610", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60023A9")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000965")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x1B53440", Offset = "0x1B52640", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60023AA")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x1B533D0", Offset = "0x1B525D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60023AC")]
	public UxmlTemplateFactory() { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023AB")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x1B53410", Offset = "0x1B52610", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60023A9")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x1B53440", Offset = "0x1B52640", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023AA")]
	public virtual string get_uxmlQualifiedName() { }

}

