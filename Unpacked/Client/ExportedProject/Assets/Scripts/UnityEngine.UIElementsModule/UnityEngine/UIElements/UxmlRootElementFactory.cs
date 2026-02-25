namespace UnityEngine.UIElements;

[Obsolete("UxmlRootElementFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B0")]
public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
{

	[Token(Token = "0x17000960")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x1B52C00", Offset = "0x1B51E00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600239F")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000961")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x1B52C30", Offset = "0x1B51E30", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60023A0")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x1B52BC0", Offset = "0x1B51DC0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60023A2")]
	public UxmlRootElementFactory() { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023A1")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x1B52C00", Offset = "0x1B51E00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600239F")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x1B52C30", Offset = "0x1B51E30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023A0")]
	public virtual string get_uxmlQualifiedName() { }

}

