namespace UnityEngine.UIElements;

[Obsolete("UxmlStyleFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004B2")]
public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
{

	[Token(Token = "0x17000962")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x1B531E0", Offset = "0x1B523E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60023A4")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000963")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x1B53210", Offset = "0x1B52410", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60023A5")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x1B531A0", Offset = "0x1B523A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60023A7")]
	public UxmlStyleFactory() { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023A6")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x1B531E0", Offset = "0x1B523E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60023A4")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x1B53210", Offset = "0x1B52410", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023A5")]
	public virtual string get_uxmlQualifiedName() { }

}

